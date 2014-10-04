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
    public partial class AddCategories : Form
    {
        static string conStr = Properties.Settings.Default.AccountDatabaseConnectionString;
        SqlConnection con = new SqlConnection(conStr);

        public AddCategories()
        {
            InitializeComponent();
        }

        private void btnAddIncome_Click(object sender, EventArgs e)
        {
            con.Open();

            SqlCommand cmd = new SqlCommand("INSERT INTO Categories (Category,CategoryType) Values(@category,@cattype)", con);
            cmd.Parameters.AddWithValue("@category", txtCategory.Text.ToString());
            cmd.Parameters.AddWithValue("@cattype",cmbCategryType.Text.ToString());

            cmd.ExecuteNonQuery();
            con.Close();

            DialogResult dg = MessageBox.Show("Category Successfuly added.  Add Another Category?", "Succes", MessageBoxButtons.YesNo);
            if (dg == DialogResult.No)
            {
                this.Close();
            }
        }

        private void btnCnclIncm_Click(object sender, EventArgs e)
        {
           
        }

        private void AddCategories_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1 mf = (Form1)Application.OpenForms["Form1"];
            if (mf != null)
            {
                mf.TopMost = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddStaff_Click(object sender, EventArgs e)
        {
            con.Open();

            SqlCommand cmd = new SqlCommand("INSERT INTO Categories (Category,CategoryType) Values(@category,@cattype)", con);
            cmd.Parameters.AddWithValue("@category", txtCategory.Text.ToString());
            cmd.Parameters.AddWithValue("@cattype", cmbCategryType.Text.ToString());

            cmd.ExecuteNonQuery();
            con.Close();

            DialogResult dg = MessageBox.Show("Category Successfuly added.  Add Another Category?", "Succes", MessageBoxButtons.YesNo);
            if (dg == DialogResult.No)
            {
                this.Close();
            }
        }
    }
}
