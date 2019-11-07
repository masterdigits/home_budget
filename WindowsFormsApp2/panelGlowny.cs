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
        uzytkownicy Aktualnie_zalogowany;
        uc_tabela_filtr tabela_fitlr;
        uc_kalendarz kalendarz;
        public panelGlowny()
        {
            InitializeComponent();
        }

        public panelGlowny(uzytkownicy u)
        {
            Aktualnie_zalogowany = u;
            //Wyslij do kontrolki
            // nazwa.AkualnieZalogowany = Aktualnie_zalogowany;
            InitializeComponent();
        }

        bool trybPrzychod = true;
        bool filtrZaawansowany = false;

        private void panelGlowny_Load(object sender, EventArgs e)
        {
            trybDodajPrzychod();
            uc_formularz_operacja1.AkualnieZalogowany = Aktualnie_zalogowany;
        }

        private void panelGlowny_Activated(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void panelGlowny_SizeChanged(object sender, EventArgs e)
        {
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;

            // Ustawienia panelu bocznego
            {
                splitContainerGlowny.SplitterDistance = this.ClientSize.Width / 4;

                // Wielkosc i lokalizacja przyciskow DodajPrzychod i DodajWydatek
                {
                    buttonDodajPrzychód.Height = this.ClientSize.Height / 13;
                    buttonDodajWydatek.Height = this.ClientSize.Height / 13;
                    buttonDodajPrzychód.Width = this.ClientSize.Width / 5;
                    buttonDodajWydatek.Width = this.ClientSize.Width / 5;

                    buttonDodajPrzychód.Left = (splitContainerMenuBoczne.Panel1.Width - buttonDodajPrzychód.Width) / 2;
                    buttonDodajWydatek.Left = (splitContainerMenuBoczne.Panel1.Width - buttonDodajWydatek.Width) / 2;
                    buttonDodajPrzychód.Top = this.ClientSize.Height / 28;
                    buttonDodajWydatek.Top = buttonDodajPrzychód.Height + 50;
                }
                /*
                // Wielkosc i lokalizacja kontrolek w panelu dodawania przychodów i wydatków
                {
                    splitContainerMenuBoczne.SplitterDistance = this.ClientSize.Height / 4;

                    textBoxDodajKwote.Height = this.ClientSize.Height / 20;
                    dateTimePickerDodajOperacje.Height = this.ClientSize.Height / 20;
                    comboBoxKategoria.Height = this.ClientSize.Height / 20;
                    richTextBoxDodaj.Height = this.ClientSize.Height / 20;
                    buttonReset.Height = this.ClientSize.Height / 20;
                    buttonZapisz.Height = this.ClientSize.Height / 20;

                    textBoxDodajKwote.Width = this.ClientSize.Width / 5;
                    dateTimePickerDodajOperacje.Width = this.ClientSize.Width / 5;
                    comboBoxKategoria.Width = this.ClientSize.Width / 5;
                    richTextBoxDodaj.Width = this.ClientSize.Width / 5;
                    buttonReset.Width = this.ClientSize.Width / 11;
                    buttonZapisz.Width = this.ClientSize.Width / 11;

                    textBoxDodajKwote.Left = (splitContainerMenuBoczne.Panel1.Width - textBoxDodajKwote.Width) / 2;
                    dateTimePickerDodajOperacje.Left = (splitContainerMenuBoczne.Panel1.Width - dateTimePickerDodajOperacje.Width) / 2;
                    comboBoxKategoria.Left = (splitContainerMenuBoczne.Panel1.Width - comboBoxKategoria.Width) / 2;
                    richTextBoxDodaj.Left = (splitContainerMenuBoczne.Panel1.Width - richTextBoxDodaj.Width) / 2;
                    buttonReset.Left = (splitContainerMenuBoczne.Panel1.Width - buttonReset.Width) / 6;
                    buttonZapisz.Left = buttonReset.Left + buttonZapisz.Width + (buttonZapisz.Width / 5);

                    textBoxDodajKwote.Top = this.ClientSize.Height / 24;
                    dateTimePickerDodajOperacje.Top = textBoxDodajKwote.Top + dateTimePickerDodajOperacje.Height + (dateTimePickerDodajOperacje.Height/2) + 5;
                    comboBoxKategoria.Top = dateTimePickerDodajOperacje.Top + comboBoxKategoria.Height + (comboBoxKategoria.Height / 2) + 5;
                    richTextBoxDodaj.Top = comboBoxKategoria.Top + comboBoxKategoria.Height + (comboBoxKategoria.Height / 2) + 5;
                    checkBoxCykliczny.Top = richTextBoxDodaj.Top + richTextBoxDodaj.Height + (comboBoxKategoria.Height / 2) + 5;
                }
                
                // Wielkosc i lokalizacja przyciskow w panelu wybierania widoku
                {
                    splitContainerMenuBoczneWidok.SplitterDistance = buttonReset.Top + (buttonReset.Top / 4);

                    buttonWidokTabelka.Height = splitContainerMenuBoczneWidok.Panel2.Height / 6;
                    buttonWidokKalendarz.Height = splitContainerMenuBoczneWidok.Panel2.Height / 6;
                    buttonWidokLiniowy.Height = splitContainerMenuBoczneWidok.Panel2.Height / 6;
                    buttonWidokKolumnowy.Height = splitContainerMenuBoczneWidok.Panel2.Height / 6;
                    buttonWidokKolowy.Height = splitContainerMenuBoczneWidok.Panel2.Height / 6;

                    buttonWidokTabelka.Width = splitContainerMenuBoczneWidok.Panel2.Width - 10;
                    buttonWidokKalendarz.Width = splitContainerMenuBoczneWidok.Panel2.Width - 10;
                    buttonWidokLiniowy.Width = splitContainerMenuBoczneWidok.Panel2.Width - 10;
                    buttonWidokKolumnowy.Width = splitContainerMenuBoczneWidok.Panel2.Width - 10;
                    buttonWidokKolowy.Width = splitContainerMenuBoczneWidok.Panel2.Width - 10;

                    buttonWidokTabelka.Left = (splitContainerMenuBoczneWidok.Panel2.Width - buttonWidokTabelka.Width) / 2 + 1;
                    buttonWidokKalendarz.Left = (splitContainerMenuBoczneWidok.Panel2.Width - buttonWidokKalendarz.Width) / 2 + 1;
                    buttonWidokLiniowy.Left = (splitContainerMenuBoczneWidok.Panel2.Width - buttonWidokLiniowy.Width) / 2 + 1;
                    buttonWidokKolumnowy.Left = (splitContainerMenuBoczneWidok.Panel2.Width - buttonWidokKolumnowy.Width) / 2 + 1;
                    buttonWidokKolowy.Left = (splitContainerMenuBoczneWidok.Panel2.Width - buttonWidokKolowy.Width) / 2 + 1;

                    buttonWidokTabelka.Top = this.ClientSize.Height / 90;
                    buttonWidokKalendarz.Top = buttonWidokTabelka.Top + buttonWidokKalendarz.Height + (buttonWidokKalendarz.Height / 6);
                    buttonWidokLiniowy.Top = buttonWidokKalendarz.Top + buttonWidokLiniowy.Height + (buttonWidokLiniowy.Height / 6);
                    buttonWidokKolumnowy.Top = buttonWidokLiniowy.Top + buttonWidokKolumnowy.Height + (buttonWidokKolumnowy.Height / 6);
                    buttonWidokKolowy.Top = buttonWidokKolumnowy.Top + buttonWidokKolowy.Height + (buttonWidokKolowy.Height / 6);
                }
                
                // Wielkosc i lokalizacja kontrolek w gornym panelu filtrowania
                {
                    splitContainerFiltr.SplitterDistance = this.ClientSize.Height / 10;

                    comboBoxFiltrWyborOperacji.Width = splitContainerFiltr.Panel1.Width / 7;
                    comboBoxFiltrUzytkownik.Width = splitContainerFiltr.Panel1.Width / 7;
                    dateTimePickerFiltrOd.Width = splitContainerFiltr.Panel1.Width / 5;
                    dateTimePickerFiltrDo.Width = splitContainerFiltr.Panel1.Width / 5;

                    comboBoxFiltrWyborOperacji.Left = splitContainerFiltr.Panel1.Width / 50;
                    comboBoxFiltrUzytkownik.Left = splitContainerFiltr.Panel1.Width / 6 + (labelDoData.Width / 2);
                    labelOdData.Left = comboBoxFiltrUzytkownik.Left + comboBoxFiltrUzytkownik.Width + (labelOdData.Width / 4);
                    dateTimePickerFiltrOd.Left = labelOdData.Left + labelOdData.Width + (labelOdData.Width / 4);
                    labelDoData.Left = dateTimePickerFiltrOd.Left + dateTimePickerFiltrOd.Width + (labelDoData.Width / 4);
                    dateTimePickerFiltrDo.Left = labelDoData.Left + labelDoData.Width + (labelDoData.Width / 4);
                    checkBoxFiltrZaawansowany.Left = dateTimePickerFiltrDo.Left + dateTimePickerFiltrDo.Width + (labelDoData.Width / 2);

                    comboBoxFiltrWyborOperacji.Top = splitContainerFiltr.Panel1.Height / 2;
                    comboBoxFiltrUzytkownik.Top = splitContainerFiltr.Panel1.Height / 2;
                    labelOdData.Top = splitContainerFiltr.Panel1.Height / 2 + 6;
                    dateTimePickerFiltrOd.Top = splitContainerFiltr.Panel1.Height / 2 + 3;
                    labelDoData.Top = splitContainerFiltr.Panel1.Height / 2 + 6;
                    dateTimePickerFiltrDo.Top = splitContainerFiltr.Panel1.Height / 2 + 3;
                    checkBoxFiltrZaawansowany.Top = splitContainerFiltr.Panel1.Height / 2 + 5;

                    // Filtr zaawansowany

                    comboBoxFiltrKategoria.Width = splitContainerFiltr.Panel1.Width / 7;
                    textBoxFiltrKwotaOd.Width = splitContainerFiltr.Panel1.Width / 8 - 3;
                    textBoxFiltrKwotaDo.Width = splitContainerFiltr.Panel1.Width / 8 - 3;
                    textBoxSzukajWOpisie.Width = splitContainerFiltr.Panel1.Width / 5;
                    buttonWyszukaj.Width = splitContainerFiltr.Panel1.Width / 8;

                    comboBoxFiltrKategoria.Left = splitContainerFiltr.Panel1.Width / 50;
                    labelOdKwota.Left = comboBoxFiltrKategoria.Left + comboBoxFiltrKategoria.Width + (labelOdKwota.Width / 4);
                    textBoxFiltrKwotaOd.Left = labelOdKwota.Left + labelOdKwota.Width + (labelOdKwota.Width / 4);
                    labelDoKwota.Left = textBoxFiltrKwotaOd.Left + textBoxFiltrKwotaOd.Width + (labelOdKwota.Width / 4);
                    textBoxFiltrKwotaDo.Left = labelDoKwota.Left + labelDoKwota.Width + (labelOdKwota.Width / 4);
                    labelSzukajWOpisie.Left = textBoxFiltrKwotaDo.Left + textBoxFiltrKwotaDo.Width + (labelDoKwota.Width / 2);
                    textBoxSzukajWOpisie.Left = labelSzukajWOpisie.Left + labelSzukajWOpisie.Width + (labelDoKwota.Width / 3) - 2;
                    buttonWyszukaj.Left = textBoxSzukajWOpisie.Left + textBoxSzukajWOpisie.Width + labelDoKwota.Width + 5;

                    comboBoxFiltrKategoria.Top = comboBoxFiltrWyborOperacji.Top + comboBoxFiltrWyborOperacji.Height + (labelDoData.Width / 2) + (labelDoData.Width / 4);
                    labelOdKwota.Top = comboBoxFiltrWyborOperacji.Top + comboBoxFiltrWyborOperacji.Height + (labelDoData.Width / 2) + (labelDoData.Width / 4) + 6;
                    textBoxFiltrKwotaOd.Top = comboBoxFiltrWyborOperacji.Top + comboBoxFiltrWyborOperacji.Height + (labelDoData.Width / 2) + (labelDoData.Width / 4) + 1;
                    labelDoKwota.Top = comboBoxFiltrWyborOperacji.Top + comboBoxFiltrWyborOperacji.Height + (labelDoData.Width / 2) + (labelDoData.Width / 4) + 6;
                    textBoxFiltrKwotaDo.Top = comboBoxFiltrWyborOperacji.Top + comboBoxFiltrWyborOperacji.Height + (labelDoData.Width / 2) + (labelDoData.Width / 4) + 1;
                    labelSzukajWOpisie.Top = comboBoxFiltrWyborOperacji.Top + comboBoxFiltrWyborOperacji.Height + (labelDoData.Width / 2) + (labelDoData.Width / 4) + 6;
                    textBoxSzukajWOpisie.Top = comboBoxFiltrWyborOperacji.Top + comboBoxFiltrWyborOperacji.Height + (labelDoData.Width / 2) + (labelDoData.Width / 4) + 1;
                    buttonWyszukaj.Top = comboBoxFiltrWyborOperacji.Top + comboBoxFiltrWyborOperacji.Height + (labelDoData.Width / 2) + (labelDoData.Width / 4);

                    // Górne przyciski

                    buttonWyloguj.Width = splitContainerFiltr.Panel1.Width / 11;
                    buttonUstawienia.Width = splitContainerFiltr.Panel1.Width / 7;
                    buttonPowiadomienia.Width = splitContainerFiltr.Panel1.Width / 9;

                    buttonWyloguj.Left = splitContainerFiltr.Panel1.Width - buttonWyloguj.Width;
                    buttonUstawienia.Left = buttonWyloguj.Left - buttonUstawienia.Width;
                    buttonPowiadomienia.Left = buttonUstawienia.Left - buttonPowiadomienia.Width;

                    buttonWyloguj.Top = splitContainerFiltr.Panel1.Top;
                    buttonUstawienia.Top = splitContainerFiltr.Panel1.Top;
                    buttonPowiadomienia.Top = splitContainerFiltr.Panel1.Top;
                }
                */
            }
        }
        /*
        private void checkBoxFiltrZaawansowany_CheckedChanged(object sender, EventArgs e)
        {

            CheckBox c = (CheckBox)sender as CheckBox;

            if (c.Checked == true)
            {
                splitContainerFiltr.SplitterDistance = 125;
                splitContainerSaldo.SplitterDistance = 605;
                filtrZaawansowany = true;
            }
            else
            {
                splitContainerFiltr.SplitterDistance = 80;
                splitContainerSaldo.SplitterDistance = 650;
                filtrZaawansowany = false;
                resetFiltruZaawansowanego();
            }
        }
        */
        /*
        private void resetFiltruZaawansowanego()
        {
            comboBoxFiltrKategoria.Text = "Wybierz kategorię";
            textBoxFiltrKwotaOd.Text = "100 zł";
            textBoxFiltrKwotaDo.Text = "100 000 zł";
            comboBoxFiltrKategoria.ForeColor = Color.DimGray;
            textBoxFiltrKwotaDo.ForeColor = Color.DimGray;
            textBoxFiltrKwotaDo.ForeColor = Color.DimGray;
        }
        */
        private void buttonDodajPrzychód_Click(object sender, EventArgs e)
        {
            trybDodajPrzychod();
        }

        private void buttonDodajWydatek_Click(object sender, EventArgs e)
        {
            trybDodajWydatek();
        }

        private void trybDodajPrzychod()
        {
            splitContainerMenuBoczneWidok.Panel1.BackColor = Color.FromArgb(128, 255, 170);
            /*
            checkBoxCykliczny.BackColor = Color.FromArgb(128, 255, 170);
            buttonReset.BackColor = Color.FromArgb(230, 255, 230);
            buttonZapisz.BackColor = Color.FromArgb(230, 255, 230);
            textBoxDodajKwote.Text = "Dodaj kwotę przychodu";
            textBoxDodajKwote.ForeColor = Color.DimGray;
            trybPrzychod = true;
            */
        }

        private void trybDodajWydatek()
        {
            splitContainerMenuBoczneWidok.Panel1.BackColor = Color.FromArgb(255, 128, 128);
            /*
            checkBoxCykliczny.BackColor = Color.FromArgb(255, 128, 128);
            buttonReset.BackColor = Color.FromArgb(255, 230, 230);
            buttonZapisz.BackColor = Color.FromArgb(255, 230, 230);
            textBoxDodajKwote.Text = "Dodaj kwotę wydatku";
            textBoxDodajKwote.ForeColor = Color.DimGray;
            trybPrzychod = false;
            */
        }

        private void buttonWidokKalendarz_Click(object sender, EventArgs e)
        {
            //trybWidokKalendarz();
            kalendarz = new uc_kalendarz(Aktualnie_zalogowany);
            splitContainerGlowny.Panel2.Controls.Clear();
            kalendarz.Dock = DockStyle.Fill;
            splitContainerGlowny.Panel2.Controls.Add(kalendarz);
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

        private void buttonWidokKolumnowy_Click(object sender, EventArgs e)
        {
            //trybKolumnowy();
        }

        private void buttonWidokTabelka_Click(object sender, EventArgs e)
        {
            tabela_fitlr = new uc_tabela_filtr(Aktualnie_zalogowany);
            splitContainerGlowny.Panel2.Controls.Clear();
            tabela_fitlr.Dock = DockStyle.Fill;
            splitContainerGlowny.Panel2.Controls.Add(tabela_fitlr);
            //trybWidokTabelka();
        }
        //Kot do zmienienia
        /*
        Dictionary<int,operacje> dict_operacje = new Dictionary<int, operacje>();
        Dictionary<int, ListViewItem> dict_rekordy = new Dictionary<int, ListViewItem>();
        
        private void trybWidokTabelka()
        {
            labelInfoKalendarz.Visible = false;
            listViewGlowne.Visible = true;
            listViewGlowne.Items.Clear();

            var query = SingletonBaza.Instance.BazaDC.operacje;
            foreach (var row in query)
            {
                var
                nowy_rekord = listViewGlowne.Items.Add(row.id_operacji.ToString());
                nowy_rekord.SubItems.Add(row.uzytkownicy.imie + " " + row.uzytkownicy.nazwisko);
                nowy_rekord.SubItems.Add(row.nazwa);
                nowy_rekord.SubItems.Add(row.kwota.ToString());
                nowy_rekord.SubItems.Add(row.data.ToShortDateString());
                nowy_rekord.SubItems.Add(row.kategoria.typ);
                nowy_rekord.SubItems.Add(row.kategoria.nazwa);
                nowy_rekord.SubItems.Add(row.forma_platnosci.nazwa);
                nowy_rekord.SubItems.Add(row.opis);
                dict_operacje.Add(row.id_operacji,row);
                dict_rekordy.Add(row.id_operacji, nowy_rekord);
            }

            chartGlowny.Visible = false;
        }
        .
        private void trybWidokKalendarz()
        {
            labelInfoKalendarz.Visible = true;
            listViewGlowne.Visible = false;
            chartGlowny.Visible = false;
        }

        private void trybWidokLiniowy()
        {
            labelInfoKalendarz.Visible = false;
            listViewGlowne.Visible = false;
            chartGlowny.Visible = true;
            chartGlowny.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
        }
        
        private void trybKolowy()
        {
            chartGlowny.Visible = true;
            chartGlowny.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            labelInfoKalendarz.Visible = false;
        }

        private void trybKolumnowy()
        {
            chartGlowny.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            labelInfoKalendarz.Visible = false;
            chartGlowny.Visible = true;
        }

        */
        /*
        private void textBoxDodajKwote_Click(object sender, EventArgs e)
        {
            if (textBoxDodajKwote.Text  == "Dodaj kwotę przychodu" || textBoxDodajKwote.Text == "Dodaj kwotę wydatku")
            {
                textBoxDodajKwote.Text = "";
                textBoxDodajKwote.ForeColor = Color.Black;
            }
        }
        
        private void comboBoxKategoria_Click(object sender, EventArgs e)
        {
            if (comboBoxKategoria.Text == "Wybierz kategorię")
            {
                comboBoxKategoria.Text = "";
                comboBoxKategoria.ForeColor = Color.Black;
            }
        }

        private void richTextBoxDodaj_Click(object sender, EventArgs e)
        {
            if (richTextBoxDodaj.Text == "Dodaj opcjonalny opis")
            {
                richTextBoxDodaj.Text = "";
                richTextBoxDodaj.ForeColor = Color.Black;
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            if (trybPrzychod==true)
            {
                textBoxDodajKwote.Text = "Dodaj kwotę przychodu";
            }
            else
            {
                textBoxDodajKwote.Text = "Dodaj kwotę wydatku";
            }
            textBoxDodajKwote.ForeColor = Color.DimGray;
            comboBoxKategoria.Text = "Wybierz kategorię";
            comboBoxKategoria.ForeColor = Color.DimGray;
            richTextBoxDodaj.Text = "Dodaj opcjonalny opis";
            richTextBoxDodaj.ForeColor = Color.DimGray;
        }

        private void comboBoxFiltrWyborOperacji_Click(object sender, EventArgs e)
        {
            if (comboBoxFiltrWyborOperacji.Text == "Wybierz operację")
            {
                comboBoxFiltrWyborOperacji.Text = "";
                comboBoxFiltrWyborOperacji.ForeColor = Color.Black;
            }
        }

        private void comboBoxFiltrKategoria_Click(object sender, EventArgs e)
        {
            if (comboBoxFiltrKategoria.Text == "Wybierz kategorię")
            {
                comboBoxFiltrKategoria.Text = "";
                comboBoxFiltrKategoria.ForeColor = Color.Black;
            }
        }

        private void textBoxFiltrKwotaOd_Click(object sender, EventArgs e)
        {
            if (textBoxFiltrKwotaOd.Text == "100 zł")
            {
                textBoxFiltrKwotaOd.Text = "";
                textBoxFiltrKwotaOd.ForeColor = Color.Black;
            }
        }

        private void textBoxFiltrKwotaDo_Click(object sender, EventArgs e)
        {
            if (textBoxFiltrKwotaDo.Text == "100 000 zł")
            {
                textBoxFiltrKwotaDo.Text = "";
                textBoxFiltrKwotaDo.ForeColor = Color.Black;
            }
        }
        */
        private void panelGlowny_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void buttonWyloguj_Click(object sender, EventArgs e)
        {

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
    }
}
