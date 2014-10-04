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
                btnUpdate.Visible = false;
                BtnRemove.Visible = false;
            }
            else if (Login.usr == 2)
            {
                btnAdd.Visible = false;
                btnUpdate.Visible = false;
                BtnRemove.Visible = false;
            }

            con.Open();
            da = new SqlDataAdapter();
            da.SelectCommand = new SqlCommand("SELECT*FROM StudentDetails", con);
            dt = new DataTable();
            da.Fill(dt);
            dv = dt.DefaultView;
            dataGridView1.DataSource = dv;
            con.Close();
        }

        #endregion

        private void button2_Click(object sender, EventArgs e)
        {
            ReportStudents s = new ReportStudents();
            s.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddStudent s = new AddStudent();
            s.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateStudent s = new UpdateStudent();
            s.Show();
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            Delete s = new Delete();
            s.Show();
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

    }
}
