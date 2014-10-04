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
    public partial class AddStaff : Form
    {
        static string conStr = Properties.Settings.Default.MainConString;
        static SqlConnection con = new SqlConnection(conStr);
        SqlDataAdapter da;

        public AddStaff()
        {
            InitializeComponent();
        }
      
        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        public void Reset()
        {
           
            cmbTitle.Text="";
            txtName.Text="";
            txtlname.Text="";
            txtID.Text="";
            txtpos.Text="";
            txtAddress.Text="";
            txtContactNo.Text="";
            txtSubject.Text="";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           
        }

        private void btnAddStaff_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                da = new SqlDataAdapter();
                da.SelectCommand = new SqlCommand("INSERT INTO Staff (Status,Title,First_Name,Last_Name,Staff_ID,Position,Address,Contact_No,Subject)VALUES (@Status,@Title,@First_Name,@Last_Name,@Staff_ID,@Position,@Address,@Contact_No,@Subject)", con);


                
                da.SelectCommand.Parameters.AddWithValue("@Status", cmbStatus.Text.ToString());
                da.SelectCommand.Parameters.AddWithValue("@Title", cmbTitle.SelectedItem.ToString());
                da.SelectCommand.Parameters.AddWithValue("@First_Name", txtName.Text.ToString());
                da.SelectCommand.Parameters.AddWithValue("@Last_Name", txtlname.Text.ToString());
                da.SelectCommand.Parameters.AddWithValue("@Staff_ID", txtID.Text.ToString());
                da.SelectCommand.Parameters.AddWithValue("@Position", txtpos.Text.ToString());
                da.SelectCommand.Parameters.AddWithValue("@Address", txtAddress.Text.ToString());
                da.SelectCommand.Parameters.AddWithValue("@Contact_No", txtContactNo.Text.ToString());
                da.SelectCommand.Parameters.AddWithValue("@Subject", txtSubject.Text.ToString());

                da.SelectCommand.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Successfully added!!!");
                Reset();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddStaff_Load(object sender, EventArgs e)
        {
            cmbStatus.SelectedItem = "Acedemic";
        }

        private void AddStaff_FormClosing(object sender, FormClosingEventArgs e)
        {
            Staff st = (Staff)Application.OpenForms["Staff"];
            if(st!=null)
            {
                st.TopMost = true;
                st.LoadStaff();
            }
            
        }

    }
}
