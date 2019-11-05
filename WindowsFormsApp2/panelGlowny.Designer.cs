namespace WindowsFormsApp2
{
    partial class panelGlowny
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

              #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.splitContainerGlowny = new System.Windows.Forms.SplitContainer();
            this.splitContainerMenuBoczne = new System.Windows.Forms.SplitContainer();
            this.buttonDodajWydatek = new System.Windows.Forms.Button();
            this.buttonDodajPrzychód = new System.Windows.Forms.Button();
            this.splitContainerMenuBoczneWidok = new System.Windows.Forms.SplitContainer();
            this.comboBoxKategoria = new System.Windows.Forms.ComboBox();
            this.checkBoxCykliczny = new System.Windows.Forms.CheckBox();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonZapisz = new System.Windows.Forms.Button();
            this.richTextBoxDodaj = new System.Windows.Forms.RichTextBox();
            this.dateTimePickerDodajOperacje = new System.Windows.Forms.DateTimePicker();
            this.textBoxDodajKwote = new System.Windows.Forms.TextBox();
            this.buttonWidokTabelka = new System.Windows.Forms.Button();
            this.buttonWidokKolumnowy = new System.Windows.Forms.Button();
            this.buttonWidokKolowy = new System.Windows.Forms.Button();
            this.buttonWidokKalendarz = new System.Windows.Forms.Button();
            this.buttonWidokLiniowy = new System.Windows.Forms.Button();
            this.splitContainerFiltr = new System.Windows.Forms.SplitContainer();
            this.buttonPowiadomienia = new System.Windows.Forms.Button();
            this.comboBoxFiltrUzytkownik = new System.Windows.Forms.ComboBox();
            this.textBoxSzukajWOpisie = new System.Windows.Forms.TextBox();
            this.buttonWyszukaj = new System.Windows.Forms.Button();
            this.labelSzukajWOpisie = new System.Windows.Forms.Label();
            this.textBoxFiltrKwotaDo = new System.Windows.Forms.TextBox();
            this.textBoxFiltrKwotaOd = new System.Windows.Forms.TextBox();
            this.comboBoxFiltrKategoria = new System.Windows.Forms.ComboBox();
            this.labelDoKwota = new System.Windows.Forms.Label();
            this.labelOdKwota = new System.Windows.Forms.Label();
            this.checkBoxFiltrZaawansowany = new System.Windows.Forms.CheckBox();
            this.labelDoData = new System.Windows.Forms.Label();
            this.dateTimePickerFiltrDo = new System.Windows.Forms.DateTimePicker();
            this.labelOdData = new System.Windows.Forms.Label();
            this.dateTimePickerFiltrOd = new System.Windows.Forms.DateTimePicker();
            this.comboBoxFiltrWyborOperacji = new System.Windows.Forms.ComboBox();
            this.buttonUstawienia = new System.Windows.Forms.Button();
            this.buttonWyloguj = new System.Windows.Forms.Button();
            this.splitContainerSaldo = new System.Windows.Forms.SplitContainer();
            this.labelInfoKalendarz = new System.Windows.Forms.Label();
            this.chartGlowny = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.listViewGlowne = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnUżytkownicy = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnOperacja = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnKwota = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnData = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnKategoria = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnOpis = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewGlowny = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerGlowny)).BeginInit();
            this.splitContainerGlowny.Panel1.SuspendLayout();
            this.splitContainerGlowny.Panel2.SuspendLayout();
            this.splitContainerGlowny.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMenuBoczne)).BeginInit();
            this.splitContainerMenuBoczne.Panel1.SuspendLayout();
            this.splitContainerMenuBoczne.Panel2.SuspendLayout();
            this.splitContainerMenuBoczne.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMenuBoczneWidok)).BeginInit();
            this.splitContainerMenuBoczneWidok.Panel1.SuspendLayout();
            this.splitContainerMenuBoczneWidok.Panel2.SuspendLayout();
            this.splitContainerMenuBoczneWidok.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerFiltr)).BeginInit();
            this.splitContainerFiltr.Panel1.SuspendLayout();
            this.splitContainerFiltr.Panel2.SuspendLayout();
            this.splitContainerFiltr.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerSaldo)).BeginInit();
            this.splitContainerSaldo.Panel1.SuspendLayout();
            this.splitContainerSaldo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartGlowny)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerGlowny
            // 
            this.splitContainerGlowny.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerGlowny.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainerGlowny.IsSplitterFixed = true;
            this.splitContainerGlowny.Location = new System.Drawing.Point(0, 0);
            this.splitContainerGlowny.Name = "splitContainerGlowny";
            // 
            // splitContainerGlowny.Panel1
            // 
            this.splitContainerGlowny.Panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.splitContainerGlowny.Panel1.Controls.Add(this.splitContainerMenuBoczne);
            // 
            // splitContainerGlowny.Panel2
            // 
            this.splitContainerGlowny.Panel2.Controls.Add(this.splitContainerFiltr);
            this.splitContainerGlowny.Size = new System.Drawing.Size(1908, 945);
            this.splitContainerGlowny.SplitterDistance = 350;
            this.splitContainerGlowny.TabIndex = 0;
            // 
            // splitContainerMenuBoczne
            // 
            this.splitContainerMenuBoczne.BackColor = System.Drawing.Color.White;
            this.splitContainerMenuBoczne.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerMenuBoczne.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainerMenuBoczne.IsSplitterFixed = true;
            this.splitContainerMenuBoczne.Location = new System.Drawing.Point(0, 0);
            this.splitContainerMenuBoczne.Name = "splitContainerMenuBoczne";
            this.splitContainerMenuBoczne.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerMenuBoczne.Panel1
            // 
            this.splitContainerMenuBoczne.Panel1.BackColor = System.Drawing.Color.White;
            this.splitContainerMenuBoczne.Panel1.Controls.Add(this.buttonDodajWydatek);
            this.splitContainerMenuBoczne.Panel1.Controls.Add(this.buttonDodajPrzychód);
            // 
            // splitContainerMenuBoczne.Panel2
            // 
            this.splitContainerMenuBoczne.Panel2.Controls.Add(this.splitContainerMenuBoczneWidok);
            this.splitContainerMenuBoczne.Size = new System.Drawing.Size(350, 945);
            this.splitContainerMenuBoczne.SplitterDistance = 200;
            this.splitContainerMenuBoczne.TabIndex = 0;
            // 
            // buttonDodajWydatek
            // 
            this.buttonDodajWydatek.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDodajWydatek.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonDodajWydatek.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonDodajWydatek.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDodajWydatek.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonDodajWydatek.Location = new System.Drawing.Point(3, 136);
            this.buttonDodajWydatek.Name = "buttonDodajWydatek";
            this.buttonDodajWydatek.Size = new System.Drawing.Size(423, 76);
            this.buttonDodajWydatek.TabIndex = 1;
            this.buttonDodajWydatek.Text = "Dodaj wydatek";
            this.buttonDodajWydatek.UseVisualStyleBackColor = true;
            this.buttonDodajWydatek.Click += new System.EventHandler(this.buttonDodajWydatek_Click);
            // 
            // buttonDodajPrzychód
            // 
            this.buttonDodajPrzychód.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDodajPrzychód.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonDodajPrzychód.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonDodajPrzychód.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDodajPrzychód.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonDodajPrzychód.Location = new System.Drawing.Point(3, 37);
            this.buttonDodajPrzychód.Name = "buttonDodajPrzychód";
            this.buttonDodajPrzychód.Size = new System.Drawing.Size(423, 76);
            this.buttonDodajPrzychód.TabIndex = 0;
            this.buttonDodajPrzychód.Text = "Dodaj przychód";
            this.buttonDodajPrzychód.UseVisualStyleBackColor = true;
            this.buttonDodajPrzychód.Click += new System.EventHandler(this.buttonDodajPrzychód_Click);
            // 
            // splitContainerMenuBoczneWidok
            // 
            this.splitContainerMenuBoczneWidok.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerMenuBoczneWidok.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainerMenuBoczneWidok.IsSplitterFixed = true;
            this.splitContainerMenuBoczneWidok.Location = new System.Drawing.Point(0, 0);
            this.splitContainerMenuBoczneWidok.Name = "splitContainerMenuBoczneWidok";
            this.splitContainerMenuBoczneWidok.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerMenuBoczneWidok.Panel1
            // 
            this.splitContainerMenuBoczneWidok.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.splitContainerMenuBoczneWidok.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.splitContainerMenuBoczneWidok.Panel1.Controls.Add(this.comboBoxKategoria);
            this.splitContainerMenuBoczneWidok.Panel1.Controls.Add(this.checkBoxCykliczny);
            this.splitContainerMenuBoczneWidok.Panel1.Controls.Add(this.buttonReset);
            this.splitContainerMenuBoczneWidok.Panel1.Controls.Add(this.buttonZapisz);
            this.splitContainerMenuBoczneWidok.Panel1.Controls.Add(this.richTextBoxDodaj);
            this.splitContainerMenuBoczneWidok.Panel1.Controls.Add(this.dateTimePickerDodajOperacje);
            this.splitContainerMenuBoczneWidok.Panel1.Controls.Add(this.textBoxDodajKwote);
            // 
            // splitContainerMenuBoczneWidok.Panel2
            // 
            this.splitContainerMenuBoczneWidok.Panel2.BackColor = System.Drawing.Color.White;
            this.splitContainerMenuBoczneWidok.Panel2.Controls.Add(this.buttonWidokTabelka);
            this.splitContainerMenuBoczneWidok.Panel2.Controls.Add(this.buttonWidokKolumnowy);
            this.splitContainerMenuBoczneWidok.Panel2.Controls.Add(this.buttonWidokKolowy);
            this.splitContainerMenuBoczneWidok.Panel2.Controls.Add(this.buttonWidokKalendarz);
            this.splitContainerMenuBoczneWidok.Panel2.Controls.Add(this.buttonWidokLiniowy);
            this.splitContainerMenuBoczneWidok.Size = new System.Drawing.Size(350, 741);
            this.splitContainerMenuBoczneWidok.SplitterDistance = 369;
            this.splitContainerMenuBoczneWidok.TabIndex = 0;
            // 
            // comboBoxKategoria
            // 
            this.comboBoxKategoria.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxKategoria.ForeColor = System.Drawing.Color.DimGray;
            this.comboBoxKategoria.FormattingEnabled = true;
            this.comboBoxKategoria.Location = new System.Drawing.Point(54, 154);
            this.comboBoxKategoria.Name = "comboBoxKategoria";
            this.comboBoxKategoria.Size = new System.Drawing.Size(372, 29);
            this.comboBoxKategoria.TabIndex = 2;
            this.comboBoxKategoria.Text = "Wybierz kategorię";
            this.comboBoxKategoria.Click += new System.EventHandler(this.comboBoxKategoria_Click);
            // 
            // checkBoxCykliczny
            // 
            this.checkBoxCykliczny.AutoSize = true;
            this.checkBoxCykliczny.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.checkBoxCykliczny.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBoxCykliczny.Location = new System.Drawing.Point(54, 24);
            this.checkBoxCykliczny.Name = "checkBoxCykliczny";
            this.checkBoxCykliczny.Size = new System.Drawing.Size(254, 23);
            this.checkBoxCykliczny.TabIndex = 7;
            this.checkBoxCykliczny.Text = "Ustaw jako przychód cykliczny";
            this.checkBoxCykliczny.UseVisualStyleBackColor = false;
            // 
            // buttonReset
            // 
            this.buttonReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonReset.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonReset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.buttonReset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReset.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonReset.Location = new System.Drawing.Point(51, 306);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(172, 43);
            this.buttonReset.TabIndex = 6;
            this.buttonReset.Text = "Resetuj";
            this.buttonReset.UseVisualStyleBackColor = false;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonZapisz
            // 
            this.buttonZapisz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonZapisz.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonZapisz.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonZapisz.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.buttonZapisz.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonZapisz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonZapisz.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonZapisz.Location = new System.Drawing.Point(254, 306);
            this.buttonZapisz.Name = "buttonZapisz";
            this.buttonZapisz.Size = new System.Drawing.Size(172, 43);
            this.buttonZapisz.TabIndex = 5;
            this.buttonZapisz.Text = "Zapisz";
            this.buttonZapisz.UseVisualStyleBackColor = false;
            // 
            // richTextBoxDodaj
            // 
            this.richTextBoxDodaj.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.richTextBoxDodaj.ForeColor = System.Drawing.Color.DimGray;
            this.richTextBoxDodaj.Location = new System.Drawing.Point(54, 202);
            this.richTextBoxDodaj.Name = "richTextBoxDodaj";
            this.richTextBoxDodaj.Size = new System.Drawing.Size(372, 70);
            this.richTextBoxDodaj.TabIndex = 4;
            this.richTextBoxDodaj.Text = "Dodaj opcjonalny opis";
            this.richTextBoxDodaj.Click += new System.EventHandler(this.richTextBoxDodaj_Click);
            // 
            // dateTimePickerDodajOperacje
            // 
            this.dateTimePickerDodajOperacje.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateTimePickerDodajOperacje.Location = new System.Drawing.Point(54, 109);
            this.dateTimePickerDodajOperacje.Name = "dateTimePickerDodajOperacje";
            this.dateTimePickerDodajOperacje.Size = new System.Drawing.Size(372, 28);
            this.dateTimePickerDodajOperacje.TabIndex = 2;
            // 
            // textBoxDodajKwote
            // 
            this.textBoxDodajKwote.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxDodajKwote.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxDodajKwote.Location = new System.Drawing.Point(54, 64);
            this.textBoxDodajKwote.Name = "textBoxDodajKwote";
            this.textBoxDodajKwote.Size = new System.Drawing.Size(372, 28);
            this.textBoxDodajKwote.TabIndex = 1;
            this.textBoxDodajKwote.Text = "Dodaj kwotę przychodu";
            this.textBoxDodajKwote.Click += new System.EventHandler(this.textBoxDodajKwote_Click);
            // 
            // buttonWidokTabelka
            // 
            this.buttonWidokTabelka.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonWidokTabelka.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.buttonWidokTabelka.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonWidokTabelka.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonWidokTabelka.Location = new System.Drawing.Point(8, 6);
            this.buttonWidokTabelka.Name = "buttonWidokTabelka";
            this.buttonWidokTabelka.Size = new System.Drawing.Size(454, 59);
            this.buttonWidokTabelka.TabIndex = 5;
            this.buttonWidokTabelka.Text = "Tabela";
            this.buttonWidokTabelka.UseVisualStyleBackColor = true;
            this.buttonWidokTabelka.Click += new System.EventHandler(this.buttonWidokTabelka_Click);
            // 
            // buttonWidokKolumnowy
            // 
            this.buttonWidokKolumnowy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonWidokKolumnowy.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.buttonWidokKolumnowy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonWidokKolumnowy.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonWidokKolumnowy.Location = new System.Drawing.Point(8, 267);
            this.buttonWidokKolumnowy.Name = "buttonWidokKolumnowy";
            this.buttonWidokKolumnowy.Size = new System.Drawing.Size(454, 64);
            this.buttonWidokKolumnowy.TabIndex = 4;
            this.buttonWidokKolumnowy.Text = "Wykres kolumnowy";
            this.buttonWidokKolumnowy.UseVisualStyleBackColor = true;
            this.buttonWidokKolumnowy.Click += new System.EventHandler(this.buttonWidokKolumnowy_Click);
            // 
            // buttonWidokKolowy
            // 
            this.buttonWidokKolowy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonWidokKolowy.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.buttonWidokKolowy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonWidokKolowy.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonWidokKolowy.Location = new System.Drawing.Point(8, 198);
            this.buttonWidokKolowy.Name = "buttonWidokKolowy";
            this.buttonWidokKolowy.Size = new System.Drawing.Size(454, 64);
            this.buttonWidokKolowy.TabIndex = 3;
            this.buttonWidokKolowy.Text = "Wykres kołowy";
            this.buttonWidokKolowy.UseVisualStyleBackColor = true;
            this.buttonWidokKolowy.Click += new System.EventHandler(this.buttonWidokKolowy_Click);
            // 
            // buttonWidokKalendarz
            // 
            this.buttonWidokKalendarz.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonWidokKalendarz.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.buttonWidokKalendarz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonWidokKalendarz.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonWidokKalendarz.Location = new System.Drawing.Point(8, 70);
            this.buttonWidokKalendarz.Name = "buttonWidokKalendarz";
            this.buttonWidokKalendarz.Size = new System.Drawing.Size(454, 59);
            this.buttonWidokKalendarz.TabIndex = 0;
            this.buttonWidokKalendarz.Text = "Kalendarz";
            this.buttonWidokKalendarz.UseVisualStyleBackColor = true;
            this.buttonWidokKalendarz.Click += new System.EventHandler(this.buttonWidokKalendarz_Click);
            // 
            // buttonWidokLiniowy
            // 
            this.buttonWidokLiniowy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonWidokLiniowy.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.buttonWidokLiniowy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonWidokLiniowy.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonWidokLiniowy.Location = new System.Drawing.Point(8, 134);
            this.buttonWidokLiniowy.Name = "buttonWidokLiniowy";
            this.buttonWidokLiniowy.Size = new System.Drawing.Size(454, 59);
            this.buttonWidokLiniowy.TabIndex = 2;
            this.buttonWidokLiniowy.Text = "Wykres liniowy";
            this.buttonWidokLiniowy.UseVisualStyleBackColor = true;
            this.buttonWidokLiniowy.Click += new System.EventHandler(this.buttonWidokLiniowy_Click);
            // 
            // splitContainerFiltr
            // 
            this.splitContainerFiltr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerFiltr.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainerFiltr.IsSplitterFixed = true;
            this.splitContainerFiltr.Location = new System.Drawing.Point(0, 0);
            this.splitContainerFiltr.Name = "splitContainerFiltr";
            this.splitContainerFiltr.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerFiltr.Panel1
            // 
            this.splitContainerFiltr.Panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.splitContainerFiltr.Panel1.Controls.Add(this.buttonPowiadomienia);
            this.splitContainerFiltr.Panel1.Controls.Add(this.comboBoxFiltrUzytkownik);
            this.splitContainerFiltr.Panel1.Controls.Add(this.textBoxSzukajWOpisie);
            this.splitContainerFiltr.Panel1.Controls.Add(this.buttonWyszukaj);
            this.splitContainerFiltr.Panel1.Controls.Add(this.labelSzukajWOpisie);
            this.splitContainerFiltr.Panel1.Controls.Add(this.textBoxFiltrKwotaDo);
            this.splitContainerFiltr.Panel1.Controls.Add(this.textBoxFiltrKwotaOd);
            this.splitContainerFiltr.Panel1.Controls.Add(this.comboBoxFiltrKategoria);
            this.splitContainerFiltr.Panel1.Controls.Add(this.labelDoKwota);
            this.splitContainerFiltr.Panel1.Controls.Add(this.labelOdKwota);
            this.splitContainerFiltr.Panel1.Controls.Add(this.checkBoxFiltrZaawansowany);
            this.splitContainerFiltr.Panel1.Controls.Add(this.labelDoData);
            this.splitContainerFiltr.Panel1.Controls.Add(this.dateTimePickerFiltrDo);
            this.splitContainerFiltr.Panel1.Controls.Add(this.labelOdData);
            this.splitContainerFiltr.Panel1.Controls.Add(this.dateTimePickerFiltrOd);
            this.splitContainerFiltr.Panel1.Controls.Add(this.comboBoxFiltrWyborOperacji);
            this.splitContainerFiltr.Panel1.Controls.Add(this.buttonUstawienia);
            this.splitContainerFiltr.Panel1.Controls.Add(this.buttonWyloguj);
            // 
            // splitContainerFiltr.Panel2
            // 
            this.splitContainerFiltr.Panel2.Controls.Add(this.splitContainerSaldo);
            this.splitContainerFiltr.Size = new System.Drawing.Size(1554, 945);
            this.splitContainerFiltr.SplitterDistance = 80;
            this.splitContainerFiltr.TabIndex = 0;
            // 
            // buttonPowiadomienia
            // 
            this.buttonPowiadomienia.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonPowiadomienia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonPowiadomienia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPowiadomienia.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.buttonPowiadomienia.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonPowiadomienia.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lavender;
            this.buttonPowiadomienia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPowiadomienia.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonPowiadomienia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPowiadomienia.Location = new System.Drawing.Point(127, 3);
            this.buttonPowiadomienia.Name = "buttonPowiadomienia";
            this.buttonPowiadomienia.Size = new System.Drawing.Size(234, 34);
            this.buttonPowiadomienia.TabIndex = 26;
            this.buttonPowiadomienia.Text = "Powiadomienia";
            this.buttonPowiadomienia.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonPowiadomienia.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonPowiadomienia.UseCompatibleTextRendering = true;
            this.buttonPowiadomienia.UseVisualStyleBackColor = false;
            // 
            // comboBoxFiltrUzytkownik
            // 
            this.comboBoxFiltrUzytkownik.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxFiltrUzytkownik.ForeColor = System.Drawing.Color.DimGray;
            this.comboBoxFiltrUzytkownik.FormattingEnabled = true;
            this.comboBoxFiltrUzytkownik.Location = new System.Drawing.Point(190, 53);
            this.comboBoxFiltrUzytkownik.Name = "comboBoxFiltrUzytkownik";
            this.comboBoxFiltrUzytkownik.Size = new System.Drawing.Size(159, 27);
            this.comboBoxFiltrUzytkownik.TabIndex = 24;
            this.comboBoxFiltrUzytkownik.Text = "Wybierz użytkownika";
            // 
            // textBoxSzukajWOpisie
            // 
            this.textBoxSzukajWOpisie.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxSzukajWOpisie.Location = new System.Drawing.Point(1015, 105);
            this.textBoxSzukajWOpisie.Name = "textBoxSzukajWOpisie";
            this.textBoxSzukajWOpisie.Size = new System.Drawing.Size(192, 27);
            this.textBoxSzukajWOpisie.TabIndex = 22;
            // 
            // buttonWyszukaj
            // 
            this.buttonWyszukaj.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonWyszukaj.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonWyszukaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonWyszukaj.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonWyszukaj.Location = new System.Drawing.Point(1247, 105);
            this.buttonWyszukaj.Name = "buttonWyszukaj";
            this.buttonWyszukaj.Size = new System.Drawing.Size(180, 29);
            this.buttonWyszukaj.TabIndex = 21;
            this.buttonWyszukaj.Text = "Wyszukaj";
            this.buttonWyszukaj.UseVisualStyleBackColor = true;
            // 
            // labelSzukajWOpisie
            // 
            this.labelSzukajWOpisie.AutoSize = true;
            this.labelSzukajWOpisie.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelSzukajWOpisie.Location = new System.Drawing.Point(855, 109);
            this.labelSzukajWOpisie.Name = "labelSzukajWOpisie";
            this.labelSzukajWOpisie.Size = new System.Drawing.Size(139, 22);
            this.labelSzukajWOpisie.TabIndex = 20;
            this.labelSzukajWOpisie.Text = "Szukaj w opisie";
            // 
            // textBoxFiltrKwotaDo
            // 
            this.textBoxFiltrKwotaDo.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxFiltrKwotaDo.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxFiltrKwotaDo.Location = new System.Drawing.Point(650, 105);
            this.textBoxFiltrKwotaDo.Name = "textBoxFiltrKwotaDo";
            this.textBoxFiltrKwotaDo.Size = new System.Drawing.Size(192, 27);
            this.textBoxFiltrKwotaDo.TabIndex = 19;
            this.textBoxFiltrKwotaDo.Text = "100 000 zł";
            this.textBoxFiltrKwotaDo.Click += new System.EventHandler(this.textBoxFiltrKwotaDo_Click);
            // 
            // textBoxFiltrKwotaOd
            // 
            this.textBoxFiltrKwotaOd.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxFiltrKwotaOd.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxFiltrKwotaOd.Location = new System.Drawing.Point(394, 105);
            this.textBoxFiltrKwotaOd.Name = "textBoxFiltrKwotaOd";
            this.textBoxFiltrKwotaOd.Size = new System.Drawing.Size(192, 27);
            this.textBoxFiltrKwotaOd.TabIndex = 18;
            this.textBoxFiltrKwotaOd.Text = "100 zł";
            this.textBoxFiltrKwotaOd.Click += new System.EventHandler(this.textBoxFiltrKwotaOd_Click);
            // 
            // comboBoxFiltrKategoria
            // 
            this.comboBoxFiltrKategoria.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxFiltrKategoria.ForeColor = System.Drawing.Color.DimGray;
            this.comboBoxFiltrKategoria.FormattingEnabled = true;
            this.comboBoxFiltrKategoria.Location = new System.Drawing.Point(61, 105);
            this.comboBoxFiltrKategoria.Name = "comboBoxFiltrKategoria";
            this.comboBoxFiltrKategoria.Size = new System.Drawing.Size(262, 27);
            this.comboBoxFiltrKategoria.TabIndex = 17;
            this.comboBoxFiltrKategoria.Text = "Wybierz kategorię";
            this.comboBoxFiltrKategoria.Click += new System.EventHandler(this.comboBoxFiltrKategoria_Click);
            // 
            // labelDoKwota
            // 
            this.labelDoKwota.AutoSize = true;
            this.labelDoKwota.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelDoKwota.Location = new System.Drawing.Point(598, 109);
            this.labelDoKwota.Name = "labelDoKwota";
            this.labelDoKwota.Size = new System.Drawing.Size(35, 22);
            this.labelDoKwota.TabIndex = 16;
            this.labelDoKwota.Text = "Do";
            // 
            // labelOdKwota
            // 
            this.labelOdKwota.AutoSize = true;
            this.labelOdKwota.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelOdKwota.ForeColor = System.Drawing.Color.Black;
            this.labelOdKwota.Location = new System.Drawing.Point(341, 109);
            this.labelOdKwota.Name = "labelOdKwota";
            this.labelOdKwota.Size = new System.Drawing.Size(36, 22);
            this.labelOdKwota.TabIndex = 15;
            this.labelOdKwota.Text = "Od";
            // 
            // checkBoxFiltrZaawansowany
            // 
            this.checkBoxFiltrZaawansowany.AutoSize = true;
            this.checkBoxFiltrZaawansowany.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBoxFiltrZaawansowany.Location = new System.Drawing.Point(1220, 56);
            this.checkBoxFiltrZaawansowany.Name = "checkBoxFiltrZaawansowany";
            this.checkBoxFiltrZaawansowany.Size = new System.Drawing.Size(207, 21);
            this.checkBoxFiltrZaawansowany.TabIndex = 13;
            this.checkBoxFiltrZaawansowany.Text = "Pokaż filtry zaawansowane";
            this.checkBoxFiltrZaawansowany.UseVisualStyleBackColor = true;
            this.checkBoxFiltrZaawansowany.CheckedChanged += new System.EventHandler(this.checkBoxFiltrZaawansowany_CheckedChanged);
            // 
            // labelDoData
            // 
            this.labelDoData.AutoSize = true;
            this.labelDoData.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelDoData.Location = new System.Drawing.Point(750, 56);
            this.labelDoData.Name = "labelDoData";
            this.labelDoData.Size = new System.Drawing.Size(35, 22);
            this.labelDoData.TabIndex = 12;
            this.labelDoData.Text = "Do";
            // 
            // dateTimePickerFiltrDo
            // 
            this.dateTimePickerFiltrDo.CalendarFont = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateTimePickerFiltrDo.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateTimePickerFiltrDo.Location = new System.Drawing.Point(800, 52);
            this.dateTimePickerFiltrDo.Name = "dateTimePickerFiltrDo";
            this.dateTimePickerFiltrDo.Size = new System.Drawing.Size(334, 25);
            this.dateTimePickerFiltrDo.TabIndex = 11;
            // 
            // labelOdData
            // 
            this.labelOdData.AutoSize = true;
            this.labelOdData.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelOdData.Location = new System.Drawing.Point(341, 56);
            this.labelOdData.Name = "labelOdData";
            this.labelOdData.Size = new System.Drawing.Size(36, 22);
            this.labelOdData.TabIndex = 8;
            this.labelOdData.Text = "Od";
            // 
            // dateTimePickerFiltrOd
            // 
            this.dateTimePickerFiltrOd.CalendarFont = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateTimePickerFiltrOd.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateTimePickerFiltrOd.Location = new System.Drawing.Point(394, 52);
            this.dateTimePickerFiltrOd.Name = "dateTimePickerFiltrOd";
            this.dateTimePickerFiltrOd.Size = new System.Drawing.Size(334, 25);
            this.dateTimePickerFiltrOd.TabIndex = 10;
            // 
            // comboBoxFiltrWyborOperacji
            // 
            this.comboBoxFiltrWyborOperacji.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxFiltrWyborOperacji.ForeColor = System.Drawing.Color.DimGray;
            this.comboBoxFiltrWyborOperacji.FormattingEnabled = true;
            this.comboBoxFiltrWyborOperacji.Location = new System.Drawing.Point(25, 52);
            this.comboBoxFiltrWyborOperacji.Name = "comboBoxFiltrWyborOperacji";
            this.comboBoxFiltrWyborOperacji.Size = new System.Drawing.Size(159, 27);
            this.comboBoxFiltrWyborOperacji.TabIndex = 3;
            this.comboBoxFiltrWyborOperacji.Text = "Wybierz operację";
            this.comboBoxFiltrWyborOperacji.Click += new System.EventHandler(this.comboBoxFiltrWyborOperacji_Click);
            // 
            // buttonUstawienia
            // 
            this.buttonUstawienia.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonUstawienia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonUstawienia.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.buttonUstawienia.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonUstawienia.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lavender;
            this.buttonUstawienia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUstawienia.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonUstawienia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonUstawienia.Location = new System.Drawing.Point(394, 5);
            this.buttonUstawienia.Name = "buttonUstawienia";
            this.buttonUstawienia.Size = new System.Drawing.Size(239, 34);
            this.buttonUstawienia.TabIndex = 1;
            this.buttonUstawienia.Text = "Panel administratora";
            this.buttonUstawienia.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonUstawienia.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonUstawienia.UseCompatibleTextRendering = true;
            this.buttonUstawienia.UseVisualStyleBackColor = false;
            // 
            // buttonWyloguj
            // 
            this.buttonWyloguj.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonWyloguj.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonWyloguj.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.buttonWyloguj.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonWyloguj.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lavender;
            this.buttonWyloguj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonWyloguj.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonWyloguj.Location = new System.Drawing.Point(701, 3);
            this.buttonWyloguj.Name = "buttonWyloguj";
            this.buttonWyloguj.Size = new System.Drawing.Size(154, 34);
            this.buttonWyloguj.TabIndex = 0;
            this.buttonWyloguj.Text = "Wyloguj się";
            this.buttonWyloguj.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonWyloguj.UseVisualStyleBackColor = false;
            this.buttonWyloguj.Click += new System.EventHandler(this.buttonWyloguj_Click);
            // 
            // splitContainerSaldo
            // 
            this.splitContainerSaldo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerSaldo.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainerSaldo.IsSplitterFixed = true;
            this.splitContainerSaldo.Location = new System.Drawing.Point(0, 0);
            this.splitContainerSaldo.Name = "splitContainerSaldo";
            this.splitContainerSaldo.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerSaldo.Panel1
            // 
            this.splitContainerSaldo.Panel1.Controls.Add(this.labelInfoKalendarz);
            this.splitContainerSaldo.Panel1.Controls.Add(this.chartGlowny);
            this.splitContainerSaldo.Panel1.Controls.Add(this.listViewGlowne);
            this.splitContainerSaldo.Panel1.Controls.Add(this.listViewGlowny);
            // 
            // splitContainerSaldo.Panel2
            // 
            this.splitContainerSaldo.Panel2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.splitContainerSaldo.Size = new System.Drawing.Size(1554, 861);
            this.splitContainerSaldo.SplitterDistance = 650;
            this.splitContainerSaldo.TabIndex = 0;
            // 
            // labelInfoKalendarz
            // 
            this.labelInfoKalendarz.AutoSize = true;
            this.labelInfoKalendarz.BackColor = System.Drawing.Color.White;
            this.labelInfoKalendarz.Font = new System.Drawing.Font("Arial", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelInfoKalendarz.Location = new System.Drawing.Point(250, 300);
            this.labelInfoKalendarz.Name = "labelInfoKalendarz";
            this.labelInfoKalendarz.Size = new System.Drawing.Size(994, 49);
            this.labelInfoKalendarz.TabIndex = 4;
            this.labelInfoKalendarz.Text = "KALENDARZ W TRAKCIE PRZYGOTOWYWANIA";
            this.labelInfoKalendarz.Visible = false;
            // 
            // chartGlowny
            // 
            chartArea1.Name = "ChartArea1";
            this.chartGlowny.ChartAreas.Add(chartArea1);
            this.chartGlowny.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chartGlowny.Legends.Add(legend1);
            this.chartGlowny.Location = new System.Drawing.Point(0, 0);
            this.chartGlowny.Name = "chartGlowny";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartGlowny.Series.Add(series1);
            this.chartGlowny.Size = new System.Drawing.Size(1554, 650);
            this.chartGlowny.TabIndex = 3;
            this.chartGlowny.Text = "chart1";
            this.chartGlowny.Visible = false;
            // 
            // listViewGlowne
            // 
            this.listViewGlowne.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.columnUżytkownicy,
            this.columnOperacja,
            this.columnKwota,
            this.columnData,
            this.columnKategoria,
            this.columnOpis});
            this.listViewGlowne.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewGlowne.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listViewGlowne.GridLines = true;
            this.listViewGlowne.HideSelection = false;
            this.listViewGlowne.Location = new System.Drawing.Point(0, 0);
            this.listViewGlowne.Name = "listViewGlowne";
            this.listViewGlowne.Size = new System.Drawing.Size(1554, 650);
            this.listViewGlowne.TabIndex = 2;
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
            // columnKategoria
            // 
            this.columnKategoria.Text = "Kategoria";
            this.columnKategoria.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnKategoria.Width = 200;
            // 
            // columnOpis
            // 
            this.columnOpis.Text = "Opis";
            this.columnOpis.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnOpis.Width = 200;
            // 
            // listViewGlowny
            // 
            this.listViewGlowny.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewGlowny.HideSelection = false;
            this.listViewGlowny.Location = new System.Drawing.Point(0, 0);
            this.listViewGlowny.Name = "listViewGlowny";
            this.listViewGlowny.Size = new System.Drawing.Size(1554, 650);
            this.listViewGlowny.TabIndex = 0;
            this.listViewGlowny.UseCompatibleStateImageBehavior = false;
            // 
            // panelGlowny
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1908, 945);
            this.Controls.Add(this.splitContainerGlowny);
            this.Name = "panelGlowny";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Budżet domowy";
            this.Activated += new System.EventHandler(this.panelGlowny_Activated);
            this.Load += new System.EventHandler(this.panelGlowny_Load);
            this.SizeChanged += new System.EventHandler(this.panelGlowny_SizeChanged);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panelGlowny_MouseClick);
            this.splitContainerGlowny.Panel1.ResumeLayout(false);
            this.splitContainerGlowny.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerGlowny)).EndInit();
            this.splitContainerGlowny.ResumeLayout(false);
            this.splitContainerMenuBoczne.Panel1.ResumeLayout(false);
            this.splitContainerMenuBoczne.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMenuBoczne)).EndInit();
            this.splitContainerMenuBoczne.ResumeLayout(false);
            this.splitContainerMenuBoczneWidok.Panel1.ResumeLayout(false);
            this.splitContainerMenuBoczneWidok.Panel1.PerformLayout();
            this.splitContainerMenuBoczneWidok.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMenuBoczneWidok)).EndInit();
            this.splitContainerMenuBoczneWidok.ResumeLayout(false);
            this.splitContainerFiltr.Panel1.ResumeLayout(false);
            this.splitContainerFiltr.Panel1.PerformLayout();
            this.splitContainerFiltr.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerFiltr)).EndInit();
            this.splitContainerFiltr.ResumeLayout(false);
            this.splitContainerSaldo.Panel1.ResumeLayout(false);
            this.splitContainerSaldo.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerSaldo)).EndInit();
            this.splitContainerSaldo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartGlowny)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainerGlowny;
        private System.Windows.Forms.SplitContainer splitContainerMenuBoczne;
        private System.Windows.Forms.SplitContainer splitContainerMenuBoczneWidok;
        private System.Windows.Forms.SplitContainer splitContainerFiltr;
        private System.Windows.Forms.Button buttonDodajWydatek;
        private System.Windows.Forms.Button buttonDodajPrzychód;
        private System.Windows.Forms.RichTextBox richTextBoxDodaj;
        private System.Windows.Forms.DateTimePicker dateTimePickerDodajOperacje;
        private System.Windows.Forms.TextBox textBoxDodajKwote;
        private System.Windows.Forms.Button buttonZapisz;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.CheckBox checkBoxCykliczny;
        private System.Windows.Forms.SplitContainer splitContainerSaldo;
        private System.Windows.Forms.Button buttonUstawienia;
        private System.Windows.Forms.Button buttonWyloguj;
        private System.Windows.Forms.ComboBox comboBoxKategoria;
        private System.Windows.Forms.ComboBox comboBoxFiltrWyborOperacji;
        private System.Windows.Forms.Label labelDoData;
        private System.Windows.Forms.DateTimePicker dateTimePickerFiltrDo;
        private System.Windows.Forms.Label labelOdData;
        private System.Windows.Forms.DateTimePicker dateTimePickerFiltrOd;
        private System.Windows.Forms.CheckBox checkBoxFiltrZaawansowany;
        private System.Windows.Forms.Label labelSzukajWOpisie;
        private System.Windows.Forms.TextBox textBoxFiltrKwotaDo;
        private System.Windows.Forms.TextBox textBoxFiltrKwotaOd;
        private System.Windows.Forms.ComboBox comboBoxFiltrKategoria;
        private System.Windows.Forms.Label labelDoKwota;
        private System.Windows.Forms.Label labelOdKwota;
        private System.Windows.Forms.Button buttonWyszukaj;
        private System.Windows.Forms.TextBox textBoxSzukajWOpisie;
        private System.Windows.Forms.ListView listViewGlowny;
        private System.Windows.Forms.Button buttonWidokKalendarz;
        private System.Windows.Forms.Button buttonWidokLiniowy;
        private System.Windows.Forms.Button buttonWidokKolumnowy;
        private System.Windows.Forms.Button buttonWidokKolowy;
        private System.Windows.Forms.ListView listViewGlowne;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartGlowny;
        private System.Windows.Forms.Label labelInfoKalendarz;
        private System.Windows.Forms.ColumnHeader columnKwota;
        private System.Windows.Forms.ColumnHeader columnData;
        private System.Windows.Forms.ColumnHeader columnKategoria;
        private System.Windows.Forms.ColumnHeader columnOpis;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader columnOperacja;
        private System.Windows.Forms.Button buttonWidokTabelka;
        private System.Windows.Forms.ComboBox comboBoxFiltrUzytkownik;
        private System.Windows.Forms.Button buttonPowiadomienia;
        private System.Windows.Forms.ColumnHeader columnUżytkownicy;
    }
}