using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace WindowsFormsApp2
{
    public partial class panelLogowania : Form
    {
        SqlCommand cmd;
        SqlConnection con;
        SqlDataAdapter da;
        public panelLogowania()
        {
            InitializeComponent();
            tryb_loguj();
        }

        private void linkLabel_register_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            tryb_rejestracja();
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            groupBoxRejestracja.Left = (this.ClientSize.Width - groupBoxRejestracja.Width) / 2;
            groupBoxLogin.Left = (this.ClientSize.Width - groupBoxLogin.Width) / 2;
            groupBoxRejestracja.Top = (this.ClientSize.Height - groupBoxRejestracja.Height) / 2;
            groupBoxLogin.Top = (this.ClientSize.Height - groupBoxLogin.Height) / 2;
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            tryb_loguj();
        }
        private void tryb_rejestracja()
        {
            groupBoxRejestracja.Visible = true;
            groupBoxLogin.Visible = false;
        }
        private void tryb_loguj()
        {
            groupBoxLogin.Visible = true;
            groupBoxRejestracja.Visible = false;
        }

        private void buttonZaloguj_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(@" Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\mkkar\Desktop\Budzet\budzet_domowy\WindowsFormsApp2\baza.mdf; Integrated Security = True; Connect Timeout = 30");
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) from Uzytkownicy where login ='" + textBoxLogin1.Text + "' and haslo='" + textBoxHaslo1.Text + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                panelGlowny PG = new panelGlowny();
                this.Hide();
                PG.ShowDialog();
            }
            else
            {
                MessageBox.Show("Błąd logowania do bazy danych!");
            }

        }

        private void buttonRejestracja_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(@" Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\mkkar\Desktop\Budzet\budzet_domowy\WindowsFormsApp2\baza.mdf; Integrated Security = True; Connect Timeout = 30");
            con.Open();
            cmd = new SqlCommand("Insert INTO Uzytkownicy(imie, nazwisko, login, haslo, email) values (@imie, @nazwisko, @login, @haslo, @email)", con);
            cmd.Parameters.AddWithValue("@imie", textBoxImie.Text);
            cmd.Parameters.AddWithValue("@nazwisko", textBoxNazwisko.Text);
            cmd.Parameters.AddWithValue("@login", textBoxLogin.Text);
            cmd.Parameters.AddWithValue("@haslo", textBoxHaslo.Text);
            cmd.Parameters.AddWithValue("@email", textBoxEmail.Text);
            cmd.ExecuteNonQuery();

            // string userText = textBoxULogin.Text;
            //string passText = textBoxHaslo.Text;
            /*
             * 
             */
            //string stRole = "administrator"; 
            MessageBox.Show("Udana rejestracja");


            panelLogowania PL = new panelLogowania();
            this.Hide();
            PL.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelGlowny PG = new panelGlowny();
            this.Hide();
            PG.ShowDialog();
        }
    }
}
