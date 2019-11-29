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
        enum Tryb_Tabelki
        {
            Zatwierdzone_operacje=0,
            Niezatwierdzone_operacje=1
        }
        Tryb_Tabelki tryb_tab;
        uc_filtr filtr;

        //Dictionary<int, operacje> dict_operacje = new Dictionary<int, operacje>();
        //Dictionary<int, ListViewItem> dict_rekordy = new Dictionary<int, ListViewItem>();

        public uc_tabela_filtr()
        {
            InitializeComponent();
            
        }
        public uc_tabela_filtr(int tt)
        {
            InitializeComponent();
            tryb_tab = (Tryb_Tabelki)tt;
            AkualnieZalogowany = SingletonBaza.Zalogowany;
            filtr = new uc_filtr(listViewGlowne);
            tableLayoutPanel1.Controls.Add(filtr, 0, 0);
        }

        public void odswierz_dana_operacje(int id)
        {
           if(tryb_tab == Tryb_Tabelki.Zatwierdzone_operacje)
            {
                filtr.odswierz_dana_operacje(id);
            }
           else
            {
                //Kod dla gosci itd
            }
        }

        private void edytujToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var row = listViewGlowne.SelectedItems;

            if (row.Count == 1)
            {
                uc_formularz_operacja ucfo = ((panelGlowny)this.FindForm()).Controls.Find("uc_formularz_operacja1", true)
    .FirstOrDefault() as uc_formularz_operacja;
                if (ucfo != null)
                {
                    ucfo.Wybrana = filtr.dict_operacje[Int32.Parse(row[0].Name)];
                    ucfo.Focus();
                    return;
                }
            }
        }

        private void usuńToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var row = listViewGlowne.SelectedItems;
            if (row.Count == 1)
            {
                var confirmResult = MessageBox.Show("Czy na pewno chcesz usunąć ten rekord?",
    "Potwierdź usunięcie",
    MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    int id = Int32.Parse(row[0].Name);
                    SingletonBaza.Instance.BazaDC.operacje.DeleteOnSubmit(filtr.dict_operacje[id]);
                    SingletonBaza.Instance.BazaDC.SubmitChanges();
                    filtr.usun_operacje(id);
                    
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