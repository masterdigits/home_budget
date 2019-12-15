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
    public partial class uc_wykres_kolumnowy : UserControl
    {
        List<operacje> dane_do_wykresu = SingletonBaza.Instance.BazaDC.operacje.ToList();


        internal List<operacje> Dane_do_Wykresu
        {
            get
            {
                return dane_do_wykresu;
            }
            set
            {
                dane_do_wykresu = value;
            }
        }

        public uc_wykres_kolumnowy()
        {
            InitializeComponent();
        }

        public void draw_year_chart() 
        {
            chart1.ChartAreas.Clear();
            chart1.ChartAreas.Add(new System.Windows.Forms.DataVisualization.Charting.ChartArea("rok"));
            
            System.Windows.Forms.DataVisualization.Charting.Series years = new System.Windows.Forms.DataVisualization.Charting.Series();
            Dictionary<int, decimal> rok_suma = new Dictionary<int, decimal>();
            //Rozróżniać wydatek od przychodu ???
            foreach(operacje o in dane_do_wykresu)
            {
                if(!rok_suma.ContainsKey(o.data.Year))
                {
                    rok_suma[o.data.Year] = 0;
                }
                rok_suma[o.data.Year] += o.kwota; 
            }

            years.Points.DataBindXY(rok_suma.Keys, rok_suma.Values);
            years.ChartArea = "rok";

            chart1.Series.Clear();

            chart1.Series.Add(years);
        }

        public void piechart_year()
        {
            //ch_kolowy.Series.Add("s1");
            ch_kolowy.Series["s1"].Points.Clear();
            ch_kolowy.Series["s1"]["PieLabelStyle"] = "Outside";
            ch_kolowy.ChartAreas[0].Area3DStyle.Enable3D = true;
            var q = SingletonBaza.Instance.BazaDC.kategoria;
            List<kategoria> kategorie = q.ToList();

            foreach (kategoria kat in kategorie)
            {
                decimal suma = dane_do_wykresu.Where(x => x.kategoria == kat).Sum(x => x.kwota);
                ch_kolowy.Series["s1"].Points.AddXY(kat.nazwa, suma);
            }
        }

        public void draw_month_chart()
        {
            // Jest jakiś wybór roku ?? 
            //String[] months_names = { "styczeń", "luty", "marzec", "kwiecień", "maj", "czerwiec", "lipiec", "sierpień", "wrzesień", "październik", "listopad", "grudzień" };
            chart2.ChartAreas.Clear();
            chart2.ChartAreas.Add(new System.Windows.Forms.DataVisualization.Charting.ChartArea("miesiąc"));
            Dictionary<string, decimal> miesiac_suma = new Dictionary<string, decimal>();
            //Rozróżniać wydatek od przychodu ???
            foreach (operacje o in dane_do_wykresu)
            {
                string nazwa_miesiace =((uc_kalendarz.Miesiace) o.data.Month).ToString();

                if (!miesiac_suma.ContainsKey(nazwa_miesiace))
                {
                    miesiac_suma[nazwa_miesiace] = 0;
                }
                miesiac_suma[nazwa_miesiace] += o.kwota;
            }


            System.Windows.Forms.DataVisualization.Charting.Series months = new System.Windows.Forms.DataVisualization.Charting.Series();
            //months.Points.DataBindXY(months_names, new double[] { 1234, 2345, 3456, 4567,5678,6543,5423,4321,1432,2314,5321,7654 });
            months.Points.DataBindXY(miesiac_suma.Keys, miesiac_suma.Values);
            months.ChartArea = "miesiąc";

            chart2.Series.Clear();

            chart2.Series.Add(months);
        }

        internal void set_size()
        {
            tabControl1.Width = this.Width - 6;
            tabControl1.Height = this.Height - 6;
            chart1.Width = tabControl1.Width - 6;
            chart1.Height = tabControl1.Height - 24;
            chart2.Width = tabControl1.Width - 6;
            chart2.Height = tabControl1.Height - 24;


        }

        private void uc_wykres_kolumnowy_Load(object sender, EventArgs e)
        {
            piechart_year();
            draw_month_chart();
            draw_year_chart();
            draw_line();
        }
        public void draw_line()
        {
            chart3.ChartAreas.Clear();
            chart3.ChartAreas.Add(new System.Windows.Forms.DataVisualization.Charting.ChartArea("miesiąc"));

            Dictionary<DateTime, decimal> rok_suma = new Dictionary<DateTime, decimal>();
            
            //Rozróżniać wydatek od przychodu ???
            foreach (operacje o in dane_do_wykresu)
            {
                if (!rok_suma.ContainsKey((DateTime)o.data))
                {
                    rok_suma[(DateTime)o.data] = 0;
                }
                rok_suma[(DateTime)o.data] += o.kwota;
            }
            System.Windows.Forms.DataVisualization.Charting.Series months = new System.Windows.Forms.DataVisualization.Charting.Series();
            months.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            //months.Points.DataBindXY(months_names, new double[] { 1234, 2345, 3456, 4567,5678,6543,5423,4321,1432,2314,5321,7654 });
            months.Points.DataBindXY(rok_suma.Keys, rok_suma.Values);
           
            months.ChartArea = "miesiąc";

            chart3.Series.Clear();

            chart3.Series.Add(months);


        }
    }
}
