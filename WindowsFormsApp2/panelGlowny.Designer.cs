namespace WindowsFormsApp2
{
    partial class panelGlowny
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

              #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.splitContainerGlowny = new System.Windows.Forms.SplitContainer();
            this.splitContainerMenuBoczne = new System.Windows.Forms.SplitContainer();
            this.buttonDodajWydatek = new System.Windows.Forms.Button();
            this.buttonDodajPrzychód = new System.Windows.Forms.Button();
            this.splitContainerMenuBoczneWidok = new System.Windows.Forms.SplitContainer();
            this.uc_formularz_operacja1 = new WindowsFormsApp2.uc_formularz_operacja();
            this.buttonWidokTabelka = new System.Windows.Forms.Button();
            this.buttonWidokKolumnowy = new System.Windows.Forms.Button();
            this.buttonWidokKolowy = new System.Windows.Forms.Button();
            this.buttonWidokKalendarz = new System.Windows.Forms.Button();
            this.buttonWidokLiniowy = new System.Windows.Forms.Button();
            this.timer_sesja = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerGlowny)).BeginInit();
            this.splitContainerGlowny.Panel1.SuspendLayout();
            this.splitContainerGlowny.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMenuBoczne)).BeginInit();
            this.splitContainerMenuBoczne.Panel1.SuspendLayout();
            this.splitContainerMenuBoczne.Panel2.SuspendLayout();
            this.splitContainerMenuBoczne.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMenuBoczneWidok)).BeginInit();
            this.splitContainerMenuBoczneWidok.Panel1.SuspendLayout();
            this.splitContainerMenuBoczneWidok.Panel2.SuspendLayout();
            this.splitContainerMenuBoczneWidok.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainerGlowny
            // 
            this.splitContainerGlowny.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerGlowny.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainerGlowny.IsSplitterFixed = true;
            this.splitContainerGlowny.Location = new System.Drawing.Point(0, 0);
            this.splitContainerGlowny.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainerGlowny.Name = "splitContainerGlowny";
            // 
            // splitContainerGlowny.Panel1
            // 
            this.splitContainerGlowny.Panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.splitContainerGlowny.Panel1.Controls.Add(this.splitContainerMenuBoczne);
            this.splitContainerGlowny.Size = new System.Drawing.Size(1806, 890);
            this.splitContainerGlowny.SplitterDistance = 350;
            this.splitContainerGlowny.SplitterWidth = 3;
            this.splitContainerGlowny.TabIndex = 0;
            // 
            // splitContainerMenuBoczne
            // 
            this.splitContainerMenuBoczne.BackColor = System.Drawing.Color.White;
            this.splitContainerMenuBoczne.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerMenuBoczne.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainerMenuBoczne.IsSplitterFixed = true;
            this.splitContainerMenuBoczne.Location = new System.Drawing.Point(0, 0);
            this.splitContainerMenuBoczne.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainerMenuBoczne.Name = "splitContainerMenuBoczne";
            this.splitContainerMenuBoczne.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerMenuBoczne.Panel1
            // 
            this.splitContainerMenuBoczne.Panel1.BackColor = System.Drawing.Color.White;
            this.splitContainerMenuBoczne.Panel1.Controls.Add(this.buttonDodajWydatek);
            this.splitContainerMenuBoczne.Panel1.Controls.Add(this.buttonDodajPrzychód);
            // 
            // splitContainerMenuBoczne.Panel2
            // 
            this.splitContainerMenuBoczne.Panel2.Controls.Add(this.splitContainerMenuBoczneWidok);
            this.splitContainerMenuBoczne.Size = new System.Drawing.Size(350, 890);
            this.splitContainerMenuBoczne.SplitterDistance = 200;
            this.splitContainerMenuBoczne.SplitterWidth = 3;
            this.splitContainerMenuBoczne.TabIndex = 0;
            // 
            // buttonDodajWydatek
            // 
            this.buttonDodajWydatek.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDodajWydatek.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonDodajWydatek.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonDodajWydatek.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDodajWydatek.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonDodajWydatek.Location = new System.Drawing.Point(11, 77);
            this.buttonDodajWydatek.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDodajWydatek.Name = "buttonDodajWydatek";
            this.buttonDodajWydatek.Size = new System.Drawing.Size(317, 62);
            this.buttonDodajWydatek.TabIndex = 1;
            this.buttonDodajWydatek.Text = "Dodaj wydatek";
            this.buttonDodajWydatek.UseVisualStyleBackColor = true;
            this.buttonDodajWydatek.Click += new System.EventHandler(this.buttonDodajWydatek_Click);
            // 
            // buttonDodajPrzychód
            // 
            this.buttonDodajPrzychód.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDodajPrzychód.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonDodajPrzychód.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonDodajPrzychód.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDodajPrzychód.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonDodajPrzychód.Location = new System.Drawing.Point(11, 11);
            this.buttonDodajPrzychód.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDodajPrzychód.Name = "buttonDodajPrzychód";
            this.buttonDodajPrzychód.Size = new System.Drawing.Size(317, 62);
            this.buttonDodajPrzychód.TabIndex = 0;
            this.buttonDodajPrzychód.Text = "Dodaj przychód";
            this.buttonDodajPrzychód.UseVisualStyleBackColor = true;
            this.buttonDodajPrzychód.Click += new System.EventHandler(this.buttonDodajPrzychód_Click);
            // 
            // splitContainerMenuBoczneWidok
            // 
            this.splitContainerMenuBoczneWidok.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerMenuBoczneWidok.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainerMenuBoczneWidok.IsSplitterFixed = true;
            this.splitContainerMenuBoczneWidok.Location = new System.Drawing.Point(0, 0);
            this.splitContainerMenuBoczneWidok.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainerMenuBoczneWidok.Name = "splitContainerMenuBoczneWidok";
            this.splitContainerMenuBoczneWidok.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerMenuBoczneWidok.Panel1
            // 
            this.splitContainerMenuBoczneWidok.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.splitContainerMenuBoczneWidok.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.splitContainerMenuBoczneWidok.Panel1.Controls.Add(this.uc_formularz_operacja1);
            // 
            // splitContainerMenuBoczneWidok.Panel2
            // 
            this.splitContainerMenuBoczneWidok.Panel2.BackColor = System.Drawing.Color.White;
            this.splitContainerMenuBoczneWidok.Panel2.Controls.Add(this.buttonWidokTabelka);
            this.splitContainerMenuBoczneWidok.Panel2.Controls.Add(this.buttonWidokKolumnowy);
            this.splitContainerMenuBoczneWidok.Panel2.Controls.Add(this.buttonWidokKolowy);
            this.splitContainerMenuBoczneWidok.Panel2.Controls.Add(this.buttonWidokKalendarz);
            this.splitContainerMenuBoczneWidok.Panel2.Controls.Add(this.buttonWidokLiniowy);
            this.splitContainerMenuBoczneWidok.Size = new System.Drawing.Size(350, 687);
            this.splitContainerMenuBoczneWidok.SplitterDistance = 327;
            this.splitContainerMenuBoczneWidok.SplitterWidth = 3;
            this.splitContainerMenuBoczneWidok.TabIndex = 0;
            // 
            // uc_formularz_operacja1
            // 
            this.uc_formularz_operacja1.AkualnieZalogowany = null;
            this.uc_formularz_operacja1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uc_formularz_operacja1.Location = new System.Drawing.Point(0, 0);
            this.uc_formularz_operacja1.Name = "uc_formularz_operacja1";
            this.uc_formularz_operacja1.Size = new System.Drawing.Size(350, 327);
            this.uc_formularz_operacja1.TabIndex = 0;
            // 
            // buttonWidokTabelka
            // 
            this.buttonWidokTabelka.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonWidokTabelka.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.buttonWidokTabelka.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonWidokTabelka.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonWidokTabelka.Location = new System.Drawing.Point(8, 93);
            this.buttonWidokTabelka.Margin = new System.Windows.Forms.Padding(2);
            this.buttonWidokTabelka.Name = "buttonWidokTabelka";
            this.buttonWidokTabelka.Size = new System.Drawing.Size(340, 48);
            this.buttonWidokTabelka.TabIndex = 5;
            this.buttonWidokTabelka.Text = "Tabela";
            this.buttonWidokTabelka.UseVisualStyleBackColor = true;
            this.buttonWidokTabelka.Click += new System.EventHandler(this.buttonWidokTabelka_Click);
            // 
            // buttonWidokKolumnowy
            // 
            this.buttonWidokKolumnowy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonWidokKolumnowy.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.buttonWidokKolumnowy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonWidokKolumnowy.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonWidokKolumnowy.Location = new System.Drawing.Point(8, 305);
            this.buttonWidokKolumnowy.Margin = new System.Windows.Forms.Padding(2);
            this.buttonWidokKolumnowy.Name = "buttonWidokKolumnowy";
            this.buttonWidokKolumnowy.Size = new System.Drawing.Size(340, 52);
            this.buttonWidokKolumnowy.TabIndex = 4;
            this.buttonWidokKolumnowy.Text = "Wykres kolumnowy";
            this.buttonWidokKolumnowy.UseVisualStyleBackColor = true;
            this.buttonWidokKolumnowy.Click += new System.EventHandler(this.buttonWidokKolumnowy_Click);
            // 
            // buttonWidokKolowy
            // 
            this.buttonWidokKolowy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonWidokKolowy.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.buttonWidokKolowy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonWidokKolowy.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonWidokKolowy.Location = new System.Drawing.Point(8, 249);
            this.buttonWidokKolowy.Margin = new System.Windows.Forms.Padding(2);
            this.buttonWidokKolowy.Name = "buttonWidokKolowy";
            this.buttonWidokKolowy.Size = new System.Drawing.Size(340, 52);
            this.buttonWidokKolowy.TabIndex = 3;
            this.buttonWidokKolowy.Text = "Wykres kołowy";
            this.buttonWidokKolowy.UseVisualStyleBackColor = true;
            this.buttonWidokKolowy.Click += new System.EventHandler(this.buttonWidokKolowy_Click);
            // 
            // buttonWidokKalendarz
            // 
            this.buttonWidokKalendarz.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonWidokKalendarz.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.buttonWidokKalendarz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonWidokKalendarz.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonWidokKalendarz.Location = new System.Drawing.Point(8, 145);
            this.buttonWidokKalendarz.Margin = new System.Windows.Forms.Padding(2);
            this.buttonWidokKalendarz.Name = "buttonWidokKalendarz";
            this.buttonWidokKalendarz.Size = new System.Drawing.Size(340, 48);
            this.buttonWidokKalendarz.TabIndex = 0;
            this.buttonWidokKalendarz.Text = "Kalendarz";
            this.buttonWidokKalendarz.UseVisualStyleBackColor = true;
            this.buttonWidokKalendarz.Click += new System.EventHandler(this.buttonWidokKalendarz_Click);
            // 
            // buttonWidokLiniowy
            // 
            this.buttonWidokLiniowy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonWidokLiniowy.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.buttonWidokLiniowy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonWidokLiniowy.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonWidokLiniowy.Location = new System.Drawing.Point(8, 197);
            this.buttonWidokLiniowy.Margin = new System.Windows.Forms.Padding(2);
            this.buttonWidokLiniowy.Name = "buttonWidokLiniowy";
            this.buttonWidokLiniowy.Size = new System.Drawing.Size(340, 48);
            this.buttonWidokLiniowy.TabIndex = 2;
            this.buttonWidokLiniowy.Text = "Wykres liniowy";
            this.buttonWidokLiniowy.UseVisualStyleBackColor = true;
            this.buttonWidokLiniowy.Click += new System.EventHandler(this.buttonWidokLiniowy_Click);
            // 
            // timer_sesja
            // 
            this.timer_sesja.Tick += new System.EventHandler(this.timer_sesja_Tick);
            // 
            // panelGlowny
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1806, 890);
            this.Controls.Add(this.splitContainerGlowny);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "panelGlowny";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Budżet domowy";
            this.Activated += new System.EventHandler(this.panelGlowny_Activated);
            this.Load += new System.EventHandler(this.panelGlowny_Load);
            this.SizeChanged += new System.EventHandler(this.panelGlowny_SizeChanged);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panelGlowny_MouseClick);
            this.splitContainerGlowny.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerGlowny)).EndInit();
            this.splitContainerGlowny.ResumeLayout(false);
            this.splitContainerMenuBoczne.Panel1.ResumeLayout(false);
            this.splitContainerMenuBoczne.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMenuBoczne)).EndInit();
            this.splitContainerMenuBoczne.ResumeLayout(false);
            this.splitContainerMenuBoczneWidok.Panel1.ResumeLayout(false);
            this.splitContainerMenuBoczneWidok.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMenuBoczneWidok)).EndInit();
            this.splitContainerMenuBoczneWidok.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainerGlowny;
        private System.Windows.Forms.SplitContainer splitContainerMenuBoczne;
        private System.Windows.Forms.SplitContainer splitContainerMenuBoczneWidok;
        private System.Windows.Forms.Button buttonDodajWydatek;
        private System.Windows.Forms.Button buttonDodajPrzychód;
        private System.Windows.Forms.Button buttonWidokKalendarz;
        private System.Windows.Forms.Button buttonWidokLiniowy;
        private System.Windows.Forms.Button buttonWidokKolumnowy;
        private System.Windows.Forms.Button buttonWidokKolowy;
        private System.Windows.Forms.Button buttonWidokTabelka;
        private uc_formularz_operacja uc_formularz_operacja1;
        private System.Windows.Forms.Timer timer_sesja;
    }
}