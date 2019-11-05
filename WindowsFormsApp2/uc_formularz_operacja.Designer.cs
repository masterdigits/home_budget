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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uc_formularz_operacja));
            this.panel1 = new System.Windows.Forms.Panel();
            this.nm_kwota = new System.Windows.Forms.NumericUpDown();
            this.labelWriteNumber = new System.Windows.Forms.Label();
            this.labelWritePrice = new System.Windows.Forms.Label();
            this.labelChooseCategory = new System.Windows.Forms.Label();
            this.labelChoosePaymentForm = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.comboBoxOperationForm = new System.Windows.Forms.ComboBox();
            this.richTextBoxDescription = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.radioButtonIncome = new System.Windows.Forms.RadioButton();
            this.radioButtonExpense = new System.Windows.Forms.RadioButton();
            this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.checkBoxCykliczny = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nm_kwota)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.checkBoxCykliczny);
            this.panel1.Controls.Add(this.nm_kwota);
            this.panel1.Controls.Add(this.labelWriteNumber);
            this.panel1.Controls.Add(this.labelWritePrice);
            this.panel1.Controls.Add(this.labelChooseCategory);
            this.panel1.Controls.Add(this.labelChoosePaymentForm);
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.comboBoxCategory);
            this.panel1.Controls.Add(this.comboBoxOperationForm);
            this.panel1.Controls.Add(this.richTextBoxDescription);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.radioButtonIncome);
            this.panel1.Controls.Add(this.radioButtonExpense);
            this.panel1.Controls.Add(this.dateTimePickerDate);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.buttonReset);
            this.panel1.Controls.Add(this.buttonSave);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 346);
            this.panel1.TabIndex = 0;
            // 
            // nm_kwota
            // 
            this.nm_kwota.Location = new System.Drawing.Point(141, 197);
            this.nm_kwota.Name = "nm_kwota";
            this.nm_kwota.Size = new System.Drawing.Size(177, 20);
            this.nm_kwota.TabIndex = 119;
            // 
            // labelWriteNumber
            // 
            this.labelWriteNumber.AutoSize = true;
            this.labelWriteNumber.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelWriteNumber.ForeColor = System.Drawing.Color.Red;
            this.labelWriteNumber.Location = new System.Drawing.Point(245, 222);
            this.labelWriteNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelWriteNumber.Name = "labelWriteNumber";
            this.labelWriteNumber.Size = new System.Drawing.Size(73, 14);
            this.labelWriteNumber.TabIndex = 118;
            this.labelWriteNumber.Text = "Wpisz liczbę!";
            this.labelWriteNumber.Visible = false;
            // 
            // labelWritePrice
            // 
            this.labelWritePrice.AutoSize = true;
            this.labelWritePrice.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelWritePrice.ForeColor = System.Drawing.Color.Red;
            this.labelWritePrice.Location = new System.Drawing.Point(243, 222);
            this.labelWritePrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelWritePrice.Name = "labelWritePrice";
            this.labelWritePrice.Size = new System.Drawing.Size(75, 14);
            this.labelWritePrice.TabIndex = 117;
            this.labelWritePrice.Text = "Wpisz kwotę!";
            this.labelWritePrice.Visible = false;
            // 
            // labelChooseCategory
            // 
            this.labelChooseCategory.AutoSize = true;
            this.labelChooseCategory.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelChooseCategory.ForeColor = System.Drawing.Color.Red;
            this.labelChooseCategory.Location = new System.Drawing.Point(199, 175);
            this.labelChooseCategory.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelChooseCategory.Name = "labelChooseCategory";
            this.labelChooseCategory.Size = new System.Drawing.Size(104, 14);
            this.labelChooseCategory.TabIndex = 115;
            this.labelChooseCategory.Text = "Wybierz kategorię!";
            this.labelChooseCategory.Visible = false;
            // 
            // labelChoosePaymentForm
            // 
            this.labelChoosePaymentForm.AutoSize = true;
            this.labelChoosePaymentForm.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelChoosePaymentForm.ForeColor = System.Drawing.Color.Red;
            this.labelChoosePaymentForm.Location = new System.Drawing.Point(199, 120);
            this.labelChoosePaymentForm.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelChoosePaymentForm.Name = "labelChoosePaymentForm";
            this.labelChoosePaymentForm.Size = new System.Drawing.Size(137, 14);
            this.labelChoosePaymentForm.TabIndex = 114;
            this.labelChoosePaymentForm.Text = "Wybierz formę płatności!";
            this.labelChoosePaymentForm.Visible = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(162, 222);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(33, 20);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 112;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Visible = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(162, 169);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(33, 20);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 110;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(162, 114);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(33, 20);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 109;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Location = new System.Drawing.Point(141, 143);
            this.comboBoxCategory.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(177, 21);
            this.comboBoxCategory.TabIndex = 104;
            // 
            // comboBoxOperationForm
            // 
            this.comboBoxOperationForm.FormattingEnabled = true;
            this.comboBoxOperationForm.Location = new System.Drawing.Point(141, 89);
            this.comboBoxOperationForm.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxOperationForm.Name = "comboBoxOperationForm";
            this.comboBoxOperationForm.Size = new System.Drawing.Size(177, 21);
            this.comboBoxOperationForm.TabIndex = 103;
            // 
            // richTextBoxDescription
            // 
            this.richTextBoxDescription.Location = new System.Drawing.Point(141, 247);
            this.richTextBoxDescription.Margin = new System.Windows.Forms.Padding(2);
            this.richTextBoxDescription.Name = "richTextBoxDescription";
            this.richTextBoxDescription.Size = new System.Drawing.Size(177, 44);
            this.richTextBoxDescription.TabIndex = 101;
            this.richTextBoxDescription.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(55, 143);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 17);
            this.label7.TabIndex = 99;
            this.label7.Text = "Kategoria";
            // 
            // radioButtonIncome
            // 
            this.radioButtonIncome.AutoSize = true;
            this.radioButtonIncome.Location = new System.Drawing.Point(246, 60);
            this.radioButtonIncome.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonIncome.Name = "radioButtonIncome";
            this.radioButtonIncome.Size = new System.Drawing.Size(69, 17);
            this.radioButtonIncome.TabIndex = 98;
            this.radioButtonIncome.TabStop = true;
            this.radioButtonIncome.Text = "Przychód";
            this.radioButtonIncome.UseVisualStyleBackColor = true;
            this.radioButtonIncome.CheckedChanged += new System.EventHandler(this.radioButtonIncome_CheckedChanged);
            // 
            // radioButtonExpense
            // 
            this.radioButtonExpense.AutoSize = true;
            this.radioButtonExpense.Location = new System.Drawing.Point(141, 60);
            this.radioButtonExpense.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonExpense.Name = "radioButtonExpense";
            this.radioButtonExpense.Size = new System.Drawing.Size(68, 17);
            this.radioButtonExpense.TabIndex = 97;
            this.radioButtonExpense.TabStop = true;
            this.radioButtonExpense.Text = "Wydatek";
            this.radioButtonExpense.UseVisualStyleBackColor = true;
            this.radioButtonExpense.CheckedChanged += new System.EventHandler(this.radioButtonExpense_CheckedChanged);
            // 
            // dateTimePickerDate
            // 
            this.dateTimePickerDate.Location = new System.Drawing.Point(141, 10);
            this.dateTimePickerDate.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePickerDate.Name = "dateTimePickerDate";
            this.dateTimePickerDate.Size = new System.Drawing.Size(177, 20);
            this.dateTimePickerDate.TabIndex = 96;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(33, 247);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 17);
            this.label6.TabIndex = 95;
            this.label6.Text = "Opis operacji";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(54, 196);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 17);
            this.label5.TabIndex = 94;
            this.label5.Text = "Kwota (zł)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 89);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 17);
            this.label4.TabIndex = 93;
            this.label4.Text = "Forma operacji";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 59);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 17);
            this.label3.TabIndex = 92;
            this.label3.Text = "Typ operacji";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 10);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 17);
            this.label2.TabIndex = 91;
            this.label2.Text = "Data operacji";
            // 
            // buttonReset
            // 
            this.buttonReset.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReset.Location = new System.Drawing.Point(162, 295);
            this.buttonReset.Margin = new System.Windows.Forms.Padding(2);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(156, 26);
            this.buttonReset.TabIndex = 90;
            this.buttonReset.Text = "Anuluj";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.Location = new System.Drawing.Point(35, 295);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(117, 26);
            this.buttonSave.TabIndex = 89;
            this.buttonSave.Text = "Dodaj";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // checkBoxCykliczny
            // 
            this.checkBoxCykliczny.AutoSize = true;
            this.checkBoxCykliczny.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.checkBoxCykliczny.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBoxCykliczny.Location = new System.Drawing.Point(141, 38);
            this.checkBoxCykliczny.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxCykliczny.Name = "checkBoxCykliczny";
            this.checkBoxCykliczny.Size = new System.Drawing.Size(177, 18);
            this.checkBoxCykliczny.TabIndex = 120;
            this.checkBoxCykliczny.Text = "Ustaw jako przychód cykliczny";
            this.checkBoxCykliczny.UseVisualStyleBackColor = false;
            // 
            // uc_formularz_operacja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "uc_formularz_operacja";
            this.Size = new System.Drawing.Size(350, 346);
            this.Enter += new System.EventHandler(this.uc_formularz_operacja_Enter);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nm_kwota)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelWriteNumber;
        private System.Windows.Forms.Label labelWritePrice;
        private System.Windows.Forms.Label labelChoosePaymentForm;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.ComboBox comboBoxOperationForm;
        private System.Windows.Forms.RichTextBox richTextBoxDescription;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton radioButtonIncome;
        private System.Windows.Forms.RadioButton radioButtonExpense;
        private System.Windows.Forms.DateTimePicker dateTimePickerDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.NumericUpDown nm_kwota;
        private System.Windows.Forms.Label labelChooseCategory;
        private System.Windows.Forms.CheckBox checkBoxCykliczny;
    }
}
