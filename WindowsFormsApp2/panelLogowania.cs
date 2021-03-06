﻿using System;
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

        public panelLogowania()
        {
            InitializeComponent();
            tryb_loguj();
        }
        String login
        {
            get
            {
                return textBoxLogin1.Text;
            }
        }
        String haslo
        {
            get
            {
                // Tutaj musi być funkcja hasujaca, która też używana jest do rejestracji!!!
                return textBoxHaslo1.Text;
            }
        }
        private void linkLabel_register_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            tryb_rejestracja();
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            
            groupBoxLogin.Left = (this.ClientSize.Width - groupBoxLogin.Width) / 2;
            
            groupBoxLogin.Top = (this.ClientSize.Height - groupBoxLogin.Height) / 2;
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            tryb_loguj();
        }
        private void tryb_rejestracja()
        {
            
            groupBoxLogin.Visible = false;
        }
        private void tryb_loguj()
        {
            groupBoxLogin.Visible = true;
            
        }

        private void buttonZaloguj_Click(object sender, EventArgs e)
        {

            var query = from uzytkownik in SingletonBaza.Instance.BazaDC.uzytkownicy
                        where uzytkownik.login == login
                        && uzytkownik.haslo == 
                        hashowanie.GetHashString(haslo)
                        select uzytkownik;
            if (query.Any())
            {
                panelGlowny PG = new panelGlowny(query.FirstOrDefault());
                this.Hide();
                SingletonBaza.ustaw_zalogowanego(query.FirstOrDefault());
                PG.Closed += (s, args) => this.Close();
                PG.ShowDialog();
                
            }
            else
            {
                MessageBox.Show("Błąd logowania do bazy danych!");
            }

        }

       /* private void buttonRejestracja_Click(object sender, EventArgs e)
        {
            uzytkownicy nowy = new uzytkownicy();
            //Tutaj walidacja jest potrzebna oraz gdy dodajemy haslo funkcja hashujaca !!!
            nowy.imie = textBoxImie.Text;
            nowy.nazwisko = textBoxNazwisko.Text;
            nowy.email = textBoxEmail.Text;
            nowy.login = textBoxLogin.Text;
            nowy.haslo = hashowanie.GetHashString(textBoxHaslo.Text);
            // Tutaj jest możliwy wybór roli jak nie to 
            nowy.id_roli = 1;

            SingletonBaza.Instance.BazaDC.uzytkownicy.InsertOnSubmit(nowy);
            SingletonBaza.Instance.BazaDC.SubmitChanges();

            MessageBox.Show("Udana rejestracja");


            panelLogowania PL = new panelLogowania();
            this.Hide();
            PL.ShowDialog();
        }*/

        private void button1_Click(object sender, EventArgs e)
        {
        }
    }
}
