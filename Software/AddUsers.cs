using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace Software
{
    public partial class AddUsers : Form
    {
        static string conStr = Properties.Settings.Default.AccountDatabaseConnectionString;
        SqlConnection con = new SqlConnection(conStr);


        public AddUsers()
        {
            InitializeComponent();
        }

        private void btnAdduser_Click(object sender, EventArgs e)
        {
            con.Open();
            
            SqlCommand cmd = new SqlCommand("INSERT INTO Users (UserName,UserDiscription) Values(@uName,@uDisc)", con);
            cmd.Parameters.AddWithValue("@uName", txtUserName.Text.ToString());
            cmd.Parameters.AddWithValue("@uDisc", txtUserDisc.Text.ToString());

            cmd.ExecuteNonQuery();
            con.Close();

            DialogResult dg = MessageBox.Show("User Successfuly added.  Add Another User?", "Succes", MessageBoxButtons.YesNo);
            if (dg == DialogResult.No)
            {
                this.Close();
            }
                

        }

        private void btnCncl_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddUsers_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1 mf = (Form1)Application.OpenForms["Form1"];
            if (mf != null)
            {
                mf.TopMost = true;
                mf.TopMost = true;
            }
        }
    }
}
