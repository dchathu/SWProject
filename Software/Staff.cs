using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Software
{
    public partial class Staff : Form
    {
        static string conStr = Properties.Settings.Default.MainConString;
        static SqlConnection con = new SqlConnection(conStr);
        DataTable dt;
        SqlDataAdapter da;
        DataView dv;
                      
        public Staff()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        { 
            
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
           
        }

        private void Staff_Load(object sender, EventArgs e)
        {
           
            if (Login.usr == 1)
            {
                btnUpdate.Visible = false;

            }
            else if (Login.usr == 2)
            {
                btnUpdate.Visible = false;
                btnAddStaff.Visible = false;
            }

            LoadStaff();
        }

        public void LoadStaff()
        {
            textBox1.Text = "Search staff by Name or Staff ID";
            con.Open();
            da = new SqlDataAdapter();
            da.SelectCommand = new SqlCommand("SELECT Title,First_Name,Last_Name,Staff_ID,Contact_No FROM Staff", con);
            dt = new DataTable();
            da.Fill(dt);
            dv = dt.DefaultView;
            staffsDataGridView.DataSource = dv;
            staffsDataGridView.Columns[0].Width = 50;
            staffsDataGridView.Columns[1].HeaderText = "First Name";
            staffsDataGridView.Columns[2].HeaderText = "Last Name";
            staffsDataGridView.Columns[3].HeaderText = "Staff Id";
            staffsDataGridView.Columns[4].HeaderText = "Contact Number";
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void form_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            string outInfo = "";
            string[] keywords = textBox1.Text.Split(' ');

            foreach (string word in keywords)
            {
                if (outInfo.Length == 0)
                {
                    outInfo = "(First_Name LIKE '%" + word + "%' OR Last_Name LIKE '%" + word + "%' OR Staff_ID LIKE '%" + word + "%')";
                }

                else
                {
                    outInfo += " AND (First_Name LIKE '%" + word + "%' Last_Name Remarks LIKE '%" + word + "%' OR Staff_ID LIKE '%" + word + "%')";
                }
            }

            dv.RowFilter = outInfo;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ReportStaff s = new ReportStaff();
            s.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AddStaff s = new AddStaff();
            s.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            UpdateStaff s = new UpdateStaff();
            s.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            
        }

        private void Staff_FormClosing(object sender, FormClosingEventArgs e)
        {
            CoverPage cs = (CoverPage)Application.OpenForms["CoverPage"];
            if (cs != null)
            {
                cs.TopMost = true;
            }
            else
            {
                CoverPage csn = new CoverPage();
                csn.Show();
            }
        }

        private void Staff_Activated(object sender, EventArgs e)
        {
            this.TopMost = false;
        }
    }
}
