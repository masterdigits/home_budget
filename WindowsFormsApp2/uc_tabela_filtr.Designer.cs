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
            this.splitContainerFiltr = new System.Windows.Forms.SplitContainer();
            this.nm_kwota_do = new System.Windows.Forms.NumericUpDown();
            this.nm_kwota_od = new System.Windows.Forms.NumericUpDown();
            this.radioButtonIncome = new System.Windows.Forms.RadioButton();
            this.radioButtonExpense = new System.Windows.Forms.RadioButton();
            this.chlb_uzytkownicy = new System.Windows.Forms.CheckedListBox();
            this.tb_nazwa = new System.Windows.Forms.TextBox();
            this.textBoxSzukajWOpisie = new System.Windows.Forms.TextBox();
            this.buttonWyszukaj = new System.Windows.Forms.Button();
            this.labelSzukajWOpisie = new System.Windows.Forms.Label();
            this.comboBoxFiltrKategoria = new System.Windows.Forms.ComboBox();
            this.labelDoKwota = new System.Windows.Forms.Label();
            this.labelOdKwota = new System.Windows.Forms.Label();
            this.checkBoxFiltrZaawansowany = new System.Windows.Forms.CheckBox();
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.uc_dodaj_date1 = new WindowsFormsApp2.uc_dodaj_date();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerFiltr)).BeginInit();
            this.splitContainerFiltr.Panel1.SuspendLayout();
            this.splitContainerFiltr.Panel2.SuspendLayout();
            this.splitContainerFiltr.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nm_kwota_do)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nm_kwota_od)).BeginInit();
            this.MenuEdycji.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.splitContainerFiltr);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1403, 880);
            this.panel1.TabIndex = 0;
            // 
            // splitContainerFiltr
            // 
            this.splitContainerFiltr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerFiltr.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainerFiltr.IsSplitterFixed = true;
            this.splitContainerFiltr.Location = new System.Drawing.Point(0, 0);
            this.splitContainerFiltr.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainerFiltr.Name = "splitContainerFiltr";
            this.splitContainerFiltr.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerFiltr.Panel1
            // 
            this.splitContainerFiltr.Panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.splitContainerFiltr.Panel1.Controls.Add(this.label3);
            this.splitContainerFiltr.Panel1.Controls.Add(this.label2);
            this.splitContainerFiltr.Panel1.Controls.Add(this.label1);
            this.splitContainerFiltr.Panel1.Controls.Add(this.uc_dodaj_date1);
            this.splitContainerFiltr.Panel1.Controls.Add(this.nm_kwota_do);
            this.splitContainerFiltr.Panel1.Controls.Add(this.nm_kwota_od);
            this.splitContainerFiltr.Panel1.Controls.Add(this.radioButtonIncome);
            this.splitContainerFiltr.Panel1.Controls.Add(this.radioButtonExpense);
            this.splitContainerFiltr.Panel1.Controls.Add(this.chlb_uzytkownicy);
            this.splitContainerFiltr.Panel1.Controls.Add(this.tb_nazwa);
            this.splitContainerFiltr.Panel1.Controls.Add(this.textBoxSzukajWOpisie);
            this.splitContainerFiltr.Panel1.Controls.Add(this.buttonWyszukaj);
            this.splitContainerFiltr.Panel1.Controls.Add(this.labelSzukajWOpisie);
            this.splitContainerFiltr.Panel1.Controls.Add(this.comboBoxFiltrKategoria);
            this.splitContainerFiltr.Panel1.Controls.Add(this.labelDoKwota);
            this.splitContainerFiltr.Panel1.Controls.Add(this.labelOdKwota);
            this.splitContainerFiltr.Panel1.Controls.Add(this.checkBoxFiltrZaawansowany);
            // 
            // splitContainerFiltr.Panel2
            // 
            this.splitContainerFiltr.Panel2.Controls.Add(this.listViewGlowne);
            this.splitContainerFiltr.Size = new System.Drawing.Size(1403, 880);
            this.splitContainerFiltr.SplitterDistance = 150;
            this.splitContainerFiltr.SplitterWidth = 3;
            this.splitContainerFiltr.TabIndex = 1;
            // 
            // nm_kwota_do
            // 
            this.nm_kwota_do.Location = new System.Drawing.Point(440, 100);
            this.nm_kwota_do.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.nm_kwota_do.Name = "nm_kwota_do";
            this.nm_kwota_do.Size = new System.Drawing.Size(120, 20);
            this.nm_kwota_do.TabIndex = 103;
            // 
            // nm_kwota_od
            // 
            this.nm_kwota_od.Location = new System.Drawing.Point(240, 100);
            this.nm_kwota_od.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.nm_kwota_od.Name = "nm_kwota_od";
            this.nm_kwota_od.Size = new System.Drawing.Size(120, 20);
            this.nm_kwota_od.TabIndex = 102;
            // 
            // radioButtonIncome
            // 
            this.radioButtonIncome.AutoSize = true;
            this.radioButtonIncome.Location = new System.Drawing.Point(405, 34);
            this.radioButtonIncome.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonIncome.Name = "radioButtonIncome";
            this.radioButtonIncome.Size = new System.Drawing.Size(69, 17);
            this.radioButtonIncome.TabIndex = 100;
            this.radioButtonIncome.TabStop = true;
            this.radioButtonIncome.Text = "Przychód";
            this.radioButtonIncome.UseVisualStyleBackColor = true;
            this.radioButtonIncome.CheckedChanged += new System.EventHandler(this.radioButtonIncome_CheckedChanged);
            // 
            // radioButtonExpense
            // 
            this.radioButtonExpense.AutoSize = true;
            this.radioButtonExpense.Location = new System.Drawing.Point(320, 34);
            this.radioButtonExpense.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonExpense.Name = "radioButtonExpense";
            this.radioButtonExpense.Size = new System.Drawing.Size(68, 17);
            this.radioButtonExpense.TabIndex = 99;
            this.radioButtonExpense.TabStop = true;
            this.radioButtonExpense.Text = "Wydatek";
            this.radioButtonExpense.UseVisualStyleBackColor = true;
            this.radioButtonExpense.CheckedChanged += new System.EventHandler(this.radioButtonExpense_CheckedChanged);
            // 
            // chlb_uzytkownicy
            // 
            this.chlb_uzytkownicy.CheckOnClick = true;
            this.chlb_uzytkownicy.FormattingEnabled = true;
            this.chlb_uzytkownicy.Location = new System.Drawing.Point(19, 31);
            this.chlb_uzytkownicy.Name = "chlb_uzytkownicy";
            this.chlb_uzytkownicy.Size = new System.Drawing.Size(153, 109);
            this.chlb_uzytkownicy.TabIndex = 28;
            // 
            // tb_nazwa
            // 
            this.tb_nazwa.Location = new System.Drawing.Point(191, 60);
            this.tb_nazwa.Name = "tb_nazwa";
            this.tb_nazwa.Size = new System.Drawing.Size(100, 20);
            this.tb_nazwa.TabIndex = 27;
            // 
            // textBoxSzukajWOpisie
            // 
            this.textBoxSzukajWOpisie.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxSzukajWOpisie.Location = new System.Drawing.Point(479, 34);
            this.textBoxSzukajWOpisie.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxSzukajWOpisie.Multiline = true;
            this.textBoxSzukajWOpisie.Name = "textBoxSzukajWOpisie";
            this.textBoxSzukajWOpisie.Size = new System.Drawing.Size(145, 48);
            this.textBoxSzukajWOpisie.TabIndex = 22;
            // 
            // buttonWyszukaj
            // 
            this.buttonWyszukaj.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonWyszukaj.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonWyszukaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonWyszukaj.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonWyszukaj.Location = new System.Drawing.Point(931, 116);
            this.buttonWyszukaj.Margin = new System.Windows.Forms.Padding(2);
            this.buttonWyszukaj.Name = "buttonWyszukaj";
            this.buttonWyszukaj.Size = new System.Drawing.Size(135, 24);
            this.buttonWyszukaj.TabIndex = 21;
            this.buttonWyszukaj.Text = "Wyszukaj";
            this.buttonWyszukaj.UseVisualStyleBackColor = true;
            this.buttonWyszukaj.Click += new System.EventHandler(this.buttonWyszukaj_Click);
            // 
            // labelSzukajWOpisie
            // 
            this.labelSzukajWOpisie.AutoSize = true;
            this.labelSzukajWOpisie.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelSzukajWOpisie.Location = new System.Drawing.Point(476, 11);
            this.labelSzukajWOpisie.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSzukajWOpisie.Name = "labelSzukajWOpisie";
            this.labelSzukajWOpisie.Size = new System.Drawing.Size(109, 17);
            this.labelSzukajWOpisie.TabIndex = 20;
            this.labelSzukajWOpisie.Text = "Szukaj w opisie";
            // 
            // comboBoxFiltrKategoria
            // 
            this.comboBoxFiltrKategoria.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxFiltrKategoria.ForeColor = System.Drawing.Color.DimGray;
            this.comboBoxFiltrKategoria.FormattingEnabled = true;
            this.comboBoxFiltrKategoria.Location = new System.Drawing.Point(320, 58);
            this.comboBoxFiltrKategoria.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxFiltrKategoria.Name = "comboBoxFiltrKategoria";
            this.comboBoxFiltrKategoria.Size = new System.Drawing.Size(154, 24);
            this.comboBoxFiltrKategoria.TabIndex = 17;
            this.comboBoxFiltrKategoria.Text = "Wybierz kategorię";
            // 
            // labelDoKwota
            // 
            this.labelDoKwota.AutoSize = true;
            this.labelDoKwota.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelDoKwota.Location = new System.Drawing.Point(388, 103);
            this.labelDoKwota.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDoKwota.Name = "labelDoKwota";
            this.labelDoKwota.Size = new System.Drawing.Size(27, 17);
            this.labelDoKwota.TabIndex = 16;
            this.labelDoKwota.Text = "Do";
            // 
            // labelOdKwota
            // 
            this.labelOdKwota.AutoSize = true;
            this.labelOdKwota.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelOdKwota.ForeColor = System.Drawing.Color.Black;
            this.labelOdKwota.Location = new System.Drawing.Point(188, 100);
            this.labelOdKwota.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelOdKwota.Name = "labelOdKwota";
            this.labelOdKwota.Size = new System.Drawing.Size(28, 17);
            this.labelOdKwota.TabIndex = 15;
            this.labelOdKwota.Text = "Od";
            // 
            // checkBoxFiltrZaawansowany
            // 
            this.checkBoxFiltrZaawansowany.AutoSize = true;
            this.checkBoxFiltrZaawansowany.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBoxFiltrZaawansowany.Location = new System.Drawing.Point(931, 82);
            this.checkBoxFiltrZaawansowany.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxFiltrZaawansowany.Name = "checkBoxFiltrZaawansowany";
            this.checkBoxFiltrZaawansowany.Size = new System.Drawing.Size(172, 19);
            this.checkBoxFiltrZaawansowany.TabIndex = 13;
            this.checkBoxFiltrZaawansowany.Text = "Pokaż filtry zaawansowane";
            this.checkBoxFiltrZaawansowany.UseVisualStyleBackColor = true;
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
            this.listViewGlowne.Location = new System.Drawing.Point(0, 0);
            this.listViewGlowne.Margin = new System.Windows.Forms.Padding(2);
            this.listViewGlowne.Name = "listViewGlowne";
            this.listViewGlowne.Size = new System.Drawing.Size(1403, 727);
            this.listViewGlowne.TabIndex = 3;
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
            this.MenuEdycji.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.edytujToolStripMenuItem,
            this.usuńToolStripMenuItem});
            this.MenuEdycji.Name = "MenuEdycji";
            this.MenuEdycji.Size = new System.Drawing.Size(108, 48);
            // 
            // edytujToolStripMenuItem
            // 
            this.edytujToolStripMenuItem.Name = "edytujToolStripMenuItem";
            this.edytujToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.edytujToolStripMenuItem.Text = "Edytuj";
            this.edytujToolStripMenuItem.Click += new System.EventHandler(this.edytujToolStripMenuItem_Click);
            // 
            // usuńToolStripMenuItem
            // 
            this.usuńToolStripMenuItem.Name = "usuńToolStripMenuItem";
            this.usuńToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.usuńToolStripMenuItem.Text = "Usuń";
            this.usuńToolStripMenuItem.Click += new System.EventHandler(this.usuńToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(188, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 17);
            this.label1.TabIndex = 104;
            this.label1.Text = "Nazwa operacji";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(16, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 17);
            this.label2.TabIndex = 105;
            this.label2.Text = "Wybierz użytkowników";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(317, 11);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 17);
            this.label3.TabIndex = 106;
            this.label3.Text = "Typ operacji";
            // 
            // uc_dodaj_date1
            // 
            this.uc_dodaj_date1.AutoSize = true;
            this.uc_dodaj_date1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.uc_dodaj_date1.BackColor = System.Drawing.Color.Transparent;
            this.uc_dodaj_date1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uc_dodaj_date1.Location = new System.Drawing.Point(629, 11);
            this.uc_dodaj_date1.Name = "uc_dodaj_date1";
            this.uc_dodaj_date1.Size = new System.Drawing.Size(296, 38);
            this.uc_dodaj_date1.TabIndex = 101;
            // 
            // uc_tabela_filtr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "uc_tabela_filtr";
            this.Size = new System.Drawing.Size(1403, 880);
            this.Load += new System.EventHandler(this.uc_tabela_filtr_Load);
            this.panel1.ResumeLayout(false);
            this.splitContainerFiltr.Panel1.ResumeLayout(false);
            this.splitContainerFiltr.Panel1.PerformLayout();
            this.splitContainerFiltr.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerFiltr)).EndInit();
            this.splitContainerFiltr.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nm_kwota_do)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nm_kwota_od)).EndInit();
            this.MenuEdycji.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainerFiltr;
        private System.Windows.Forms.TextBox textBoxSzukajWOpisie;
        private System.Windows.Forms.Button buttonWyszukaj;
        private System.Windows.Forms.Label labelSzukajWOpisie;
        private System.Windows.Forms.ComboBox comboBoxFiltrKategoria;
        private System.Windows.Forms.Label labelDoKwota;
        private System.Windows.Forms.Label labelOdKwota;
        private System.Windows.Forms.CheckBox checkBoxFiltrZaawansowany;
        private System.Windows.Forms.TextBox tb_nazwa;
        private System.Windows.Forms.CheckedListBox chlb_uzytkownicy;
        private System.Windows.Forms.RadioButton radioButtonIncome;
        private System.Windows.Forms.RadioButton radioButtonExpense;
        private uc_dodaj_date uc_dodaj_date1;
        private System.Windows.Forms.NumericUpDown nm_kwota_do;
        private System.Windows.Forms.NumericUpDown nm_kwota_od;
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
        private System.Windows.Forms.ContextMenuStrip MenuEdycji;
        private System.Windows.Forms.ToolStripMenuItem edytujToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuńToolStripMenuItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
