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

namespace _038_WIndowCal
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        private bool opFlag;
        private double saved;
        private string op;
        private bool afterCalc;
        private double memory;
        private bool memFlag;

        public MainWindow()
        {
            InitializeComponent();

            btnMC.IsEnabled = false;
            btnMR.IsEnabled = false;
        }

        // 숫자버튼
        private void btn_Click(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;      // (Button)sender; 같은 의미
            string s = btn.Content.ToString();

            if (txtResult.Text == "0" || opFlag == true || afterCalc==true || memFlag == true)
            {
                afterCalc = false;
                opFlag = false;
                memFlag = false;
                txtResult.Text = s;
            }
            else
                txtResult.Text += s;
        }

        // 소수점 버튼
        private void btnDot_Click(object sender, RoutedEventArgs e)
        {
            if (txtResult.Text.Contains("."))
                return;
            else
                txtResult.Text += ".";
        }
         
        // +-버튼
        private void btnPlusMinus_Click(object sender, RoutedEventArgs e)
        {
            txtResult.Text = (double.Parse(txtResult.Text) * -1).ToString();
        }

        // +, -, *, / 버튼
        private void op_Click(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            string s = btn.Content.ToString();

            txtEXP.Text = txtResult.Text + s;

            opFlag = true;
            saved = double.Parse(txtResult.Text);
            op = s;
        }

        private void btnEqual_Click(object sender, RoutedEventArgs e)
        {
            double v = double.Parse(txtResult.Text);
            txtEXP.Text += txtResult.Text + "=";
            switch(op)
            {
                case "＋":
                    txtResult.Text = (saved + v).ToString();
                    break;
                case "－":
                    txtResult.Text = (saved - v).ToString();
                    break;
                case "×":
                    txtResult.Text = (saved * v).ToString();
                    break;
                case "÷":
                    txtResult.Text = (saved / v).ToString();
                    break;
            }
            afterCalc = true;
        }

        // % 버튼
        private void btnPercent_Click(object sender, RoutedEventArgs e)
        {
            double p = double.Parse(txtResult.Text);
            p = saved * p / 100;
            txtResult.Text = p.ToString();
        }

        // 제곱근 버튼
        private void btnSqrt_Click(object sender, RoutedEventArgs e)
        {
            if (txtEXP.Text == "")
                txtEXP.Text = "√(" + txtResult.Text + ")";
            else
                txtEXP.Text = "√(" + txtEXP.Text + ")";

            txtResult.Text = (Math.Sqrt(double.Parse(txtResult.Text))).ToString();
        }

        // 제곱 버튼
        private void btnSqr_Click(object sender, RoutedEventArgs e)
        {
            if (txtEXP.Text == "")
                txtEXP.Text = "sqr(" + txtResult.Text + ")";
            else
                txtEXP.Text = "sqr(" + txtEXP.Text + ")";

            double v = double.Parse(txtResult.Text);
            txtResult.Text = (v * v).ToString();
        }

        // 1/x 버튼
        private void btnRecip_Click(object sender, RoutedEventArgs e)
        {
            if (txtEXP.Text == "")
                txtEXP.Text = "1/(" + txtResult.Text + ")";
            else
                txtEXP.Text = "sqr(" + txtEXP.Text + ")";

            double v = double.Parse(txtResult.Text);
            txtResult.Text = (1/v).ToString();
        }

        // CE 버튼
        private void btnCE_Click(object sender, RoutedEventArgs e)
        {
            txtResult.Text = "";
        }

        // C 버튼
        private void btnC_Click(object sender, RoutedEventArgs e)
        {
            txtResult.Text = "";
            txtEXP.Text = "";
            saved = 0;
            op = "";
            opFlag = false;
            afterCalc = false;
        }

        // Delete 버튼
        private void btnDelect_Click(object sender, RoutedEventArgs e)
        {
            txtResult.Text = txtResult.Text.Remove(txtResult.Text.Length - 1);
            if (txtResult.Text.Length == 0)
                txtResult.Text = "0";                
        }

        // MS 버튼
        private void btnMS_Click(object sender, RoutedEventArgs e)
        {
            memory = double.Parse(txtResult.Text);
            btnMR.IsEnabled = true;
            btnMC.IsEnabled = true;
            memFlag = true;
        }

        // MR 버튼
        private void btnMR_Click(object sender, RoutedEventArgs e)
        {
            txtResult.Text = memory.ToString();
            memFlag = true;
        }

        private void btnMC_Click(object sender, RoutedEventArgs e)
        {
            memory = 0;
            btnMC.IsEnabled = false;
            btnMR.IsEnabled = false;
        }

        // M+ 버튼
        private void btnMPluse_Click(object sender, RoutedEventArgs e)
        {
            memory += double.Parse(txtResult.Text);
        }

        // M- 버튼
        private void btnMMinus_Click(object sender, RoutedEventArgs e)
        {
            memory -= double.Parse(txtResult.Text);
        }

    }
}
