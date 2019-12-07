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
    public partial class uc_okno_powiadomienia : UserControl
    {
        powiadomienia powiadomienieDoEdycji;
        enum Tryb_okna_powiadomien
        {
            wyswietl_wiadomosc_moja = 0,
            wyswietl_wiadomosc_inna = 2,
            tworz_wiadomosc = 1
        }

        Tryb_okna_powiadomien tryb_aktualny;
        public uc_okno_powiadomienia(int top)
        {
            tryb_aktualny = (Tryb_okna_powiadomien) top;

            InitializeComponent();
        }

        public uc_okno_powiadomienia(powiadomienia pow, int top)
        {
            tryb_aktualny = (Tryb_okna_powiadomien)top;
            powiadomienieDoEdycji = pow;
            InitializeComponent();
            tb_nazwa.Text = powiadomienieDoEdycji.nazwa;
            rtb_opis.Text = powiadomienieDoEdycji.opis;
        }

        private void uc_okno_powiadomienia_Load(object sender, EventArgs e)
        {

            switch (tryb_aktualny)
            {
                case Tryb_okna_powiadomien.wyswietl_wiadomosc_inna:
                    btn_wyslij.Dispose();
                    btn_anuluj.Text = "Zamknij";
                    tb_nazwa.Enabled = false;
                    rtb_opis.Enabled = false;
                    Label nadawca = new Label();
                    panel1.Controls.Add(nadawca);
                    nadawca.Location = clb_uzytkownicy.Location;
                    nadawca.Text = powiadomienieDoEdycji.uzytkownicy.ImieNaziwsko;
                    l_do.Text = "Od";
                    clb_uzytkownicy.Dispose();
                    break;
                case Tryb_okna_powiadomien.tworz_wiadomosc:
                    ((ListBox)clb_uzytkownicy).DataSource = SingletonBaza.Instance.BazaDC.uzytkownicy;
                    ((ListBox)clb_uzytkownicy).DisplayMember = "NazwiskoImie";
                    break;
                case Tryb_okna_powiadomien.wyswietl_wiadomosc_moja:
                    btn_wyslij.Dispose();
                    btn_anuluj.Text = "Zamknij";
                    tb_nazwa.Enabled = false;
                    rtb_opis.Enabled = false;
                    Label odbiorcy = new Label();
                    panel1.Controls.Add(odbiorcy);
                    odbiorcy.Location = clb_uzytkownicy.Location;
                    foreach(powiadomienie_odbiorcy pow_odb in powiadomienieDoEdycji.powiadomienie_odbiorcy)
                    {
                        odbiorcy.Text += pow_odb.uzytkownicy.ImieNaziwsko + " ";
                    }
                    clb_uzytkownicy.Dispose();
                    break;

            }
        }

        private void btn_wyslij_Click(object sender, EventArgs e)
        {
            powiadomienia doZapisu = null;
            if(powiadomienieDoEdycji !=null)
            {
                doZapisu = powiadomienieDoEdycji;

            }
            else
            {
                doZapisu = new powiadomienia();
                SingletonBaza.Instance.BazaDC.powiadomienia.InsertOnSubmit(doZapisu);
            }
            doZapisu.uzytkownicy = SingletonBaza.Zalogowany;
            doZapisu.nazwa = tb_nazwa.Text;
            doZapisu.opis = rtb_opis.Text;
            foreach (uzytkownicy u in clb_uzytkownicy.CheckedItems)
            {
                doZapisu.powiadomienie_odbiorcy.Add(
                    new powiadomienie_odbiorcy
                    { powiadomienia= doZapisu,
                    uzytkownicy =u}
                    );
            }
            SingletonBaza.Instance.BazaDC.SubmitChanges();
        }

        private void btn_anuluj_Click(object sender, EventArgs e)
        {
            powiadomienieDoEdycji = null;
            Dispose();
        }
    }
}
