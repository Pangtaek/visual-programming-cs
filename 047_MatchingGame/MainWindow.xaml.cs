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

namespace _047_MatchingGame
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        int[] rnd = new int[16];                                    // TagSet()에서 사용할 배열.
        DispatcherTimer myTimer = new DispatcherTimer();            // using System.Windows.Threading;
        public MainWindow()
        {
            InitializeComponent();
            BoardSet();
            myTimer.Interval = new TimeSpan(0, 0, 0, 0, 750);
            myTimer.Tick += MyTimer_Tick;
        }

        private void MyTimer_Tick(object sender, EventArgs e)
        {
            myTimer.Stop();
            first.Content = MakeImage("../../Images/check.png");
            second.Content = MakeImage("../../Images/check.png");
            first = null;
            second = null;
        }

        private void BoardSet()
        {
            for(int i=0; i<16; i++)
            {
                Button btn = new Button();
                btn.Background = Brushes.White;
                btn.Margin = new Thickness(10);
            
                btn.Tag = TagSet();       // 랜덤하고 각 숫자가 2개씩
                btn.Content = MakeImage("../../Images/check.png");    // 난수로 바꾸고 그림으로 대채됨.

                // 버튼 클릭 이벤트
                btn.Click += Btn_Click;

                board.Children.Add(btn);
            }
        }
        Button first = null;
        Button second = null;
        private int matched = 0;

        private void Btn_Click(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            string[] icon = { "딸기", "레몬", "모과", "배", "사과", "수박", "파인애플", "포도" };
            string fruitName = icon[(int)btn.Tag];

            if (first == null)
            {
                first = btn;
                btn.Content = MakeImage("../../Images/" + fruitName + ".png");
                return;
            }
            else if (second == null)       // 지금 누른 버튼이 두번째 버튼이라면
            {
                second = btn;
                btn.Content = MakeImage("../../Images/" + fruitName + ".png");
            }
            else
                return;

            // 비교하기
            if((int)first.Tag == (int)second.Tag)
            {
                first = null;
                second = null;
                matched += 2;   // 매칭된 버튼의 개수
                if (matched >= 16)
                {
                    MessageBoxResult res =
                        MessageBox.Show("성공! 다시 하겠습니까?", "성공!", MessageBoxButton.YesNo);
                    if (res == MessageBoxResult.Yes) // 초기화
                    {
                        RndReset();
                        BoardReset();
                        BoardSet();
                        matched = 0;
                    }
                    else
                        this.Close();
                }
            }
            else        // 같지 않다면
            {
                myTimer.Start();
            }
        }

        private void BoardReset()
        {
            board.Children.Clear();
        }

        private void RndReset()
        {
            for(int i =0; i<16; i++)
                rnd[i] = 0;
        }

        private Image MakeImage(string v)
        {
            BitmapImage bi = new BitmapImage();
            bi.BeginInit();
            bi.UriSource = new Uri(v, UriKind.Relative);
            bi.EndInit();

            Image myImage = new Image();
            myImage.Margin = new Thickness(10);
            myImage.Stretch = Stretch.Fill;
            myImage.Source = bi;

            return myImage;
        }

        // 0~7까지의 그림 종류에 해당하는 번호
        // 각 번호는 2개씩 할당되어야 함.
        private int TagSet()
        {
            Random r = new Random();
            while (true)
            {
                int n = r.Next(16);     // 0~15까지의 숫자.
                if (rnd[n] == 0)        // 처음 나온 숫자?
                {
                    rnd[n] = 1;
                    return n % 8;
                }
            }
        }
    }
}
