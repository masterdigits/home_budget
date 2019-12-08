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
        public uc_wykres_kolumnowy()
        {
            InitializeComponent();
        }

        public void draw_year_chart() 
        {
            chart1.ChartAreas.Add(new System.Windows.Forms.DataVisualization.Charting.ChartArea("rok"));

            System.Windows.Forms.DataVisualization.Charting.Series years = new System.Windows.Forms.DataVisualization.Charting.Series();
            years.Points.DataBindXY(new double[] { 2015, 2016, 2017, 2018 }, new double[] { 34567, 35678, 36789, 41235 });
            years.ChartArea = "rok";

            chart1.Series.Clear();

            chart1.Series.Add(years);
        }

        public void draw_month_chart()
        {
            String[] months_names = { "styczeń", "luty", "marzec", "kwiecień", "maj", "czerwiec", "lipiec", "sierpień", "wrzesień", "październik", "listopad", "grudzień" };
            chart2.ChartAreas.Add(new System.Windows.Forms.DataVisualization.Charting.ChartArea("miesiąc"));

            System.Windows.Forms.DataVisualization.Charting.Series months = new System.Windows.Forms.DataVisualization.Charting.Series();
            months.Points.DataBindXY(months_names, new double[] { 1234, 2345, 3456, 4567,5678,6543,5423,4321,1432,2314,5321,7654 });
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
    }
}
