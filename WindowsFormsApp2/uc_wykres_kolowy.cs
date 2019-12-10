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
    public partial class uc_wykres_kolowy : UserControl
    {
        public uc_wykres_kolowy()
        {
            InitializeComponent();
        }
    }
}
        

        // funkcja pozwalajaca uzyskac kategorie z odfiltrowanych rekordow 
        // Get_kategorie()

        // funckja pozwalaajca uzyskac daty z odfiltrowanych rekordow
        // Get_daty()
        
//        chart1.Series["s2"].Points.Clear();
//        chart1.Series["s2"]["PieLabelStyle"] = "Outside";
//        chart1.ChartAreas[0].Area3DStyle.Enable3D = true;

//        foreach (var kat in kategorie)
//        {
//            List<string> list = new List<string>();
//            list.Add(kat);

//            var operation = SingletonBaza.Instance.BazaDC.kategoria

//                if (operation.FirstOrDefault() != null)
//            {
//                var suma = operation.Sum(x => x.Kwota);
//                chart1.Series["s2"].Points.AddXY(kat, suma);
//            }
//        }
//    }
//}
//}
