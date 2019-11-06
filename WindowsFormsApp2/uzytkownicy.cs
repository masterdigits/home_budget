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
        public override string ToString()
        {
            return imie + " " + nazwisko;
        }
    }
}
