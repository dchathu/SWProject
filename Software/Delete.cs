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
    public partial class Delete : Form
    {
        static string conStr = Properties.Settings.Default.MainConString;
        static SqlConnection con = new SqlConnection(conStr);

        public Delete()
        {
            InitializeComponent();
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure???", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    con.Open();
                    SqlCommand cmd1 = new SqlCommand("DELETE FROM StudentDetails WHERE RegNo=@reg_no", con);
                    SqlCommand cmd2 = new SqlCommand("DELETE FROM FamilyDetails WHERE RegNo=@reg_no", con);

                    cmd1.Parameters.AddWithValue("@reg_no", comboBox2.Text.ToString());
                    cmd2.Parameters.AddWithValue("@reg_no", comboBox2.Text.ToString());
                    cmd1.ExecuteNonQuery();
                    cmd2.ExecuteNonQuery();

                    con.Close();
                    MessageBox.Show("Record is deleted!!", "confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Reset();
                }
            }
            catch (Exception ex)
            {
                { MessageBox.Show("Input Error", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
        }

        private void Delete_Load(object sender, EventArgs e)
        {

            con.Open();
            SqlCommand myCommand = new SqlCommand("SELECT RegNo FROM StudentDetails", con);
            SqlDataReader myReader = myCommand.ExecuteReader();

            while (myReader.Read())
            {
                comboBox2.Items.Add(myReader.GetValue(0).ToString());
            }

            myReader.Close();
            myReader.Dispose();
            con.Close();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
            con.Open();
            SqlCommand myCommand = new SqlCommand("SELECT * FROM StudentDetails WHERE RegNo=@reg_no", con);
            myCommand.Parameters.AddWithValue("@reg_no", comboBox2.Text.ToString());
            SqlDataReader myReader = myCommand.ExecuteReader();

            while (myReader.Read())
            {
                txtname.Text = myReader.GetValue(0).ToString() + "." + myReader.GetValue(1).ToString() + " " + myReader.GetValue(2).ToString();
                txtyear.Text = myReader.GetValue(6).ToString();
                txtadrs.Text = myReader.GetValue(4).ToString();
                txtgendr.Text = myReader.GetValue(8).ToString();
                txtnic.Text = myReader.GetValue(7).ToString();
            }
            myReader.Close();
            myReader.Dispose();
            con.Close();
        }

        public void Reset()
        {
            comboBox2.Text="";
            txtname.Text ="";
            txtyear.Text = "";
            txtadrs.Text = "";
            txtgendr.Text = "";
            txtnic.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Delete_FormClosing(object sender, FormClosingEventArgs e)
        {
            ReportStudents rs = (ReportStudents)Application.OpenForms["ReportStudents"];
            if (rs != null)
            {
                rs.TopMost = true;
            }
        }
    }
}
