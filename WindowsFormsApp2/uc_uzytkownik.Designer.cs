namespace WindowsFormsApp2
{
    partial class uc_uzytkownik
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
            this.tb_imie = new System.Windows.Forms.TextBox();
            this.tb_nazwisko = new System.Windows.Forms.TextBox();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.tb_login = new System.Windows.Forms.TextBox();
            this.tb_haslo = new System.Windows.Forms.TextBox();
            this.cb_role = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.nm_majatek = new System.Windows.Forms.NumericUpDown();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.zmieńHasłoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.anulujZmiannęToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.nm_majatek)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_imie
            // 
            this.tb_imie.Location = new System.Drawing.Point(12, 3);
            this.tb_imie.Name = "tb_imie";
            this.tb_imie.Size = new System.Drawing.Size(91, 20);
            this.tb_imie.TabIndex = 0;
            // 
            // tb_nazwisko
            // 
            this.tb_nazwisko.Location = new System.Drawing.Point(123, 3);
            this.tb_nazwisko.Name = "tb_nazwisko";
            this.tb_nazwisko.Size = new System.Drawing.Size(91, 20);
            this.tb_nazwisko.TabIndex = 1;
            // 
            // tb_email
            // 
            this.tb_email.Location = new System.Drawing.Point(234, 3);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(151, 20);
            this.tb_email.TabIndex = 2;
            // 
            // tb_login
            // 
            this.tb_login.Location = new System.Drawing.Point(405, 3);
            this.tb_login.Name = "tb_login";
            this.tb_login.Size = new System.Drawing.Size(118, 20);
            this.tb_login.TabIndex = 3;
            // 
            // tb_haslo
            // 
            this.tb_haslo.ContextMenuStrip = this.contextMenuStrip1;
            this.tb_haslo.Enabled = false;
            this.tb_haslo.Location = new System.Drawing.Point(543, 3);
            this.tb_haslo.Name = "tb_haslo";
            this.tb_haslo.Size = new System.Drawing.Size(118, 20);
            this.tb_haslo.TabIndex = 4;
            // 
            // cb_role
            // 
            this.cb_role.FormattingEnabled = true;
            this.cb_role.Location = new System.Drawing.Point(839, 2);
            this.cb_role.Name = "cb_role";
            this.cb_role.Size = new System.Drawing.Size(182, 21);
            this.cb_role.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(1041, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 20);
            this.button1.TabIndex = 7;
            this.button1.Text = "Usuń użytkownika";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // nm_majatek
            // 
            this.nm_majatek.Location = new System.Drawing.Point(681, 2);
            this.nm_majatek.Name = "nm_majatek";
            this.nm_majatek.Size = new System.Drawing.Size(138, 20);
            this.nm_majatek.TabIndex = 8;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zmieńHasłoToolStripMenuItem,
            this.anulujZmiannęToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(140, 48);
            // 
            // zmieńHasłoToolStripMenuItem
            // 
            this.zmieńHasłoToolStripMenuItem.Name = "zmieńHasłoToolStripMenuItem";
            this.zmieńHasłoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.zmieńHasłoToolStripMenuItem.Text = "Zmień hasło";
            this.zmieńHasłoToolStripMenuItem.Click += new System.EventHandler(this.zmieńHasłoToolStripMenuItem_Click);
            // 
            // anulujZmiannęToolStripMenuItem
            // 
            this.anulujZmiannęToolStripMenuItem.Name = "anulujZmiannęToolStripMenuItem";
            this.anulujZmiannęToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.anulujZmiannęToolStripMenuItem.Text = "Anuluj";
            this.anulujZmiannęToolStripMenuItem.Click += new System.EventHandler(this.anulujZmiannęToolStripMenuItem_Click);
            // 
            // uc_uzytkownik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.nm_majatek);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cb_role);
            this.Controls.Add(this.tb_haslo);
            this.Controls.Add(this.tb_login);
            this.Controls.Add(this.tb_email);
            this.Controls.Add(this.tb_nazwisko);
            this.Controls.Add(this.tb_imie);
            this.Name = "uc_uzytkownik";
            this.Size = new System.Drawing.Size(1183, 28);
            ((System.ComponentModel.ISupportInitialize)(this.nm_majatek)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_imie;
        private System.Windows.Forms.TextBox tb_nazwisko;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.TextBox tb_login;
        private System.Windows.Forms.TextBox tb_haslo;
        private System.Windows.Forms.ComboBox cb_role;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown nm_majatek;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem zmieńHasłoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem anulujZmiannęToolStripMenuItem;
    }
}
