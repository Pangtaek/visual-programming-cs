using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace _050_Rotationg_Clock
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        private double hourDegree;
        private double minDegree;
        private double secDegree;

        public MainWindow()
        {
            InitializeComponent();
            // 시계판
            DrawFace();
            // 시계바늘
            MakeClockHands();
            // 타이머  using System.Windows.Threading;
            DispatcherTimer dt = new DispatcherTimer();
            dt.Interval = new TimeSpan(0, 0, 0, 0, 10);
            dt.Tick += Dt_Tick;
            dt.Start();
        }

        private void MakeClockHands()
        {
            int w = 300;
            int h = 300;

            secHand.X1 = w / 2;     // 시계 중심
            secHand.Y1 = h / 2;     // 시계 중심
            secHand.X2 = w / 2;
            secHand.Y2 = 20;

            minHand.X1 = w / 2;     // 시계 중심
            minHand.Y1 = h / 2;     // 시계 중심
            minHand.X2 = w / 2;
            minHand.Y2 = 40;

            hourHand.X1 = w / 2;     // 시계 중심
            hourHand.Y1 = h / 2;     // 시계 중심
            hourHand.X2 = w / 2;
            hourHand.Y2 = 60;
        }

        // 눈금을 가진 시계판
        private void DrawFace()
        {
            Line[] marking = new Line[60];
            // 시계 크기
            int w = 300;
            
            for(int i = 0; i<60; i++)
            {
                marking[i] = new Line();
                marking[i].Stroke = Brushes.LightSteelBlue;
                marking[i].X1 = w / 2;
                marking[i].Y1 = 2;
                marking[i].X2 = w / 2;
                // 큰눈금
                if (i % 5 == 0)
                {
                    marking[i].Y2 = 20;
                    marking[i].StrokeThickness = 5;
                }
                // 작은눈금
                else
                {
                    marking[i].Y2 = 10;
                    marking[i].StrokeThickness = 2;
                }

                RotateTransform rt = new RotateTransform(6 * i);
                rt.CenterX = w / 2;
                rt.CenterY = w / 2;
                marking[i].RenderTransform = rt;
                analogClick.Children.Add(marking[i]);
            }
        }

        private void Dt_Tick(object sender, EventArgs e)
        {
            int w = 300;
            DateTime c = DateTime.Now;
            int hour = c.Hour;
            int min = c.Minute;
            int sec = c.Second;
            
            hourDegree = hour * 30 + min * 0.5;
            minDegree = min * 6;
            secDegree = sec * 6 + c.Millisecond * 0.006;

            RotateTransform rtH = new RotateTransform(hourDegree);
            rtH.CenterX = w / 2;
            rtH.CenterY = w / 2;
            hourHand.RenderTransform = rtH;

            RotateTransform rtM = new RotateTransform(minDegree);
            rtM.CenterX = w / 2;
            rtM.CenterY = w / 2;
            minHand.RenderTransform = rtM;

            RotateTransform rtS = new RotateTransform(secDegree);
            rtS.CenterX = w / 2;
            rtS.CenterY = w / 2;
            secHand.RenderTransform = rtS;
        }
    }
}
