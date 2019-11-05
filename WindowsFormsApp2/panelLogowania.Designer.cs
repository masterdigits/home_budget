namespace WindowsFormsApp2
{
    partial class panelLogowania
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

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(panelLogowania));
            this.groupBoxRejestracja = new System.Windows.Forms.GroupBox();
            this.buttonPowrot = new System.Windows.Forms.Button();
            this.labelMajatek = new System.Windows.Forms.Label();
            this.labelNazwisko = new System.Windows.Forms.Label();
            this.labelImie = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.textBoxMajatek = new System.Windows.Forms.TextBox();
            this.textBoxNazwisko = new System.Windows.Forms.TextBox();
            this.textBoxImie = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.labelHaslo = new System.Windows.Forms.Label();
            this.labelLogin = new System.Windows.Forms.Label();
            this.buttonRejestracja = new System.Windows.Forms.Button();
            this.textBoxHaslo = new System.Windows.Forms.TextBox();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.linkLabelRejestracja = new System.Windows.Forms.LinkLabel();
            this.linkLabelZapomnialem = new System.Windows.Forms.LinkLabel();
            this.groupBoxLogin = new System.Windows.Forms.GroupBox();
            this.buttonZaloguj = new System.Windows.Forms.Button();
            this.textBoxHaslo1 = new System.Windows.Forms.TextBox();
            this.labelHaslo1 = new System.Windows.Forms.Label();
            this.textBoxLogin1 = new System.Windows.Forms.TextBox();
            this.labelLogin1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBoxRejestracja.SuspendLayout();
            this.groupBoxLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxRejestracja
            // 
            this.groupBoxRejestracja.AutoSize = true;
            this.groupBoxRejestracja.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBoxRejestracja.Controls.Add(this.buttonPowrot);
            this.groupBoxRejestracja.Controls.Add(this.labelMajatek);
            this.groupBoxRejestracja.Controls.Add(this.labelNazwisko);
            this.groupBoxRejestracja.Controls.Add(this.labelImie);
            this.groupBoxRejestracja.Controls.Add(this.labelEmail);
            this.groupBoxRejestracja.Controls.Add(this.textBoxMajatek);
            this.groupBoxRejestracja.Controls.Add(this.textBoxNazwisko);
            this.groupBoxRejestracja.Controls.Add(this.textBoxImie);
            this.groupBoxRejestracja.Controls.Add(this.textBoxEmail);
            this.groupBoxRejestracja.Controls.Add(this.labelHaslo);
            this.groupBoxRejestracja.Controls.Add(this.labelLogin);
            this.groupBoxRejestracja.Controls.Add(this.buttonRejestracja);
            this.groupBoxRejestracja.Controls.Add(this.textBoxHaslo);
            this.groupBoxRejestracja.Controls.Add(this.textBoxLogin);
            this.groupBoxRejestracja.Location = new System.Drawing.Point(512, 91);
            this.groupBoxRejestracja.Name = "groupBoxRejestracja";
            this.groupBoxRejestracja.Size = new System.Drawing.Size(403, 500);
            this.groupBoxRejestracja.TabIndex = 0;
            this.groupBoxRejestracja.TabStop = false;
            // 
            // buttonPowrot
            // 
            this.buttonPowrot.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonPowrot.Location = new System.Drawing.Point(192, 440);
            this.buttonPowrot.Name = "buttonPowrot";
            this.buttonPowrot.Size = new System.Drawing.Size(100, 35);
            this.buttonPowrot.TabIndex = 15;
            this.buttonPowrot.Text = "Powrót";
            this.buttonPowrot.UseVisualStyleBackColor = true;
            this.buttonPowrot.Click += new System.EventHandler(this.button_back_Click);
            // 
            // labelMajatek
            // 
            this.labelMajatek.AutoSize = true;
            this.labelMajatek.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelMajatek.ForeColor = System.Drawing.SystemColors.Control;
            this.labelMajatek.Location = new System.Drawing.Point(31, 363);
            this.labelMajatek.Name = "labelMajatek";
            this.labelMajatek.Size = new System.Drawing.Size(99, 29);
            this.labelMajatek.TabIndex = 14;
            this.labelMajatek.Text = "Majątek";
            // 
            // labelNazwisko
            // 
            this.labelNazwisko.AutoSize = true;
            this.labelNazwisko.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelNazwisko.ForeColor = System.Drawing.SystemColors.Control;
            this.labelNazwisko.Location = new System.Drawing.Point(31, 294);
            this.labelNazwisko.Name = "labelNazwisko";
            this.labelNazwisko.Size = new System.Drawing.Size(115, 29);
            this.labelNazwisko.TabIndex = 13;
            this.labelNazwisko.Text = "Nazwisko";
            // 
            // labelImie
            // 
            this.labelImie.AutoSize = true;
            this.labelImie.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelImie.ForeColor = System.Drawing.SystemColors.Control;
            this.labelImie.Location = new System.Drawing.Point(31, 225);
            this.labelImie.Name = "labelImie";
            this.labelImie.Size = new System.Drawing.Size(62, 29);
            this.labelImie.TabIndex = 12;
            this.labelImie.Text = "Imie";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelEmail.ForeColor = System.Drawing.SystemColors.Control;
            this.labelEmail.Location = new System.Drawing.Point(31, 156);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(85, 29);
            this.labelEmail.TabIndex = 11;
            this.labelEmail.Text = "E-mail";
            // 
            // textBoxMajatek
            // 
            this.textBoxMajatek.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxMajatek.Location = new System.Drawing.Point(36, 395);
            this.textBoxMajatek.Name = "textBoxMajatek";
            this.textBoxMajatek.Size = new System.Drawing.Size(273, 34);
            this.textBoxMajatek.TabIndex = 10;
            // 
            // textBoxNazwisko
            // 
            this.textBoxNazwisko.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxNazwisko.Location = new System.Drawing.Point(36, 326);
            this.textBoxNazwisko.Name = "textBoxNazwisko";
            this.textBoxNazwisko.Size = new System.Drawing.Size(273, 34);
            this.textBoxNazwisko.TabIndex = 9;
            // 
            // textBoxImie
            // 
            this.textBoxImie.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxImie.Location = new System.Drawing.Point(36, 257);
            this.textBoxImie.Name = "textBoxImie";
            this.textBoxImie.Size = new System.Drawing.Size(273, 34);
            this.textBoxImie.TabIndex = 8;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxEmail.Location = new System.Drawing.Point(36, 188);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(273, 34);
            this.textBoxEmail.TabIndex = 7;
            // 
            // labelHaslo
            // 
            this.labelHaslo.AutoSize = true;
            this.labelHaslo.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelHaslo.ForeColor = System.Drawing.SystemColors.Control;
            this.labelHaslo.Location = new System.Drawing.Point(31, 87);
            this.labelHaslo.Name = "labelHaslo";
            this.labelHaslo.Size = new System.Drawing.Size(75, 29);
            this.labelHaslo.TabIndex = 4;
            this.labelHaslo.Text = "Hasło";
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelLogin.ForeColor = System.Drawing.SystemColors.Control;
            this.labelLogin.Location = new System.Drawing.Point(31, 18);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(73, 29);
            this.labelLogin.TabIndex = 3;
            this.labelLogin.Text = "Login";
            // 
            // buttonRejestracja
            // 
            this.buttonRejestracja.BackColor = System.Drawing.SystemColors.Control;
            this.buttonRejestracja.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonRejestracja.Location = new System.Drawing.Point(36, 440);
            this.buttonRejestracja.Name = "buttonRejestracja";
            this.buttonRejestracja.Size = new System.Drawing.Size(150, 35);
            this.buttonRejestracja.TabIndex = 2;
            this.buttonRejestracja.Text = "Zarejestruj";
            this.buttonRejestracja.UseVisualStyleBackColor = false;
            this.buttonRejestracja.Click += new System.EventHandler(this.buttonRejestracja_Click);
            // 
            // textBoxHaslo
            // 
            this.textBoxHaslo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxHaslo.Location = new System.Drawing.Point(36, 119);
            this.textBoxHaslo.Name = "textBoxHaslo";
            this.textBoxHaslo.PasswordChar = '*';
            this.textBoxHaslo.Size = new System.Drawing.Size(273, 34);
            this.textBoxHaslo.TabIndex = 1;
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxLogin.Location = new System.Drawing.Point(36, 50);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(273, 34);
            this.textBoxLogin.TabIndex = 0;
            // 
            // linkLabelRejestracja
            // 
            this.linkLabelRejestracja.ActiveLinkColor = System.Drawing.Color.Blue;
            this.linkLabelRejestracja.AutoSize = true;
            this.linkLabelRejestracja.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.linkLabelRejestracja.LinkColor = System.Drawing.Color.White;
            this.linkLabelRejestracja.Location = new System.Drawing.Point(28, 227);
            this.linkLabelRejestracja.Name = "linkLabelRejestracja";
            this.linkLabelRejestracja.Size = new System.Drawing.Size(115, 20);
            this.linkLabelRejestracja.TabIndex = 6;
            this.linkLabelRejestracja.TabStop = true;
            this.linkLabelRejestracja.Text = "Zarejestruj się";
            this.linkLabelRejestracja.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_register_LinkClicked);
            // 
            // linkLabelZapomnialem
            // 
            this.linkLabelZapomnialem.ActiveLinkColor = System.Drawing.Color.Blue;
            this.linkLabelZapomnialem.AutoSize = true;
            this.linkLabelZapomnialem.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.linkLabelZapomnialem.LinkColor = System.Drawing.Color.White;
            this.linkLabelZapomnialem.Location = new System.Drawing.Point(28, 197);
            this.linkLabelZapomnialem.Name = "linkLabelZapomnialem";
            this.linkLabelZapomnialem.Size = new System.Drawing.Size(158, 20);
            this.linkLabelZapomnialem.TabIndex = 5;
            this.linkLabelZapomnialem.TabStop = true;
            this.linkLabelZapomnialem.Text = "Zapomniałem hasło";
            // 
            // groupBoxLogin
            // 
            this.groupBoxLogin.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBoxLogin.Controls.Add(this.buttonZaloguj);
            this.groupBoxLogin.Controls.Add(this.linkLabelRejestracja);
            this.groupBoxLogin.Controls.Add(this.linkLabelZapomnialem);
            this.groupBoxLogin.Controls.Add(this.textBoxHaslo1);
            this.groupBoxLogin.Controls.Add(this.labelHaslo1);
            this.groupBoxLogin.Controls.Add(this.textBoxLogin1);
            this.groupBoxLogin.Controls.Add(this.labelLogin1);
            this.groupBoxLogin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBoxLogin.Location = new System.Drawing.Point(27, 91);
            this.groupBoxLogin.Name = "groupBoxLogin";
            this.groupBoxLogin.Size = new System.Drawing.Size(400, 280);
            this.groupBoxLogin.TabIndex = 16;
            this.groupBoxLogin.TabStop = false;
            // 
            // buttonZaloguj
            // 
            this.buttonZaloguj.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonZaloguj.Location = new System.Drawing.Point(28, 159);
            this.buttonZaloguj.Name = "buttonZaloguj";
            this.buttonZaloguj.Size = new System.Drawing.Size(100, 35);
            this.buttonZaloguj.TabIndex = 4;
            this.buttonZaloguj.Text = "Zaloguj";
            this.buttonZaloguj.UseVisualStyleBackColor = true;
            this.buttonZaloguj.Click += new System.EventHandler(this.buttonZaloguj_Click);
            // 
            // textBoxHaslo1
            // 
            this.textBoxHaslo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxHaslo1.Location = new System.Drawing.Point(28, 119);
            this.textBoxHaslo1.Name = "textBoxHaslo1";
            this.textBoxHaslo1.PasswordChar = '*';
            this.textBoxHaslo1.Size = new System.Drawing.Size(273, 34);
            this.textBoxHaslo1.TabIndex = 3;
            // 
            // labelHaslo1
            // 
            this.labelHaslo1.AutoSize = true;
            this.labelHaslo1.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelHaslo1.ForeColor = System.Drawing.SystemColors.Control;
            this.labelHaslo1.Location = new System.Drawing.Point(27, 87);
            this.labelHaslo1.Name = "labelHaslo1";
            this.labelHaslo1.Size = new System.Drawing.Size(75, 29);
            this.labelHaslo1.TabIndex = 2;
            this.labelHaslo1.Text = "Hasło";
            // 
            // textBoxLogin1
            // 
            this.textBoxLogin1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxLogin1.Location = new System.Drawing.Point(28, 50);
            this.textBoxLogin1.Name = "textBoxLogin1";
            this.textBoxLogin1.Size = new System.Drawing.Size(273, 34);
            this.textBoxLogin1.TabIndex = 1;
            // 
            // labelLogin1
            // 
            this.labelLogin1.AutoSize = true;
            this.labelLogin1.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelLogin1.ForeColor = System.Drawing.SystemColors.Control;
            this.labelLogin1.Location = new System.Drawing.Point(27, 18);
            this.labelLogin1.Name = "labelLogin1";
            this.labelLogin1.Size = new System.Drawing.Size(73, 29);
            this.labelLogin1.TabIndex = 0;
            this.labelLogin1.Text = "Login";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(196, 472);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(179, 70);
            this.button1.TabIndex = 17;
            this.button1.Text = "Klik";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelLogowania
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1000, 778);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBoxLogin);
            this.Controls.Add(this.groupBoxRejestracja);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "panelLogowania";
            this.Text = "Zaloguj sie";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.groupBoxRejestracja.ResumeLayout(false);
            this.groupBoxRejestracja.PerformLayout();
            this.groupBoxLogin.ResumeLayout(false);
            this.groupBoxLogin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxRejestracja;
        private System.Windows.Forms.Label labelHaslo;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Button buttonRejestracja;
        private System.Windows.Forms.TextBox textBoxHaslo;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.LinkLabel linkLabelZapomnialem;
        private System.Windows.Forms.LinkLabel linkLabelRejestracja;
        private System.Windows.Forms.TextBox textBoxImie;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label labelMajatek;
        private System.Windows.Forms.Label labelNazwisko;
        private System.Windows.Forms.Label labelImie;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox textBoxMajatek;
        private System.Windows.Forms.TextBox textBoxNazwisko;
        private System.Windows.Forms.Button buttonPowrot;
        private System.Windows.Forms.GroupBox groupBoxLogin;
        private System.Windows.Forms.Button buttonZaloguj;
        private System.Windows.Forms.TextBox textBoxHaslo1;
        private System.Windows.Forms.Label labelHaslo1;
        private System.Windows.Forms.TextBox textBoxLogin1;
        private System.Windows.Forms.Label labelLogin1;
        private System.Windows.Forms.Button button1;
    }
}

