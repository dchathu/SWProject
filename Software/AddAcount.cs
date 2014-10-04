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
    public partial class AddAcount : Form
    {
        
        string conStr=Properties.Settings.Default.AccountDatabaseConnectionString;
        

        public AddAcount()
        {
            InitializeComponent();
        }

        protected void btnCancelAdd_Click(object sender, EventArgs e)
        {
            
        }

        private void btnResetFields_Click(object sender, EventArgs e)
        {
            
        }

        public void clearFields()
        {
            txtAdAcDisc.Clear();
            txtAdAcIniBal.Clear();
            txtAdAcName.Clear();
            txtAdAcNum.Clear();
            cmbAdAcType.Text = "Select Account Type";
        }

        private void btnAddAc_Click(object sender, EventArgs e)
        {
            
        }

        private void AddAcount_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1 mf = (Form1)Application.OpenForms["Form1"];
            if (mf != null)
            {
                mf.LoadAccounts();
                mf.LoadTransactions(mf.dtpSt.Value, mf.dtpEn.Value);
                mf.TopMost = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddStaff_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conStr);
            con.Open();

            string sql = "INSERT INTO Accounts (AccountName,AccountNumber,AccountType,InitialBalance,AccountDiscription,AvailableBal,TotalIncome,TotalExpense) VALUES (@ActName,@ActNum,@ActType,@IniBal,@ActDisc,@IniBal,0,0)";
            SqlCommand cmd = new SqlCommand(sql, con);

            cmd.Parameters.AddWithValue("@ActName", txtAdAcName.Text);
            cmd.Parameters.AddWithValue("@ActNum", Convert.ToInt64(txtAdAcNum.Text));
            cmd.Parameters.AddWithValue("@ActType", cmbAdAcType.Text);
            cmd.Parameters.AddWithValue("@IniBal", Convert.ToInt64(txtAdAcIniBal.Text));
            cmd.Parameters.AddWithValue("@ActDisc", txtAdAcDisc.Text);
            cmd.ExecuteNonQuery();

            con.Close();
            

            DialogResult dg = MessageBox.Show("Account Successfully Added", "Success", MessageBoxButtons.OK);
            if (dg == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clearFields();
        }
    }
}
