namespace WindowsFormsApp2
{
    partial class uc_formularz_operacja
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
            this.textBoxNazwa = new System.Windows.Forms.TextBox();
            this.labelNazwaOperacji = new System.Windows.Forms.Label();
            this.checkBoxCykliczny = new System.Windows.Forms.CheckBox();
            this.numericUpDownKwota = new System.Windows.Forms.NumericUpDown();
            this.comboBoxKategoria = new System.Windows.Forms.ComboBox();
            this.comboBoxFormaOperacji = new System.Windows.Forms.ComboBox();
            this.richTextBoxOpisOperacji = new System.Windows.Forms.RichTextBox();
            this.labelKategoria = new System.Windows.Forms.Label();
            this.radioButtonPrzychod = new System.Windows.Forms.RadioButton();
            this.radioButtonWydatek = new System.Windows.Forms.RadioButton();
            this.dateTimePickerOperacji = new System.Windows.Forms.DateTimePicker();
            this.labelOpisOperacji = new System.Windows.Forms.Label();
            this.labelKwota = new System.Windows.Forms.Label();
            this.labelFormaOperacji = new System.Windows.Forms.Label();
            this.labelTypOperacji = new System.Windows.Forms.Label();
            this.labelDataOperacji = new System.Windows.Forms.Label();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonZapisz = new System.Windows.Forms.Button();
            this.pictureWykrzyknikKwota = new System.Windows.Forms.PictureBox();
            this.pictureWykrzyknikKategoria = new System.Windows.Forms.PictureBox();
            this.pictureWykrzyknikForma = new System.Windows.Forms.PictureBox();
            this.pictureWykrzyknikNazwa = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKwota)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureWykrzyknikKwota)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureWykrzyknikKategoria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureWykrzyknikForma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureWykrzyknikNazwa)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.pictureWykrzyknikKwota);
            this.panel1.Controls.Add(this.pictureWykrzyknikKategoria);
            this.panel1.Controls.Add(this.pictureWykrzyknikForma);
            this.panel1.Controls.Add(this.pictureWykrzyknikNazwa);
            this.panel1.Controls.Add(this.textBoxNazwa);
            this.panel1.Controls.Add(this.labelNazwaOperacji);
            this.panel1.Controls.Add(this.checkBoxCykliczny);
            this.panel1.Controls.Add(this.numericUpDownKwota);
            this.panel1.Controls.Add(this.comboBoxKategoria);
            this.panel1.Controls.Add(this.comboBoxFormaOperacji);
            this.panel1.Controls.Add(this.richTextBoxOpisOperacji);
            this.panel1.Controls.Add(this.labelKategoria);
            this.panel1.Controls.Add(this.radioButtonPrzychod);
            this.panel1.Controls.Add(this.radioButtonWydatek);
            this.panel1.Controls.Add(this.dateTimePickerOperacji);
            this.panel1.Controls.Add(this.labelOpisOperacji);
            this.panel1.Controls.Add(this.labelKwota);
            this.panel1.Controls.Add(this.labelFormaOperacji);
            this.panel1.Controls.Add(this.labelTypOperacji);
            this.panel1.Controls.Add(this.labelDataOperacji);
            this.panel1.Controls.Add(this.buttonReset);
            this.panel1.Controls.Add(this.buttonZapisz);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(451, 491);
            this.panel1.TabIndex = 0;
            // 
            // textBoxNazwa
            // 
            this.textBoxNazwa.BackColor = System.Drawing.Color.White;
            this.textBoxNazwa.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxNazwa.Location = new System.Drawing.Point(180, 73);
            this.textBoxNazwa.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNazwa.Name = "textBoxNazwa";
            this.textBoxNazwa.Size = new System.Drawing.Size(235, 27);
            this.textBoxNazwa.TabIndex = 0;
            // 
            // labelNazwaOperacji
            // 
            this.labelNazwaOperacji.AutoSize = true;
            this.labelNazwaOperacji.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelNazwaOperacji.Location = new System.Drawing.Point(28, 73);
            this.labelNazwaOperacji.Name = "labelNazwaOperacji";
            this.labelNazwaOperacji.Size = new System.Drawing.Size(120, 19);
            this.labelNazwaOperacji.TabIndex = 121;
            this.labelNazwaOperacji.Text = "Nazwa operacji";
            // 
            // checkBoxCykliczny
            // 
            this.checkBoxCykliczny.AutoSize = true;
            this.checkBoxCykliczny.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxCykliczny.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBoxCykliczny.Location = new System.Drawing.Point(27, 389);
            this.checkBoxCykliczny.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxCykliczny.Name = "checkBoxCykliczny";
            this.checkBoxCykliczny.Size = new System.Drawing.Size(254, 23);
            this.checkBoxCykliczny.TabIndex = 120;
            this.checkBoxCykliczny.Text = "Ustaw jako przychód cykliczny";
            this.checkBoxCykliczny.UseVisualStyleBackColor = false;
            // 
            // numericUpDownKwota
            // 
            this.numericUpDownKwota.BackColor = System.Drawing.Color.White;
            this.numericUpDownKwota.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numericUpDownKwota.Location = new System.Drawing.Point(180, 256);
            this.numericUpDownKwota.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDownKwota.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numericUpDownKwota.Name = "numericUpDownKwota";
            this.numericUpDownKwota.Size = new System.Drawing.Size(236, 27);
            this.numericUpDownKwota.TabIndex = 119;
            // 
            // comboBoxKategoria
            // 
            this.comboBoxKategoria.BackColor = System.Drawing.Color.White;
            this.comboBoxKategoria.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxKategoria.FormattingEnabled = true;
            this.comboBoxKategoria.Location = new System.Drawing.Point(180, 209);
            this.comboBoxKategoria.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxKategoria.Name = "comboBoxKategoria";
            this.comboBoxKategoria.Size = new System.Drawing.Size(235, 27);
            this.comboBoxKategoria.TabIndex = 104;
            // 
            // comboBoxFormaOperacji
            // 
            this.comboBoxFormaOperacji.BackColor = System.Drawing.Color.White;
            this.comboBoxFormaOperacji.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxFormaOperacji.FormattingEnabled = true;
            this.comboBoxFormaOperacji.Location = new System.Drawing.Point(180, 163);
            this.comboBoxFormaOperacji.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxFormaOperacji.Name = "comboBoxFormaOperacji";
            this.comboBoxFormaOperacji.Size = new System.Drawing.Size(235, 27);
            this.comboBoxFormaOperacji.TabIndex = 103;
            // 
            // richTextBoxOpisOperacji
            // 
            this.richTextBoxOpisOperacji.BackColor = System.Drawing.Color.White;
            this.richTextBoxOpisOperacji.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.richTextBoxOpisOperacji.Location = new System.Drawing.Point(181, 305);
            this.richTextBoxOpisOperacji.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.richTextBoxOpisOperacji.Name = "richTextBoxOpisOperacji";
            this.richTextBoxOpisOperacji.Size = new System.Drawing.Size(235, 53);
            this.richTextBoxOpisOperacji.TabIndex = 101;
            this.richTextBoxOpisOperacji.Text = "";
            // 
            // labelKategoria
            // 
            this.labelKategoria.AutoSize = true;
            this.labelKategoria.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelKategoria.Location = new System.Drawing.Point(28, 209);
            this.labelKategoria.Name = "labelKategoria";
            this.labelKategoria.Size = new System.Drawing.Size(79, 19);
            this.labelKategoria.TabIndex = 99;
            this.labelKategoria.Text = "Kategoria";
            // 
            // radioButtonPrzychod
            // 
            this.radioButtonPrzychod.AutoSize = true;
            this.radioButtonPrzychod.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioButtonPrzychod.Location = new System.Drawing.Point(315, 25);
            this.radioButtonPrzychod.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonPrzychod.Name = "radioButtonPrzychod";
            this.radioButtonPrzychod.Size = new System.Drawing.Size(100, 23);
            this.radioButtonPrzychod.TabIndex = 98;
            this.radioButtonPrzychod.TabStop = true;
            this.radioButtonPrzychod.Text = "Przychód";
            this.radioButtonPrzychod.UseVisualStyleBackColor = true;
            this.radioButtonPrzychod.CheckedChanged += new System.EventHandler(this.radioButtonIncome_CheckedChanged);
            // 
            // radioButtonWydatek
            // 
            this.radioButtonWydatek.AutoSize = true;
            this.radioButtonWydatek.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioButtonWydatek.Location = new System.Drawing.Point(181, 25);
            this.radioButtonWydatek.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonWydatek.Name = "radioButtonWydatek";
            this.radioButtonWydatek.Size = new System.Drawing.Size(95, 23);
            this.radioButtonWydatek.TabIndex = 97;
            this.radioButtonWydatek.TabStop = true;
            this.radioButtonWydatek.Text = "Wydatek";
            this.radioButtonWydatek.UseVisualStyleBackColor = true;
            this.radioButtonWydatek.CheckedChanged += new System.EventHandler(this.radioButtonExpense_CheckedChanged);
            // 
            // dateTimePickerOperacji
            // 
            this.dateTimePickerOperacji.CalendarMonthBackground = System.Drawing.Color.White;
            this.dateTimePickerOperacji.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateTimePickerOperacji.Location = new System.Drawing.Point(180, 119);
            this.dateTimePickerOperacji.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePickerOperacji.Name = "dateTimePickerOperacji";
            this.dateTimePickerOperacji.Size = new System.Drawing.Size(235, 27);
            this.dateTimePickerOperacji.TabIndex = 96;
            // 
            // labelOpisOperacji
            // 
            this.labelOpisOperacji.AutoSize = true;
            this.labelOpisOperacji.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelOpisOperacji.Location = new System.Drawing.Point(28, 305);
            this.labelOpisOperacji.Name = "labelOpisOperacji";
            this.labelOpisOperacji.Size = new System.Drawing.Size(105, 19);
            this.labelOpisOperacji.TabIndex = 95;
            this.labelOpisOperacji.Text = "Opis operacji";
            // 
            // labelKwota
            // 
            this.labelKwota.AutoSize = true;
            this.labelKwota.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelKwota.Location = new System.Drawing.Point(28, 256);
            this.labelKwota.Name = "labelKwota";
            this.labelKwota.Size = new System.Drawing.Size(81, 19);
            this.labelKwota.TabIndex = 94;
            this.labelKwota.Text = "Kwota (zł)";
            // 
            // labelFormaOperacji
            // 
            this.labelFormaOperacji.AutoSize = true;
            this.labelFormaOperacji.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelFormaOperacji.Location = new System.Drawing.Point(28, 163);
            this.labelFormaOperacji.Name = "labelFormaOperacji";
            this.labelFormaOperacji.Size = new System.Drawing.Size(119, 19);
            this.labelFormaOperacji.TabIndex = 93;
            this.labelFormaOperacji.Text = "Forma operacji";
            // 
            // labelTypOperacji
            // 
            this.labelTypOperacji.AutoSize = true;
            this.labelTypOperacji.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTypOperacji.Location = new System.Drawing.Point(28, 27);
            this.labelTypOperacji.Name = "labelTypOperacji";
            this.labelTypOperacji.Size = new System.Drawing.Size(98, 19);
            this.labelTypOperacji.TabIndex = 92;
            this.labelTypOperacji.Text = "Typ operacji";
            // 
            // labelDataOperacji
            // 
            this.labelDataOperacji.AutoSize = true;
            this.labelDataOperacji.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelDataOperacji.Location = new System.Drawing.Point(28, 119);
            this.labelDataOperacji.Name = "labelDataOperacji";
            this.labelDataOperacji.Size = new System.Drawing.Size(106, 19);
            this.labelDataOperacji.TabIndex = 91;
            this.labelDataOperacji.Text = "Data operacji";
            // 
            // buttonReset
            // 
            this.buttonReset.AutoSize = true;
            this.buttonReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonReset.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.buttonReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReset.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReset.Location = new System.Drawing.Point(27, 438);
            this.buttonReset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(179, 51);
            this.buttonReset.TabIndex = 90;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonZapisz
            // 
            this.buttonZapisz.AutoSize = true;
            this.buttonZapisz.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonZapisz.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.buttonZapisz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonZapisz.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonZapisz.Location = new System.Drawing.Point(236, 438);
            this.buttonZapisz.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonZapisz.Name = "buttonZapisz";
            this.buttonZapisz.Size = new System.Drawing.Size(179, 51);
            this.buttonZapisz.TabIndex = 89;
            this.buttonZapisz.Text = "Zapisz";
            this.buttonZapisz.UseVisualStyleBackColor = true;
            this.buttonZapisz.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // pictureWykrzyknikKwota
            // 
            this.pictureWykrzyknikKwota.Image = global::WindowsFormsApp2.Properties.Resources.kisspng_exclamation_mark_information_interjection_question_5adfd51503cdd9_8283211215246185170156;
            this.pictureWykrzyknikKwota.Location = new System.Drawing.Point(421, 257);
            this.pictureWykrzyknikKwota.Name = "pictureWykrzyknikKwota";
            this.pictureWykrzyknikKwota.Size = new System.Drawing.Size(27, 26);
            this.pictureWykrzyknikKwota.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureWykrzyknikKwota.TabIndex = 125;
            this.pictureWykrzyknikKwota.TabStop = false;
            this.pictureWykrzyknikKwota.Visible = false;
            // 
            // pictureWykrzyknikKategoria
            // 
            this.pictureWykrzyknikKategoria.Image = global::WindowsFormsApp2.Properties.Resources.kisspng_exclamation_mark_information_interjection_question_5adfd51503cdd9_8283211215246185170156;
            this.pictureWykrzyknikKategoria.Location = new System.Drawing.Point(421, 210);
            this.pictureWykrzyknikKategoria.Name = "pictureWykrzyknikKategoria";
            this.pictureWykrzyknikKategoria.Size = new System.Drawing.Size(27, 26);
            this.pictureWykrzyknikKategoria.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureWykrzyknikKategoria.TabIndex = 124;
            this.pictureWykrzyknikKategoria.TabStop = false;
            this.pictureWykrzyknikKategoria.Visible = false;
            // 
            // pictureWykrzyknikForma
            // 
            this.pictureWykrzyknikForma.Image = global::WindowsFormsApp2.Properties.Resources.kisspng_exclamation_mark_information_interjection_question_5adfd51503cdd9_8283211215246185170156;
            this.pictureWykrzyknikForma.Location = new System.Drawing.Point(421, 163);
            this.pictureWykrzyknikForma.Name = "pictureWykrzyknikForma";
            this.pictureWykrzyknikForma.Size = new System.Drawing.Size(27, 26);
            this.pictureWykrzyknikForma.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureWykrzyknikForma.TabIndex = 123;
            this.pictureWykrzyknikForma.TabStop = false;
            this.pictureWykrzyknikForma.Visible = false;
            // 
            // pictureWykrzyknikNazwa
            // 
            this.pictureWykrzyknikNazwa.Image = global::WindowsFormsApp2.Properties.Resources.kisspng_exclamation_mark_information_interjection_question_5adfd51503cdd9_8283211215246185170156;
            this.pictureWykrzyknikNazwa.Location = new System.Drawing.Point(421, 73);
            this.pictureWykrzyknikNazwa.Name = "pictureWykrzyknikNazwa";
            this.pictureWykrzyknikNazwa.Size = new System.Drawing.Size(27, 26);
            this.pictureWykrzyknikNazwa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureWykrzyknikNazwa.TabIndex = 122;
            this.pictureWykrzyknikNazwa.TabStop = false;
            this.pictureWykrzyknikNazwa.Visible = false;
            // 
            // uc_formularz_operacja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "uc_formularz_operacja";
            this.Size = new System.Drawing.Size(451, 491);
            this.Enter += new System.EventHandler(this.uc_formularz_operacja_Enter);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKwota)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureWykrzyknikKwota)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureWykrzyknikKategoria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureWykrzyknikForma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureWykrzyknikNazwa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBoxKategoria;
        private System.Windows.Forms.ComboBox comboBoxFormaOperacji;
        private System.Windows.Forms.RichTextBox richTextBoxOpisOperacji;
        private System.Windows.Forms.Label labelKategoria;
        private System.Windows.Forms.RadioButton radioButtonPrzychod;
        private System.Windows.Forms.RadioButton radioButtonWydatek;
        private System.Windows.Forms.DateTimePicker dateTimePickerOperacji;
        private System.Windows.Forms.Label labelOpisOperacji;
        private System.Windows.Forms.Label labelKwota;
        private System.Windows.Forms.Label labelFormaOperacji;
        private System.Windows.Forms.Label labelTypOperacji;
        private System.Windows.Forms.Label labelDataOperacji;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonZapisz;
        private System.Windows.Forms.NumericUpDown numericUpDownKwota;
        private System.Windows.Forms.CheckBox checkBoxCykliczny;
        private System.Windows.Forms.TextBox textBoxNazwa;
        private System.Windows.Forms.Label labelNazwaOperacji;
        private System.Windows.Forms.PictureBox pictureWykrzyknikNazwa;
        private System.Windows.Forms.PictureBox pictureWykrzyknikKwota;
        private System.Windows.Forms.PictureBox pictureWykrzyknikKategoria;
        private System.Windows.Forms.PictureBox pictureWykrzyknikForma;
    }
}
