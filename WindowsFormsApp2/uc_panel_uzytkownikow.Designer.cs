namespace WindowsFormsApp2
{
    partial class uc_panel_uzytkownikow
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureRolaUżytkownika = new System.Windows.Forms.PictureBox();
            this.pictureHasło = new System.Windows.Forms.PictureBox();
            this.pictureLogin = new System.Windows.Forms.PictureBox();
            this.pictureEmail = new System.Windows.Forms.PictureBox();
            this.pictureNazwisko = new System.Windows.Forms.PictureBox();
            this.pictureImię = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Nazwisko = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelImię = new System.Windows.Forms.Label();
            this.buttonDodaj = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureRolaUżytkownika)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureHasło)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureNazwisko)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureImię)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1577, 985);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.Color.SandyBrown;
            this.panel1.Controls.Add(this.pictureRolaUżytkownika);
            this.panel1.Controls.Add(this.pictureHasło);
            this.panel1.Controls.Add(this.pictureLogin);
            this.panel1.Controls.Add(this.pictureEmail);
            this.panel1.Controls.Add(this.pictureNazwisko);
            this.panel1.Controls.Add(this.pictureImię);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.Nazwisko);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.labelImię);
            this.panel1.Controls.Add(this.buttonDodaj);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1569, 54);
            this.panel1.TabIndex = 0;
            // 
            // pictureRolaUżytkownika
            // 
            this.pictureRolaUżytkownika.Image = global::WindowsFormsApp2.Properties.Resources.FAVPNG_question_mark_icon_wallpaper_v5jBEb5G;
            this.pictureRolaUżytkownika.Location = new System.Drawing.Point(1082, 19);
            this.pictureRolaUżytkownika.Name = "pictureRolaUżytkownika";
            this.pictureRolaUżytkownika.Size = new System.Drawing.Size(21, 20);
            this.pictureRolaUżytkownika.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureRolaUżytkownika.TabIndex = 30;
            this.pictureRolaUżytkownika.TabStop = false;
            // 
            // pictureHasło
            // 
            this.pictureHasło.Image = global::WindowsFormsApp2.Properties.Resources.FAVPNG_question_mark_icon_wallpaper_v5jBEb5G;
            this.pictureHasło.Location = new System.Drawing.Point(806, 19);
            this.pictureHasło.Name = "pictureHasło";
            this.pictureHasło.Size = new System.Drawing.Size(21, 20);
            this.pictureHasło.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureHasło.TabIndex = 28;
            this.pictureHasło.TabStop = false;
            this.pictureHasło.Click += new System.EventHandler(this.pictureHasło_Click);
            // 
            // pictureLogin
            // 
            this.pictureLogin.Image = global::WindowsFormsApp2.Properties.Resources.FAVPNG_question_mark_icon_wallpaper_v5jBEb5G;
            this.pictureLogin.Location = new System.Drawing.Point(622, 19);
            this.pictureLogin.Name = "pictureLogin";
            this.pictureLogin.Size = new System.Drawing.Size(21, 20);
            this.pictureLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureLogin.TabIndex = 27;
            this.pictureLogin.TabStop = false;
            this.pictureLogin.Click += new System.EventHandler(this.pictureLogin_Click);
            // 
            // pictureEmail
            // 
            this.pictureEmail.Image = global::WindowsFormsApp2.Properties.Resources.FAVPNG_question_mark_icon_wallpaper_v5jBEb5G;
            this.pictureEmail.Location = new System.Drawing.Point(422, 19);
            this.pictureEmail.Name = "pictureEmail";
            this.pictureEmail.Size = new System.Drawing.Size(21, 20);
            this.pictureEmail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureEmail.TabIndex = 26;
            this.pictureEmail.TabStop = false;
            this.pictureEmail.Click += new System.EventHandler(this.pictureEmail_Click);
            // 
            // pictureNazwisko
            // 
            this.pictureNazwisko.Image = global::WindowsFormsApp2.Properties.Resources.FAVPNG_question_mark_icon_wallpaper_v5jBEb5G;
            this.pictureNazwisko.Location = new System.Drawing.Point(255, 19);
            this.pictureNazwisko.Name = "pictureNazwisko";
            this.pictureNazwisko.Size = new System.Drawing.Size(21, 20);
            this.pictureNazwisko.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureNazwisko.TabIndex = 25;
            this.pictureNazwisko.TabStop = false;
            this.pictureNazwisko.Click += new System.EventHandler(this.pictureNazwisko_Click);
            // 
            // pictureImię
            // 
            this.pictureImię.Image = global::WindowsFormsApp2.Properties.Resources.FAVPNG_question_mark_icon_wallpaper_v5jBEb5G;
            this.pictureImię.Location = new System.Drawing.Point(81, 19);
            this.pictureImię.Name = "pictureImię";
            this.pictureImię.Size = new System.Drawing.Size(21, 20);
            this.pictureImię.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureImię.TabIndex = 24;
            this.pictureImię.TabStop = false;
            this.pictureImię.Click += new System.EventHandler(this.pictureImię_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(913, 19);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(162, 23);
            this.label7.TabIndex = 23;
            this.label7.Text = "Rola użytkownika";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(552, 19);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 23);
            this.label5.TabIndex = 21;
            this.label5.Text = "Login";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(340, 19);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 23);
            this.label4.TabIndex = 20;
            this.label4.Text = "E-mail";
            // 
            // Nazwisko
            // 
            this.Nazwisko.AutoSize = true;
            this.Nazwisko.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Nazwisko.Location = new System.Drawing.Point(153, 19);
            this.Nazwisko.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Nazwisko.Name = "Nazwisko";
            this.Nazwisko.Size = new System.Drawing.Size(93, 23);
            this.Nazwisko.TabIndex = 19;
            this.Nazwisko.Text = "Nazwisko";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(732, 19);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 23);
            this.label2.TabIndex = 18;
            this.label2.Text = "Hasło";
            // 
            // labelImię
            // 
            this.labelImię.AutoSize = true;
            this.labelImię.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelImię.Location = new System.Drawing.Point(30, 19);
            this.labelImię.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelImię.Name = "labelImię";
            this.labelImię.Size = new System.Drawing.Size(47, 23);
            this.labelImię.TabIndex = 17;
            this.labelImię.Text = "Imię";
            // 
            // buttonDodaj
            // 
            this.buttonDodaj.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDodaj.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonDodaj.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.buttonDodaj.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.buttonDodaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDodaj.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonDodaj.Location = new System.Drawing.Point(1150, 11);
            this.buttonDodaj.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDodaj.Name = "buttonDodaj";
            this.buttonDodaj.Size = new System.Drawing.Size(205, 38);
            this.buttonDodaj.TabIndex = 15;
            this.buttonDodaj.Text = "Dodaj użytkownika";
            this.buttonDodaj.UseVisualStyleBackColor = true;
            this.buttonDodaj.Click += new System.EventHandler(this.button1_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(4, 66);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1569, 915);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // uc_panel_uzytkownikow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "uc_panel_uzytkownikow";
            this.Size = new System.Drawing.Size(1577, 985);
            this.Load += new System.EventHandler(this.uc_panel_uzytkownikow_Load);
            this.VisibleChanged += new System.EventHandler(this.uc_panel_uzytkownikow_VisibleChanged);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureRolaUżytkownika)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureHasło)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureNazwisko)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureImię)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Nazwisko;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelImię;
        private System.Windows.Forms.Button buttonDodaj;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureImię;
        private System.Windows.Forms.PictureBox pictureNazwisko;
        private System.Windows.Forms.PictureBox pictureEmail;
        private System.Windows.Forms.PictureBox pictureLogin;
        private System.Windows.Forms.PictureBox pictureHasło;
        private System.Windows.Forms.PictureBox pictureRolaUżytkownika;
    }
}
