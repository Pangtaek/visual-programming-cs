using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _020_Basic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_btn_Click(object sender, EventArgs e)
        {
            if (txt_name.Text != "")
                lbl_answer.Text = txt_name.Text + "님! 안녕하세요!";
            else
                MessageBox.Show("input your name");
        }
    }
}
