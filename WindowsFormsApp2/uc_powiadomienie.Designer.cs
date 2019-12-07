namespace WindowsFormsApp2
{
    partial class uc_powiadomienie
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.l_nadawca = new System.Windows.Forms.Label();
            this.l_nazwa = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.prześlijDalejToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuńToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.ContextMenuStrip = this.contextMenuStrip1;
            this.panel1.Controls.Add(this.l_nazwa);
            this.panel1.Controls.Add(this.l_nadawca);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 0;
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
            // 
            // l_nadawca
            // 
            this.l_nadawca.AutoSize = true;
            this.l_nadawca.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.l_nadawca.Location = new System.Drawing.Point(20, 16);
            this.l_nadawca.Name = "l_nadawca";
            this.l_nadawca.Size = new System.Drawing.Size(60, 24);
            this.l_nadawca.TabIndex = 0;
            this.l_nadawca.Text = "label1";
            this.l_nadawca.Click += new System.EventHandler(this.panel1_Click);
            // 
            // l_nazwa
            // 
            this.l_nazwa.AutoSize = true;
            this.l_nazwa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.l_nazwa.Location = new System.Drawing.Point(20, 59);
            this.l_nazwa.Name = "l_nazwa";
            this.l_nazwa.Size = new System.Drawing.Size(60, 24);
            this.l_nazwa.TabIndex = 1;
            this.l_nazwa.Text = "label2";
            this.l_nazwa.Click += new System.EventHandler(this.panel1_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.prześlijDalejToolStripMenuItem,
            this.usuńToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(139, 48);
            // 
            // prześlijDalejToolStripMenuItem
            // 
            this.prześlijDalejToolStripMenuItem.Name = "prześlijDalejToolStripMenuItem";
            this.prześlijDalejToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.prześlijDalejToolStripMenuItem.Text = "Prześlij dalej";
            // 
            // usuńToolStripMenuItem
            // 
            this.usuńToolStripMenuItem.Name = "usuńToolStripMenuItem";
            this.usuńToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.usuńToolStripMenuItem.Text = "Usuń";
            // 
            // uc_powiadomienie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "uc_powiadomienie";
            this.Size = new System.Drawing.Size(200, 100);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label l_nazwa;
        private System.Windows.Forms.Label l_nadawca;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem prześlijDalejToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuńToolStripMenuItem;
    }
}
