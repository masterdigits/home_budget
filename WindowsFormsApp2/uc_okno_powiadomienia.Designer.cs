namespace WindowsFormsApp2
{
    partial class uc_okno_powiadomienia
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
            this.l_do = new System.Windows.Forms.Label();
            this.clb_uzytkownicy = new System.Windows.Forms.CheckedListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_nazwa = new System.Windows.Forms.TextBox();
            this.rtb_opis = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_wyslij = new System.Windows.Forms.Button();
            this.btn_anuluj = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.btn_anuluj);
            this.panel1.Controls.Add(this.btn_wyslij);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.rtb_opis);
            this.panel1.Controls.Add(this.tb_nazwa);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.clb_uzytkownicy);
            this.panel1.Controls.Add(this.l_do);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1327, 794);
            this.panel1.TabIndex = 0;
            // 
            // l_do
            // 
            this.l_do.AutoSize = true;
            this.l_do.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.l_do.Location = new System.Drawing.Point(25, 29);
            this.l_do.Name = "l_do";
            this.l_do.Size = new System.Drawing.Size(34, 24);
            this.l_do.TabIndex = 0;
            this.l_do.Text = "Do";
            // 
            // clb_uzytkownicy
            // 
            this.clb_uzytkownicy.FormattingEnabled = true;
            this.clb_uzytkownicy.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.clb_uzytkownicy.Items.AddRange(new object[] {
            "A ",
            "B",
            "C"});
            this.clb_uzytkownicy.Location = new System.Drawing.Point(167, 29);
            this.clb_uzytkownicy.MultiColumn = true;
            this.clb_uzytkownicy.Name = "clb_uzytkownicy";
            this.clb_uzytkownicy.Size = new System.Drawing.Size(1093, 19);
            this.clb_uzytkownicy.Sorted = true;
            this.clb_uzytkownicy.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(25, 71);
            this.label2.MaximumSize = new System.Drawing.Size(139, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 48);
            this.label2.TabIndex = 2;
            this.label2.Text = "Temat powiadomienia";
            // 
            // tb_nazwa
            // 
            this.tb_nazwa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tb_nazwa.Location = new System.Drawing.Point(167, 80);
            this.tb_nazwa.Name = "tb_nazwa";
            this.tb_nazwa.Size = new System.Drawing.Size(1093, 29);
            this.tb_nazwa.TabIndex = 3;
            // 
            // rtb_opis
            // 
            this.rtb_opis.Location = new System.Drawing.Point(167, 137);
            this.rtb_opis.Name = "rtb_opis";
            this.rtb_opis.Size = new System.Drawing.Size(1093, 512);
            this.rtb_opis.TabIndex = 4;
            this.rtb_opis.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(29, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Treść";
            // 
            // btn_wyslij
            // 
            this.btn_wyslij.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_wyslij.Location = new System.Drawing.Point(211, 668);
            this.btn_wyslij.Name = "btn_wyslij";
            this.btn_wyslij.Size = new System.Drawing.Size(413, 87);
            this.btn_wyslij.TabIndex = 6;
            this.btn_wyslij.Text = "Wyślij";
            this.btn_wyslij.UseVisualStyleBackColor = true;
            this.btn_wyslij.Click += new System.EventHandler(this.btn_wyslij_Click);
            // 
            // btn_anuluj
            // 
            this.btn_anuluj.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_anuluj.Location = new System.Drawing.Point(748, 668);
            this.btn_anuluj.Name = "btn_anuluj";
            this.btn_anuluj.Size = new System.Drawing.Size(413, 87);
            this.btn_anuluj.TabIndex = 7;
            this.btn_anuluj.Text = "Anuluj";
            this.btn_anuluj.UseVisualStyleBackColor = true;
            this.btn_anuluj.Click += new System.EventHandler(this.btn_anuluj_Click);
            // 
            // uc_okno_powiadomienia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "uc_okno_powiadomienia";
            this.Size = new System.Drawing.Size(1327, 794);
            this.Load += new System.EventHandler(this.uc_okno_powiadomienia_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_anuluj;
        private System.Windows.Forms.Button btn_wyslij;
        public System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox rtb_opis;
        private System.Windows.Forms.TextBox tb_nazwa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox clb_uzytkownicy;
        private System.Windows.Forms.Label l_do;
    }
}
