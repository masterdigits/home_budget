namespace WindowsFormsApp2
{
    partial class uc_filtr
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.uc_dodaj_date1 = new WindowsFormsApp2.uc_dodaj_date();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxSzukajWOpisie = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nm_kwota_do = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nm_kwota_od = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.radioButtonIncome = new System.Windows.Forms.RadioButton();
            this.chlb_uzytkownicy = new System.Windows.Forms.CheckedListBox();
            this.radioButtonExpense = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxFiltrKategoria = new System.Windows.Forms.ComboBox();
            this.tb_nazwa = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nm_kwota_do)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nm_kwota_od)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.uc_dodaj_date1);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.textBoxSzukajWOpisie);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.nm_kwota_do);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.nm_kwota_od);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.radioButtonIncome);
            this.panel1.Controls.Add(this.chlb_uzytkownicy);
            this.panel1.Controls.Add(this.radioButtonExpense);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.comboBoxFiltrKategoria);
            this.panel1.Controls.Add(this.tb_nazwa);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1051, 176);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(866, 121);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 24);
            this.button1.TabIndex = 21;
            this.button1.Text = "Wyszukaj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // uc_dodaj_date1
            // 
            this.uc_dodaj_date1.AutoSize = true;
            this.uc_dodaj_date1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.uc_dodaj_date1.BackColor = System.Drawing.Color.Transparent;
            this.uc_dodaj_date1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uc_dodaj_date1.Location = new System.Drawing.Point(705, 16);
            this.uc_dodaj_date1.Name = "uc_dodaj_date1";
            this.uc_dodaj_date1.Size = new System.Drawing.Size(296, 38);
            this.uc_dodaj_date1.TabIndex = 101;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(323, 62);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(166, 17);
            this.label7.TabIndex = 108;
            this.label7.Text = "Wybierz przedział kwoty";
            // 
            // textBoxSzukajWOpisie
            // 
            this.textBoxSzukajWOpisie.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxSzukajWOpisie.Location = new System.Drawing.Point(529, 36);
            this.textBoxSzukajWOpisie.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxSzukajWOpisie.Multiline = true;
            this.textBoxSzukajWOpisie.Name = "textBoxSzukajWOpisie";
            this.textBoxSzukajWOpisie.Size = new System.Drawing.Size(145, 99);
            this.textBoxSzukajWOpisie.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(323, 17);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 17);
            this.label4.TabIndex = 107;
            this.label4.Text = "Wybierz kategorię";
            // 
            // nm_kwota_do
            // 
            this.nm_kwota_do.Location = new System.Drawing.Point(386, 118);
            this.nm_kwota_do.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.nm_kwota_do.Name = "nm_kwota_do";
            this.nm_kwota_do.Size = new System.Drawing.Size(120, 20);
            this.nm_kwota_do.TabIndex = 103;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(526, 16);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 17);
            this.label8.TabIndex = 20;
            this.label8.Text = "Szukaj w opisie";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(194, 59);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 17);
            this.label3.TabIndex = 106;
            this.label3.Text = "Typ operacji";
            // 
            // nm_kwota_od
            // 
            this.nm_kwota_od.Location = new System.Drawing.Point(386, 87);
            this.nm_kwota_od.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.nm_kwota_od.Name = "nm_kwota_od";
            this.nm_kwota_od.Size = new System.Drawing.Size(120, 20);
            this.nm_kwota_od.TabIndex = 102;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(17, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 17);
            this.label1.TabIndex = 105;
            this.label1.Text = "Wybierz użytkowników";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(194, 16);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 17);
            this.label2.TabIndex = 104;
            this.label2.Text = "Nazwa operacji";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(323, 118);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "Do";
            // 
            // radioButtonIncome
            // 
            this.radioButtonIncome.AutoSize = true;
            this.radioButtonIncome.Location = new System.Drawing.Point(197, 118);
            this.radioButtonIncome.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonIncome.Name = "radioButtonIncome";
            this.radioButtonIncome.Size = new System.Drawing.Size(69, 17);
            this.radioButtonIncome.TabIndex = 100;
            this.radioButtonIncome.TabStop = true;
            this.radioButtonIncome.Text = "Przychód";
            this.radioButtonIncome.UseVisualStyleBackColor = true;
            this.radioButtonIncome.CheckedChanged += new System.EventHandler(this.radioButtonIncome_CheckedChanged);
            // 
            // chlb_uzytkownicy
            // 
            this.chlb_uzytkownicy.CheckOnClick = true;
            this.chlb_uzytkownicy.FormattingEnabled = true;
            this.chlb_uzytkownicy.Location = new System.Drawing.Point(20, 36);
            this.chlb_uzytkownicy.Name = "chlb_uzytkownicy";
            this.chlb_uzytkownicy.Size = new System.Drawing.Size(153, 109);
            this.chlb_uzytkownicy.TabIndex = 28;
            // 
            // radioButtonExpense
            // 
            this.radioButtonExpense.AutoSize = true;
            this.radioButtonExpense.Location = new System.Drawing.Point(197, 87);
            this.radioButtonExpense.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonExpense.Name = "radioButtonExpense";
            this.radioButtonExpense.Size = new System.Drawing.Size(68, 17);
            this.radioButtonExpense.TabIndex = 99;
            this.radioButtonExpense.TabStop = true;
            this.radioButtonExpense.Text = "Wydatek";
            this.radioButtonExpense.UseVisualStyleBackColor = true;
            this.radioButtonExpense.CheckedChanged += new System.EventHandler(this.radioButtonExpense_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(322, 90);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Od";
            // 
            // comboBoxFiltrKategoria
            // 
            this.comboBoxFiltrKategoria.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxFiltrKategoria.ForeColor = System.Drawing.Color.DimGray;
            this.comboBoxFiltrKategoria.FormattingEnabled = true;
            this.comboBoxFiltrKategoria.Location = new System.Drawing.Point(326, 36);
            this.comboBoxFiltrKategoria.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxFiltrKategoria.Name = "comboBoxFiltrKategoria";
            this.comboBoxFiltrKategoria.Size = new System.Drawing.Size(180, 24);
            this.comboBoxFiltrKategoria.TabIndex = 17;
            this.comboBoxFiltrKategoria.Text = "Wybierz kategorię";
            // 
            // tb_nazwa
            // 
            this.tb_nazwa.Location = new System.Drawing.Point(197, 36);
            this.tb_nazwa.Name = "tb_nazwa";
            this.tb_nazwa.Size = new System.Drawing.Size(100, 20);
            this.tb_nazwa.TabIndex = 27;
            // 
            // uc_filtr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "uc_filtr";
            this.Size = new System.Drawing.Size(1051, 176);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nm_kwota_do)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nm_kwota_od)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox chlb_uzytkownicy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_nazwa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioButtonExpense;
        private System.Windows.Forms.RadioButton radioButtonIncome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxFiltrKategoria;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nm_kwota_od;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nm_kwota_do;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxSzukajWOpisie;
        private uc_dodaj_date uc_dodaj_date1;
        private System.Windows.Forms.Button button1;
    }
}
