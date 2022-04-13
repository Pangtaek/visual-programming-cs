using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _022_FavoriteFruit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_choose_Click(object sender, EventArgs e)
        {
            string checkStates = "";
            CheckBox[] cBox = { cbox_strawberry, cbox_pear, cbox_apple, cbox_mango, cbox_banana };
            foreach (var fruit in cBox)
                checkStates += string.Format("{0} : {1} \n", fruit.Text, fruit.Checked);
            MessageBox.Show(checkStates, "Summary");

            string summary = string.Format("좋아하는 과일 : ");
            foreach(var fruit in cBox)
            {
                if (fruit.Checked == true)
                    summary += fruit.Text + "\n";
            }
            MessageBox.Show(summary, "summary");
        }
    }
}
