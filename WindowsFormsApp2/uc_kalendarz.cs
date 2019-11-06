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
    public partial class uc_kalendarz : UserControl
    {
        DateTime firstDay;
        uzytkownicy Aktualny;
        List<uzytkownicy> Wybrani_uzytkownicy = new List<uzytkownicy>();
        uc_panel_dnia[,] panele_dnia;
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
            firstDay = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
        }


        public void wczytaj_kalendarz()
        {
            panele_dnia = new uc_panel_dnia[6,7];
            tlp_kalendarz.ColumnStyles[0].SizeType = SizeType.AutoSize;
            int ile = 0 - (int)System.Enum.Parse(typeof(DniTygodnia), firstDay.DayOfWeek.ToString());
            for (int i = 1; i < 7; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    uc_panel_dnia upd = new uc_panel_dnia(firstDay.AddDays(ile), Aktualny);
                    panele_dnia[i - 1, j] = upd;
                    ile++;
                    tlp_kalendarz.Controls.Add(upd, j, i);
                }
            }
        }

        private void btn_nast_miesiac_Click(object sender, EventArgs e)
        {
            firstDay = firstDay.AddMonths(1);
            odswierz_operacje();

        }
        private void odswierz_operacje()
        {
            if (panele_dnia != null)
            {
                int ile = 0 - (int)System.Enum.Parse(typeof(DniTygodnia), firstDay.DayOfWeek.ToString());
                for (int i = 1; i < 7; i++)
                {
                    for (int j = 0; j < 7; j++)
                    {
                        panele_dnia[i - 1, j].Dzien = firstDay.AddDays(ile);
                        panele_dnia[i - 1, j].wyswietl_operacje();
                        ile++;
                    }
                }
            }
        }

        private void btn_poprzedni_miesiac_Click(object sender, EventArgs e)
        {
            firstDay = firstDay.AddMonths(-1);
            odswierz_operacje();
        }

        private void uc_kalendarz_Load(object sender, EventArgs e)
        {
            wczytaj_lata();
            wczytaj_miesiace();
            cb_rok.SelectedItem = DateTime.Now.Year;
            cb_miesiac.SelectedItem = (Miesiace)DateTime.Now.Month;
            wczytaj_kalendarz();
            wczytaj_uzytkownikow();
        }

        private void wczytaj_lata()
        {
            var query = from op in SingletonBaza.Instance.BazaDC.operacje
                        select op.data.Year;
            cb_rok.DataSource = query.Distinct();
        }
        private void wczytaj_miesiace()
        {
            var query = from op in SingletonBaza.Instance.BazaDC.operacje
                        where op.data.Year == (int)cb_rok.SelectedItem
                        select (Miesiace) op.data.Month;
            cb_miesiac.DataSource = query.Distinct();
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
            if (panele_dnia != null)
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
                    for (int i = 1; i < 7; i++)
                    {
                        for (int j = 0; j < 7; j++)
                        {
                            panele_dnia[i - 1, j].WybraniUzytkownicy = Wybrani_uzytkownicy;
                        }
                    }
                }
                for (int i = 1; i < 7; i++)
                {
                    for (int j = 0; j < 7; j++)
                    {
                        panele_dnia[i - 1, j].wyswietl_operacje();
                    }
                }
            }
        }

        private void cb_rok_SelectedIndexChanged(object sender, EventArgs e)
        {
            wczytaj_miesiace();
            if (firstDay != null && panele_dnia != null)
            {
                firstDay = new DateTime((int)cb_rok.SelectedItem, firstDay.Month, 1);
                odswierz_operacje();
            }
        }

        private void cb_miesiac_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (firstDay != null && panele_dnia!=null)
            {
                firstDay = new DateTime(firstDay.Year, (int)System.Enum.Parse(typeof(Miesiace), cb_miesiac.SelectedItem.ToString()), 1);
                odswierz_operacje();
            }
        }
    }
}
