using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _027_ThreeListbox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label3.Text = "SelectedIndex";
            label4.Text = "SelectedItem";
            listBox2.Items.Add("호주 시드니");
            listBox2.Items.Add("독일 베를린");
            listBox2.Items.Add("대한민국 서울");
            listBox2.Items.Add("프랑스 파리");
            listBox2.Items.Add("독일 프랑크푸르트");
            listBox2.Items.Add("호주 멜버튼");
            listBox2.Items.Add("미국 뉴욕");
            listBox2.Items.Add("싱가포르 싱가포르");
            listBox2.Items.Add("영국 런던");
            listBox2.Items.Add("일본 도쿄");

            List<string> lstGDP = new List<string>() { "미국", "러시아", "중국", "영국", "독일",
            "프랑스", "이스라엘", "사우디아라비아", "UAE"};
            listBox3.DataSource = lstGDP;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox lst = sender as ListBox;
            txt_SIndex1.Text = lst.SelectedIndex.ToString();
            txt_SItem1.Text = lst.SelectedItem.ToString();
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox lst = sender as ListBox;
            txt_SIndex2.Text = lst.SelectedIndex.ToString();
            txt_SItem2.Text = lst.SelectedItem.ToString();
        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox lst = sender as ListBox;
            txt_SIndex3.Text = lst.SelectedIndex.ToString();
            txt_SItem3.Text = lst.SelectedItem.ToString();
        }
    }
}
