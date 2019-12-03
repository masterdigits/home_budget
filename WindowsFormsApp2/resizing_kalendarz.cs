using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace WindowsFormsApp2
{
    class resizing_kalendarz
    {
        private static int wysokosc;
        private static int szerokosc;

        public static int Szerokosc
        {
            get
            {
                return szerokosc;
            }
            set
            {
                szerokosc = value;
            }
        }
        public static int Wysokosc
        {
            get
            {
                return wysokosc;
            }
            set
            {
                wysokosc = value;
            }
        }

    }
}
