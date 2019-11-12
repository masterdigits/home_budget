namespace WindowsFormsApp2
{
    partial class AdminPanel
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
            this.groupBoxButton = new System.Windows.Forms.GroupBox();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.groupBoxAdd = new System.Windows.Forms.GroupBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.numericUpDownMajątek = new System.Windows.Forms.NumericUpDown();
            this.labelMajątek = new System.Windows.Forms.Label();
            this.textBoxHasło = new System.Windows.Forms.TextBox();
            this.labelHasło = new System.Windows.Forms.Label();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.labelLogin = new System.Windows.Forms.Label();
            this.groupBoxEdit = new System.Windows.Forms.GroupBox();
            this.labelUsers = new System.Windows.Forms.Label();
            this.buttonAcept = new System.Windows.Forms.Button();
            this.Users = new System.Windows.Forms.ListBox();
            this.radioButtonAdmin = new System.Windows.Forms.RadioButton();
            this.radioButtonMod = new System.Windows.Forms.RadioButton();
            this.radioButtonUser = new System.Windows.Forms.RadioButton();
            this.radioButtonObser = new System.Windows.Forms.RadioButton();
            this.buttonAcept2 = new System.Windows.Forms.Button();
            this.groupBoxButton.SuspendLayout();
            this.groupBoxAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMajątek)).BeginInit();
            this.groupBoxEdit.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxButton
            // 
            this.groupBoxButton.Controls.Add(this.buttonEdit);
            this.groupBoxButton.Controls.Add(this.buttonAdd);
            this.groupBoxButton.Location = new System.Drawing.Point(3, 3);
            this.groupBoxButton.Name = "groupBoxButton";
            this.groupBoxButton.Size = new System.Drawing.Size(385, 85);
            this.groupBoxButton.TabIndex = 0;
            this.groupBoxButton.TabStop = false;
            // 
            // buttonEdit
            // 
            this.buttonEdit.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonEdit.Location = new System.Drawing.Point(194, 10);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(180, 69);
            this.buttonEdit.TabIndex = 1;
            this.buttonEdit.Text = "Zmień uprawnienia";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonAdd.Location = new System.Drawing.Point(7, 10);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(180, 69);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "Dodaj użytkownika";
            this.buttonAdd.UseVisualStyleBackColor = true;
            // 
            // groupBoxAdd
            // 
            this.groupBoxAdd.Controls.Add(this.buttonAcept);
            this.groupBoxAdd.Controls.Add(this.textBoxEmail);
            this.groupBoxAdd.Controls.Add(this.labelEmail);
            this.groupBoxAdd.Controls.Add(this.numericUpDownMajątek);
            this.groupBoxAdd.Controls.Add(this.labelMajątek);
            this.groupBoxAdd.Controls.Add(this.textBoxHasło);
            this.groupBoxAdd.Controls.Add(this.labelHasło);
            this.groupBoxAdd.Controls.Add(this.textBoxLogin);
            this.groupBoxAdd.Controls.Add(this.labelLogin);
            this.groupBoxAdd.Location = new System.Drawing.Point(4, 95);
            this.groupBoxAdd.Name = "groupBoxAdd";
            this.groupBoxAdd.Size = new System.Drawing.Size(384, 382);
            this.groupBoxAdd.TabIndex = 1;
            this.groupBoxAdd.TabStop = false;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxEmail.Location = new System.Drawing.Point(12, 193);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(361, 34);
            this.textBoxEmail.TabIndex = 8;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelEmail.Location = new System.Drawing.Point(7, 161);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(85, 29);
            this.labelEmail.TabIndex = 7;
            this.labelEmail.Text = "E-mail";
            // 
            // numericUpDownMajątek
            // 
            this.numericUpDownMajątek.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numericUpDownMajątek.Location = new System.Drawing.Point(12, 262);
            this.numericUpDownMajątek.Name = "numericUpDownMajątek";
            this.numericUpDownMajątek.Size = new System.Drawing.Size(361, 34);
            this.numericUpDownMajątek.TabIndex = 6;
            // 
            // labelMajątek
            // 
            this.labelMajątek.AutoSize = true;
            this.labelMajątek.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelMajątek.Location = new System.Drawing.Point(7, 230);
            this.labelMajątek.Name = "labelMajątek";
            this.labelMajątek.Size = new System.Drawing.Size(99, 29);
            this.labelMajątek.TabIndex = 4;
            this.labelMajątek.Text = "Majątek";
            // 
            // textBoxHasło
            // 
            this.textBoxHasło.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxHasło.Location = new System.Drawing.Point(12, 124);
            this.textBoxHasło.Name = "textBoxHasło";
            this.textBoxHasło.Size = new System.Drawing.Size(361, 34);
            this.textBoxHasło.TabIndex = 3;
            // 
            // labelHasło
            // 
            this.labelHasło.AutoSize = true;
            this.labelHasło.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelHasło.Location = new System.Drawing.Point(7, 92);
            this.labelHasło.Name = "labelHasło";
            this.labelHasło.Size = new System.Drawing.Size(75, 29);
            this.labelHasło.TabIndex = 2;
            this.labelHasło.Text = "Hasło";
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxLogin.Location = new System.Drawing.Point(12, 55);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(361, 34);
            this.textBoxLogin.TabIndex = 1;
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelLogin.Location = new System.Drawing.Point(7, 22);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(73, 29);
            this.labelLogin.TabIndex = 0;
            this.labelLogin.Text = "Login";
            // 
            // groupBoxEdit
            // 
            this.groupBoxEdit.Controls.Add(this.buttonAcept2);
            this.groupBoxEdit.Controls.Add(this.radioButtonObser);
            this.groupBoxEdit.Controls.Add(this.radioButtonUser);
            this.groupBoxEdit.Controls.Add(this.radioButtonMod);
            this.groupBoxEdit.Controls.Add(this.radioButtonAdmin);
            this.groupBoxEdit.Controls.Add(this.labelUsers);
            this.groupBoxEdit.Controls.Add(this.Users);
            this.groupBoxEdit.Location = new System.Drawing.Point(394, 95);
            this.groupBoxEdit.Name = "groupBoxEdit";
            this.groupBoxEdit.Size = new System.Drawing.Size(384, 334);
            this.groupBoxEdit.TabIndex = 2;
            this.groupBoxEdit.TabStop = false;
            // 
            // labelUsers
            // 
            this.labelUsers.AutoSize = true;
            this.labelUsers.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelUsers.Location = new System.Drawing.Point(6, 18);
            this.labelUsers.Name = "labelUsers";
            this.labelUsers.Size = new System.Drawing.Size(242, 29);
            this.labelUsers.TabIndex = 1;
            this.labelUsers.Text = "Wybierz użytkownika";
            // 
            // buttonAcept
            // 
            this.buttonAcept.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonAcept.Location = new System.Drawing.Point(11, 307);
            this.buttonAcept.Name = "buttonAcept";
            this.buttonAcept.Size = new System.Drawing.Size(180, 69);
            this.buttonAcept.TabIndex = 3;
            this.buttonAcept.Text = "Zatwierdź";
            this.buttonAcept.UseVisualStyleBackColor = true;
            // 
            // Users
            // 
            this.Users.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Users.FormattingEnabled = true;
            this.Users.ItemHeight = 29;
            this.Users.Items.AddRange(new object[] {
            "User1",
            "User2",
            "User3"});
            this.Users.Location = new System.Drawing.Point(11, 50);
            this.Users.Name = "Users";
            this.Users.Size = new System.Drawing.Size(367, 33);
            this.Users.TabIndex = 0;
            // 
            // radioButtonAdmin
            // 
            this.radioButtonAdmin.AutoSize = true;
            this.radioButtonAdmin.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioButtonAdmin.Location = new System.Drawing.Point(12, 96);
            this.radioButtonAdmin.Name = "radioButtonAdmin";
            this.radioButtonAdmin.Size = new System.Drawing.Size(184, 33);
            this.radioButtonAdmin.TabIndex = 2;
            this.radioButtonAdmin.TabStop = true;
            this.radioButtonAdmin.Text = "Administrator";
            this.radioButtonAdmin.UseVisualStyleBackColor = true;
            // 
            // radioButtonMod
            // 
            this.radioButtonMod.AutoSize = true;
            this.radioButtonMod.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioButtonMod.Location = new System.Drawing.Point(12, 135);
            this.radioButtonMod.Name = "radioButtonMod";
            this.radioButtonMod.Size = new System.Drawing.Size(148, 33);
            this.radioButtonMod.TabIndex = 3;
            this.radioButtonMod.TabStop = true;
            this.radioButtonMod.Text = "Moderator";
            this.radioButtonMod.UseVisualStyleBackColor = true;
            // 
            // radioButtonUser
            // 
            this.radioButtonUser.AutoSize = true;
            this.radioButtonUser.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioButtonUser.Location = new System.Drawing.Point(12, 174);
            this.radioButtonUser.Name = "radioButtonUser";
            this.radioButtonUser.Size = new System.Drawing.Size(161, 33);
            this.radioButtonUser.TabIndex = 4;
            this.radioButtonUser.TabStop = true;
            this.radioButtonUser.Text = "Użytkownik";
            this.radioButtonUser.UseVisualStyleBackColor = true;
            // 
            // radioButtonObser
            // 
            this.radioButtonObser.AutoSize = true;
            this.radioButtonObser.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioButtonObser.Location = new System.Drawing.Point(12, 213);
            this.radioButtonObser.Name = "radioButtonObser";
            this.radioButtonObser.Size = new System.Drawing.Size(158, 33);
            this.radioButtonObser.TabIndex = 5;
            this.radioButtonObser.TabStop = true;
            this.radioButtonObser.Text = "Obserwator";
            this.radioButtonObser.UseVisualStyleBackColor = true;
            // 
            // buttonAcept2
            // 
            this.buttonAcept2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonAcept2.Location = new System.Drawing.Point(6, 252);
            this.buttonAcept2.Name = "buttonAcept2";
            this.buttonAcept2.Size = new System.Drawing.Size(180, 69);
            this.buttonAcept2.TabIndex = 6;
            this.buttonAcept2.Text = "Zatwierdź";
            this.buttonAcept2.UseVisualStyleBackColor = true;
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Controls.Add(this.groupBoxEdit);
            this.Controls.Add(this.groupBoxAdd);
            this.Controls.Add(this.groupBoxButton);
            this.Name = "AdminPanel";
            this.Size = new System.Drawing.Size(400, 480);
            this.Load += new System.EventHandler(this.AdminPanel_Load);
            this.groupBoxButton.ResumeLayout(false);
            this.groupBoxAdd.ResumeLayout(false);
            this.groupBoxAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMajątek)).EndInit();
            this.groupBoxEdit.ResumeLayout(false);
            this.groupBoxEdit.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxButton;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.GroupBox groupBoxAdd;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.NumericUpDown numericUpDownMajątek;
        private System.Windows.Forms.Label labelMajątek;
        private System.Windows.Forms.TextBox textBoxHasło;
        private System.Windows.Forms.Label labelHasło;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.GroupBox groupBoxEdit;
        private System.Windows.Forms.Label labelUsers;
        private System.Windows.Forms.Button buttonAcept;
        private System.Windows.Forms.ListBox Users;
        private System.Windows.Forms.Button buttonAcept2;
        private System.Windows.Forms.RadioButton radioButtonObser;
        private System.Windows.Forms.RadioButton radioButtonUser;
        private System.Windows.Forms.RadioButton radioButtonMod;
        private System.Windows.Forms.RadioButton radioButtonAdmin;
    }
}
