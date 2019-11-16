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
            this.ButtonMessage = new System.Windows.Forms.Button();
            this.ButtonEdit = new System.Windows.Forms.Button();
            this.ButtonAdd = new System.Windows.Forms.Button();
            this.GroupBoxAdd = new System.Windows.Forms.GroupBox();
            this.labelRola = new System.Windows.Forms.Label();
            this.comboBoxRole = new System.Windows.Forms.ComboBox();
            this.buttonAcept = new System.Windows.Forms.Button();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.numericUpDownMajątek = new System.Windows.Forms.NumericUpDown();
            this.labelMajątek = new System.Windows.Forms.Label();
            this.textBoxHasło = new System.Windows.Forms.TextBox();
            this.labelHasło = new System.Windows.Forms.Label();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.labelLogin = new System.Windows.Forms.Label();
            this.GroupBoxEdit = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.comboBoxUsers = new System.Windows.Forms.ComboBox();
            this.labelUsers = new System.Windows.Forms.Label();
            this.GroupBoxMessage = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBoxButton.SuspendLayout();
            this.GroupBoxAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMajątek)).BeginInit();
            this.GroupBoxEdit.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxButton
            // 
            this.groupBoxButton.Controls.Add(this.ButtonMessage);
            this.groupBoxButton.Controls.Add(this.ButtonEdit);
            this.groupBoxButton.Controls.Add(this.ButtonAdd);
            this.groupBoxButton.Location = new System.Drawing.Point(3, 3);
            this.groupBoxButton.Name = "groupBoxButton";
            this.groupBoxButton.Size = new System.Drawing.Size(572, 85);
            this.groupBoxButton.TabIndex = 0;
            this.groupBoxButton.TabStop = false;
            // 
            // ButtonMessage
            // 
            this.ButtonMessage.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonMessage.Location = new System.Drawing.Point(380, 10);
            this.ButtonMessage.Name = "ButtonMessage";
            this.ButtonMessage.Size = new System.Drawing.Size(180, 69);
            this.ButtonMessage.TabIndex = 2;
            this.ButtonMessage.Text = "Wiadomości";
            this.ButtonMessage.UseVisualStyleBackColor = true;
            this.ButtonMessage.Click += new System.EventHandler(this.ButtonMessage_Click);
            // 
            // ButtonEdit
            // 
            this.ButtonEdit.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonEdit.Location = new System.Drawing.Point(194, 10);
            this.ButtonEdit.Name = "ButtonEdit";
            this.ButtonEdit.Size = new System.Drawing.Size(180, 69);
            this.ButtonEdit.TabIndex = 1;
            this.ButtonEdit.Text = "Edytuj Użytkowników";
            this.ButtonEdit.UseVisualStyleBackColor = true;
            this.ButtonEdit.Click += new System.EventHandler(this.ButtonEdit_Click);
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonAdd.Location = new System.Drawing.Point(7, 10);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(180, 69);
            this.ButtonAdd.TabIndex = 0;
            this.ButtonAdd.Text = "Dodaj użytkownika";
            this.ButtonAdd.UseVisualStyleBackColor = true;
            // 
            // GroupBoxAdd
            // 
            this.GroupBoxAdd.Controls.Add(this.labelRola);
            this.GroupBoxAdd.Controls.Add(this.comboBoxRole);
            this.GroupBoxAdd.Controls.Add(this.buttonAcept);
            this.GroupBoxAdd.Controls.Add(this.textBoxEmail);
            this.GroupBoxAdd.Controls.Add(this.labelEmail);
            this.GroupBoxAdd.Controls.Add(this.numericUpDownMajątek);
            this.GroupBoxAdd.Controls.Add(this.labelMajątek);
            this.GroupBoxAdd.Controls.Add(this.textBoxHasło);
            this.GroupBoxAdd.Controls.Add(this.labelHasło);
            this.GroupBoxAdd.Controls.Add(this.textBoxLogin);
            this.GroupBoxAdd.Controls.Add(this.labelLogin);
            this.GroupBoxAdd.Location = new System.Drawing.Point(4, 95);
            this.GroupBoxAdd.Name = "GroupBoxAdd";
            this.GroupBoxAdd.Size = new System.Drawing.Size(145, 460);
            this.GroupBoxAdd.TabIndex = 1;
            this.GroupBoxAdd.TabStop = false;
            // 
            // labelRola
            // 
            this.labelRola.AutoSize = true;
            this.labelRola.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelRola.Location = new System.Drawing.Point(7, 299);
            this.labelRola.Name = "labelRola";
            this.labelRola.Size = new System.Drawing.Size(62, 29);
            this.labelRola.TabIndex = 10;
            this.labelRola.Text = "Rola";
            // 
            // comboBoxRole
            // 
            this.comboBoxRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxRole.FormattingEnabled = true;
            this.comboBoxRole.Location = new System.Drawing.Point(12, 331);
            this.comboBoxRole.Name = "comboBoxRole";
            this.comboBoxRole.Size = new System.Drawing.Size(547, 37);
            this.comboBoxRole.TabIndex = 9;
            // 
            // buttonAcept
            // 
            this.buttonAcept.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonAcept.Location = new System.Drawing.Point(12, 374);
            this.buttonAcept.Name = "buttonAcept";
            this.buttonAcept.Size = new System.Drawing.Size(180, 69);
            this.buttonAcept.TabIndex = 3;
            this.buttonAcept.Text = "Zatwierdź";
            this.buttonAcept.UseVisualStyleBackColor = true;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxEmail.Location = new System.Drawing.Point(12, 193);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(547, 34);
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
            this.numericUpDownMajątek.Size = new System.Drawing.Size(547, 34);
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
            this.textBoxHasło.Size = new System.Drawing.Size(547, 34);
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
            this.textBoxLogin.Size = new System.Drawing.Size(547, 34);
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
            // GroupBoxEdit
            // 
            this.GroupBoxEdit.Controls.Add(this.button1);
            this.GroupBoxEdit.Controls.Add(this.listBox1);
            this.GroupBoxEdit.Controls.Add(this.comboBoxUsers);
            this.GroupBoxEdit.Controls.Add(this.labelUsers);
            this.GroupBoxEdit.Location = new System.Drawing.Point(155, 95);
            this.GroupBoxEdit.Name = "GroupBoxEdit";
            this.GroupBoxEdit.Size = new System.Drawing.Size(408, 460);
            this.GroupBoxEdit.TabIndex = 2;
            this.GroupBoxEdit.TabStop = false;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(6, 96);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(547, 452);
            this.listBox1.TabIndex = 8;
            // 
            // comboBoxUsers
            // 
            this.comboBoxUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxUsers.FormattingEnabled = true;
            this.comboBoxUsers.Location = new System.Drawing.Point(6, 50);
            this.comboBoxUsers.Name = "comboBoxUsers";
            this.comboBoxUsers.Size = new System.Drawing.Size(366, 37);
            this.comboBoxUsers.TabIndex = 7;
            this.comboBoxUsers.Text = "Użytkonicy";
            // 
            // labelUsers
            // 
            this.labelUsers.AutoSize = true;
            this.labelUsers.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelUsers.Location = new System.Drawing.Point(1, 18);
            this.labelUsers.Name = "labelUsers";
            this.labelUsers.Size = new System.Drawing.Size(242, 29);
            this.labelUsers.TabIndex = 1;
            this.labelUsers.Text = "Wybierz użytkownika";
            // 
            // GroupBoxMessage
            // 
            this.GroupBoxMessage.Location = new System.Drawing.Point(289, 95);
            this.GroupBoxMessage.Name = "GroupBoxMessage";
            this.GroupBoxMessage.Size = new System.Drawing.Size(200, 100);
            this.GroupBoxMessage.TabIndex = 3;
            this.GroupBoxMessage.TabStop = false;
            this.GroupBoxMessage.Text = "Work in progress";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(377, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 69);
            this.button1.TabIndex = 9;
            this.button1.Text = "Zatwierdź";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Controls.Add(this.GroupBoxMessage);
            this.Controls.Add(this.GroupBoxEdit);
            this.Controls.Add(this.GroupBoxAdd);
            this.Controls.Add(this.groupBoxButton);
            this.Name = "AdminPanel";
            this.Size = new System.Drawing.Size(578, 558);
            this.AutoSizeChanged += new System.EventHandler(this.AdminPanel_Load);
            this.Load += new System.EventHandler(this.AdminPanel_Load);
            this.groupBoxButton.ResumeLayout(false);
            this.GroupBoxAdd.ResumeLayout(false);
            this.GroupBoxAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMajątek)).EndInit();
            this.GroupBoxEdit.ResumeLayout(false);
            this.GroupBoxEdit.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxButton;
        private System.Windows.Forms.Button ButtonEdit;
        private System.Windows.Forms.Button ButtonAdd;
        private System.Windows.Forms.GroupBox GroupBoxAdd;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.NumericUpDown numericUpDownMajątek;
        private System.Windows.Forms.Label labelMajątek;
        private System.Windows.Forms.TextBox textBoxHasło;
        private System.Windows.Forms.Label labelHasło;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.GroupBox GroupBoxEdit;
        private System.Windows.Forms.Label labelUsers;
        private System.Windows.Forms.Button buttonAcept;
        private System.Windows.Forms.Label labelRola;
        private System.Windows.Forms.ComboBox comboBoxRole;
        private System.Windows.Forms.Button ButtonMessage;
        private System.Windows.Forms.ComboBox comboBoxUsers;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox GroupBoxMessage;
        private System.Windows.Forms.Button button1;
    }
}
