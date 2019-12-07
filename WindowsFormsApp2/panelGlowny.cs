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
        uc_tabela_filtr tabela_zatwierdzone;
        uc_tabela_filtr tabela_niezatwierdzone;
        uc_kalendarz kalendarz;
        uc_panel_uzytkownikow panel_admistratora;
        uc_panel_powiadomień panel_Powiadomien;
        enum wybrana_kontrolka
        {
            tabela_zatwierdzone = 0,
            kalendarz = 1,
            panel_administratora = 2,
            tabela_niezatwierdzone = 3,
            panel_powiadomien = 4
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
            switch (wk)
            {
                case wybrana_kontrolka.kalendarz:
                    if (tabela_zatwierdzone != null)
                    {
                        tabela_zatwierdzone.Visible = false;
                    }
                    if (panel_admistratora != null)
                    {
                        panel_admistratora.Visible = false;
                    }
                    if (tabela_niezatwierdzone != null)
                    {
                        tabela_niezatwierdzone.Visible = false;
                    }
                    if (panel_Powiadomien != null)
                    {
                        panel_Powiadomien.Visible = false;
                    }
                    if (kalendarz != null)
                    {
                        kalendarz.Visible = true;
                    }
                    break;
                case wybrana_kontrolka.tabela_zatwierdzone:
                    if (kalendarz != null)
                    {
                        kalendarz.Visible = false;
                    }
                    if (panel_admistratora != null)
                    {
                        panel_admistratora.Visible = false;
                    }
                    if (tabela_niezatwierdzone != null)
                    {
                        tabela_niezatwierdzone.Visible = false;
                    }
                    if (panel_Powiadomien != null)
                    {
                        panel_Powiadomien.Visible = false;
                    }
                    if (tabela_zatwierdzone != null)
                    {
                        tabela_zatwierdzone.Visible = true;
                    }
                    break;
                case wybrana_kontrolka.panel_administratora:
                    if (tabela_zatwierdzone != null)
                    {
                        tabela_zatwierdzone.Visible = false;
                    }
                    if (kalendarz != null)
                    {
                        kalendarz.Visible = false;
                    }
                    if (tabela_niezatwierdzone != null)
                    {
                        tabela_niezatwierdzone.Visible = false;
                    }
                    if (panel_Powiadomien != null)
                    {
                        panel_Powiadomien.Visible = false;
                    }
                    if (panel_admistratora != null)
                    {
                        panel_admistratora.Visible = true;
                    }
                    break;
                case wybrana_kontrolka.tabela_niezatwierdzone:
                    if (tabela_zatwierdzone != null)
                    {
                        tabela_zatwierdzone.Visible = false;
                    }
                    if (kalendarz != null)
                    {
                        kalendarz.Visible = false;
                    }
                    if (panel_admistratora != null)
                    {
                        panel_admistratora.Visible = false;
                    }
                    if (panel_Powiadomien != null)
                    {
                        panel_Powiadomien.Visible = false;
                    }
                    if (tabela_niezatwierdzone != null)
                    {
                        tabela_niezatwierdzone.Visible = true;
                    }
                    break;
                case wybrana_kontrolka.panel_powiadomien:
                    if (tabela_zatwierdzone != null)
                    {
                        tabela_zatwierdzone.Visible = false;
                    }
                    if (kalendarz != null)
                    {
                        kalendarz.Visible = false;
                    }
                    if (panel_admistratora != null)
                    {
                        panel_admistratora.Visible = false;
                    }
                    if (tabela_niezatwierdzone != null)
                    {
                        tabela_niezatwierdzone.Visible = false;
                    }
                    if (panel_Powiadomien != null)
                    {
                        panel_Powiadomien.Visible = true;
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

            schowaj_kontekts(wybrana_kontrolka.tabela_zatwierdzone);
            if (tabela_zatwierdzone == null)
            {
                tabela_zatwierdzone = new uc_tabela_filtr(0);
                tlp_kontekst.Controls.Add(tabela_zatwierdzone);
                tabela_zatwierdzone.Dock = DockStyle.Fill;
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
            if (kalendarz != null)
            {
                kalendarz.odswierz_panel_dnia(dzien);
            }
        }
        public void odsiwerz_dana_operacje_w_tabeli(int id)
        {

            if (tabela_zatwierdzone != null)
            {
                tabela_zatwierdzone.odswierz_dana_operacje(id);
            }

            if (tabela_niezatwierdzone != null)
            {
                tabela_niezatwierdzone.odswierz_dana_operacje(id);
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
            if (kalendarz != null)
            {
                kalendarz.zmien_roziar();
            }
            /*
            Control control = (Control)sender;

            float scaleFactor = (float)GetFormArea(control.Size) / (float)_lastFormSize;
            ResizeFont(this.Controls, scaleFactor);
            _lastFormSize = GetFormArea(control.Size);
            */
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
                    //|| c.GetType() == tlp_kontekst.GetType())
                    {
                        return;
                    }

                    ResizeFont(c.Controls, scaleFactor);
                }
                else
                {
                    //c.Font = new Font(c.Font.FontFamily.Name, c.Font.Size * scaleFactor);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            schowaj_kontekts(wybrana_kontrolka.panel_administratora);
            if (panel_admistratora == null)
            {
                if (SingletonBaza.Zalogowany.czy_admistrator())
                {
                    panel_admistratora = new uc_panel_uzytkownikow();
                    tlp_kontekst.Controls.Add(panel_admistratora);
                    panel_admistratora.Dock = DockStyle.Fill;
                }

            }
        }

        private void buttonTabbelaNiezatwierdzonych_Click(object sender, EventArgs e)
        {
            schowaj_kontekts(wybrana_kontrolka.tabela_niezatwierdzone);
            if (tabela_niezatwierdzone == null)
            {
                if (SingletonBaza.Zalogowany.czy_obserwator()
                    || SingletonBaza.Zalogowany.czy_admistrator()
                    || SingletonBaza.Zalogowany.czy_moderator())
                {
                    tabela_niezatwierdzone = new uc_tabela_filtr(1);
                    tlp_kontekst.Controls.Add(tabela_niezatwierdzone);
                    tabela_niezatwierdzone.Dock = DockStyle.Fill;
                }
            }
        }

        private void uc_formularz_operacja1_Load(object sender, EventArgs e)
        {

        }

        private void tlp_kontekst_Resize(object sender, EventArgs e)
        {
            resizing_kalendarz.Szerokosc = tlp_kontekst.Size.Width;
            resizing_kalendarz.Wysokosc = tlp_kontekst.Size.Height;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SingletonBaza.Instance.BazaDC.Refresh(System.Data.Linq.RefreshMode.OverwriteCurrentValues,
                SingletonBaza.Instance.BazaDC.operacje);
            SingletonBaza.Instance.BazaDC.Refresh(System.Data.Linq.RefreshMode.OverwriteCurrentValues,
                SingletonBaza.Instance.BazaDC.uzytkownicy);
            /*
            if (tabela_zatwierdzone != null)
            {
                tlp_kontekst.Controls.Remove(tabela_zatwierdzone);
                tabela_zatwierdzone.Dispose();
                tabela_zatwierdzone = null;
            }
            if (kalendarz !=null)
            {
                tlp_kontekst.Controls.Remove(kalendarz);
                kalendarz.Dispose();
                kalendarz = null;
            }
            if (tabela_niezatwierdzone !=null)
            {
                tlp_kontekst.Controls.Remove(tabela_niezatwierdzone);
                tabela_niezatwierdzone.Dispose();
                tabela_niezatwierdzone = null;
            }
            */
        }

        private void button1_Click(object sender, EventArgs e)
        {
            schowaj_kontekts(wybrana_kontrolka.panel_powiadomien);
            if (panel_Powiadomien == null)
            {

                panel_Powiadomien = new uc_panel_powiadomień();
                tlp_kontekst.Controls.Add(panel_Powiadomien);
                panel_Powiadomien.Dock = DockStyle.Fill;
            }
        }
    }
}
