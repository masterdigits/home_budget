using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    partial class uzytkownicy
    {
        public bool czy_moderator()
        {
            if(this.role.nazwa == "Moderator")
            {
                return true;
            }
            return false;
        }
        public bool czy_admistrator()
        {
            if (this.role.nazwa == "Administrator")
            {
                return true;
            }
            return false;
        }
        public bool czy_obserwator()
        {
            if (this.role.nazwa == "Obserwator")
            {
                return true;
            }
            return false;
        }
        public bool czy_uzytkownik()
        {
            if (this.role.nazwa == "Uzytkownik")
            {
                return true;
            }
            return false;
        }
        public string ImieNaziwsko
        {
            get
            {
                return imie + " " + nazwisko;
            }
        }
        public bool dostep_do_operacji(operacje sprawdzana)
        {
            if(this == sprawdzana.uzytkownicy 
                || this.role.nazwa == "Administrator"
                || this.role.nazwa == "Moderator")
            {
                return true;
            }
            return false; 
        }


        public override string ToString()
        {
            return imie + " " + nazwisko;
        }
    }
}
