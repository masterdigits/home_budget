using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class uc_powiadomienie : UserControl
    {
        powiadomienia wyswietlane_powiadomienie;
        Panel kontener;

        internal Panel Kontener
        {
            get
            {
                return kontener;
            }
            set
            {
                kontener = value;
            }
        }
        


        internal powiadomienia Wyswietlane_powiadomienie
        {
            get
            {
                return wyswietlane_powiadomienie;
            }
        }

        public uc_powiadomienie()
        {
            InitializeComponent();
        }
        public uc_powiadomienie(powiadomienia pow)
        {
            InitializeComponent();
            wyswietlane_powiadomienie = pow;
            l_nadawca.Text = wyswietlane_powiadomienie.uzytkownicy.ImieNaziwsko;
            l_nazwa.Text = wyswietlane_powiadomienie.nazwa;
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            if(kontener !=null)
            {
                kontener.Controls.Clear();
                uc_okno_powiadomienia nowe;
                if (wyswietlane_powiadomienie.uzytkownicy == SingletonBaza.Zalogowany)
                {
                    nowe = new uc_okno_powiadomienia(wyswietlane_powiadomienie, 0);

                }
                else
                {
                    nowe = new uc_okno_powiadomienia(wyswietlane_powiadomienie, 2);
                }
                nowe.Dock = DockStyle.Fill;
                kontener.Controls.Add(nowe);
            }
        }
    }
}
