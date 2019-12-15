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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.zmieńHasłoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.anulujZmiannęToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cb_role = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonZapisz = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_imie
            // 
            this.tb_imie.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tb_imie.Location = new System.Drawing.Point(0, 4);
            this.tb_imie.Margin = new System.Windows.Forms.Padding(4);
            this.tb_imie.Name = "tb_imie";
            this.tb_imie.Size = new System.Drawing.Size(120, 27);
            this.tb_imie.TabIndex = 0;
            this.tb_imie.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_imie_KeyPress);
            // 
            // tb_nazwisko
            // 
            this.tb_nazwisko.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tb_nazwisko.Location = new System.Drawing.Point(145, 4);
            this.tb_nazwisko.Margin = new System.Windows.Forms.Padding(4);
            this.tb_nazwisko.Name = "tb_nazwisko";
            this.tb_nazwisko.Size = new System.Drawing.Size(120, 27);
            this.tb_nazwisko.TabIndex = 1;
            this.tb_nazwisko.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_nazwisko_KeyPress);
            // 
            // tb_email
            // 
            this.tb_email.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tb_email.Location = new System.Drawing.Point(296, 4);
            this.tb_email.Margin = new System.Windows.Forms.Padding(4);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(200, 27);
            this.tb_email.TabIndex = 2;
            // 
            // tb_login
            // 
            this.tb_login.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tb_login.Location = new System.Drawing.Point(523, 4);
            this.tb_login.Margin = new System.Windows.Forms.Padding(4);
            this.tb_login.Name = "tb_login";
            this.tb_login.Size = new System.Drawing.Size(156, 27);
            this.tb_login.TabIndex = 3;
            this.tb_login.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_login_KeyPress);
            // 
            // tb_haslo
            // 
            this.tb_haslo.ContextMenuStrip = this.contextMenuStrip1;
            this.tb_haslo.Enabled = false;
            this.tb_haslo.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tb_haslo.Location = new System.Drawing.Point(703, 5);
            this.tb_haslo.Margin = new System.Windows.Forms.Padding(4);
            this.tb_haslo.Name = "tb_haslo";
            this.tb_haslo.Size = new System.Drawing.Size(156, 27);
            this.tb_haslo.TabIndex = 4;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zmieńHasłoToolStripMenuItem,
            this.anulujZmiannęToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(160, 52);
            // 
            // zmieńHasłoToolStripMenuItem
            // 
            this.zmieńHasłoToolStripMenuItem.Name = "zmieńHasłoToolStripMenuItem";
            this.zmieńHasłoToolStripMenuItem.Size = new System.Drawing.Size(159, 24);
            this.zmieńHasłoToolStripMenuItem.Text = "Zmień hasło";
            this.zmieńHasłoToolStripMenuItem.Click += new System.EventHandler(this.zmieńHasłoToolStripMenuItem_Click);
            // 
            // anulujZmiannęToolStripMenuItem
            // 
            this.anulujZmiannęToolStripMenuItem.Name = "anulujZmiannęToolStripMenuItem";
            this.anulujZmiannęToolStripMenuItem.Size = new System.Drawing.Size(159, 24);
            this.anulujZmiannęToolStripMenuItem.Text = "Anuluj";
            this.anulujZmiannęToolStripMenuItem.Click += new System.EventHandler(this.anulujZmiannęToolStripMenuItem_Click);
            // 
            // cb_role
            // 
            this.cb_role.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cb_role.FormattingEnabled = true;
            this.cb_role.Location = new System.Drawing.Point(883, 5);
            this.cb_role.Margin = new System.Windows.Forms.Padding(4);
            this.cb_role.Name = "cb_role";
            this.cb_role.Size = new System.Drawing.Size(241, 27);
            this.cb_role.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(1274, 6);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 28);
            this.button1.TabIndex = 7;
            this.button1.Text = "Usuń";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonZapisz
            // 
            this.buttonZapisz.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonZapisz.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonZapisz.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonZapisz.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonZapisz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonZapisz.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonZapisz.Location = new System.Drawing.Point(1155, 6);
            this.buttonZapisz.Margin = new System.Windows.Forms.Padding(4);
            this.buttonZapisz.Name = "buttonZapisz";
            this.buttonZapisz.Size = new System.Drawing.Size(101, 28);
            this.buttonZapisz.TabIndex = 9;
            this.buttonZapisz.Text = "Zapisz";
            this.buttonZapisz.UseVisualStyleBackColor = true;
            this.buttonZapisz.Click += new System.EventHandler(this.buttonZapisz_Click);
            // 
            // uc_uzytkownik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.buttonZapisz);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cb_role);
            this.Controls.Add(this.tb_haslo);
            this.Controls.Add(this.tb_login);
            this.Controls.Add(this.tb_email);
            this.Controls.Add(this.tb_nazwisko);
            this.Controls.Add(this.tb_imie);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "uc_uzytkownik";
            this.Size = new System.Drawing.Size(1577, 34);
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
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem zmieńHasłoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem anulujZmiannęToolStripMenuItem;
        private System.Windows.Forms.Button buttonZapisz;
    }
}
