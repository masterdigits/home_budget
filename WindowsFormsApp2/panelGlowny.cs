using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class panelGlowny : Form
    {
        private int _lastFormSize;
        uzytkownicy Aktualnie_zalogowany;
        uc_tabela_filtr tabela_fitlr;
        uc_kalendarz kalendarz;

        enum wybrana_kontrolka
        {
            tabela_fitlr =0,
            kalendarz =1
        }


        public panelGlowny()
        {
            InitializeComponent();

        }

        public panelGlowny(uzytkownicy u)
        {
            Aktualnie_zalogowany = u;
            InitializeComponent();
            this.Resize += new EventHandler(Form2_Resize);
            _lastFormSize = GetFormArea(this.Size);
            
        }


        private void panelGlowny_Load(object sender, EventArgs e)
        {
            uc_formularz_operacja1.AkualnieZalogowany = Aktualnie_zalogowany;
            timer_sesja.Start();
        }

        private void panelGlowny_Activated(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
        

        private void buttonWidokKalendarz_Click(object sender, EventArgs e)
        {
            schowaj_kontekts(wybrana_kontrolka.kalendarz);
            if (kalendarz == null)
            {
                kalendarz = new uc_kalendarz(Aktualnie_zalogowany);
                tlp_kontekst.Controls.Add(kalendarz);
                kalendarz.Dock = DockStyle.Fill;
            }else if(!kalendarz.Visible)
            {
                kalendarz.Visible = true;
               // kalendarz.BringToFront();
            }
        }

        private void buttonWidokLiniowy_Click(object sender, EventArgs e)
        {
            //trybWidokLiniowy();
        }

        private void buttonWidokKolowy_Click(object sender, EventArgs e)
        {
            //trybKolowy();
            //Kod do usunięcia testowanie focusu uc_form_operacji
            var q = from o in SingletonBaza.Instance.BazaDC.operacje
                    select o;
            operacje test = q.FirstOrDefault();
            uc_formularz_operacja1.Wybrana = test;
            uc_formularz_operacja1.Focus();



        }
        private void schowaj_kontekts(wybrana_kontrolka wk)
        {
            switch(wk)
            {
                case wybrana_kontrolka.kalendarz:
                    if (tabela_fitlr != null)
                    {
                        tabela_fitlr.Visible = false;
                    }
                    break;
                case wybrana_kontrolka.tabela_fitlr:
                    if (kalendarz != null)
                    {
                        kalendarz.Visible = false;
                    }
                    break;
            }

        }

        private void buttonWidokKolumnowy_Click(object sender, EventArgs e)
        {
            //trybKolumnowy();
        }

        private void buttonWidokTabelka_Click(object sender, EventArgs e)
        {
            
            schowaj_kontekts(wybrana_kontrolka.tabela_fitlr);
            if (tabela_fitlr == null)
            {
                tabela_fitlr = new uc_tabela_filtr(Aktualnie_zalogowany);
                tlp_kontekst.Controls.Add(tabela_fitlr);
                tabela_fitlr.Dock = DockStyle.Fill;
            }else if(!tabela_fitlr.Visible)
            {
                tabela_fitlr.Visible = true;
                //tabela_fitlr.BringToFront();
            }
        }


        private void buttonWyloguj_Click(object sender, EventArgs e)
        {
            //To tak nie działa!!!
            panelLogowania PL = new panelLogowania();
            this.Hide();
            PL.ShowDialog();
        }
        // Tutaj jest co dodałem do odswierzania kalendarza 

        public void odswierz_dany_dzien(DateTime dzien)
        {
            if(kalendarz != null)
            {
                kalendarz.odswierz_panel_dnia(dzien);
            }
        }
        public void odsiwerz_dana_operacje_w_tabeli(int id)
        {
            if (tabela_fitlr != null)
            {
                tabela_fitlr.odswierz_dana_operacje(id);
            }
        }

        private void timer_sesja_Tick(object sender, EventArgs e)
        {
            if (!SingletonBaza.sprawdz_sesje())
            {
                timer_sesja.Stop();
                MessageBox.Show("Ktoś zalogowal się na konto na innym urządzeniu!");
                this.Close();
            }
        }
        private int GetFormArea(Size size)
        {
            return size.Height * size.Width;
        }

        private void Form2_Resize(object sender, EventArgs e)
        {
            Control control = (Control)sender;

            float scaleFactor = (float)GetFormArea(control.Size) / (float)_lastFormSize;
            ResizeFont(this.Controls, scaleFactor);
            _lastFormSize = GetFormArea(control.Size);

        }

        private void ResizeFont(Control.ControlCollection coll, float scaleFactor)
        {
            foreach (Control c in coll)
            {
                /*
                if(c.GetType() == uc_formularz_operacja1.GetType())
                {
                    return;
                }
                */
                if (c.HasChildren)
                {
                    if (c.GetType() == uc_formularz_operacja1.GetType())
                    {
                        return;
                    }
                    ResizeFont(c.Controls, scaleFactor);
                }
                else
                {

                  c.Font = new Font(c.Font.FontFamily.Name, c.Font.Size * scaleFactor);
                }
            }
        }

        private void buttonDodajWydatek_Click(object sender, EventArgs e)
        {
        }
    }
}
