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
        public Dictionary<int, operacje> dict_operacje = new Dictionary<int, operacje>();
        Dictionary<int, ListViewItem> dict_rekordy = new Dictionary<int, ListViewItem>();
        enum Tryb_Tabelki
        {
            Zatwierdzone_operacje=0,
            Niezatwierdzone_operacje=1
        }
        Tryb_Tabelki tryb_tab;
        uc_filtr filtr= null;
        public uc_tabela_filtr(int tt)
        {
            InitializeComponent();
            tryb_tab = (Tryb_Tabelki)tt;
            if (tryb_tab == Tryb_Tabelki.Zatwierdzone_operacje)
            {

                filtr = new uc_filtr(listViewGlowne);
                tableLayoutPanel1.Controls.Add(filtr, 0, 0);
            } else if (tryb_tab == Tryb_Tabelki.Niezatwierdzone_operacje)
            {
                // Dodaje niezatwierdzone operacje
                trybWidokTabelkaNiezatiwerdzone();
                // Dodaje opcje w menu kontekstowym Zatwierdź jeśli użytkownik zalogowany jest adm/mod
                if (SingletonBaza.Zalogowany.czy_admistrator()
                    || SingletonBaza.Zalogowany.czy_moderator())
                {
                    MenuEdycji.Items.Add("Zatwierdź", null, zatwierdzToolStripMenuItem_Click);
                }
            }
        }
        public void trybWidokTabelkaNiezatiwerdzone()
        {
            listViewGlowne.Items.Clear();
            var query = SingletonBaza.Instance.BazaDC.operacje.Where(x => x.Zatwierdzone == false);
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

        private void zatwierdzToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var row = listViewGlowne.SelectedItems;

            if (row.Count == 1)
            {
                operacje Zatwierdzona = dict_operacje[Int32.Parse(row[0].Name)];
                Zatwierdzona.Zatwierdzone = true;
                SingletonBaza.Instance.BazaDC.SubmitChanges();
                ((panelGlowny)this.FindForm()).odsiwerz_dana_operacje_w_tabeli(Zatwierdzona.id_operacji);
                dict_operacje.Remove(Zatwierdzona.id_operacji);
                listViewGlowne.Items.Remove(dict_rekordy[Zatwierdzona.id_operacji]);
                dict_rekordy.Remove(Zatwierdzona.id_operacji);
            }
        }

        public void odswierz_dana_operacje(int id)
        {
            if (tryb_tab == Tryb_Tabelki.Zatwierdzone_operacje)
            {
                filtr.odswierz_dana_operacje(id);
            }
            else if(tryb_tab == Tryb_Tabelki.Niezatwierdzone_operacje)
            {
                var query = from op in SingletonBaza.Instance.BazaDC.operacje
                            where op.id_operacji == id
                            select op;
                operacje o = query.FirstOrDefault();
                if (o != null)
                {
                    if (o.Zatwierdzone == false)
                    {
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
                        if (dict_rekordy.ContainsKey(id))
                        {
                            listViewGlowne.Items.Remove(dict_rekordy[id]);
                        }
                        dict_rekordy[id] = nowy_rekord;
                    }
                    else if (dict_rekordy.ContainsKey(id))
                    {
                        dict_operacje.Remove(id);
                        listViewGlowne.Items.Remove(dict_rekordy[id]);
                        dict_rekordy.Remove(id);
                    }
                }
            }
        }


        private void edytujToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var row = listViewGlowne.SelectedItems;

            if (row.Count == 1)
            {
                operacje doEdycji = null; ;
                switch (tryb_tab)
                {
                    case Tryb_Tabelki.Zatwierdzone_operacje:
                        doEdycji = filtr.dict_operacje[Int32.Parse(row[0].Name)];
                        break;
                    case Tryb_Tabelki.Niezatwierdzone_operacje:
                        doEdycji = dict_operacje[Int32.Parse(row[0].Name)];
                        break;
                }
                if (doEdycji.czy_ma_dostep())
                {
                    if (!doEdycji.czy_ktos_inny_edytuje_operacje())
                    {
                        doEdycji.stworz_sesje();
                        foreach(sesja_operacja o in doEdycji.sesja_operacja)
                        {
                            MessageBox.Show(o.data_stworzenia.ToString());
                        }

                        uc_formularz_operacja ucfo = ((panelGlowny)this.FindForm()).Controls.Find("uc_formularz_operacja1", true)
    .FirstOrDefault() as uc_formularz_operacja;
                        if (ucfo != null)
                        {
                            ucfo.Wybrana = doEdycji;
                            ucfo.Focus();
                            return;
                        }
                    }else
                    {
                        MessageBox.Show("Użytkownik teraz edytuje operacje: " + doEdycji.kto_edytuje_operacje());
                    }
                }else
                {
                    MessageBox.Show("Brak dostepu do operacji");
                }
            }

            
        }

        private void usuńToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var row = listViewGlowne.SelectedItems;
            if (row.Count == 1)
            {
                operacje doUsuniecia = null; 
                switch(tryb_tab)
                {
                    case Tryb_Tabelki.Zatwierdzone_operacje:
                        doUsuniecia = filtr.dict_operacje[Int32.Parse(row[0].Name)];

                        break;
                    case Tryb_Tabelki.Niezatwierdzone_operacje:
                        doUsuniecia = dict_operacje[Int32.Parse(row[0].Name)];
                        break;
                }

                if (doUsuniecia.czy_ma_dostep())
                {
                    var confirmResult = MessageBox.Show("Czy na pewno chcesz usunąć ten rekord?",
                    "Potwierdź usunięcie",
                      MessageBoxButtons.YesNo);
                    if (confirmResult == DialogResult.Yes)
                    {
                        SingletonBaza.Instance.BazaDC.operacje.DeleteOnSubmit(doUsuniecia);
                        SingletonBaza.Instance.BazaDC.SubmitChanges();
                        switch (tryb_tab)
                        {
                            case Tryb_Tabelki.Zatwierdzone_operacje:
                                filtr.usun_operacje(doUsuniecia.id_operacji);
                                break;
                            case Tryb_Tabelki.Niezatwierdzone_operacje:
                                dict_operacje.Remove(doUsuniecia.id_operacji);
                                listViewGlowne.Items.Remove(dict_rekordy[doUsuniecia.id_operacji]);
                                dict_rekordy.Remove(doUsuniecia.id_operacji);
                                break;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Brak dostepu do operacji");
                }
            }
        }

        private void uc_tabela_filtr_Load(object sender, EventArgs e)
        {
            if(tryb_tab == Tryb_Tabelki.Zatwierdzone_operacje)
            {
                filtr.trybWidokTabelka();
            }
        }
    }
}