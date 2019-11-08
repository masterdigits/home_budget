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
        public static string sprawdz_sesje()
        {
            var q = from u in SingletonBaza._instance.BazaDC.uzytkownicy
                    where Akt.id_uzytkownika == u.id_uzytkownika
                    select u;
            if(q.FirstOrDefault()!= null && _sesja== q.FirstOrDefault().sesja)
            {
                return q.FirstOrDefault().sesja;
            }else
            {
                return "";
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
