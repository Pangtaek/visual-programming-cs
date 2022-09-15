using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _024_Score
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_calculate_Click(object sender, EventArgs e)
        {
            double sum = double.Parse(txt_kor.Text) + double.Parse(txt_eng.Text) + double.Parse(txt_math.Text);
            double avg = sum / 3;

            txt_sum.Text = sum.ToString();
            txt_avg.Text = avg.ToString("0.0");
        }
    }
}
