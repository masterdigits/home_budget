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
    public partial class uc_filtr : UserControl
    {
        ListView lv_operacje;
        uc_wykres_kolumnowy uwk_operacje;
        // Wlasciwie filtr nie musi operowac na danych a jedynie przez internal oddac operacje przefiltorwane przez niego
        // ktore następnie zostaną wykorzystane do odswierzenia listview !!!  
        // Nalezy to poprawic!!!
        public Dictionary<int, operacje> dict_operacje = new Dictionary<int, operacje>();
        Dictionary<int, ListViewItem> dict_rekordy = new Dictionary<int, ListViewItem>();


        public enum Tryb_filtra
        {
            wykres = 0,
            tabela = 1
        }
        Tryb_filtra Tryb_aktualny;

        internal Tryb_filtra Tryb_aktualny_filtra
        {
            get
            {
                return Tryb_aktualny;
            }
            set
            {
                Tryb_aktualny = value;
            }
        }


        public uc_filtr()
        {
            InitializeComponent();
            wczytaj_kategorie();
            wczytaj_uzytkownikow();
        }
        public uc_filtr(ListView lvo, uc_wykres_kolumnowy ch)
        {
            Tryb_aktualny = Tryb_filtra.tabela;
            uwk_operacje = ch;
            lv_operacje = lvo;
            InitializeComponent();
            wczytaj_kategorie();
            wczytaj_uzytkownikow();
        }
        public uc_filtr(uc_wykres_kolumnowy ch)
        {
            Tryb_aktualny = Tryb_filtra.tabela;
            uwk_operacje = ch;
            InitializeComponent();
            wczytaj_kategorie();
            wczytaj_uzytkownikow();
        }

        // Ustaliłem że filter zarządza tabelką wiec bedzie tutaj kod operacji na tabelce oprócz edycji
        public void trybWidokTabelka()
        {
           //lv_operacje.Visible = true;
            lv_operacje.Items.Clear();

            var query = SingletonBaza.Instance.BazaDC.operacje.Where(x => x.Zatwierdzone == true);
            foreach (var row in query)
            {
                var
                nowy_rekord = lv_operacje.Items.Add(row.id_operacji.ToString());
                nowy_rekord.Name = row.id_operacji.ToString();
                nowy_rekord.SubItems.Add(row.uzytkownicy.imie + " " + row.uzytkownicy.nazwisko);
                nowy_rekord.SubItems.Add(row.nazwa);
                nowy_rekord.SubItems.Add(row.kwota.ToString());
                nowy_rekord.SubItems.Add(row.data.ToShortDateString());
                nowy_rekord.SubItems.Add(row.kategoria.typ);
                nowy_rekord.SubItems.Add(row.kategoria.nazwa);
                nowy_rekord.SubItems.Add(row.forma_platnosci.nazwa);
                nowy_rekord.SubItems.Add(row.opis);
                dict_operacje.Add(row.id_operacji, row);
                dict_rekordy.Add(row.id_operacji, nowy_rekord);
            }
        }
        // Ten kod może być wywowyłany bezpośrednio w form przez internal
        //Należy do kiedyś poprawić kiedy ustalony bedzię końcowy interfejs apliakcji
        public void odswierz_dana_operacje(int id)
        {
            var query = from op in SingletonBaza.Instance.BazaDC.operacje
                        where op.id_operacji == id
                        select op;
            operacje o = query.FirstOrDefault();
            if (o != null)
            {
                if (o.Zatwierdzone == true)
                {
                    dict_operacje[id] = o;
                    var
                    nowy_rekord = lv_operacje.Items.Add(o.id_operacji.ToString());
                    nowy_rekord.Name = o.id_operacji.ToString();
                    nowy_rekord.SubItems.Add(o.uzytkownicy.imie + " " + o.uzytkownicy.nazwisko);
                    nowy_rekord.SubItems.Add(o.nazwa);
                    nowy_rekord.SubItems.Add(o.kwota.ToString());
                    nowy_rekord.SubItems.Add(o.data.ToShortDateString());
                    nowy_rekord.SubItems.Add(o.kategoria.typ);
                    nowy_rekord.SubItems.Add(o.kategoria.nazwa);
                    nowy_rekord.SubItems.Add(o.forma_platnosci.nazwa);
                    nowy_rekord.SubItems.Add(o.opis);
                    if (dict_rekordy.ContainsKey(id))
                    {
                        lv_operacje.Items.Remove(dict_rekordy[id]);
                    }
                    dict_rekordy[id] = nowy_rekord;
                }
                else if (dict_rekordy.ContainsKey(id))
                {
                    dict_operacje.Remove(id);
                    lv_operacje.Items.Remove(dict_rekordy[id]);
                    dict_rekordy.Remove(id);
                }
            }
        }
        private void wczytaj_kategorie()
        {
            if (radioButtonExpense.Checked)
            {
                comboBoxFiltrKategoria.DataSource = SingletonBaza.Instance.BazaDC.kategoria.Where(x => x.typ == "wydatek");
            }
            else if (radioButtonIncome.Checked)
            {
                comboBoxFiltrKategoria.DataSource = SingletonBaza.Instance.BazaDC.kategoria.Where(x => x.typ == "przychod");
            }
            comboBoxFiltrKategoria.DisplayMember = "nazwa";
        }
        private void wczytaj_uzytkownikow()
        {
            ((ListBox)chlb_uzytkownicy).DataSource = SingletonBaza.Instance.BazaDC.uzytkownicy;
            ((ListBox)chlb_uzytkownicy).DisplayMember = "NazwiskoImie";
            if (SingletonBaza.Zalogowany != null)
            {
                chlb_uzytkownicy.SetItemChecked(chlb_uzytkownicy.Items.IndexOf(SingletonBaza.Zalogowany), true);
            }
        }
        private void CzyszcKategorie()
        {
            comboBoxFiltrKategoria.SelectedItem = null;
        }
        private void buttonWyszukaj_tabela_Click(object sender, EventArgs e)
        {
            //To tutaj zmienić na eventchanged dla każdej kontrolki
            String f_nazwa = null;
            List<uzytkownicy> f_uzyt = null;
            DateTime od_data = DateTime.MinValue;
            DateTime do_data = DateTime.MinValue;
            kategoria f_kategoria = null;
            decimal od_kwota = 0;
            decimal do_kwota = 0;
            string f_opis = null;
            if (tb_nazwa.Text != "")
            {
                f_nazwa = tb_nazwa.Text;
            }

            if (chlb_uzytkownicy.CheckedItems.Count > 0)
            {

                f_uzyt = new List<uzytkownicy>();
                foreach (uzytkownicy u in chlb_uzytkownicy.CheckedItems)
                {

                    f_uzyt.Add(u);
                }
            }

            if (uc_dodaj_date1.Data_od != DateTime.MinValue)
            {
                od_data = uc_dodaj_date1.Data_od;
            }
            if (uc_dodaj_date1.Data_do != DateTime.MinValue)
            {
                do_data = uc_dodaj_date1.Data_do;
            }

            if (comboBoxFiltrKategoria.SelectedItem != null)
            {
                f_kategoria = comboBoxFiltrKategoria.SelectedItem as kategoria;
            }
            if (nm_kwota_od.Value != 0)
            {
                od_kwota = nm_kwota_od.Value;
            }
            if (nm_kwota_do.Value != 0)
            {
                do_kwota = nm_kwota_do.Value;
            }
            if (textBoxSzukajWOpisie.Text != "")
            {
                f_opis = textBoxSzukajWOpisie.Text;
            }
            foreach (KeyValuePair<int, operacje> entry in dict_operacje)
            {
                if (!entry.Value.filtr(f_nazwa, f_uzyt, od_data, do_data,
                    f_kategoria, od_kwota, do_kwota, f_opis))
                {
                    lv_operacje.Items.Remove(dict_rekordy[entry.Key]);
                }
                else
                {
                    if (!lv_operacje.Items.Contains(dict_rekordy[entry.Key]))
                    {
                        lv_operacje.Items.Add(dict_rekordy[entry.Key]);
                    }
                }

            }
        }

        private void radioButtonExpense_CheckedChanged(object sender, EventArgs e)
        {
            wczytaj_kategorie();
            CzyszcKategorie();
        }

        private void radioButtonIncome_CheckedChanged(object sender, EventArgs e)
        {
            wczytaj_kategorie();
            CzyszcKategorie();
        }
        public void usun_operacje(int id)
        {
            dict_operacje.Remove(id);
            lv_operacje.Items.Remove(dict_rekordy[id]);
            dict_rekordy.Remove(id);
        }

        //Tutaj by się zaczynał kod do modyfikacji wykresów na podstawie filtra. Po stworzeniu event click przyciska ma być dodawany na podstawie trybu filtra 
        private void buttonWyszukaj_wykres_Click(object sender, EventArgs e)
        {
            List<operacje> dane_do_wykresu = new List<operacje>();

            String f_nazwa = null;
            List<uzytkownicy> f_uzyt = null;
            DateTime od_data = DateTime.MinValue;
            DateTime do_data = DateTime.MinValue;
            kategoria f_kategoria = null;
            decimal od_kwota = 0;
            decimal do_kwota = 0;
            string f_opis = null;
            if (tb_nazwa.Text != "")
            {
                f_nazwa = tb_nazwa.Text;
            }

            if (chlb_uzytkownicy.CheckedItems.Count > 0)
            {

                f_uzyt = new List<uzytkownicy>();
                foreach (uzytkownicy u in chlb_uzytkownicy.CheckedItems)
                {

                    f_uzyt.Add(u);
                }
            }

            if (uc_dodaj_date1.Data_od != DateTime.MinValue)
            {
                od_data = uc_dodaj_date1.Data_od;
            }
            if (uc_dodaj_date1.Data_do != DateTime.MinValue)
            {
                do_data = uc_dodaj_date1.Data_do;
            }

            if (comboBoxFiltrKategoria.SelectedItem != null)
            {
                f_kategoria = comboBoxFiltrKategoria.SelectedItem as kategoria;
            }
            if (nm_kwota_od.Value != 0)
            {
                od_kwota = nm_kwota_od.Value;
            }
            if (nm_kwota_do.Value != 0)
            {
                do_kwota = nm_kwota_do.Value;
            }
            if (textBoxSzukajWOpisie.Text != "")
            {
                f_opis = textBoxSzukajWOpisie.Text;
            }

            List<operacje> dane = new List<operacje>();
            foreach(operacje o in SingletonBaza.Instance.BazaDC.operacje)
            {
                if (o.filtr(f_nazwa, f_uzyt, od_data, do_data,
                    f_kategoria, od_kwota, do_kwota, f_opis))
                {
                    dane.Add(o);
                }
            }

            uwk_operacje.Dane_do_Wykresu = dane;
            uwk_operacje.draw_year_chart();
            uwk_operacje.draw_month_chart();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            if(Tryb_aktualny == Tryb_filtra.tabela)
            {
                buttonWyszukaj_tabela_Click(null, null);
            }
            else
            {
                buttonWyszukaj_wykres_Click(null, null);
            }
        }
    }
}
