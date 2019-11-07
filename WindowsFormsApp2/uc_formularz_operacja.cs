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

            tb_nazwa.Text = operacjaDoEdycji.nazwa;
            dateTimePickerDate.Value = operacjaDoEdycji.data;
            comboBoxCategory.SelectedItem = operacjaDoEdycji.kategoria;
            comboBoxOperationForm.SelectedItem = operacjaDoEdycji.forma_platnosci;
            nm_kwota.Value = operacjaDoEdycji.kwota;
            richTextBoxDescription.Text = operacjaDoEdycji.opis;
            
        }
        
        private void WczytajWszystko()
        {
            if (radioButtonExpense.Checked)
            {
                comboBoxCategory.DataSource = SingletonBaza.Instance.BazaDC.kategoria.Where(x => x.typ == "wydatek");
            }
            else if (radioButtonIncome.Checked)
            {
                comboBoxCategory.DataSource = SingletonBaza.Instance.BazaDC.kategoria.Where(x => x.typ == "przychod");
            }

            comboBoxOperationForm.DataSource = SingletonBaza.Instance.BazaDC.forma_platnosci;

            comboBoxCategory.DisplayMember = "nazwa";
            comboBoxOperationForm.DisplayMember = "nazwa";
            
        }

        private void CzyszcKategorie()
        {
            comboBoxCategory.SelectedItem = null;
        }

        private void Czysc()
        {
            CzyszcKategorie();
            tb_nazwa.Clear();
            comboBoxOperationForm.SelectedItem = null;
            nm_kwota.Value = 0;
            richTextBoxDescription.Clear();
            dateTimePickerDate.Value = DateTime.Today;
        }

        private bool ValidationAddEditForm()
        {
            bool Check = false;
            //Sprawdzanie tekstu???


            if (comboBoxOperationForm.SelectedIndex == -1)
            {
                pictureBox2.Visible = true;
                labelChoosePaymentForm.Visible = true;
                Check = true;
            }
            else
            {
                pictureBox2.Visible = false;
                labelChoosePaymentForm.Visible = false;
            }

            if (comboBoxCategory.SelectedIndex == -1)
            {
                pictureBox3.Visible = true;
                labelChooseCategory.Visible = true;
                Check = true;
            }
            else
            {
                pictureBox3.Visible = false;
                labelChooseCategory.Visible = false;
            }


            if (nm_kwota.Value == 0)
            {
                pictureBox5.Visible = true;
                labelWritePrice.Visible = true;
                Check = true;
            }
            else
            {
                pictureBox5.Visible = false;
                labelWritePrice.Visible = false;
            }
            return Check;
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

                operacjaDoEdycji.nazwa = tb_nazwa.Text;
                operacjaDoEdycji.kategoria = comboBoxCategory.SelectedItem as kategoria;
                operacjaDoEdycji.forma_platnosci = comboBoxOperationForm.SelectedItem as forma_platnosci;
                operacjaDoEdycji.data = dateTimePickerDate.Value;
                operacjaDoEdycji.kwota = nm_kwota.Value;
                operacjaDoEdycji.uzytkownicy = AkualnieZalogowany;
                operacjaDoEdycji.opis = richTextBoxDescription.Text;
                operacjaDoEdycji.uzytkownicy = AkualnieZalogowany;
                SingletonBaza.Instance.BazaDC.SubmitChanges();
                ((panelGlowny) this.FindForm()).odswierz_dany_dzien(operacjaDoEdycji.data);
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
        }

        private void uc_formularz_operacja_Enter(object sender, EventArgs e)
        {
            if (operacjaDoEdycji == null)
            {
                radioButtonExpense.Checked = true;
                WczytajWszystko();
                Czysc();
            }
            else
            {
                WczytajWszystko();
                if (operacjaDoEdycji.kategoria.typ == "wydatek")
                {
                    radioButtonExpense.Checked = true;
                }
                else if (operacjaDoEdycji.kategoria.typ == "przychod")
                {
                    radioButtonIncome.Checked = true;
                }
                tb_nazwa.Text = operacjaDoEdycji.nazwa;
                comboBoxCategory.SelectedItem = operacjaDoEdycji.kategoria;
                comboBoxOperationForm.SelectedItem = operacjaDoEdycji.forma_platnosci;
                nm_kwota.Value = operacjaDoEdycji.kwota;
                richTextBoxDescription.Text = operacjaDoEdycji.opis;
                dateTimePickerDate.Value = operacjaDoEdycji.data;
            }
        }
    }
}
