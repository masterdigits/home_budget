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
    public partial class uc_panel_uzytkownikow : UserControl
    {
        public uc_panel_uzytkownikow()
        {
            InitializeComponent();
        }

        private void uc_panel_uzytkownikow_Load(object sender, EventArgs e)
        {
            foreach(uzytkownicy u in SingletonBaza.Instance.BazaDC.uzytkownicy)
            {
                uc_uzytkownik uzyt = new uc_uzytkownik(u);
                flowLayoutPanel1.Controls.Add(uzyt);
            }
        }

        private void uc_panel_uzytkownikow_VisibleChanged(object sender, EventArgs e)
        {
            if(Visible==false)
            {
                foreach (uc_uzytkownik u in flowLayoutPanel1.Controls)
                {
                    u.Zapisz();
                    if(u.Enabled==false)
                    {
                        flowLayoutPanel1.Controls.Remove(u);
                    }
                }
                SingletonBaza.Instance.BazaDC.SubmitChanges();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            uc_uzytkownik nowy = new uc_uzytkownik();
            flowLayoutPanel1.Controls.Add(nowy);
        }

        private void pictureImię_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Limit znaków: 50");
        }

        private void pictureNazwisko_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Limit znaków: 50");
        }

        private void pictureEmail_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Musi być w formacie: slowo@email.cos");
        }

        private void pictureLogin_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nie może się powtarzać. Minimalna liczba znaków: 50");
        }

        private void pictureMajątek_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nie może być równy zero");
        }

        private void pictureHasło_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Minimalna liczba znaków: 6");
        }
    }
}
