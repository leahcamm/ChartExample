using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

/*
 * From https://www.youtube.com/watch?v=2xs7JNW549o&t=195s
 * 
 * Downloaded code from:
 * https://www.dropbox.com/s/qeuy5konx1429jd/DataVisualization%20Chart.rar?dl=0
 */

namespace DataVisualization_Chart
{
    public partial class ChartExample : Form
    {
        string name = "myData";
        List<double> x = new List<double>();
        List<double> y = new List<double>();
        public ChartExample()
        {
            Random rng = new Random();
            InitializeComponent();
            string[] charttype = new string[] { "Area", "Bar", "Bubble", "Column", "Doughnut", "Line", "Point", "Funnel",
                "RangeBar", "Spline", "SplineArea", "StepLine" };
            comboBox1.Items.AddRange(charttype);
            int points = 1000;
            int range = 20;
            for (int i = 0; i < points; i++)
            {
                x.Add(i - points/2);
                //y.Add(Math.Pow((i - 10), 2));
                //x.Add(rng.Next(-100, 101));
                y.Add(rng.Next(-range, range));
            }
        }

        private void plot_Click(object sender, EventArgs e)
        {
            chart1.BackColor = Color.LightBlue;
            chart1.Series.Add(name);
            chart1.Series[name].Color = Color.DarkSlateGray;
            // chart1.Series[name].Label = "Y = #"+Y_Label+"\nX = #"+X_Label;
            chart1.ChartAreas[0].AxisX.TitleForeColor = Color.Gold;

            chart1.Series[name].Points.DataBindXY(x, y);
            chart1.Series[name].ChartArea = "ChartArea1";
            chart1.Series[name].SetDefault(true);
            chart1.Series[name].Enabled = true;
            chart1.Visible = true;
            chart1.Show();
            comboBox1.Enabled = true;
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string s = comboBox1.SelectedItem.ToString();
            switch (s)
            {
                case "Area":
                    chart1.Series[name].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
                    chart1.ChartAreas[0].AxisX.Minimum = x.Min();
                    chart1.ChartAreas[0].AxisX.Interval = 1;
                    break;
                case "Bar":
                    chart1.Series[name].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
                    chart1.ChartAreas[0].AxisX.Minimum = x.Min();;
                    chart1.ChartAreas[0].AxisX.Interval = 1;
                    break;
                case "Bubble":
                    chart1.Series[name].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bubble;
                    chart1.ChartAreas[0].AxisX.Minimum = x.Min();;
                    chart1.ChartAreas[0].AxisX.Interval = 1;
                    break;
                case "Column":
                    chart1.Series[name].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
                    chart1.ChartAreas[0].AxisX.Minimum = x.Min();;
                    chart1.ChartAreas[0].AxisX.Interval = 1;
                    break;
                case "Doughnut":
                    chart1.Series[name].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
                    chart1.ChartAreas[0].AxisX.Minimum = x.Min();;
                    chart1.ChartAreas[0].AxisX.Interval = 1;
                    break;
                case "Line":
                    chart1.Series[name].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                    chart1.ChartAreas[0].AxisX.Minimum = x.Min();;
                    chart1.ChartAreas[0].AxisX.Interval = 1;
                    break;
                case "Point":
                    chart1.Series[name].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
                    chart1.ChartAreas[0].AxisX.Minimum = x.Min();;
                    chart1.ChartAreas[0].AxisX.Interval = 1;
                    break;
                case "Funnel":
                    chart1.Series[name].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Funnel;
                    chart1.ChartAreas[0].AxisX.Minimum = x.Min();;
                    chart1.ChartAreas[0].AxisX.Interval = 1;
                    break;
                case "RangeBar":
                    chart1.Series[name].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.RangeBar;
                    chart1.ChartAreas[0].AxisX.Minimum = x.Min();;
                    chart1.ChartAreas[0].AxisX.Interval = 1;
                    chart1.ChartAreas[0].AxisX.Maximum =x.Max();
                    break;
                case "Spline":
                    chart1.Series[name].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
                    chart1.ChartAreas[0].AxisX.Minimum = x.Min();;
                    chart1.ChartAreas[0].AxisX.Interval = 1;
                    break;
                case "SplineArea":
                    chart1.Series[name].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea;
                    chart1.ChartAreas[0].AxisX.Minimum = x.Min();;
                    chart1.ChartAreas[0].AxisX.Interval = 1;
                    break;
                case "StepLine":
                    chart1.Series[name].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StepLine;
                    chart1.ChartAreas[0].AxisX.Minimum = x.Min();;
                    chart1.ChartAreas[0].AxisX.Interval = 1;
                    break;
            }
        }
    }
}
