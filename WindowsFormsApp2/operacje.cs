using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    partial class operacje
    {
        public bool czy_ma_dostep()
        {
            bool odp = true;
            if (this.uzytkownicy != SingletonBaza.Zalogowany
                || !SingletonBaza.Zalogowany.czy_admistrator()
                || !SingletonBaza.Zalogowany.czy_moderator())
            {
                odp =false;
            }
            return odp;
        }
        public bool czy_ktos_inny_edytuje_operacje()
        {
            SingletonBaza.Instance.BazaDC.Refresh(System.Data.Linq.RefreshMode.OverwriteCurrentValues,
            SingletonBaza.Instance.BazaDC.sesja_operacja);
            bool odp = false;
            foreach (sesja_operacja o in sesja_operacja)
            {
                if(o.uzytkownicy != SingletonBaza.Zalogowany )
                {
                    odp = true;
                }
            }
            return odp;

        }
        public bool czy_sesja_wygasla()
        {
            bool odp = false;
            foreach (sesja_operacja o in sesja_operacja)
            {
                TimeSpan span = DateTime.Now.Subtract((DateTime)o.data_stworzenia);
                if (span.TotalMinutes >= 5)
                {
                    odp = true;
                }
            }
            return odp;
        }


        public string kto_edytuje_operacje()
        {
            string odp="";
            foreach (sesja_operacja o in sesja_operacja)
            {
                odp = o.uzytkownicy.ImieNaziwsko;
            }
            return odp;
        }

        public void stworz_sesje()
        {
            sesja_operacja nowa = new sesja_operacja();
            nowa.operacje = this;
            nowa.uzytkownicy = SingletonBaza.Zalogowany;
            SingletonBaza.Instance.BazaDC.sesja_operacja.InsertOnSubmit(nowa);
            SingletonBaza.Instance.BazaDC.SubmitChanges();

        }




        public bool filtr(String f_nazwa,
            List<uzytkownicy> f_uzyt, 
            DateTime od_data, DateTime do_data, 
            kategoria f_kategoria , decimal od_kwota,
             decimal do_kwota,
            string f_opis)
        {
            if(f_nazwa != null && !(nazwa.Contains(f_nazwa)))
            {
                return false;
            }

            if (f_uzyt != null)
            {
                bool sprawdz_uzytkownikow = false;

                foreach (uzytkownicy u in f_uzyt)
                {
                    if (this.uzytkownicy == u)
                    {
                        sprawdz_uzytkownikow = true;
                    }
                }
                if (sprawdz_uzytkownikow==false)
                {
                    return false;
                }
            }
            
            if(od_data!=DateTime.MinValue &&
                do_data!=DateTime.MinValue &&
                od_data > data
                && data < do_data)
            {
                return false;
            }
            
            if(f_kategoria!= null && kategoria != f_kategoria)
            {
                return false;
            }
            if (od_kwota != 0 && od_kwota> kwota)
            {
                return false;
            }
            if (do_kwota != 0 && kwota > do_kwota)
            {
                return false;
            }
            if(f_opis!=null && !opis.Contains(f_opis))
            {
                return false;
            }
            
            return true;
        }
    }
}
