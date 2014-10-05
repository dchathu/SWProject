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
    public partial class Students : Form
    {
        static string conStr = Properties.Settings.Default.MainConString;
        public static SqlConnection con = new SqlConnection(conStr);
        SqlDataAdapter da;
        DataView dv;
        DataTable dt;

        public Students()
        {
            InitializeComponent();
        }
        
        #region Form Load

        private void Students_Load(object sender, EventArgs e)
        {
           
           
            if (Login.usr == 1)
            {
                
            }
            else if (Login.usr == 2)
            {
                
            }

            con.Open();
            da = new SqlDataAdapter();
            da.SelectCommand = new SqlCommand("SELECT Title,FirstName,LastName,RegNo,AcedemicCourse,ContactNumber FROM StudentDetails", con);
            dt = new DataTable();
            da.Fill(dt);
            dv = dt.DefaultView;
            dataGridView1.DataSource = dv;
            dataGridView1.Columns[0].Width = 50;
            con.Close();
        }

        #endregion

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
           
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void form_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }

        #region Auto Search
        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            
            string outInfo = "";
            string []keywords=textBox1.Text.Split(' ');

            foreach (string word in keywords)
            {
                if (outInfo.Length == 0)
                {
                    outInfo = "(FirstName LIKE '%" + word + "%' OR LastName LIKE '%" +word + "%')";
                }

                else
                {
                    outInfo += " AND (FirstName LIKE '%" + word + "%' OR LastName LIKE '%" + word + "%')";
                }
            }

            dv.RowFilter = outInfo;

        }

        #endregion

        private void Students_FormClosing(object sender, FormClosingEventArgs e)
        {
            CoverPage cp = (CoverPage)Application.OpenForms["CoverPage"];
            if (cp != null)
            {
                cp.TopMost = true;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ReportStudents rs = (ReportStudents)Application.OpenForms["ReportStudents"];
            if (rs != null)
            {
                rs.TopMost = true;
            }

            else
            {
                ReportStudents s = new ReportStudents();
                s.Show();
            }
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AddStudent ast=(AddStudent)Application.OpenForms["AddStudent"];
            if (ast != null)
            {
                ast.TopMost = true;
            }
            else
            {
                AddStudent s = new AddStudent();
                s.Show();
            }   
        }

        private void button8_Click(object sender, EventArgs e)
        {
            UpdateStudent us = (UpdateStudent)Application.OpenForms["UpdateStudent"];
            if (us != null)
            {
                us.TopMost = true;
            }
            else
            {
                UpdateStudent s = new UpdateStudent();
                s.Show();
            }
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Delete ds = (Delete)Application.OpenForms["Delete"];
            if (ds != null)
            {
                ds.TopMost = true;
            }
            else
            {
                Delete s = new Delete();
                s.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyUp_1(object sender, KeyEventArgs e)
        {
            string outInfo = "";
            string[] keywords = textBox1.Text.Split(' ');

            foreach (string word in keywords)
            {
                if (outInfo.Length == 0)
                {
                    

                    outInfo = "(FirstName LIKE '%" + word + "%' OR LastName LIKE '%" + word + "%' OR AcedemicCourse LIKE '%" + word + "%')";
                }

                else
                {
                    outInfo += " AND (FirstName LIKE '%" + word + "%' OR LastName LIKE '%" + word + "%' OR AcedemicCourse LIKE '%" + word + "%')";
                }
            }

            dv.RowFilter = outInfo;
        }

    }
}
