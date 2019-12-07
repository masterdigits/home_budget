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
    public partial class uc_panel_powiadomień : UserControl
    {
        enum Tryb_powiadomien
        {
            skrzynka = 0,
            wyslane = 1
        }
        Tryb_powiadomien tryb_aktualny = Tryb_powiadomien.skrzynka;

        public uc_panel_powiadomień()
        {
            InitializeComponent();
        }

        public void wczytaj_powiadomienia()
        {
            flp_powiadomienia.Controls.Clear();

            switch (tryb_aktualny)
            {
                case Tryb_powiadomien.skrzynka:
                    /*
                    var q = from pow in SingletonBaza.Instance.BazaDC.powiadomienia
                            join pow_odb in SingletonBaza.Instance.BazaDC.powiadomienie_odbiorcy
                            on pow.id_powiadomienia equals pow_odb.id_powiadomienia
                            join uzyt in SingletonBaza.Instance.BazaDC.uzytkownicy
                            on pow_odb.id_uzytkownika equals uzyt.id_uzytkownika
                            where pow_odb.id_uzytkownika == SingletonBaza.Zalogowany.id_uzytkownika
                            select pow;
                    */
                    foreach (powiadomienie_odbiorcy pow_odb in SingletonBaza.Zalogowany.powiadomienie_odbiorcy)
                    {
                        uc_powiadomienie nowy = new uc_powiadomienie(pow_odb.powiadomienia);
                        nowy.Kontener = p_kontener;
                        flp_powiadomienia.Controls.Add(nowy);
                    }
                    break;
                case Tryb_powiadomien.wyslane:
                    foreach (powiadomienia pow in SingletonBaza.Zalogowany.powiadomienia)
                    {
                        uc_powiadomienie nowy = new uc_powiadomienie(pow);
                        nowy.Kontener = p_kontener;
                        flp_powiadomienia.Controls.Add(nowy);
                    }
                    break;
            }

        }
        public void dodaj_pow(powiadomienia pow)
        {
            uc_powiadomienie nowy = new uc_powiadomienie(pow);
            flp_powiadomienia.Controls.Add(nowy);
        }

        private void skrzynkaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tryb_aktualny = Tryb_powiadomien.skrzynka;
            wczytaj_powiadomienia();
        }

        private void wysłaneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tryb_aktualny = Tryb_powiadomien.wyslane;
            wczytaj_powiadomienia();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            uc_okno_powiadomienia nowe = new uc_okno_powiadomienia(1);
            nowe.Dock = DockStyle.Fill;
            p_kontener.Controls.Add(nowe);
        }

        private void odświerzToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SingletonBaza.Instance.BazaDC.Refresh(System.Data.Linq.RefreshMode.OverwriteCurrentValues,
            SingletonBaza.Instance.BazaDC.powiadomienia);
            wczytaj_powiadomienia();
        }
    }
}
