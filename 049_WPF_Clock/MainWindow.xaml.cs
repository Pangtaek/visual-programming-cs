using System;
using System.Windows;
using System.Windows.Media;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace _049_WPF_Clock
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        Point center;
        int radius;
        int hourHand, minHand, secHand;
        // using System.Windows.Threading;
        DispatcherTimer timer;
        bool analog_Flag = true;        // true : analog    false : digital
        bool millSec_Flag = false;      // true : 밀리초   false : 초
        public MainWindow()
        {
            InitializeComponent();
            analogClockSetting();
            timerSetting();
        }

        private void timerSetting()
        {
            timer = new DispatcherTimer();
            timer.Interval = new TimeSpan(0, 0, 0, 1);  // day, hour, min, sec, millsec
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            DateTime c = DateTime.Now;
            canvas1.Children.Clear();
            if (analog_Flag == true)
            {
                // 아날로그 시계판 그리기
                DrawClockFace();

                // 시침, 분침, 초침의 각도 구하기
                double degreeHour = (c.Hour % 12) * 30 + c.Minute * 0.5;
                double degreeMin = (c.Minute * 6 + c.Second * 0.1);
                double degreeSec = degreeSec = c.Second * 6 + c.Millisecond * 6.0 / 1000; ;
                //if (millSec_Flag == true)
                //    degreeSec = c.Second * 6 + c.Millisecond * 6.0 / 1000;
                //else
                //    degreeSec = c.Second * 6;
                // 라디안으로 변환
                double radHour = Math.PI * degreeHour / 180;
                double radMin = Math.PI * degreeMin / 180;
                double radSec = Math.PI * degreeSec / 180;

                // 시간에 따라 시계바늘을 그린다.
                DrawHands(radHour, radMin, radSec);
            }
            else
            {
                txtDate.Text = DateTime.Today.ToString("D");
                if (millSec_Flag == false)
                    txtTime.Text = String.Format("{0:D2} : {1:D2} : {2:D2}", c.Hour, c.Minute, c.Second);
                else
                    txtTime.Text = String.Format("{0:D2} : {1:D2} : {2:D2}.{3:D3}", c.Hour, c.Minute, c.Second, c.Millisecond);
            }
        }

        // 시계바늘 그리기
        private void DrawHands(double radHour, double radMin, double radSec)
        {
            // 시침
            DrawLine((int)(hourHand * Math.Sin(radHour)), (int)(hourHand * Math.Cos(radHour) * -1), 0, 0, Brushes.RoyalBlue, 12, center.X, center.Y);
            // 분침
            DrawLine((int)(minHand * Math.Sin(radMin)), (int)(minHand * Math.Cos(radMin) * -1), 0, 0, Brushes.SkyBlue, 8, center.X, center.Y);
            // 초침
            DrawLine((int)(secHand * Math.Sin(radSec)), (int)(secHand * Math.Cos(radSec) * -1), 0, 0, Brushes.OrangeRed, 5, center.X, center.Y);
            // 배꼽
            int coreSize = 16;
            Ellipse core = new Ellipse();
            core.Margin = new Thickness(center.X - coreSize / 2, center.Y - coreSize / 2, 0, 0);
            core.Stroke = Brushes.DarkRed;
            core.StrokeThickness = 3;
            core.Fill = Brushes.Gold;
            core.Width = coreSize;
            core.Height = coreSize;
            canvas1.Children.Add(core);
        }

        // 시계바늘 그리기(DrawHands -> DrawLine)
        private void DrawLine(int x1, int y1, int x2, int y2, Brush color, int thick, double Cx, double Cy)
        {
            Line line = new Line();
            line.X1 = x1;
            line.Y1 = y1;
            line.X2 = x2;
            line.Y2 = y2;
            line.Stroke = color;
            line.StrokeThickness = thick;
            line.Margin = new Thickness(Cx, Cy, 0, 0);
            line.StrokeStartLineCap = PenLineCap.Round;
            canvas1.Children.Add(line);
        }

        private void Analog_Click(object sender, RoutedEventArgs e)
        {
            analog_Flag = true;
            txtDate.Text = "";
            txtTime.Text = "";
        }

        private void Digital_Click(object sender, RoutedEventArgs e)
        {
            analog_Flag = false;
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Sec_Click(object sender, RoutedEventArgs e)
        {
            millSec_Flag = false;
            timer.Interval = new TimeSpan(0, 0, 0, 1);  // 1sec
        }

        private void MillSec_Click(object sender, RoutedEventArgs e)
        {
            millSec_Flag = true;
            timer.Interval = new TimeSpan(0, 0, 0, 0, 10);     // 0.01sec
        }

        private void DrawClockFace()
        {
            // Stroke = 윤곽선
            analogClock.Stroke = Brushes.LightSteelBlue;
            analogClock.StrokeThickness = 30;
            canvas1.Children.Add(analogClock);
        }

        private void analogClockSetting()
        {
            center = new Point(canvas1.Width / 2, canvas1.Height / 2);
            radius = (int)(canvas1.Width / 2);
            hourHand = (int)(radius * 0.45);
            minHand = (int)(radius * 0.55);
            secHand = (int)(radius * 0.65);
        }
    }
}
