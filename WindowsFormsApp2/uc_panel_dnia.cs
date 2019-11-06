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
    public partial class uc_panel_dnia : UserControl
    {
        uzytkownicy Aktualny;
        DateTime data;
        internal DateTime Dzien
        {
            get
            {
                return data;
            }
            set
            {
                data = value;
                lb_nazwa_dnia.Text = data.Date.Day.ToString();
            }
        }

        public uc_panel_dnia()
        {
            InitializeComponent();
        }
        public uc_panel_dnia(DateTime d, uzytkownicy akt)
        {
            InitializeComponent();
            Aktualny = akt;
            data = d;

        }
        private void uc_panel_dnia_Load(object sender, EventArgs e)
        {
            wyswietl_operacje();
        }
        public void wyswietl_operacje()
        {
            flP_dane_operacji.Controls.Clear();
            var query = from op in Aktualny.operacje
                        where op.data == data
                        select op;
            lb_nazwa_dnia.Text = data.Day.ToString();
            if (query != null)
            {
                foreach (operacje o in query)
                {
                    uc_operacja nowy = new uc_operacja(o);
                    flP_dane_operacji.Controls.Add(nowy);
                }
            }
        }

    }
}
