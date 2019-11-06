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
        uc_panel_dnia[,] panele_dnia =  new uc_panel_dnia[6,7];
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
            tlp_kalendarz.ColumnStyles[0].SizeType = SizeType.AutoSize;
            int ile = 0 - (int)System.Enum.Parse(typeof(DniTygodnia), firstDay.DayOfWeek.ToString());
            for (int i = 1; i < 7; i++)
            {
                for (int j = 0; j < 7; j++)
                {

                    uc_panel_dnia upd = new uc_panel_dnia(firstDay.AddDays(ile), Aktualny);
                    panele_dnia[i - 1, j] = upd;
                    ile++;
                    //MessageBox.Show(ile.ToString());
                    tlp_kalendarz.Controls.Add(upd, j, i);
                }
            }
        }

        private void btn_nast_miesiac_Click(object sender, EventArgs e)
        {
            firstDay = firstDay.AddMonths(1);
            MessageBox.Show(firstDay.Month.ToString());
            int ile = 0 - (int) System.Enum.Parse(typeof(DniTygodnia), firstDay.DayOfWeek.ToString());
            MessageBox.Show(ile.ToString());
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

        private void btn_poprzedni_miesiac_Click(object sender, EventArgs e)
        {
            firstDay = firstDay.AddMonths(-1);
            MessageBox.Show(firstDay.Month.ToString());
            int ile = 0 - (int)System.Enum.Parse(typeof(DniTygodnia), firstDay.DayOfWeek.ToString());
            MessageBox.Show(ile.ToString());
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

        private void uc_kalendarz_Load(object sender, EventArgs e)
        {
            wczytaj_kalendarz();
        }
    }
}
