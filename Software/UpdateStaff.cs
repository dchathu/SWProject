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
    public partial class UpdateStaff : Form
    {
        static string conStr = Properties.Settings.Default.MainConString;
        static SqlConnection con = new SqlConnection(conStr);
        DataTable dt;
        SqlDataAdapter da;

        public UpdateStaff()
        {
            InitializeComponent();
        }
        
        private void btnadd_Click(object sender, EventArgs e)
        {
           
        }

        private void UpdateStaff_Load(object sender, EventArgs e)
        {
            con.Open();

            SqlCommand myCommand = new SqlCommand("Select Staff_ID from Staff", con);
            SqlDataReader myReader = myCommand.ExecuteReader();

            while (myReader.Read())
            {
                cmbID.Items.Add(myReader.GetValue(0).ToString());
            }
            myReader.Close();
            myReader.Dispose();
            con.Close();
        }

        private void cmbID_SelectedIndexChanged(object sender, EventArgs e)
        {
             try
             {
                 con.Open();

                 SqlCommand myCommand = new SqlCommand("Select * from Staff WHERE Staff_ID=@Staff_ID", con);
                 myCommand.Parameters.AddWithValue("@Staff_ID", cmbID.SelectedItem.ToString());
                 SqlDataReader myReader = myCommand.ExecuteReader();

                 while (myReader.Read())
                 {
                     if (myReader.GetValue(1).ToString().Trim() == "Acedemic")
                         cmbStatus.SelectedItem = "Acedemic";
                     else
                         cmbStatus.SelectedItem = "Non Acedemic";

                     cmbTitle.Text = myReader.GetValue(2).ToString();
                     txtName.Text = myReader.GetValue(3).ToString();
                     txtlname.Text = myReader.GetValue(4).ToString();
                     txtpos.Text = myReader.GetValue(6).ToString();
                     txtAddress.Text = myReader.GetValue(7).ToString();
                     txtContactNo.Text = myReader.GetValue(8).ToString();
                     txtSubject.Text = myReader.GetValue(9).ToString();
                 }
                 myReader.Close();
                 myReader.Dispose();
                 con.Close();
             }

             catch (Exception ex)
             {
                 MessageBox.Show(ex.Message);
             }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        public void Reset()
        {
            cmbID.Text = ""; cmbStatus.SelectedItem = "Acedemic";
            cmbTitle.Text = "";
            txtName.Text = "";
            txtlname.Text = "";
            txtpos.Text ="";
            txtAddress.Text = "";
            txtContactNo.Text = "";
            txtSubject.Text = "";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void btnAddStaff_Click(object sender, EventArgs e)
        {
            con.Open();

            SqlCommand myCommand = new SqlCommand("UPDATE Staff SET Status=@Status,Title=@Title,First_Name=@First_Name,Last_Name=@Last_Name,Position=@Position,Address=@Address,Contact_No=@Contact_No,Subject=@Subject WHERE Staff_ID=@Staff_ID", con);
            

            
            myCommand.Parameters.AddWithValue("@Status", cmbStatus.Text.ToString());
            myCommand.Parameters.AddWithValue("@Staff_ID", cmbID.Text.ToString());
            myCommand.Parameters.AddWithValue("@Title", cmbTitle.Text.ToString());
            myCommand.Parameters.AddWithValue("@First_Name", txtName.Text.ToString());
            myCommand.Parameters.AddWithValue("@Last_Name", txtlname.Text.ToString());
            myCommand.Parameters.AddWithValue("@Position", txtpos.Text.ToString());
            myCommand.Parameters.AddWithValue("@Address", txtAddress.Text.ToString());
            myCommand.Parameters.AddWithValue("@Contact_No", txtContactNo.Text.ToString());
            myCommand.Parameters.AddWithValue("@Subject", txtSubject.Text.ToString());


            myCommand.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Successfully Updated!!!");
            Reset();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure???", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                con.Open();
                SqlCommand myCommand = new SqlCommand("DELETE FROM Staff WHERE Staff_ID=@Staff_ID", con);
                myCommand.Parameters.AddWithValue("@Staff_ID", cmbID.Text.ToString());

                myCommand.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Record is deleted!!", "confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Reset();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UpdateStaff_FormClosing(object sender, FormClosingEventArgs e)
        {
            Staff st = (Staff)Application.OpenForms["Staff"];
            if (st != null)
            {
                st.TopMost = true;
                st.LoadStaff();
            }
        }

    }
}
