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
        public uzytkownicy AkualnieZalogowany { get; set; }

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
        }

        private bool ValidationAddEditForm()
        {
            bool Check = false;

            if (textBoxNazwa.Text == "")
            {
                pictureWykrzyknikNazwa.Visible = true;
                textBoxNazwa.BackColor = Color.FromArgb(255, 204, 204);
                Check = true;
            }
            else
            {
                pictureWykrzyknikNazwa.Visible = false;
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
            operacjaDoEdycji = null;
            Czysc();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (ValidationAddEditForm() == true)
            {
                return;
            }
            else
            {
                if (operacjaDoEdycji == null)
                {
                    operacjaDoEdycji = new operacje();
                    SingletonBaza.Instance.BazaDC.operacje.InsertOnSubmit(operacjaDoEdycji);
                }
                DateTime stara_data = operacjaDoEdycji.data;
                operacjaDoEdycji.nazwa = textBoxNazwa.Text;
                operacjaDoEdycji.kategoria = comboBoxKategoria.SelectedItem as kategoria;
                operacjaDoEdycji.forma_platnosci = comboBoxFormaOperacji.SelectedItem as forma_platnosci;
                operacjaDoEdycji.data = dateTimePickerOperacji.Value;
                operacjaDoEdycji.kwota = numericUpDownKwota.Value;
                operacjaDoEdycji.uzytkownicy = AkualnieZalogowany;
                operacjaDoEdycji.opis = richTextBoxOpisOperacji.Text;
                operacjaDoEdycji.uzytkownicy = AkualnieZalogowany;
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
    }
}
