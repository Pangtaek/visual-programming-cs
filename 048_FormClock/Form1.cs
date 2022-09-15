using System;
using System.Drawing;
using System.Windows.Forms;

namespace _048_FormClock
{
    public partial class Form1 : Form
    {
        Graphics g;
        bool analogClock_Flag = true;
        Point center;                       // 시계의 중심점
        int radius;                         // 시계의 반지름
        private int faceSize;               // 시계판 크기의 절반
        int hourHand;                       // 시침의 길이
        int minHand;                        // 분침
        int secHand;                        // 초침
        Timer t = new Timer();
        public Form1()
        {
            InitializeComponent();

            this.Text = "Form Clock";
            this.ClientSize = new Size(300, 300);
            //flowLayoutPanel1.CreateGraphics();
            g = flowLayoutPanel1.CreateGraphics();

            AnalogClockSetting();
            TimerSetting();
        }

        private void TimerSetting()
        {
            t.Interval = 1000;              // 1sec
            t.Tick += T_Tick;
            t.Start();
        }

        private void T_Tick(object sender, EventArgs e)
        {
            DateTime c = DateTime.Now;
            flowLayoutPanel1.Refresh();         // 시계판 지우기
            if (analogClock_Flag == true)
            {
                DrawClockFace();                // 시계판 그리기

                // 시침, 분침, 초침의 각도 구하기
                double degreeHour = (c.Hour % 12) * 30 + c.Minute * 0.5;
                double degreeMin = (c.Minute * 6 + c.Second * 0.1);
                double degreeSec = c.Second * 6;

                // 라디안으로 변환
                double radHour = Math.PI * degreeHour / 180;
                double radMin = Math.PI * degreeMin / 180;
                double radSec = Math.PI * degreeSec / 180;

                DrawHands(radHour, radMin, radSec);
            }
            else
            {
                string date = DateTime.Today.ToString("D");
                string time = string.Format("{0:D2}:{1:D2}:{2:D2}", c.Hour, c.Minute, c.Second);
                g.DrawString(date, new Font("맑은 고딕", 12, FontStyle.Bold), Brushes.SkyBlue, new Point(center.X -85, center.Y - 30));
                g.DrawString(time, new Font("맑은 고딕", 32, FontStyle.Bold | FontStyle.Italic), Brushes.SteelBlue, new Point(center.X - 100, center.Y));
            }
        }

        // 시계바늘 그리기
        private void DrawHands(double radHour, double radMin, double radSec)
        {
            // 시침
            DrawLine((int)(hourHand * Math.Sin(radHour)),(int)(hourHand * Math.Cos(radHour)*-1), 0, 0, Brushes.RoyalBlue, 12, center.X, center.Y);
            // 분침
            DrawLine((int)(minHand * Math.Sin(radMin)), (int)(minHand * Math.Cos(radMin) * -1), 0, 0, Brushes.SkyBlue, 8, center.X, center.Y);
            // 초침
            DrawLine((int)(secHand * Math.Sin(radSec)), (int)(secHand * Math.Cos(radSec) * -1), 0, 0, Brushes.OrangeRed, 5, center.X, center.Y);
            // 배꼽
            int coreSize = 16;
            Rectangle r = new Rectangle(center.X-coreSize/2, center.Y-coreSize/2, coreSize, coreSize);
            g.FillEllipse(Brushes.Gold, r);
            Pen p = new Pen(Brushes.DarkRed, 3);
            g.DrawEllipse(p, r);
        }

        // 시계바늘 그리기(DrawHands -> DrawLine)
        private void DrawLine(int x1, int y1 , int x2, int y2, Brush color, int thick, int Cx, int Cy)
        {
            Pen pen = new Pen(color, thick);
            // pen의 시작이 round
            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            // pen의 끝이 round
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
            // graphs 라이브러리의 메소드 DrawLine
            g.DrawLine(pen, x1 + Cx, y1 + Cy, x2 + Cx, y2 + Cy);
        }

        // 시계판 그리기
        private void DrawClockFace()
        {
            Pen pen = new Pen(Brushes.LightSteelBlue, 30);
            // Ellipse = 타원
            g.DrawEllipse(pen, center.X - faceSize, center.Y - faceSize, (int)(faceSize * 2), (int)(faceSize * 2));
        }

        private void AnalogClockSetting()
        {
            center = new Point(flowLayoutPanel1.Width / 2, flowLayoutPanel1.Height / 2);
            radius = flowLayoutPanel1.Height / 2;
            faceSize = (int)(radius * 0.8);
            hourHand = (int)(radius * 0.45);
            minHand = (int)(radius * 0.55);
            secHand = (int)(radius * 0.65);
        }

        private void 아날로그ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            analogClock_Flag = true;
        }

        private void 디지털ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            analogClock_Flag = false;
        }

        private void 종료ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
