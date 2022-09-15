using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\Users\임광택\OneDrive\문서\SDB.accdb
namespace _040_PhoneBook
{
    public partial class Form1 : Form
    {
        OleDbConnection conn = null;
        OleDbCommand  comm = null;
        OleDbDataReader reader = null;
        string connStr = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\임광택\OneDrive\문서\SDB.accdb";

        public Form1()
        {
            InitializeComponent();
            ShowStudents();
        }

        // DB에서 학생정보를 익어와서 리스트박스에 표시
        private void ShowStudents()
        {
            if(conn == null)
            {
                conn = new OleDbConnection(connStr);
                conn.Open();
            }
            string sql = "SELECT * FROM StudentTable";
            comm = new OleDbCommand(sql, conn);
            reader = comm.ExecuteReader();
            lbStudent.Items.Add("ID" + '\t' + "SId" + '\t' + '\t' + "SName" + '\t' + "Phone");
            while (reader.Read())
            {
                string x = "";
                x += reader["ID"] + "\t";
                x += reader["SId"] + "\t";
                x += reader["SName"] + "\t";
                x += reader["Phone"];
                lbStudent.Items.Add(x);
            }
            reader.Close();
            conn.Close();
            conn = null;
        }

        private void lbStudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            // event를 보내는 sender = listbox
            ListBox lb = sender as ListBox;     // ListBox lb = (ListBox)sender;
            if (lb.SelectedItem == null)
                return;
            string[] s = lb.SelectedItem.ToString().Split('\t');
            txtID.Text = s[0];
            txtSId.Text = s[1];
            txtSName.Text = s[2];
            txtPhone.Text = s[3];
        }

        private void btnAdd_Old_Click(object sender, EventArgs e)
        {
            if (txtSId.Text == "" || txtSName.Text == "" || txtPhone.Text == "" || txtID.Text == "")
                return;
            
            if(conn == null)
            {
                conn = new OleDbConnection(connStr);
                conn.Open();
            }

            string sql = string.Format("INSERT INTO StudentTable VALUES({0}, {1}, '{2}', '{3}')"
                ,txtID.Text, txtSId.Text, txtSName.Text, txtPhone.Text);
            comm = new OleDbCommand(sql, conn);
            int x =comm.ExecuteNonQuery();     // Read하는 것이 아니므로 ExcuteNonQuery

            if (x == 1)
                MessageBox.Show("정상 삽입!");

            conn.Close();
            conn = null;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtSId.Text == "" || txtSName.Text == "" || txtPhone.Text == "")
                return;

            ConnOpen();

            string sql = string.Format("INSERT INTO StudentTable(SId, SName, Phone) VALUES({0}, '{1}', '{2}')"
                , txtSId.Text, txtSName.Text, txtPhone.Text);
            comm = new OleDbCommand(sql, conn);
            int x = comm.ExecuteNonQuery();     // Read하는 것이 아니므로 ExcuteNonQuery

            if (x == 1)
                MessageBox.Show("정상 삽입!");
            ConnClose();
        }

        private void ConnClose()
        {
            conn.Close();
            conn = null;

            lbStudent.Items.Clear();
            lbStudent.Items.Add("ID" + '\t' + "SId" + '\t' + '\t' + "SName" + '\t' + "Phone");
            ShowStudents();
        }

        private void ConnOpen()
        {
            if (conn == null)
            {
                conn = new OleDbConnection(connStr);
                conn.Open();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "")
                return;

            ConnOpen();

            string sql = string.Format("DELETE FROM StudentTable WHERE ID={0}", txtID.Text);
            // string sql = "DELETE FROM StudentTable WHERE ID=" + txtID.Text;

            comm = new OleDbCommand(sql, conn);

            int x = comm.ExecuteNonQuery();
            if (x == 1)
                MessageBox.Show("삭제 성공!");

            ConnClose();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ConnOpen();

            string sql = string.Format("UPDATE StudentTable SET SId={0}, SName='{1}', Phone='{2}' WHERE Id={3}",
                txtSId.Text, txtSName.Text, txtPhone.Text, txtID.Text);

            comm = new OleDbCommand(sql, conn);

            int x = comm.ExecuteNonQuery();
            if (x == 1)
                MessageBox.Show("수정 성공!");

            ConnClose();
        }

        private void btnSerch_Click(object sender, EventArgs e)
        {
            if (txtSId.Text == "" && txtSName.Text == "" && txtPhone.Text == "")
                return;

            ConnOpen();

            string sql = "SELECT * FROM StudentTable ";
            if (txtSId.Text != "")
                sql += "WHERE SId = " + txtSId.Text;

            else if(txtSName.Text != "")
                sql += "WHERE SName = '" + txtSName.Text + "'";

            else if (txtPhone.Text != "")
                sql += "WHERE Phone = '" + txtPhone.Text + "'";

            lbStudent.Items.Clear();
            lbStudent.Items.Add("ID" + '\t' + "SId" + '\t' + '\t' + "SName" + '\t' + "Phone");
            comm = new OleDbCommand(sql, conn);
            reader = comm.ExecuteReader();
            while (reader.Read())
            {
                string x = "";
                x += reader["ID"] + "\t";
                x += reader["SId"] + "\t";
                x += reader["SName"] + "\t";
                x += reader["Phone"];
                lbStudent.Items.Add(x);
            }
            reader.Close();

            conn.Close();
            conn = null;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
            txtSName.Text = "";
            txtSId.Text = "";
            txtPhone.Text = "";
        }

        private void btnViewAll_Click(object sender, EventArgs e)
        {
            lbStudent.Items.Clear();
            ShowStudents();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();                       // Close();
        }
    }
}

// https://github.com/professorkang/VP02        // 강병익 교수님 깃허브