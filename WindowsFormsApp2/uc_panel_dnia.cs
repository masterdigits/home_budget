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
        List<uzytkownicy> Wybrani_uzytkownicy = new List<uzytkownicy>();
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
        internal List<uzytkownicy> WybraniUzytkownicy
        {
            get
            {
                return Wybrani_uzytkownicy;
            }
            set
            {
                Wybrani_uzytkownicy = value;
            }
        }

        public uc_panel_dnia()
        {
            InitializeComponent();
        }
        public uc_panel_dnia(DateTime d,uzytkownicy akt)
        {
            InitializeComponent();
            Aktualny = akt;
            data = d;

        }
        private void uc_panel_dnia_Load(object sender, EventArgs e)
        {
            wyswietl_operacje();
        }
        public void zmien_roziar(int szerokosc)
        {
            int nowa_szerokosc = szerokosc / 7+33;
            //Size = new Size(nowa_szerokosc, this.Size.Height);
            foreach(uc_operacja uo in flP_dane_operacji.Controls)
            {
                uo.zmien_roziar(nowa_szerokosc);
            }
        }

        public void wyswietl_operacje()
        {
            flP_dane_operacji.Controls.Clear();
            lb_nazwa_dnia.Text = data.Day.ToString();
            if (Wybrani_uzytkownicy.Count > 0)
            {
                foreach (uzytkownicy u in Wybrani_uzytkownicy)
                {
                    var query = from op in u.operacje
                                where op.data == data
                                && op.Zatwierdzone == true
                                select op;
                    if (query != null)
                    {
                        foreach (operacje o in query)
                        {
                            uc_operacja nowy = new uc_operacja(o);
                            //nowy.Anchor = AnchorStyles.None;
                            flP_dane_operacji.MinimumSize = new Size(nowy.Width + 33, 0);
                            flP_dane_operacji.Controls.Add(nowy);
                        }
                    }
                }
            }
        }

    }
}
