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
            this.timer_sesja = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tlp_kontekst = new System.Windows.Forms.TableLayoutPanel();
            this.tlp_menu_boczne = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonDodajPrzychód = new System.Windows.Forms.Button();
            this.buttonDodajWydatek = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonWidokTabelka = new System.Windows.Forms.Button();
            this.buttonWidokLiniowy = new System.Windows.Forms.Button();
            this.buttonWidokKalendarz = new System.Windows.Forms.Button();
            this.buttonWidokKolumnowy = new System.Windows.Forms.Button();
            this.buttonWidokKolowy = new System.Windows.Forms.Button();
            this.panel_menu_glowne = new System.Windows.Forms.Panel();
            this.uc_formularz_operacja1 = new WindowsFormsApp2.uc_formularz_operacja();
            this.tableLayoutPanel1.SuspendLayout();
            this.tlp_menu_boczne.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer_sesja
            // 
            this.timer_sesja.Interval = 5000;
            this.timer_sesja.Tick += new System.EventHandler(this.timer_sesja_Tick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 350F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.tlp_kontekst, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tlp_menu_boczne, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel_menu_glowne, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1806, 890);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // tlp_kontekst
            // 
            this.tlp_kontekst.AutoSize = true;
            this.tlp_kontekst.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlp_kontekst.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.tlp_kontekst.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetPartial;
            this.tlp_kontekst.ColumnCount = 1;
            this.tlp_kontekst.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_kontekst.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_kontekst.Location = new System.Drawing.Point(353, 50);
            this.tlp_kontekst.Name = "tlp_kontekst";
            this.tlp_kontekst.RowCount = 1;
            this.tlp_kontekst.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 79.56989F));
            this.tlp_kontekst.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.43011F));
            this.tlp_kontekst.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 834F));
            this.tlp_kontekst.Size = new System.Drawing.Size(1450, 837);
            this.tlp_kontekst.TabIndex = 3;
            // 
            // tlp_menu_boczne
            // 
            this.tlp_menu_boczne.AutoSize = true;
            this.tlp_menu_boczne.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetDouble;
            this.tlp_menu_boczne.ColumnCount = 1;
            this.tlp_menu_boczne.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlp_menu_boczne.Controls.Add(this.panel1, 0, 0);
            this.tlp_menu_boczne.Controls.Add(this.panel2, 0, 1);
            this.tlp_menu_boczne.Controls.Add(this.panel3, 0, 2);
            this.tlp_menu_boczne.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_menu_boczne.Location = new System.Drawing.Point(3, 50);
            this.tlp_menu_boczne.MinimumSize = new System.Drawing.Size(350, 0);
            this.tlp_menu_boczne.Name = "tlp_menu_boczne";
            this.tlp_menu_boczne.RowCount = 3;
            this.tlp_menu_boczne.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlp_menu_boczne.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlp_menu_boczne.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlp_menu_boczne.Size = new System.Drawing.Size(350, 837);
            this.tlp_menu_boczne.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.buttonDodajPrzychód);
            this.panel1.Controls.Add(this.buttonDodajWydatek);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(6, 6);
            this.panel1.MinimumSize = new System.Drawing.Size(344, 150);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(344, 150);
            this.panel1.TabIndex = 0;
            // 
            // buttonDodajPrzychód
            // 
            this.buttonDodajPrzychód.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDodajPrzychód.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonDodajPrzychód.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonDodajPrzychód.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDodajPrzychód.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonDodajPrzychód.Location = new System.Drawing.Point(8, 78);
            this.buttonDodajPrzychód.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDodajPrzychód.Name = "buttonDodajPrzychód";
            this.buttonDodajPrzychód.Size = new System.Drawing.Size(317, 66);
            this.buttonDodajPrzychód.TabIndex = 0;
            this.buttonDodajPrzychód.Text = "Dodaj przychód";
            this.buttonDodajPrzychód.UseVisualStyleBackColor = true;
            // 
            // buttonDodajWydatek
            // 
            this.buttonDodajWydatek.AutoSize = true;
            this.buttonDodajWydatek.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDodajWydatek.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonDodajWydatek.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonDodajWydatek.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDodajWydatek.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonDodajWydatek.Location = new System.Drawing.Point(8, 8);
            this.buttonDodajWydatek.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDodajWydatek.Name = "buttonDodajWydatek";
            this.buttonDodajWydatek.Size = new System.Drawing.Size(317, 66);
            this.buttonDodajWydatek.TabIndex = 1;
            this.buttonDodajWydatek.Text = "Dodaj wydatek";
            this.buttonDodajWydatek.UseVisualStyleBackColor = true;
            this.buttonDodajWydatek.Click += new System.EventHandler(this.buttonDodajWydatek_Click);
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel2.Controls.Add(this.uc_formularz_operacja1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(6, 165);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(344, 376);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.AutoSize = true;
            this.panel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel3.Controls.Add(this.buttonWidokTabelka);
            this.panel3.Controls.Add(this.buttonWidokLiniowy);
            this.panel3.Controls.Add(this.buttonWidokKalendarz);
            this.panel3.Controls.Add(this.buttonWidokKolumnowy);
            this.panel3.Controls.Add(this.buttonWidokKolowy);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(6, 550);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(344, 281);
            this.panel3.TabIndex = 2;
            // 
            // buttonWidokTabelka
            // 
            this.buttonWidokTabelka.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonWidokTabelka.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.buttonWidokTabelka.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonWidokTabelka.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonWidokTabelka.Location = new System.Drawing.Point(2, 15);
            this.buttonWidokTabelka.Margin = new System.Windows.Forms.Padding(2);
            this.buttonWidokTabelka.Name = "buttonWidokTabelka";
            this.buttonWidokTabelka.Size = new System.Drawing.Size(340, 52);
            this.buttonWidokTabelka.TabIndex = 5;
            this.buttonWidokTabelka.Text = "Tabela";
            this.buttonWidokTabelka.UseVisualStyleBackColor = true;
            this.buttonWidokTabelka.Click += new System.EventHandler(this.buttonWidokTabelka_Click);
            // 
            // buttonWidokLiniowy
            // 
            this.buttonWidokLiniowy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonWidokLiniowy.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.buttonWidokLiniowy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonWidokLiniowy.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonWidokLiniowy.Location = new System.Drawing.Point(2, 119);
            this.buttonWidokLiniowy.Margin = new System.Windows.Forms.Padding(2);
            this.buttonWidokLiniowy.Name = "buttonWidokLiniowy";
            this.buttonWidokLiniowy.Size = new System.Drawing.Size(340, 52);
            this.buttonWidokLiniowy.TabIndex = 2;
            this.buttonWidokLiniowy.Text = "Wykres liniowy";
            this.buttonWidokLiniowy.UseVisualStyleBackColor = true;
            // 
            // buttonWidokKalendarz
            // 
            this.buttonWidokKalendarz.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonWidokKalendarz.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.buttonWidokKalendarz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonWidokKalendarz.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonWidokKalendarz.Location = new System.Drawing.Point(2, 67);
            this.buttonWidokKalendarz.Margin = new System.Windows.Forms.Padding(2);
            this.buttonWidokKalendarz.Name = "buttonWidokKalendarz";
            this.buttonWidokKalendarz.Size = new System.Drawing.Size(340, 48);
            this.buttonWidokKalendarz.TabIndex = 0;
            this.buttonWidokKalendarz.Text = "Kalendarz";
            this.buttonWidokKalendarz.UseVisualStyleBackColor = true;
            this.buttonWidokKalendarz.Click += new System.EventHandler(this.buttonWidokKalendarz_Click);
            // 
            // buttonWidokKolumnowy
            // 
            this.buttonWidokKolumnowy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonWidokKolumnowy.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.buttonWidokKolumnowy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonWidokKolumnowy.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonWidokKolumnowy.Location = new System.Drawing.Point(2, 227);
            this.buttonWidokKolumnowy.Margin = new System.Windows.Forms.Padding(2);
            this.buttonWidokKolumnowy.Name = "buttonWidokKolumnowy";
            this.buttonWidokKolumnowy.Size = new System.Drawing.Size(340, 52);
            this.buttonWidokKolumnowy.TabIndex = 4;
            this.buttonWidokKolumnowy.Text = "Wykres kolumnowy";
            this.buttonWidokKolumnowy.UseVisualStyleBackColor = true;
            // 
            // buttonWidokKolowy
            // 
            this.buttonWidokKolowy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonWidokKolowy.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.buttonWidokKolowy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonWidokKolowy.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonWidokKolowy.Location = new System.Drawing.Point(2, 171);
            this.buttonWidokKolowy.Margin = new System.Windows.Forms.Padding(2);
            this.buttonWidokKolowy.Name = "buttonWidokKolowy";
            this.buttonWidokKolowy.Size = new System.Drawing.Size(340, 56);
            this.buttonWidokKolowy.TabIndex = 3;
            this.buttonWidokKolowy.Text = "Wykres kołowy";
            this.buttonWidokKolowy.UseVisualStyleBackColor = true;
            // 
            // panel_menu_glowne
            // 
            this.panel_menu_glowne.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tableLayoutPanel1.SetColumnSpan(this.panel_menu_glowne, 2);
            this.panel_menu_glowne.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_menu_glowne.Location = new System.Drawing.Point(3, 3);
            this.panel_menu_glowne.Name = "panel_menu_glowne";
            this.panel_menu_glowne.Size = new System.Drawing.Size(1800, 41);
            this.panel_menu_glowne.TabIndex = 0;
            // 
            // uc_formularz_operacja1
            // 
            this.uc_formularz_operacja1.AkualnieZalogowany = null;
            this.uc_formularz_operacja1.AutoSize = true;
            this.uc_formularz_operacja1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.uc_formularz_operacja1.Location = new System.Drawing.Point(6, 19);
            this.uc_formularz_operacja1.Name = "uc_formularz_operacja1";
            this.uc_formularz_operacja1.Size = new System.Drawing.Size(335, 354);
            this.uc_formularz_operacja1.TabIndex = 0;
            // 
            // panelGlowny
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1806, 890);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "panelGlowny";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Budżet domowy";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.panelGlowny_Activated);
            this.Load += new System.EventHandler(this.panelGlowny_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tlp_menu_boczne.ResumeLayout(false);
            this.tlp_menu_boczne.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer_sesja;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tlp_menu_boczne;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonDodajPrzychód;
        private System.Windows.Forms.Button buttonDodajWydatek;
        private System.Windows.Forms.Panel panel2;
        private uc_formularz_operacja uc_formularz_operacja1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button buttonWidokTabelka;
        private System.Windows.Forms.Button buttonWidokLiniowy;
        private System.Windows.Forms.Button buttonWidokKalendarz;
        private System.Windows.Forms.Button buttonWidokKolumnowy;
        private System.Windows.Forms.Button buttonWidokKolowy;
        private System.Windows.Forms.TableLayoutPanel tlp_kontekst;
        private System.Windows.Forms.Panel panel_menu_glowne;
    }
}