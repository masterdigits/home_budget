using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    partial class operacje
    {
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
            if(f_opis!=null && opis.Contains(f_opis))
            {
                return false;
            }
            
            return true;
        }
    }
}
