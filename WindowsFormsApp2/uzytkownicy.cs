using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    partial class uzytkownicy
    {
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
