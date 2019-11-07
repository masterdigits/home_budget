using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class uc_dodaj_date : UserControl
    {
        bool pokaz_wiecej = true;
        DateTimePicker data_od;
        DateTimePicker data_do;
        internal DateTime Data_od
        {
            get
            {
                if(data_od!=null)
                {
                    return data_od.Value;
                }else
                {
                    return DateTime.MinValue;
                }
            }
        }
        internal DateTime Data_do
        {
            get
            {
                if (data_do != null)
                {
                    return data_do.Value;
                }
                else
                {
                    return DateTime.MinValue;
                }
            }
        }


        public uc_dodaj_date()
        {
            InitializeComponent();
        }

        private void btn_arrow_Click(object sender, EventArgs e)
        {
            if (!pokaz_wiecej)
            {
                btn_arrow.Text = "Wybierz datę";
                btn_arrow.ImageIndex = 1;
                pokaz_wiecej = !pokaz_wiecej;
                flp_daty.Controls.Clear();
                data_do = null;
                data_od = null;
            }
            else
            {
                btn_arrow.Text = "Usuń wybór";
                FlowLayoutPanel panel_od = new FlowLayoutPanel();
                panel_od.AutoSize = true;
                //panel_od.Visible = false;
                Label label_od = new Label();
                label_od.Text = "Date od";
                label_od.AutoSize = true;
                data_od = new DateTimePicker();
                panel_od.Controls.Add(label_od);
                panel_od.Controls.Add(data_od);
                flp_daty.Controls.Add(panel_od);

                FlowLayoutPanel panel_do = new FlowLayoutPanel();
                panel_do.AutoSize = true;
                Label label_do = new Label();
                label_do.AutoSize = true;
                label_do.Text = "Date do";
                data_do = new DateTimePicker();
                panel_do.Controls.Add(label_do);
                panel_do.Controls.Add(data_do);
                flp_daty.Controls.Add(panel_do);

                btn_arrow.ImageIndex = 0;
                pokaz_wiecej = !pokaz_wiecej;
            }
        }
    }
}
