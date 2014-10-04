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
    public partial class ReportStaff : Form
    {
        static string constr = Properties.Settings.Default.MainConString;
        static SqlConnection con = new SqlConnection(constr);
        DataTable dt;
        SqlDataAdapter da;
        int pos = 0;
        DataRow row;

        public ReportStaff()
        {
            InitializeComponent();
        }

        private void ReportStaff_Load(object sender, EventArgs e)
        {
            da = new SqlDataAdapter();
            da.SelectCommand = new SqlCommand("SELECT*FROM Staff", con);
            dt = new DataTable();
            da.Fill(dt);
            con.Close();

            navStaffDetails();
        }

        private void navStaffDetails()
        {
            if (dt.Rows.Count > 0)
            {
                row = dt.Rows[pos];
                lblNumber.Text = (pos+1).ToString() + " Of " + dt.Rows.Count.ToString();
                txtName.Text = row.ItemArray.GetValue(1).ToString().Trim() + " " + row.ItemArray.GetValue(2).ToString().Trim() + " " + row.ItemArray.GetValue(3).ToString().Trim() + " " + row.ItemArray.GetValue(4).ToString().Trim();
                txtStaffId.Text = row.ItemArray.GetValue(5).ToString();
                txtPosition.Text = row.ItemArray.GetValue(6).ToString();
                txtAddress.Text = row.ItemArray.GetValue(7).ToString();
                txtContactNo.Text = row.ItemArray.GetValue(8).ToString();
                txtSubject.Text = row.ItemArray.GetValue(9).ToString();
            }

            else
            {
                MessageBox.Show("No records to Show");

            }
                
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAllDetails_Click(object sender, EventArgs e)
        {
            pos = 0;
            navStaffDetails();
        }

        private void btnAddStaff_Click(object sender, EventArgs e)
        {
            if (pos != 0)
            {
                pos--;
                navStaffDetails();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (pos != dt.Rows.Count - 1)
            {
                pos++;
                navStaffDetails();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            pos = dt.Rows.Count - 1;
            navStaffDetails();
        }

    }
}
