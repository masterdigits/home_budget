﻿namespace WindowsFormsApp2
{
    partial class uc_panel_dnia
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
            this.flP_dane_operacji = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_nazwa_dnia = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.flP_dane_operacji, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(258, 56);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // flP_dane_operacji
            // 
            this.flP_dane_operacji.AutoScroll = true;
            this.flP_dane_operacji.AutoSize = true;
            this.flP_dane_operacji.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flP_dane_operacji.Dock = System.Windows.Forms.DockStyle.Left;
            this.flP_dane_operacji.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flP_dane_operacji.Location = new System.Drawing.Point(3, 53);
            this.flP_dane_operacji.Name = "flP_dane_operacji";
            this.flP_dane_operacji.Size = new System.Drawing.Size(0, 1);
            this.flP_dane_operacji.TabIndex = 1;
            this.flP_dane_operacji.WrapContents = false;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.lb_nazwa_dnia);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(252, 44);
            this.panel1.TabIndex = 0;
            // 
            // lb_nazwa_dnia
            // 
            this.lb_nazwa_dnia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_nazwa_dnia.AutoSize = true;
            this.lb_nazwa_dnia.Font = new System.Drawing.Font("Arial", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lb_nazwa_dnia.Location = new System.Drawing.Point(134, 0);
            this.lb_nazwa_dnia.Name = "lb_nazwa_dnia";
            this.lb_nazwa_dnia.Size = new System.Drawing.Size(55, 40);
            this.lb_nazwa_dnia.TabIndex = 0;
            this.lb_nazwa_dnia.Text = "30";
            // 
            // uc_panel_dnia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "uc_panel_dnia";
            this.Size = new System.Drawing.Size(258, 56);
            this.Load += new System.EventHandler(this.uc_panel_dnia_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb_nazwa_dnia;
        private System.Windows.Forms.FlowLayoutPanel flP_dane_operacji;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}
