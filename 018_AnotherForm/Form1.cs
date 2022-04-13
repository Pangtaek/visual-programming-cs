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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.Text = "Form2 생성";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form form2 = new Form2();
            this.AddOwnedForm(form2);
            form2.Show();
        }
    }
}
