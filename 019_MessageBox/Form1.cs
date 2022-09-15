using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _019_MessageBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MessageBox.Show("messagebox");
            MessageBox.Show("messagebox", "title");
            DialogResult answer1 = MessageBox.Show("messagebox", "title", MessageBoxButtons.YesNo);
            DialogResult answer2 = MessageBox.Show("messagebox", "title", 
                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            DialogResult answer3 = MessageBox.Show("messagebox", "title", MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            MessageBox.Show("messagebox", "title", MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Exclamation);
            string msg = string.Format("Your choose {0}, {1}, {2}",
                answer1.ToString(), answer2.ToString(), answer3.ToString());
            MessageBox.Show(msg);

        }
    }
}
