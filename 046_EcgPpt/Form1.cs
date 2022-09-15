using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
// 노란전구 -> 불필요한 using제거 -> using(11개->5개)

namespace _046_EcgPpt
{
    public partial class Form1 : Form
    {
        private double[] ecg = new double[100000];
        private double[] ppg = new double[100000];
        private int ecgCount;       // ecg 데이터 개수
        private int ppgCount;       // ppg 데이터 개수
        private Timer t = new Timer();
        public Form1()
        {
            InitializeComponent();
            this.Text = "ECG/PPG";
            this.WindowState = FormWindowState.Maximized;

            EcgRead();
            PpgRead();
            ChartSetting();
            t.Interval = 10;        // 0.01초
            t.Tick += T_Tick;
        }

        int cursorX = 0;            // 디스플레이되는 데이터의 시작점
        bool scrolling = false;     // 스크롤 가능 = true
        private int speed = 2;
        private void T_Tick(object sender, EventArgs e)
        {
            // 한 화면의 500개의 데이터를 보여줄 예정
            if (cursorX + 500 < ecgCount)
                chart1.ChartAreas[0].AxisX.ScaleView.Zoom(cursorX, cursorX + 500);
            else
                t.Stop();
            cursorX += speed;
        }

        private void ChartSetting()
        {
            // chart 영역 설정
            // 커서 사용 가능
            chart1.ChartAreas[0].CursorX.IsUserEnabled = true;
            // zoom 범위 선택 가능
            chart1.ChartAreas[0].CursorX.IsUserSelectionEnabled = true;

            // chart 영역 설정
            chart1.ChartAreas[0].BackColor = Color.Black;
            chart1.ChartAreas[0].AxisX.Minimum = 0;
            chart1.ChartAreas[0].AxisX.Maximum = ecgCount;
            chart1.ChartAreas[0].AxisX.Interval = 50;
            chart1.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.Gray;
            chart1.ChartAreas[0].AxisX.MajorGrid.LineDashStyle = ChartDashStyle.Dash;   // using System.Windows.Forms.DataVisualization.Charting

            chart1.ChartAreas[0].AxisY.Minimum = -2;
            chart1.ChartAreas[0].AxisY.Maximum = 6;
            chart1.ChartAreas[0].AxisY.Interval = 0.5;
            chart1.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.Gray;
            chart1.ChartAreas[0].AxisY.MajorGrid.LineDashStyle = ChartDashStyle.Dash;

            // Series 2개 새로 만들기
            chart1.Series.Clear();
            chart1.Series.Add("ECG");
            chart1.Series.Add("PPG");

            chart1.Series[0].ChartType = SeriesChartType.Line;
            chart1.Series[0].Color = Color.Orange;
            chart1.Series[0].BorderWidth = 2;
            chart1.Series[0].LegendText = "ECG";

            chart1.Series[1].ChartType = SeriesChartType.Line;
            chart1.Series[1].Color = Color.LightGreen;
            chart1.Series[1].BorderWidth = 2;
            chart1.Series[1].LegendText = "PPG";

            // 데이터를 series에 추가
            foreach(var v in ecg)
            {
                chart1.Series[0].Points.Add(v);
            }

            foreach(var v in ppg)
            {
                chart1.Series[1].Points.Add(v);
            }
        }

        private void PpgRead()
        {
            string fileName = "../../Data/PPG.txt";
            string[] lines = File.ReadAllLines(fileName);   // using system.IO

            double min = double.MaxValue;
            double max = double.MinValue;

            int i = 0;
            foreach (var line in lines)
            {
                ppg[i] = double.Parse(line);
                if (ppg[i] < min) min = ppg[i];
                if (ppg[i] > max) max = ppg[i];
                i++;
            }
            ppgCount = i;
            string s = string.Format("ppg : Count = {0}, min = {1}, max = {2}", ppgCount, min, max);
            MessageBox.Show(s);
        }

        private void EcgRead()
        {
            string fileName = "../../Data/ecg.txt";
            string[] lines = File.ReadAllLines(fileName);   // using system.IO

            double min = double.MaxValue;
            double max = double.MinValue;

            int i = 0;
            foreach(var line in lines)
            {
                ecg[i] = double.Parse(line) + 3;      // 차트에 겹치기 때문에 분리를 위해 + 3
                if (ecg[i] < min) min = ecg[i];
                if (ecg[i] > max) max = ecg[i];
                i++;
            }
            ecgCount = i;
            string s = string.Format("ECG : Count = {0}, min = {1}, max = {2}", ecgCount, min, max);
            MessageBox.Show(s);
        }

        private void atoScrollToolStripMenuItem_Click(object sender, EventArgs e)
        {
            t.Start();
            scrolling = true;
        }

        private void viewAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chart1.ChartAreas[0].AxisX.ScaleView.Zoom(0, ecgCount);
            t.Stop();
            scrolling = false;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        bool isTimerRunning = true;
        private int dataCount = 500;
        private void chart1_Click(object sender, EventArgs e)
        {
            if (isTimerRunning)
            {
                t.Stop();
                isTimerRunning = false;
            }
            else
            {
                t.Start();
                isTimerRunning = true;
            }
        }

        private void chart1_MouseClick(object sender, MouseEventArgs e)
        {
            HitTestResult htr = chart1.HitTest(e.X, e.Y);
            if(htr.ChartElementType == ChartElementType.DataPoint)
            {
                t.Stop();
                string s = string.Format("Count : {0}, ECG : {1}, PPG : {2}",
                    htr.PointIndex,
                    chart1.Series[0].Points[htr.PointIndex].YValues[0],
                    chart1.Series[1].Points[htr.PointIndex].YValues[0]);
                MessageBox.Show(s);
            }
        }

        // 차트에서 zoom 했을 때
        private void chart1_SelectionRangeChanged(object sender, CursorEventArgs e)
        {
            int min = (int)(chart1.ChartAreas[0].AxisX.ScaleView.ViewMinimum);
            int max = (int)(chart1.ChartAreas[0].AxisX.ScaleView.ViewMaximum);

            cursorX = min;
            dataCount = max - min;
        }

        private void speedUpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            speed *= 2;
        }

        private void speedDownToolStripMenuItem_Click(object sender, EventArgs e)
        {
            speed /= 2;
        }
    }
}
