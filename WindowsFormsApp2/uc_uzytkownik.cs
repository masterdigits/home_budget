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
    public partial class uc_uzytkownik : UserControl
    {
        uzytkownicy Edytowana;
        public uc_uzytkownik()
        {
            InitializeComponent();
            wczytaj_role();
            tb_haslo.Enabled= true;
        }
        public uc_uzytkownik(uzytkownicy u)
        {
            InitializeComponent();
            wczytaj_role();
            Edytowana = u;
            tb_imie.Text = Edytowana.imie;
            tb_nazwisko.Text = Edytowana.nazwisko;
            tb_email.Text = Edytowana.email;
            tb_login.Text = Edytowana.login;
            //Brak majątku w bazie :D
            nm_majatek.Value = 0;
            cb_role.SelectedItem = Edytowana.role;
        }
        private void wczytaj_role()
        {
            cb_role.DataSource = SingletonBaza.Instance.BazaDC.role;
            cb_role.DisplayMember = "nazwa";
        }
        internal void Zapisz()
        {
            uzytkownicy doZapisu = null;
            if(Edytowana==null)
            {
                doZapisu = new uzytkownicy();
            }
            else
            {
                doZapisu = Edytowana;
            }
            if(Enabled)
            {
                doZapisu.imie = tb_imie.Text;
                doZapisu.nazwisko = tb_nazwisko.Text;
                doZapisu.email = tb_email.Text;
                doZapisu.login = tb_login.Text;
                if (tb_haslo.Enabled)
                {
                    doZapisu.haslo = hashowanie.GetHashString(tb_haslo.Text);
                }
                tb_haslo.Enabled = false;
            }
            else
            {
                if (Edytowana != null)
                {
                    SingletonBaza.Instance.BazaDC.operacje.DeleteAllOnSubmit(SingletonBaza.Instance.BazaDC.operacje.Where(x => x.uzytkownicy == doZapisu));
                    SingletonBaza.Instance.BazaDC.uzytkownicy.DeleteOnSubmit(doZapisu);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Czy na pewno chcesz usunąć użytkownika ? Usunięcie użytkwnika spowoduje usunięcie wraz z nim wszystkie utworzone przez niego operacje!", "Usuwanie użytkownika", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {

                Enabled = false;
            }
        }

        private void zmieńHasłoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tb_haslo.Enabled = true;
        }

        private void anulujZmiannęToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tb_haslo.Text = "";
            tb_haslo.Enabled = false;
        }
    }
}
