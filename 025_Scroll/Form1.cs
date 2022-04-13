using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _025_Scroll
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.BackColor = Color.Khaki;
            panel1.BackColor = Color.FromArgb(0, 0, 0);
            txt_red.Text = 0.ToString();
            txt_green.Text = 0.ToString();
            txt_blue.Text = 0.ToString();
            hScrollBar_Red.Maximum = 255 + 9;
            hScrollBar_Green.Maximum = 255 + 9;
            hScrollBar_Blue.Maximum = 255 + 9;
        }

        private void scr_Scroll(object sender, ScrollEventArgs e)
        {
            txt_red.Text = hScrollBar_Red.Value.ToString();
            txt_green.Text = hScrollBar_Green.Value.ToString();
            txt_blue.Text = hScrollBar_Blue.Value.ToString();

            panel1.BackColor = Color.FromArgb(hScrollBar_Red.Value, hScrollBar_Green.Value, hScrollBar_Blue.Value);
        }

        private void txt_blue_TextChanged(object sender, EventArgs e)
        {
            if(txt_red.Text != "" && txt_blue.Text != "" && txt_green.Text != "")
            {
                hScrollBar_Red.Value = int.Parse(txt_red.Text);
                hScrollBar_Green.Value = int.Parse(txt_green.Text);
                hScrollBar_Blue.Value = int.Parse(txt_blue.Text);

                panel1.BackColor = Color.FromArgb(hScrollBar_Red.Value, hScrollBar_Green.Value, hScrollBar_Green.Value);
            }
        }
    }
}
