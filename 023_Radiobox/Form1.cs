using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _023_Radiobox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_choose_Click(object sender, EventArgs e)
        {
            string result = "";
            if (rbtn_kor.Checked)
                result += "국적 : 한국\n";
            else if (rbtn_cha.Checked)
                result += "국적 : 중국\n";
            else if (rbtn_jp.Checked)
                result += "국적 : 일본\n";
            else if (rbtn_another.Checked)
                result += "국적 : 그 외\n";

            if (rbtn_male.Checked)
                result += "성별 : 남성";
            else if (rbtn_female.Checked)
                result += "성별 : 여성";

            MessageBox.Show(result);

        }
    }
}
