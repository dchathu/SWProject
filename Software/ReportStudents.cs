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
    public partial class ReportStudents : Form
    {
        static string conStr = Properties.Settings.Default.MainConString;
        static SqlConnection con = new SqlConnection(conStr);
        SqlDataAdapter da;
        DataTable dt;
        DataRow row;
        int pos = 0;

        public ReportStudents()
        {
            InitializeComponent();
        }

        private void ReportStudents_Load(object sender, EventArgs e)
        {
            da = new SqlDataAdapter();
            da.SelectCommand = new SqlCommand("SELECT*FROM StudentDetails", con);
            dt=new DataTable();
            da.Fill(dt);

            navStudentDetails();
        }

        private void navStudentDetails()
        {
            row = dt.Rows[pos];
            txtTitle.Text = row.ItemArray.GetValue(1).ToString();
            txtFname.Text=row.ItemArray.GetValue(2).ToString();
            txtLname.Text=row.ItemArray.GetValue(3).ToString();
            txtPerAddress.Text=row.ItemArray.GetValue(4).ToString();
            txtRegNo.Text=row.ItemArray.GetValue(5).ToString();
            txtYear.Text=row.ItemArray.GetValue(6).ToString();
            txtNIC.Text=row.ItemArray.GetValue(7).ToString();
            txtGender.Text=row.ItemArray.GetValue(8).ToString();
            txtBday.Text=row.ItemArray.GetValue(9).ToString();
            txtCourse.Text=row.ItemArray.GetValue(10).ToString();
            txtStatus.Text=row.ItemArray.GetValue(11).ToString();
            txtContact.Text=row.ItemArray.GetValue(12).ToString();
            txtContact2.Text = row.ItemArray.GetValue(13).ToString();
            txtEmail.Text=row.ItemArray.GetValue(14).ToString();
            txtFb.Text=row.ItemArray.GetValue(15).ToString();
            txtDistrict.Text=row.ItemArray.GetValue(16).ToString();
            txtLanguage.Text=row.ItemArray.GetValue(17).ToString();
            txtReligion.Text=row.ItemArray.GetValue(18).ToString();
            txtCultural.Text=row.ItemArray.GetValue(19).ToString();
            txtSchool.Text=row.ItemArray.GetValue(20).ToString();
            txtALRes.Text=row.ItemArray.GetValue(21).ToString();
            txtHostel.Text=row.ItemArray.GetValue(22).ToString();
            txtIndorgame.Text=row.ItemArray.GetValue(23).ToString();
            txtAthletic.Text=row.ItemArray.GetValue(24).ToString();
            txtmajorGames.Text=row.ItemArray.GetValue(25).ToString();
            txtMedical.Text = row.ItemArray.GetValue(26).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            ReportStudents rs = (ReportStudents)Application.OpenForms["ReportStudents"];
            if (rs != null)
            {
                rs.TopMost = true;
            }
        }

        private void form_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            pos = 0;
            navStudentDetails();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (pos != 0)
            {
                pos--;
                navStudentDetails();
            }
            
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (pos != dt.Rows.Count - 1)
            {
                pos++;
                navStudentDetails();
            }
           
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            pos = dt.Rows.Count - 1;
            navStudentDetails();
        }

        private void ReportStudents_Activated(object sender, EventArgs e)
        {
            this.TopMost = false;
        }
    }
}
