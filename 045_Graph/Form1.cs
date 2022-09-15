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

namespace _045_Graph
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "Graph using Chart Control";
        }

        protected override void OnPaint(PaintEventArgs e)   // Paint 이벤트 발생 -> OnPaint메소드 실행
        {
            base.OnPaint(e);
            chart1.ChartAreas[0].BackColor = Color.Black;
            // x축
            chart1.ChartAreas[0].AxisX.Minimum = -20;
            chart1.ChartAreas[0].AxisX.Maximum = 20;
            chart1.ChartAreas[0].AxisX.Interval = 2;
            chart1.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.Gray;
            chart1.ChartAreas[0].AxisX.MajorGrid.LineDashStyle = ChartDashStyle.Dash;

            // y축
            chart1.ChartAreas[0].AxisY.Minimum = -2;
            chart1.ChartAreas[0].AxisY.Maximum = 2;
            chart1.ChartAreas[0].AxisY.Interval = 0.5;
            chart1.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.Gray;
            chart1.ChartAreas[0].AxisY.LineDashStyle = ChartDashStyle.Dash;

            // Series 설정(sin)
            chart1.Series[0].ChartType = SeriesChartType.Line;
            chart1.Series[0].Color = Color.LightGreen;
            chart1.Series[0].BorderWidth = 2;
            chart1.Series[0].LegendText = "sin(x) / x";

            // Series 설정(cos)
            if (chart1.Series.Count == 1)   // form의 크기를 늘렸을때의 오류 방지
                chart1.Series.Add("cos");
            chart1.Series[1].ChartType = SeriesChartType.Line;
            chart1.Series[1].Color = Color.Orange;
            chart1.Series[1].BorderWidth = 2;
            chart1.Series[1].LegendText = "cos(x) / x";

            // Series에 Data 추가
            for(double x = -20; x<20; x += 0.1)
            {
                double y = Math.Sin(x) / x;
                chart1.Series[0].Points.AddXY(x, y);

                y = Math.Cos(x) / x;
                chart1.Series[1].Points.AddXY(x, y);
            }

            // sin(x) / x 그래프
            chart1.ChartAreas.Add("ChartArea2");
            chart1.ChartAreas[1].BackColor = Color.Black;

            chart1.ChartAreas[1].AxisX.Minimum = 0;
            chart1.ChartAreas[1].AxisX.Maximum = 20;
            chart1.ChartAreas[1].AxisX.Interval = 1;
            chart1.ChartAreas[1].AxisX.MajorGrid.LineColor = Color.Gray;
            chart1.ChartAreas[1].AxisX.MajorGrid.LineDashStyle = ChartDashStyle.Dash;

            chart1.ChartAreas[1].AxisY.Minimum = -0.4;
            chart1.ChartAreas[1].AxisY.Maximum = 1;
            chart1.ChartAreas[1].AxisY.Interval = 0.2;
            chart1.ChartAreas[1].AxisY.MajorGrid.LineColor = Color.Gray;
            chart1.ChartAreas[1].AxisY.LineDashStyle = ChartDashStyle.Dash;

            chart1.Series.Add("sin2");
            chart1.Series[2].ChartArea = "ChartArea2";

            chart1.Series[2].ChartType = SeriesChartType.Line;
            chart1.Series[2].Color = Color.LightGreen;
            chart1.Series[2].BorderWidth = 2;
            chart1.Series[2].LegendText = "sin(x) / x";
            chart1.Series[2].IsVisibleInLegend = false;     // 범례 숨김

            for (double x = 0; x < 20; x += 0.1)
            {
                double y = Math.Sin(x) / x;
                chart1.Series[2].Points.AddXY(x, y);
            }
        }
    }
}
