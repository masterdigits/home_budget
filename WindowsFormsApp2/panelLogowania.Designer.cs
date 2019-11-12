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
            this.linkLabelZapomnialem = new System.Windows.Forms.LinkLabel();
            this.groupBoxLogin = new System.Windows.Forms.GroupBox();
            this.buttonZaloguj = new System.Windows.Forms.Button();
            this.textBoxHaslo1 = new System.Windows.Forms.TextBox();
            this.labelHaslo1 = new System.Windows.Forms.Label();
            this.textBoxLogin1 = new System.Windows.Forms.TextBox();
            this.labelLogin1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBoxLogin.SuspendLayout();
            this.SuspendLayout();
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
            this.groupBoxLogin.Controls.Add(this.linkLabelZapomnialem);
            this.groupBoxLogin.Controls.Add(this.textBoxHaslo1);
            this.groupBoxLogin.Controls.Add(this.labelHaslo1);
            this.groupBoxLogin.Controls.Add(this.textBoxLogin1);
            this.groupBoxLogin.Controls.Add(this.labelLogin1);
            this.groupBoxLogin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBoxLogin.Location = new System.Drawing.Point(27, 91);
            this.groupBoxLogin.Name = "groupBoxLogin";
            this.groupBoxLogin.Size = new System.Drawing.Size(400, 238);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "panelLogowania";
            this.Text = "Zaloguj sie";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.groupBoxLogin.ResumeLayout(false);
            this.groupBoxLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.LinkLabel linkLabelZapomnialem;
        private System.Windows.Forms.GroupBox groupBoxLogin;
        private System.Windows.Forms.Button buttonZaloguj;
        private System.Windows.Forms.TextBox textBoxHaslo1;
        private System.Windows.Forms.Label labelHaslo1;
        private System.Windows.Forms.TextBox textBoxLogin1;
        private System.Windows.Forms.Label labelLogin1;
        private System.Windows.Forms.Button button1;
    }
}

