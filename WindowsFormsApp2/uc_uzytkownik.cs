using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Net;
using System.Net.Mail;

namespace WindowsFormsApp2
{
    public partial class uc_uzytkownik : UserControl
    {
        uzytkownicy Edytowana;
        public uc_uzytkownik()
        {
            InitializeComponent();
            wczytaj_role();
            tb_haslo.Enabled = true;
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
            //nm_majatek.Value = 0;
            cb_role.SelectedItem = Edytowana.role;
        }

        private void wczytaj_role()
        {
            cb_role.DataSource = SingletonBaza.Instance.BazaDC.role;
            cb_role.DisplayMember = "nazwa";
        }

        public static bool EmailIsValid(string email)
        {
            string expression = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";

            if (Regex.IsMatch(email, expression))
            {
                if (Regex.Replace(email, expression, string.Empty).Length == 0)
                {
                    return true;
                }
            }
            return false;
        }

        private bool Walidacja()
        {
            bool Check = false;

            if (!EmailIsValid(tb_email.Text))
            {
                Check = true;
                tb_email.BackColor = Color.FromArgb(255, 204, 204);
            }
            else
            {
                tb_email.BackColor = Color.White;
                Check = false;
            }

            if (SingletonBaza.Instance.BazaDC.uzytkownicy.SingleOrDefault(x => x.login.Equals(tb_login.Text)) != null
                || tb_login.Text == "" || tb_login.Text.Length > 50)
            {
                Check = true;
                tb_login.BackColor = Color.FromArgb(255, 204, 204);
            }
            else
            {
                Check = false;
                tb_login.BackColor = Color.White;
            }

            if (tb_imie.Text == "" || tb_imie.Text.Length > 50)
            {
                Check = true;
                tb_imie.BackColor = Color.FromArgb(255, 204, 204);
            }
            else
            {
                Check = false;
                tb_imie.BackColor = Color.White;
            }

            if (tb_nazwisko.Text == "" || tb_nazwisko.Text.Length > 50)
            {
                Check = true;
                tb_nazwisko.BackColor = Color.FromArgb(255, 204, 204);
            }
            else
            {
                Check = false;
                tb_nazwisko.BackColor = Color.White;
            }

            if (!Enabled && ( tb_haslo.Text == "" || tb_haslo.Text.Length < 6))
            {
                Check = true;
                tb_haslo.BackColor = Color.FromArgb(255, 204, 204);
            }
            else
            {
                Check = false;
                tb_haslo.BackColor = Color.White;
            }

            if (cb_role.SelectedIndex == -1)
            {
                Check = true;
                cb_role.BackColor = Color.FromArgb(255, 204, 204);
            }
            else
            {
                Check = false;
                cb_role.BackColor = Color.White;
            }

            if (Check == true)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        internal void Zapisz()
        {
            // edytowana
            if (Edytowana != null)
            {
                if (Walidacja() == false)
                {
                    return;
                }
            }
            else
            {
                bool haslo = false;
                uzytkownicy doZapisu = null;
                if (Edytowana == null)
                {
                    doZapisu = new uzytkownicy();
                    SingletonBaza.Instance.BazaDC.uzytkownicy.InsertOnSubmit(doZapisu);
                }
                else
                {
                    doZapisu = Edytowana;
                }
                if (Enabled)
                {
                    doZapisu.imie = tb_imie.Text;
                    doZapisu.nazwisko = tb_nazwisko.Text;
                    doZapisu.email = tb_email.Text;
                    doZapisu.login = tb_login.Text;
                    if (tb_haslo.Enabled)
                    {
                        haslo = true;
                        doZapisu.haslo = hashowanie.GetHashString(tb_haslo.Text);
                    }
                    doZapisu.role = cb_role.SelectedItem as role;
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
                SingletonBaza.Instance.BazaDC.SubmitChanges();
                if (haslo)
                {
                    ZmiannaHasla();
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

        private void buttonZapisz_Click(object sender, EventArgs e)
        {
            role rola = Edytowana.role;
            Zapisz();
            if(rola.nazwa == "Obserwator" && Edytowana.role.nazwa != "Obserwator")
            {
                foreach(operacje o in Edytowana.operacje.Where(x => x.Zatwierdzone == false))
                {
                    o.Zatwierdzone = true;
                    ((panelGlowny)this.FindForm()).odsiwerz_dana_operacje_w_tabeli(o.id_operacji);
                }
                SingletonBaza.Instance.BazaDC.SubmitChanges();
            }

        }

        private void tb_login_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = e.KeyChar != (char)Keys.Back && !char.IsSeparator(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }

        private void tb_imie_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = e.KeyChar != (char)Keys.Back && !char.IsSeparator(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }

        private void tb_nazwisko_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = e.KeyChar != (char)Keys.Back && !char.IsSeparator(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }

        private void ZmiannaHasla()
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress("homebudget12145@gmail.com");
                mail.To.Add(Edytowana.email);
                mail.Subject = "HomeBudget -Twoje hasło zostało zmiennione";
                mail.Body = "Twoje hasło zostało zmiennione na \"" + tb_haslo.Text+"\"";

                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential("homebudget12145@gmail.com", "#Qwerty123");
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);
                MessageBox.Show("Mail został wysłany");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


    }
}
