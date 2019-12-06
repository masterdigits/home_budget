using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class SingletonBaza
    {
        private static string _sesja;
        private static uzytkownicy Akt;
        private static SingletonBaza _instance;
        private BazaDataContext _bazaDC;
        public BazaDataContext BazaDC
        {
            get
            {
                    return _bazaDC;
            }
        }
        protected SingletonBaza()
        {

            _bazaDC = new BazaDataContext();
            _sesja = hashowanie.GetSession();
        }
        public static string ustaw_zalogowanego(uzytkownicy zalogowany)
        {
            if (Akt == null)
            {
                Akt = zalogowany;
                Akt.sesja = _sesja;
                _instance.BazaDC.SubmitChanges();
                return _sesja;
            }else
            {
                return _sesja;
            }
        }
        public static uzytkownicy Zalogowany
        {
            get
            {
                return Akt;
            }
        }

        public static bool czy_ktos_inny_edytuje_operacje(int id)
        {
            Instance.BazaDC.Refresh(System.Data.Linq.RefreshMode.OverwriteCurrentValues,
            Instance.BazaDC.sesja_operacja);
            var q = from se in Instance.BazaDC.sesja_operacja
                    where se.id_operacji == id
                    select se;

            if (q.FirstOrDefault() == null)
            {
                return false;
            }else
            {
                if (q.FirstOrDefault().uzytkownicy == SingletonBaza.Zalogowany)
                {
                    return false;
                }
            }
            return true;
        }
        public static bool czy_sesja_wygasla(int id)
        {
            var q = from se in Instance.BazaDC.sesja_operacja
                    where se.id_operacji == id
                    select se;
            if (q.FirstOrDefault() == null)
            {
                return false;
            }
            sesja_operacja so = q.FirstOrDefault();
            DateTime end = DateTime.Now;
            DateTime start = (DateTime)so.data_stworzenia;
            TimeSpan span = end.Subtract(start);
            if (span.TotalMinutes >= 5 || so.uzytkownicy == SingletonBaza.Zalogowany)
            {
                Instance.BazaDC.sesja_operacja.DeleteOnSubmit(so);
                Instance.BazaDC.SubmitChanges();
                return true;
            }
            return false;
        }

        public static string kto_edytuje_operacje(int id)
        {
            var q = from se in Instance.BazaDC.sesja_operacja
                    where se.id_operacji == id
                    select se;
            if(q.FirstOrDefault() != null)
            {
                return q.FirstOrDefault().uzytkownicy.ImieNaziwsko; 
            }
            return "";
            
        }
        public static void usun_moje_sesje()
        {
            var q = from se in SingletonBaza.Instance.BazaDC.sesja_operacja
                    where se.uzytkownicy == Zalogowany
                    select se;
            Instance.BazaDC.sesja_operacja.DeleteAllOnSubmit(q);
            Instance.BazaDC.SubmitChanges();
        }

        public static void stworz_sesje(int id)
        {
            usun_moje_sesje();
            sesja_operacja nowa = new sesja_operacja();
            nowa.id_operacji = id;
            nowa.uzytkownicy = SingletonBaza.Zalogowany;
            nowa.data_stworzenia = DateTime.Now;
            Instance.BazaDC.sesja_operacja.InsertOnSubmit(nowa);
            Instance.BazaDC.SubmitChanges();
        }
        public static void usun_sesje(int id)
        {
            var q = from se in SingletonBaza.Instance.BazaDC.sesja_operacja
                    where se.id_operacji == id
                    select se;
            Instance.BazaDC.sesja_operacja.DeleteAllOnSubmit(q);
            Instance.BazaDC.SubmitChanges();
        }


        public static bool sprawdz_sesje()
        {
            Instance.BazaDC.Refresh(System.Data.Linq.RefreshMode.OverwriteCurrentValues,
            Instance.BazaDC.uzytkownicy);
            var q = from u in Instance.BazaDC.uzytkownicy
                    where Akt.id_uzytkownika == u.id_uzytkownika
                    select u;
            if(q.FirstOrDefault()!= null && _sesja== q.FirstOrDefault().sesja)
            {
                return true;
            }else
            {
                return false;
            }
        }


        public static SingletonBaza Instance
        {
            get
            {
                if (_instance == null)
                {
                        _instance = new SingletonBaza();
                }
                return _instance;
            }
        }
    }
}
