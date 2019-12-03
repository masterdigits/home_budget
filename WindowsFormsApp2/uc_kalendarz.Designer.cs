namespace WindowsFormsApp2
{
    partial class uc_kalendarz
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
            this.tlp_głowny = new System.Windows.Forms.TableLayoutPanel();
            this.pn_ustawienia_kal = new System.Windows.Forms.Panel();
            this.chlb_uzytkownicy = new System.Windows.Forms.CheckedListBox();
            this.cb_rok = new System.Windows.Forms.ComboBox();
            this.cb_miesiac = new System.Windows.Forms.ComboBox();
            this.btn_poprzedni_miesiac = new System.Windows.Forms.Button();
            this.btn_nast_miesiac = new System.Windows.Forms.Button();
            this.tlp_kalendarz = new System.Windows.Forms.TableLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tlp_głowny.SuspendLayout();
            this.pn_ustawienia_kal.SuspendLayout();
            this.tlp_kalendarz.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlp_głowny
            // 
            this.tlp_głowny.AutoSize = true;
            this.tlp_głowny.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlp_głowny.ColumnCount = 1;
            this.tlp_głowny.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlp_głowny.Controls.Add(this.pn_ustawienia_kal, 0, 0);
            this.tlp_głowny.Controls.Add(this.tlp_kalendarz, 0, 1);
            this.tlp_głowny.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_głowny.Location = new System.Drawing.Point(0, 0);
            this.tlp_głowny.Name = "tlp_głowny";
            this.tlp_głowny.RowCount = 2;
            this.tlp_głowny.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tlp_głowny.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlp_głowny.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_głowny.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_głowny.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_głowny.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_głowny.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_głowny.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_głowny.Size = new System.Drawing.Size(1161, 400);
            this.tlp_głowny.TabIndex = 0;
            // 
            // pn_ustawienia_kal
            // 
            this.pn_ustawienia_kal.AutoSize = true;
            this.pn_ustawienia_kal.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pn_ustawienia_kal.Controls.Add(this.chlb_uzytkownicy);
            this.pn_ustawienia_kal.Controls.Add(this.cb_rok);
            this.pn_ustawienia_kal.Controls.Add(this.cb_miesiac);
            this.pn_ustawienia_kal.Controls.Add(this.btn_poprzedni_miesiac);
            this.pn_ustawienia_kal.Controls.Add(this.btn_nast_miesiac);
            this.pn_ustawienia_kal.Location = new System.Drawing.Point(3, 3);
            this.pn_ustawienia_kal.Name = "pn_ustawienia_kal";
            this.pn_ustawienia_kal.Size = new System.Drawing.Size(1155, 68);
            this.pn_ustawienia_kal.TabIndex = 2;
            // 
            // chlb_uzytkownicy
            // 
            this.chlb_uzytkownicy.CheckOnClick = true;
            this.chlb_uzytkownicy.FormattingEnabled = true;
            this.chlb_uzytkownicy.Location = new System.Drawing.Point(29, 14);
            this.chlb_uzytkownicy.Name = "chlb_uzytkownicy";
            this.chlb_uzytkownicy.Size = new System.Drawing.Size(120, 49);
            this.chlb_uzytkownicy.TabIndex = 6;
            this.chlb_uzytkownicy.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.chlb_uzytkownicy_ItemCheck);
            this.chlb_uzytkownicy.SelectedIndexChanged += new System.EventHandler(this.chlb_uzytkownicy_SelectedIndexChanged);
            // 
            // cb_rok
            // 
            this.cb_rok.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_rok.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cb_rok.FormattingEnabled = true;
            this.cb_rok.Location = new System.Drawing.Point(704, 27);
            this.cb_rok.Name = "cb_rok";
            this.cb_rok.Size = new System.Drawing.Size(121, 37);
            this.cb_rok.TabIndex = 4;
            this.cb_rok.SelectedIndexChanged += new System.EventHandler(this.cb_rok_SelectedIndexChanged);
            // 
            // cb_miesiac
            // 
            this.cb_miesiac.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_miesiac.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cb_miesiac.FormattingEnabled = true;
            this.cb_miesiac.Location = new System.Drawing.Point(837, 27);
            this.cb_miesiac.Name = "cb_miesiac";
            this.cb_miesiac.Size = new System.Drawing.Size(121, 37);
            this.cb_miesiac.TabIndex = 3;
            this.cb_miesiac.SelectedIndexChanged += new System.EventHandler(this.cb_miesiac_SelectedIndexChanged);
            // 
            // btn_poprzedni_miesiac
            // 
            this.btn_poprzedni_miesiac.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_poprzedni_miesiac.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_poprzedni_miesiac.Location = new System.Drawing.Point(976, 23);
            this.btn_poprzedni_miesiac.Name = "btn_poprzedni_miesiac";
            this.btn_poprzedni_miesiac.Size = new System.Drawing.Size(83, 42);
            this.btn_poprzedni_miesiac.TabIndex = 2;
            this.btn_poprzedni_miesiac.Text = "<";
            this.btn_poprzedni_miesiac.UseVisualStyleBackColor = true;
            this.btn_poprzedni_miesiac.Click += new System.EventHandler(this.btn_poprzedni_miesiac_Click);
            // 
            // btn_nast_miesiac
            // 
            this.btn_nast_miesiac.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_nast_miesiac.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_nast_miesiac.Location = new System.Drawing.Point(1072, 23);
            this.btn_nast_miesiac.Name = "btn_nast_miesiac";
            this.btn_nast_miesiac.Size = new System.Drawing.Size(80, 42);
            this.btn_nast_miesiac.TabIndex = 1;
            this.btn_nast_miesiac.Text = ">";
            this.btn_nast_miesiac.UseVisualStyleBackColor = true;
            this.btn_nast_miesiac.Click += new System.EventHandler(this.btn_nast_miesiac_Click);
            // 
            // tlp_kalendarz
            // 
            this.tlp_kalendarz.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlp_kalendarz.ColumnCount = 7;
            this.tlp_kalendarz.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tlp_kalendarz.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tlp_kalendarz.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tlp_kalendarz.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tlp_kalendarz.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tlp_kalendarz.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tlp_kalendarz.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tlp_kalendarz.Controls.Add(this.label7, 6, 0);
            this.tlp_kalendarz.Controls.Add(this.label6, 5, 0);
            this.tlp_kalendarz.Controls.Add(this.label5, 4, 0);
            this.tlp_kalendarz.Controls.Add(this.label4, 3, 0);
            this.tlp_kalendarz.Controls.Add(this.label3, 2, 0);
            this.tlp_kalendarz.Controls.Add(this.label2, 1, 0);
            this.tlp_kalendarz.Controls.Add(this.label1, 0, 0);
            this.tlp_kalendarz.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_kalendarz.Location = new System.Drawing.Point(3, 103);
            this.tlp_kalendarz.Name = "tlp_kalendarz";
            this.tlp_kalendarz.RowCount = 7;
            this.tlp_kalendarz.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlp_kalendarz.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlp_kalendarz.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlp_kalendarz.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlp_kalendarz.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlp_kalendarz.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlp_kalendarz.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlp_kalendarz.Size = new System.Drawing.Size(1155, 294);
            this.tlp_kalendarz.TabIndex = 0;
            this.tlp_kalendarz.Resize += new System.EventHandler(this.tlp_kalendarz_Resize);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.CadetBlue;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(987, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(165, 50);
            this.label7.TabIndex = 6;
            this.label7.Text = "Niedziela";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.CadetBlue;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(823, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(158, 50);
            this.label6.TabIndex = 5;
            this.label6.Text = "Sobota";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.CadetBlue;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(659, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 50);
            this.label5.TabIndex = 4;
            this.label5.Text = "Piątek";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.CadetBlue;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(495, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 50);
            this.label4.TabIndex = 3;
            this.label4.Text = "Czwartek";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.CadetBlue;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(331, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 50);
            this.label3.TabIndex = 2;
            this.label3.Text = "Środa";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.CadetBlue;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(167, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 50);
            this.label2.TabIndex = 1;
            this.label2.Text = "Wtorek";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.CadetBlue;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Poniedziałek";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uc_kalendarz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.tlp_głowny);
            this.MinimumSize = new System.Drawing.Size(400, 400);
            this.Name = "uc_kalendarz";
            this.Size = new System.Drawing.Size(1161, 400);
            this.Load += new System.EventHandler(this.uc_kalendarz_Load);
            this.tlp_głowny.ResumeLayout(false);
            this.tlp_głowny.PerformLayout();
            this.pn_ustawienia_kal.ResumeLayout(false);
            this.tlp_kalendarz.ResumeLayout(false);
            this.tlp_kalendarz.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlp_głowny;
        private System.Windows.Forms.TableLayoutPanel tlp_kalendarz;
        private System.Windows.Forms.Panel pn_ustawienia_kal;
        private System.Windows.Forms.Button btn_poprzedni_miesiac;
        private System.Windows.Forms.Button btn_nast_miesiac;
        private System.Windows.Forms.ComboBox cb_rok;
        private System.Windows.Forms.ComboBox cb_miesiac;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox chlb_uzytkownicy;
    }
}
