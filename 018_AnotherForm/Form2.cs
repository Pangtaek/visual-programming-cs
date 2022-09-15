using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _018_AnotherForm
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            button1.Text = "exit";
             CenterToParent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
