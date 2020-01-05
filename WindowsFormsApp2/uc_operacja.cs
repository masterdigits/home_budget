﻿using System;
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

    public partial class uc_operacja : UserControl
    {

        operacje wyswietlanaOperacja;
        bool pokaz_wiecej = true;
        public static Image resizeImage(Image imgToResize, Size size)
        {
            return (Image)(new Bitmap(imgToResize, size));
        }
        public uc_operacja()
        {
            InitializeComponent();
        }
        public uc_operacja(operacje o)
        {
            InitializeComponent();
            wyswietlanaOperacja = o;
            lb_kwota.Text = wyswietlanaOperacja.kwota.ToString();
            if(wyswietlanaOperacja.kategoria.typ == "wydatek")
            {
                lb_kwota.ForeColor = Color.Red;
            }
            else
            {
                lb_kwota.ForeColor = Color.Green;
            }
            label1.Text = wyswietlanaOperacja.nazwa;
        }


        private void btn_arrow_Click(object sender, EventArgs e)
        {
            if (!pokaz_wiecej)
            {
                btn_arrow.ImageIndex = 1;
                pokaz_wiecej = !pokaz_wiecej;
                flowLayoutPanel1.Controls.Clear();
            }else
            {
                Label label = new Label();
                label.Text = wyswietlanaOperacja.opis;
                flowLayoutPanel1.Controls.Add(label);
                btn_arrow.ImageIndex = 0;
                pokaz_wiecej = !pokaz_wiecej;
            }
        }

        private void panel1_DoubleClick(object sender, EventArgs e)
        {
            if (wyswietlanaOperacja.czy_ma_dostep())
            {
                if (!SingletonBaza.czy_ktos_inny_edytuje_operacje(wyswietlanaOperacja.id_operacji)
                    || SingletonBaza.czy_sesja_wygasla(wyswietlanaOperacja.id_operacji))
                {
                    SingletonBaza.stworz_sesje(wyswietlanaOperacja.id_operacji);
                    uc_formularz_operacja ucfo = ((panelGlowny)this.FindForm()).Controls.Find("uc_formularz_operacja1", true)
                .FirstOrDefault() as uc_formularz_operacja;
                    if (ucfo != null)
                    {
                        ucfo.Wybrana = wyswietlanaOperacja;
                        ucfo.Focus();
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Użytkownik " + SingletonBaza.kto_edytuje_operacje(wyswietlanaOperacja.id_operacji) + " teraz edytuje operacje!");
                }
            }
            else
            {
                MessageBox.Show("Brak dostepu do operacji");
            }

        }

        private void lb_kwota_Click(object sender, EventArgs e)
        {
            if (wyswietlanaOperacja.czy_ma_dostep())
            {
                if (!SingletonBaza.czy_ktos_inny_edytuje_operacje(wyswietlanaOperacja.id_operacji)
                    || SingletonBaza.czy_sesja_wygasla(wyswietlanaOperacja.id_operacji))
                {
                    SingletonBaza.stworz_sesje(wyswietlanaOperacja.id_operacji);
                    uc_formularz_operacja ucfo = ((panelGlowny)this.FindForm()).Controls.Find("uc_formularz_operacja1", true)
                .FirstOrDefault() as uc_formularz_operacja;
                    if (ucfo != null)
                    {
                        ucfo.Wybrana = wyswietlanaOperacja;
                        ucfo.Focus();
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Użytkownik " + SingletonBaza.kto_edytuje_operacje(wyswietlanaOperacja.id_operacji) + " teraz edytuje operacje!");
                }
            }
            else
            {
                MessageBox.Show("Brak dostepu do operacji");
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (wyswietlanaOperacja.czy_ma_dostep())
            {
                if (!SingletonBaza.czy_ktos_inny_edytuje_operacje(wyswietlanaOperacja.id_operacji)
                    || SingletonBaza.czy_sesja_wygasla(wyswietlanaOperacja.id_operacji))
                {
                    SingletonBaza.stworz_sesje(wyswietlanaOperacja.id_operacji);
                    uc_formularz_operacja ucfo = ((panelGlowny)this.FindForm()).Controls.Find("uc_formularz_operacja1", true)
                .FirstOrDefault() as uc_formularz_operacja;
                    if (ucfo != null)
                    {
                        ucfo.Wybrana = wyswietlanaOperacja;
                        ucfo.Focus();
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Użytkownik " + SingletonBaza.kto_edytuje_operacje(wyswietlanaOperacja.id_operacji) + " teraz edytuje operacje!");
                }
            }
            else
            {
                MessageBox.Show("Brak dostepu do operacji");
            }

        }

        private void btn_usun_Click(object sender, EventArgs e)
        {
            if (wyswietlanaOperacja.czy_ma_dostep())
            {
                if (!SingletonBaza.czy_ktos_inny_edytuje_operacje(wyswietlanaOperacja.id_operacji)
                    || SingletonBaza.czy_sesja_wygasla(wyswietlanaOperacja.id_operacji))
                {
                    DialogResult dialog = MessageBox.Show("Czy chcesz usunać operacje?", "Usuwanie operacji", MessageBoxButtons.YesNo);
                    if (dialog == DialogResult.Yes)
                    {
                        SingletonBaza.Instance.BazaDC.operacje.DeleteOnSubmit(wyswietlanaOperacja);
                        SingletonBaza.Instance.BazaDC.SubmitChanges();
                        this.Parent.Controls.Remove(this);
                    }
                }
                else
                {
                    MessageBox.Show("Użytkownik " + SingletonBaza.kto_edytuje_operacje(wyswietlanaOperacja.id_operacji) + " teraz edytuje operacje!");
                }
            }
            else
            {
                MessageBox.Show("Brak dostepu do operacji");
            }
        }

        public void zmienRozmiar(int rozmiar)
        {
            int stary_rozmiar = this.Width;
            this.Size = new Size(rozmiar - 33, this.Height);
            //panel1.Size = new Size(rozmiar - 33, panel1.Height);
            //panel1.Dock = DockStyle.Fill;

            float scaleFactor = (float)this.Width / (float)stary_rozmiar;
            if (scaleFactor>1)
            {
                Font nowa = new Font(label1.Font.FontFamily.Name, label1.Font.Size * scaleFactor);
                lb_kwota.Font = nowa;
                label1.Font = nowa;
            }
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            this.Focus();
        }
    }
}
