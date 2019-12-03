using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace WindowsFormsApp2
{
    public partial class uc_kalendarz : UserControl
    {

        DateTime firstDay;
        uzytkownicy Aktualny;
        List<uzytkownicy> Wybrani_uzytkownicy = new List<uzytkownicy>();
        Dictionary<DateTime, uc_panel_dnia> panele_dnia = new Dictionary<DateTime,uc_panel_dnia>();
        //uc_panel_dnia[,] panele_dnia;
        public enum DniTygodnia
        {
            Monday = 0,
            Tuesday = 1,
            Wednesday = 2,
            Thursday = 3,
            Friday = 4,
            Saturday = 5,
            Sunday = 6,
        }
        public enum Miesiace
        {
            Styczeń = 1,
            Luty = 2,
            Marzec = 3,
            Kwiecień = 4,
            Maj = 5,
            Czerwiec = 6,
            Lipiec = 7,
            Sierpień = 8,
            Wrzesień = 9,
            Październik = 10,
            Listopad = 11,
            Grudzień = 12
        }
        public uc_kalendarz()
        {
            InitializeComponent();
            firstDay = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
        }

        public uc_kalendarz(uzytkownicy akt)
        {
            Aktualny = akt;
            InitializeComponent();
        }
        public void odswierz_operacje()
        {
            foreach (KeyValuePair<DateTime, uc_panel_dnia> entry in panele_dnia)
            {
                entry.Value.wyswietl_operacje();
            }
        }

        public void wczytaj_kalendarz()
        {
            firstDay = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            int ile = 0 - (int)System.Enum.Parse(typeof(DniTygodnia), firstDay.DayOfWeek.ToString());
            for (int i = 1; i < 7; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    uc_panel_dnia upd = new uc_panel_dnia(firstDay.AddDays(ile), Aktualny);
                    upd.Dock = DockStyle.Fill;
                    
                    panele_dnia.Add(firstDay.AddDays(ile), upd);
                    ile++;
                    tlp_kalendarz.Controls.Add(upd, j, i);
                }
            }
        }

        private void btn_nast_miesiac_Click(object sender, EventArgs e)
        {
            firstDay = firstDay.AddMonths(1);
            cb_miesiac.SelectedItem = (Miesiace)firstDay.Month;
            if( (int) cb_rok.SelectedItem != firstDay.Year )
            {
                cb_rok.SelectedItem = firstDay.Year;
            }
            przesun_miesiac();

        }

        private void przesun_miesiac()
        {
            if (panele_dnia != null)
            {
                Dictionary<DateTime, uc_panel_dnia> nowy = new Dictionary<DateTime, uc_panel_dnia>();
                int ile = 0 - (int)System.Enum.Parse(typeof(DniTygodnia), firstDay.DayOfWeek.ToString());
                foreach(KeyValuePair<DateTime,uc_panel_dnia> entry in panele_dnia)
                {
                    entry.Value.Dzien = firstDay.AddDays(ile);
                    entry.Value.wyswietl_operacje();
                    nowy.Add(entry.Value.Dzien, entry.Value);
                    ile++;
                }
                panele_dnia = nowy;
            }
        }

        private void btn_poprzedni_miesiac_Click(object sender, EventArgs e)
        {
            firstDay = firstDay.AddMonths(-1);
            cb_miesiac.SelectedItem = (Miesiace)firstDay.Month;
            if ((int)cb_rok.SelectedItem != firstDay.Year)
            {
                cb_rok.SelectedItem = firstDay.Year;
            }
            przesun_miesiac();
        }

        private void uc_kalendarz_Load(object sender, EventArgs e)
        {
            wczytaj_lata();
            wczytaj_miesiace();
            wczytaj_kalendarz();
            wczytaj_uzytkownikow();
        }

        private void wczytaj_lata()
        {
            List<int> lata = new List<int>();
            int ten_rok = DateTime.Now.Year;
            for(int i= 10; i>=-10; i--)
            {
                lata.Add(ten_rok - i);
            }
            cb_rok.DataSource = lata;
            cb_rok.SelectedItem = DateTime.Now.Year;
        }
        private void wczytaj_miesiace()
        {
            cb_miesiac.DataSource = Enum.GetValues(typeof(Miesiace))
                .Cast<Miesiace>()
                ;
            cb_miesiac.SelectedItem = (Miesiace)DateTime.Now.Month;
        }

        private void wczytaj_uzytkownikow()
        {
            ((ListBox)chlb_uzytkownicy).DataSource = SingletonBaza.Instance.BazaDC.uzytkownicy;
            ((ListBox)chlb_uzytkownicy).DisplayMember = "NazwiskoImie";
            chlb_uzytkownicy.SetItemChecked(chlb_uzytkownicy.Items.IndexOf(Aktualny), true);
        }

        private void chlb_uzytkownicy_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void chlb_uzytkownicy_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (panele_dnia.Count > 0 && firstDay!= null)
            {
                if (e.NewValue == CheckState.Checked)
                {
                    Wybrani_uzytkownicy.Add(chlb_uzytkownicy.Items[e.Index] as uzytkownicy);
                }
                else
                {
                    Wybrani_uzytkownicy.Remove(chlb_uzytkownicy.Items[e.Index] as uzytkownicy);
                }
                if (Wybrani_uzytkownicy.Count > 0)
                {
                    foreach (KeyValuePair<DateTime, uc_panel_dnia> entry in panele_dnia)
                    {
                        entry.Value.WybraniUzytkownicy = Wybrani_uzytkownicy;
                    }
                }
                odswierz_operacje();
            }
        }

        private void cb_rok_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (firstDay != null && panele_dnia.Count > 0)
            {
                firstDay = new DateTime((int)cb_rok.SelectedItem, firstDay.Month, 1);
                przesun_miesiac();
            }
        }

        private void cb_miesiac_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (firstDay != null && panele_dnia.Count > 0)
            {
                firstDay = new DateTime(firstDay.Year, (int)System.Enum.Parse(typeof(Miesiace), cb_miesiac.SelectedItem.ToString()), 1);
                przesun_miesiac();
            }
        }

        // Kod do odswierzania dnia po zmianie
        public void odswierz_panel_dnia(DateTime dzien)
        {
            if (panele_dnia.ContainsKey(dzien))
            {
                panele_dnia[dzien].wyswietl_operacje();
            }
        }
        public void zmien_roziar()
        {
            /*
            foreach( Control con in tlp_kalendarz.Controls)
            {
                if( con is uc_panel_dnia)
                {
                    (con as uc_panel_dnia).zmien_roziar(resizing_kalendarz.Szerokosc);
                }
            }
            */
        }

        private void ResizeFont(Control.ControlCollection coll, float scaleFactor)
        {
            foreach (Control c in coll)
            {

                if (c.HasChildren)
                {

                    ResizeFont(c.Controls, scaleFactor);
                }
                else
                {
                   c.Font = new Font(c.Font.FontFamily.Name, c.Font.Size * scaleFactor);
                }
            }
        }

        private void tlp_kalendarz_Resize(object sender, EventArgs e)
        {
            foreach (Control con in tlp_kalendarz.Controls)
            {
                if (con is uc_panel_dnia)
                {
                    con.Size = new Size( Size.Width / 7, con.Height);
                }
            }
        }
    }
}
