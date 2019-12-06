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
    public partial class uc_formularz_operacja : UserControl
    {
        private operacje operacjaDoEdycji;

        internal operacje Wybrana
        {
            get
            {
                return operacjaDoEdycji;
            }
            set
            {
                operacjaDoEdycji = value;
            }
        }

        public uc_formularz_operacja()
        {
            InitializeComponent();
        }

        public uc_formularz_operacja(operacje o)
        {
            InitializeComponent();
            this.operacjaDoEdycji = o;

            textBoxNazwa.Text = operacjaDoEdycji.nazwa;
            dateTimePickerOperacji.Value = operacjaDoEdycji.data;
            comboBoxKategoria.SelectedItem = operacjaDoEdycji.kategoria;
            comboBoxFormaOperacji.SelectedItem = operacjaDoEdycji.forma_platnosci;
            numericUpDownKwota.Value = operacjaDoEdycji.kwota;
            richTextBoxOpisOperacji.Text = operacjaDoEdycji.opis;
            textBoxNazwa.BackColor = Color.FromArgb(255, 204, 204);

        }
        
        private void WczytajWszystko()
        {
            if (radioButtonWydatek.Checked)
            {
                comboBoxKategoria.DataSource = SingletonBaza.Instance.BazaDC.kategoria.Where(x => x.typ == "wydatek");
            }
            else if (radioButtonPrzychod.Checked)
            {
                comboBoxKategoria.DataSource = SingletonBaza.Instance.BazaDC.kategoria.Where(x => x.typ == "przychod");
            }

            comboBoxFormaOperacji.DataSource = SingletonBaza.Instance.BazaDC.forma_platnosci;

            comboBoxKategoria.DisplayMember = "nazwa";
            comboBoxFormaOperacji.DisplayMember = "nazwa";
            
        }

        private void CzyszcKategorie()
        {
            comboBoxKategoria.SelectedItem = null;
        }

        private void Czysc()
        {
            CzyszcKategorie();
            textBoxNazwa.Clear();
            comboBoxFormaOperacji.SelectedItem = null;
            numericUpDownKwota.Value = 0;
            richTextBoxOpisOperacji.Clear();
            dateTimePickerOperacji.Value = DateTime.Today;
            textBoxNazwa.BackColor = Color.White;
            comboBoxFormaOperacji.BackColor = Color.White;
            comboBoxKategoria.BackColor = Color.White;
            numericUpDownKwota.BackColor = Color.White;
            pictureWykrzyknikForma.Visible = false;
            pictureWykrzyknikKategoria.Visible = false;
            pictureWykrzyknikKwota.Visible = false;
            pictureBoxNazwaWykrzyknik.Visible = false;
        }

        private bool ValidationAddEditForm()
        {
            bool Check = false;

            if (textBoxNazwa.Text.Length > 20)
            {
                pictureBoxNazwaWykrzyknik.Visible = true;
                textBoxNazwa.BackColor = Color.FromArgb(255, 204, 204);
                Check = true;
            }
            else
            {
                pictureBoxNazwaWykrzyknik.Visible = false;
                textBoxNazwa.BackColor = Color.White;
            }

            if (comboBoxFormaOperacji.SelectedIndex == -1)
            {
                pictureWykrzyknikForma.Visible = true;
                comboBoxFormaOperacji.BackColor = Color.FromArgb(255, 204, 204);
                Check = true;
            }
            else
            {
                pictureWykrzyknikForma.Visible = false;
                comboBoxFormaOperacji.BackColor = Color.White;
            }

            if (comboBoxKategoria.SelectedIndex == -1)
            {
                pictureWykrzyknikKategoria.Visible = true;
                comboBoxKategoria.BackColor = Color.FromArgb(255, 204, 204);
                Check = true;
            }
            else
            {
                pictureWykrzyknikKategoria.Visible = false;
                comboBoxKategoria.BackColor = Color.White;
            }

            if (numericUpDownKwota.Value == 0)
            {
                pictureWykrzyknikKwota.Visible = true;
                numericUpDownKwota.BackColor = Color.FromArgb(255, 204, 204);
                Check = true;
            }
            else
            {
                pictureWykrzyknikKwota.Visible = false;
                numericUpDownKwota.BackColor = Color.White;
            }

            if (Check == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void ResetOperacji()
        {
            if (operacjaDoEdycji != null)
            {
                operacjaDoEdycji.usun_sesje();
            }
            operacjaDoEdycji = null;
            Czysc();
        }
        enum Tryb_formularza
        {
            nowy = 0,
            edycja = 1
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (ValidationAddEditForm() == true)
            {
                return;
            }
            else
            {
                Tryb_formularza tryb;
                if (operacjaDoEdycji == null)
                {
                    tryb = Tryb_formularza.nowy;
                    operacjaDoEdycji = new operacje();
                    SingletonBaza.Instance.BazaDC.operacje.InsertOnSubmit(operacjaDoEdycji);
                }
                else
                {
                    tryb = Tryb_formularza.edycja;
                }
                DateTime stara_data = operacjaDoEdycji.data;
                operacjaDoEdycji.nazwa = textBoxNazwa.Text;
                operacjaDoEdycji.kategoria = comboBoxKategoria.SelectedItem as kategoria;
                operacjaDoEdycji.forma_platnosci = comboBoxFormaOperacji.SelectedItem as forma_platnosci;
                operacjaDoEdycji.data = dateTimePickerOperacji.Value;
                operacjaDoEdycji.kwota = numericUpDownKwota.Value;
                if(tryb == Tryb_formularza.nowy)
                {
                    operacjaDoEdycji.uzytkownicy = SingletonBaza.Zalogowany;
                }
                operacjaDoEdycji.Zatwierdzone = true;
                if(SingletonBaza.Zalogowany.czy_obserwator())
                {
                    MessageBox.Show("obserwator");
                    operacjaDoEdycji.Zatwierdzone = false;
                }
                operacjaDoEdycji.opis = richTextBoxOpisOperacji.Text;
                SingletonBaza.Instance.BazaDC.SubmitChanges();
                ((panelGlowny) this.FindForm()).odswierz_dany_dzien(operacjaDoEdycji.data);
                if(operacjaDoEdycji.data!= stara_data)
                {
                    ((panelGlowny)this.FindForm()).odswierz_dany_dzien(stara_data);
                }
                ((panelGlowny)this.FindForm()).odsiwerz_dana_operacje_w_tabeli(operacjaDoEdycji.id_operacji);
                ResetOperacji();
                
            }
        }

        private void radioButtonExpense_CheckedChanged(object sender, EventArgs e)
        {
            WczytajWszystko();
            CzyszcKategorie();
        }

        private void radioButtonIncome_CheckedChanged(object sender, EventArgs e)
        {
            WczytajWszystko();
            CzyszcKategorie();
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            Czysc();
            ResetOperacji();
            ((panelGlowny)this.FindForm()).Focus();
        }

        private void uc_formularz_operacja_Enter(object sender, EventArgs e)
        {
            if (operacjaDoEdycji == null)
            {
                radioButtonWydatek.Checked = true;
                WczytajWszystko();
                Czysc();
            }
            else
            {
                WczytajWszystko();
                if (operacjaDoEdycji.kategoria.typ == "wydatek")
                {
                    radioButtonWydatek.Checked = true;
                }
                else if (operacjaDoEdycji.kategoria.typ == "przychod")
                {
                    radioButtonPrzychod.Checked = true;
                }
                textBoxNazwa.Text = operacjaDoEdycji.nazwa;
                comboBoxKategoria.SelectedItem = operacjaDoEdycji.kategoria;
                comboBoxFormaOperacji.SelectedItem = operacjaDoEdycji.forma_platnosci;
                numericUpDownKwota.Value = operacjaDoEdycji.kwota;
                richTextBoxOpisOperacji.Text = operacjaDoEdycji.opis;
                dateTimePickerOperacji.Value = operacjaDoEdycji.data;
            }
        }

        private void pictureBoxNazwaWykrzyknik_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Limit znaków 20");
        }

        private void pictureWykrzyknikForma_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Wybierz formę płatności");
        }

        private void pictureWykrzyknikKategoria_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Wybierz kategorię");
        }

        private void pictureWykrzyknikKwota_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Kwota musi być większa od 0");
        }
    }
}
