using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _026_ScoreCal
{
    public partial class Form1 : Form
    {
        TextBox[] titles;
        ComboBox[] crds;
        ComboBox[] grds;
        public Form1()
        {
            InitializeComponent();
            lbl_result.Text = "학점";
            btn_result.Text = "계산";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txt_course1.Text = "인체의구조와기능1";
            txt_course2.Text = "기업가정신";
            txt_course3.Text = "데이터사이언스";
            txt_course4.Text = "일반수학";
            txt_course5.Text = "중국어1";
            txt_course6.Text = "비주얼프로그래밍";
            txt_course7.Text = "컴퓨터2-스프레드시트";

            crds = new ComboBox[] { cmb_1, cmb_2, cmb_3, cmb_4, cmb_5, cmb_6, cmb_7 };
            grds = new ComboBox[] { cmb_8, cmb_9, cmb_10, cmb_11, cmb_12, cmb_13, cmb_14 };
            titles = new TextBox[] { txt_course1, txt_course2, txt_course3, txt_course4,
                    txt_course5, txt_course6, txt_course7};
            int[] arrCredit = { 1, 2, 3, 4, 5 };
            List<string> lstGrade = new List<string> { "A+", "A0", "B+", "B0", "C+", "C0", "D+", "D0", "F" };

            foreach(var crd in crds)
            {
                foreach (var i in arrCredit)
                    crd.Items.Add(i);
                crd.SelectedItem = 3;
            }

            foreach (var grd in grds)
            {
                foreach (var i in lstGrade)
                    grd.Items.Add(i);
                grd.SelectedItem = "A+";
            }
        }

        private void btn_result_Click(object sender, EventArgs e)
        {
            double totalScore = 0;
            int totalCredits = 0;

            for(int i = 0; i < titles.Length; i++)
            {
                if(titles[i].Text != "")
                {
                    totalCredits += int.Parse(crds[i].SelectedItem.ToString());
                    totalScore += int.Parse(crds[i].SelectedItem.ToString()) * GetGrade(grds[i].SelectedItem.ToString());
                }
            }
            txt_result.Text = (totalScore / totalCredits).ToString("0.00");
        }

        private double GetGrade(string v)
        {
            if (v == "A+")
                return 4.5;
            else if (v == "A0")
                return 4.0;
            else if (v == "B+")
                return 3.5;
            else if (v == "B0")
                return 3.0;
            else if (v == "C+")
                return 2.5;
            else if (v == "C0")
                return 2.0;
            else if (v == "D+")
                return 1.5;
            else if (v == "D0")
                return 1.0;
            else
                return 0;
        }
    }
}
