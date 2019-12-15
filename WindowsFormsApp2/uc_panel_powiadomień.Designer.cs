namespace WindowsFormsApp2
{
    partial class uc_panel_powiadomień
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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.skrzynkaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wysłaneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.odświerzToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flp_powiadomienia = new System.Windows.Forms.FlowLayoutPanel();
            this.p_kontener = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 267F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.p_kontener, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(2044, 985);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.menuStrip2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.menuStrip1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.flp_powiadomienia, 0, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(259, 977);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.skrzynkaToolStripMenuItem,
            this.wysłaneToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 28);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip2.Size = new System.Drawing.Size(259, 25);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // skrzynkaToolStripMenuItem
            // 
            this.skrzynkaToolStripMenuItem.Name = "skrzynkaToolStripMenuItem";
            this.skrzynkaToolStripMenuItem.Size = new System.Drawing.Size(78, 21);
            this.skrzynkaToolStripMenuItem.Text = "Skrzynka";
            this.skrzynkaToolStripMenuItem.Click += new System.EventHandler(this.skrzynkaToolStripMenuItem_Click);
            // 
            // wysłaneToolStripMenuItem
            // 
            this.wysłaneToolStripMenuItem.Name = "wysłaneToolStripMenuItem";
            this.wysłaneToolStripMenuItem.Size = new System.Drawing.Size(76, 21);
            this.wysłaneToolStripMenuItem.Text = "Wysłane";
            this.wysłaneToolStripMenuItem.Click += new System.EventHandler(this.wysłaneToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.odświerzToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(259, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(31, 24);
            this.toolStripMenuItem1.Text = "+";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // odświerzToolStripMenuItem
            // 
            this.odświerzToolStripMenuItem.Name = "odświerzToolStripMenuItem";
            this.odświerzToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
            this.odświerzToolStripMenuItem.Text = "Odśwież";
            this.odświerzToolStripMenuItem.Click += new System.EventHandler(this.odświerzToolStripMenuItem_Click);
            // 
            // flp_powiadomienia
            // 
            this.flp_powiadomienia.AutoScroll = true;
            this.flp_powiadomienia.AutoSize = true;
            this.flp_powiadomienia.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flp_powiadomienia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flp_powiadomienia.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flp_powiadomienia.Location = new System.Drawing.Point(4, 57);
            this.flp_powiadomienia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.flp_powiadomienia.Name = "flp_powiadomienia";
            this.flp_powiadomienia.Size = new System.Drawing.Size(251, 916);
            this.flp_powiadomienia.TabIndex = 2;
            // 
            // p_kontener
            // 
            this.p_kontener.AutoSize = true;
            this.p_kontener.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.p_kontener.Dock = System.Windows.Forms.DockStyle.Fill;
            this.p_kontener.Location = new System.Drawing.Point(271, 4);
            this.p_kontener.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.p_kontener.Name = "p_kontener";
            this.p_kontener.Size = new System.Drawing.Size(1769, 977);
            this.p_kontener.TabIndex = 1;
            // 
            // uc_panel_powiadomień
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "uc_panel_powiadomień";
            this.Size = new System.Drawing.Size(2044, 985);
            this.Load += new System.EventHandler(this.uc_panel_powiadomień_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem skrzynkaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wysłaneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem odświerzToolStripMenuItem;
        private System.Windows.Forms.FlowLayoutPanel flp_powiadomienia;
        private System.Windows.Forms.Panel p_kontener;
    }
}
