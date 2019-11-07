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

    public partial class uc_operacja : UserControl
    {

        operacje wyswietlanaOperacja;
        bool pokaz_wiecej = true;
        public static Image resizeImage(Image imgToResize, Size size)
        {
            return (Image)(new Bitmap(imgToResize, size));
        }
        public uc_operacja()
        {
            InitializeComponent();
        }
        public uc_operacja(operacje o)
        {
            InitializeComponent();
            wyswietlanaOperacja = o;
            lb_kwota.Text = wyswietlanaOperacja.kwota.ToString();
            if(wyswietlanaOperacja.kategoria.typ == "wydatek")
            {
                lb_kwota.ForeColor = Color.Red;
            }
            else
            {
                lb_kwota.ForeColor = Color.Green;
            }
            label1.Text = wyswietlanaOperacja.nazwa;
        }


        private void btn_arrow_Click(object sender, EventArgs e)
        {
            List<Label> customLabels = new List<Label>();
            if (!pokaz_wiecej)
            {
                btn_arrow.ImageIndex = 1;
                pokaz_wiecej = !pokaz_wiecej;
                flowLayoutPanel1.Controls.Clear();
            }else
            {
                Label label = new Label();
                label.Text = wyswietlanaOperacja.opis;
                customLabels.Add(label);
                flowLayoutPanel1.Controls.Add(label);
                btn_arrow.ImageIndex = 0;
                pokaz_wiecej = !pokaz_wiecej;
            }
        }
        //EventHandler doubleclick
        // To nie dziala niżej :(
        /*
        protected override void OnControlAdded(ControlEventArgs e)
        {
            e.Control.DoubleClick += uc_operacja_DoubleClick;
            
            base.OnControlAdded(e);
        }

        private void uc_operacja_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show("jestem");
            foreach( Control c in ((panelGlowny)this.FindForm()).Controls)
            {
                if(c.Name == "uc_formularz_operacja1")
                {
                    uc_formularz_operacja ucfo = c as uc_formularz_operacja;
                    if( ucfo != null)
                    {
                        ucfo.Wybrana = wyswietlanaOperacja;
                        ucfo.Focus();
                        return;
                    }
                }
            }
        }
        */
        private void panel1_DoubleClick(object sender, EventArgs e)
        {
            uc_formularz_operacja ucfo = ((panelGlowny)this.FindForm()).Controls.Find("uc_formularz_operacja1", true)
                .FirstOrDefault() as uc_formularz_operacja;
                    if (ucfo != null)
                    {
                        ucfo.Wybrana = wyswietlanaOperacja;
                        ucfo.Focus();
                        return;
                    }          
        }

        private void lb_kwota_Click(object sender, EventArgs e)
        {
            uc_formularz_operacja ucfo = ((panelGlowny)this.FindForm()).Controls.Find("uc_formularz_operacja1", true)
    .FirstOrDefault() as uc_formularz_operacja;
            if (ucfo != null)
            {
                ucfo.Wybrana = wyswietlanaOperacja;
                ucfo.Focus();
                return;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            uc_formularz_operacja ucfo = ((panelGlowny)this.FindForm()).Controls.Find("uc_formularz_operacja1", true)
    .FirstOrDefault() as uc_formularz_operacja;
            if (ucfo != null)
            {
                ucfo.Wybrana = wyswietlanaOperacja;
                ucfo.Focus();
                return;
            }
        }
    }
}
