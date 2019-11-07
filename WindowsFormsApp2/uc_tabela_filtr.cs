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
    public partial class uc_tabela_filtr : UserControl
    {

        public uzytkownicy AkualnieZalogowany { get; set; }


        Dictionary<int, operacje> dict_operacje = new Dictionary<int, operacje>();
        Dictionary<int, ListViewItem> dict_rekordy = new Dictionary<int, ListViewItem>();

        public uc_tabela_filtr()
        {
            InitializeComponent();
        }
        public uc_tabela_filtr(uzytkownicy akt)
        {
            InitializeComponent();
            AkualnieZalogowany = akt;
        }
        public void odswierz_dana_operacje(int id)
        {
            var query = from op in SingletonBaza.Instance.BazaDC.operacje
                        where op.id_operacji == id
                        select op;
            if(query.FirstOrDefault()!=null)
            {
                operacje o = query.FirstOrDefault();
                dict_operacje[id] = o;
                var
                nowy_rekord = listViewGlowne.Items.Add(o.id_operacji.ToString());
                nowy_rekord.Name = o.id_operacji.ToString();
                nowy_rekord.SubItems.Add(o.uzytkownicy.imie + " " + o.uzytkownicy.nazwisko);
                nowy_rekord.SubItems.Add(o.nazwa);
                nowy_rekord.SubItems.Add(o.kwota.ToString());
                nowy_rekord.SubItems.Add(o.data.ToShortDateString());
                nowy_rekord.SubItems.Add(o.kategoria.typ);
                nowy_rekord.SubItems.Add(o.kategoria.nazwa);
                nowy_rekord.SubItems.Add(o.forma_platnosci.nazwa);
                nowy_rekord.SubItems.Add(o.opis);
                listViewGlowne.Items.Remove(dict_rekordy[id]);
                dict_rekordy[id] = nowy_rekord;
            }
        }

        private void trybWidokTabelka()
        {
            listViewGlowne.Visible = true;
            listViewGlowne.Items.Clear();

            var query = SingletonBaza.Instance.BazaDC.operacje;
            foreach (var row in query)
            {
                var
                nowy_rekord = listViewGlowne.Items.Add(row.id_operacji.ToString());
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
            chlb_uzytkownicy.SetItemChecked(chlb_uzytkownicy.Items.IndexOf(AkualnieZalogowany), true);
        }

        private void buttonWyszukaj_Click(object sender, EventArgs e)
        {
            String f_nazwa = null;
            List<uzytkownicy> f_uzyt= null;
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
                if (!entry.Value.filtr(f_nazwa, f_uzyt,od_data,do_data,
                    f_kategoria,od_kwota,do_kwota,f_opis))
                {
                    listViewGlowne.Items.Remove(dict_rekordy[entry.Key]);
                }else
                {
                    if (!listViewGlowne.Items.Contains(dict_rekordy[entry.Key]))
                    {
                        listViewGlowne.Items.Add(dict_rekordy[entry.Key]);
                    }
                }

            }
        }
        private void CzyszcKategorie()
        {
            comboBoxFiltrKategoria.SelectedItem = null;
        }
        private void uc_tabela_filtr_Load(object sender, EventArgs e)
        {
            wczytaj_kategorie();
            wczytaj_uzytkownikow();
            trybWidokTabelka();
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

        private void edytujToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var row = listViewGlowne.SelectedItems;

            if(row.Count ==1)
            {
                uc_formularz_operacja ucfo = ((panelGlowny)this.FindForm()).Controls.Find("uc_formularz_operacja1", true)
    .FirstOrDefault() as uc_formularz_operacja;
                if (ucfo != null)
                {
                    ucfo.Wybrana = dict_operacje[Int32.Parse(row[0].Name)];
                    ucfo.Focus();
                    return;
                }
            }
        }
    }
}
