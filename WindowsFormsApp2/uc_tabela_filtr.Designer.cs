namespace WindowsFormsApp2
{
    partial class uc_tabela_filtr
    {
        /// <summary> 
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.listViewGlowne = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnUżytkownicy = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnOperacja = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnKwota = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnData = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnTyp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnKategoria = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnForma = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnOpis = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MenuEdycji = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.edytujToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuńToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.MenuEdycji.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1871, 1083);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.listViewGlowne, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1871, 1083);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // listViewGlowne
            // 
            this.listViewGlowne.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.columnUżytkownicy,
            this.columnOperacja,
            this.columnKwota,
            this.columnData,
            this.columnTyp,
            this.columnKategoria,
            this.columnForma,
            this.columnOpis});
            this.listViewGlowne.ContextMenuStrip = this.MenuEdycji;
            this.listViewGlowne.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewGlowne.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listViewGlowne.FullRowSelect = true;
            this.listViewGlowne.GridLines = true;
            this.listViewGlowne.HideSelection = false;
            this.listViewGlowne.HoverSelection = true;
            this.listViewGlowne.Location = new System.Drawing.Point(3, 2);
            this.listViewGlowne.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listViewGlowne.Name = "listViewGlowne";
            this.listViewGlowne.Size = new System.Drawing.Size(1865, 1079);
            this.listViewGlowne.TabIndex = 112;
            this.listViewGlowne.UseCompatibleStateImageBehavior = false;
            this.listViewGlowne.View = System.Windows.Forms.View.Details;
            // 
            // ID
            // 
            this.ID.Text = "";
            this.ID.Width = 0;
            // 
            // columnUżytkownicy
            // 
            this.columnUżytkownicy.Text = "Użytkownik";
            this.columnUżytkownicy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnUżytkownicy.Width = 200;
            // 
            // columnOperacja
            // 
            this.columnOperacja.Text = "Operacja";
            this.columnOperacja.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnOperacja.Width = 150;
            // 
            // columnKwota
            // 
            this.columnKwota.Text = "Kwota";
            this.columnKwota.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnKwota.Width = 200;
            // 
            // columnData
            // 
            this.columnData.Text = "Data";
            this.columnData.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnData.Width = 150;
            // 
            // columnTyp
            // 
            this.columnTyp.DisplayIndex = 8;
            this.columnTyp.Text = "Typ";
            this.columnTyp.Width = 120;
            // 
            // columnKategoria
            // 
            this.columnKategoria.DisplayIndex = 5;
            this.columnKategoria.Text = "Kategoria";
            this.columnKategoria.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnKategoria.Width = 200;
            // 
            // columnForma
            // 
            this.columnForma.Text = "Forma platności";
            this.columnForma.Width = 130;
            // 
            // columnOpis
            // 
            this.columnOpis.DisplayIndex = 6;
            this.columnOpis.Text = "Opis";
            this.columnOpis.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnOpis.Width = 200;
            // 
            // MenuEdycji
            // 
            this.MenuEdycji.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuEdycji.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.edytujToolStripMenuItem,
            this.usuńToolStripMenuItem});
            this.MenuEdycji.Name = "MenuEdycji";
            this.MenuEdycji.Size = new System.Drawing.Size(120, 52);
            // 
            // edytujToolStripMenuItem
            // 
            this.edytujToolStripMenuItem.Name = "edytujToolStripMenuItem";
            this.edytujToolStripMenuItem.Size = new System.Drawing.Size(119, 24);
            this.edytujToolStripMenuItem.Text = "Edytuj";
            this.edytujToolStripMenuItem.Click += new System.EventHandler(this.edytujToolStripMenuItem_Click);
            // 
            // usuńToolStripMenuItem
            // 
            this.usuńToolStripMenuItem.Name = "usuńToolStripMenuItem";
            this.usuńToolStripMenuItem.Size = new System.Drawing.Size(119, 24);
            this.usuńToolStripMenuItem.Text = "Usuń";
            this.usuńToolStripMenuItem.Click += new System.EventHandler(this.usuńToolStripMenuItem_Click);
            // 
            // uc_tabela_filtr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "uc_tabela_filtr";
            this.Size = new System.Drawing.Size(1871, 1083);
            this.Load += new System.EventHandler(this.uc_tabela_filtr_Load);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.MenuEdycji.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ContextMenuStrip MenuEdycji;
        private System.Windows.Forms.ToolStripMenuItem edytujToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuńToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ListView listViewGlowne;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader columnUżytkownicy;
        private System.Windows.Forms.ColumnHeader columnOperacja;
        private System.Windows.Forms.ColumnHeader columnKwota;
        private System.Windows.Forms.ColumnHeader columnData;
        private System.Windows.Forms.ColumnHeader columnTyp;
        private System.Windows.Forms.ColumnHeader columnKategoria;
        private System.Windows.Forms.ColumnHeader columnForma;
        private System.Windows.Forms.ColumnHeader columnOpis;
    }
}
