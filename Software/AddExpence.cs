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
    public partial class AddExpence : Form
    {
        static string conStr = Properties.Settings.Default.AccountDatabaseConnectionString;
        static SqlConnection con = new SqlConnection(conStr);

        public AddExpence()
        {
            InitializeComponent();
        }

        private void btnAddExpense_Click(object sender, EventArgs e)
        {
           
        }

        private void AddExpence_Load(object sender, EventArgs e)
        {
            LoadFields();
        }

        private void LoadFields()
        {
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT*FROM Categories WHERE CategoryType='Expense'", con);
            DataTable dt = new DataTable();
            da.Fill(dt);

            foreach (DataRow row in dt.Rows)
            {
                cmbCategry.Items.Add(row["Category"].ToString());
            }

            da.Dispose();
            dt.Clear();

            da = new SqlDataAdapter("SELECT UserName FROM Users", con);
            da.Fill(dt);

            foreach (DataRow row in dt.Rows)
            {
                cmbUsers.Items.Add(row["UserName"].ToString());
            }
            con.Close();
        }

        private void clearFields()
        {
            txtAmount.Clear();
            txtTrnsDisc.Clear();
            cmbCategry.SelectedIndex = -1;
            cmbUsers.SelectedIndex = -1;
            dtTransDate.Value = DateTime.Today;
        }

        private void btnCnclIncm_Click(object sender, EventArgs e)
        {
            
        }

        private void AddExpence_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1 mf = (Form1)Application.OpenForms["Form1"];
            if (mf != null)
            {
                mf.LoadTransactions(mf.dtpSt.Value, mf.dtpEn.Value);
                mf.LoadAccounts();
                mf.TopMost = true;
            }
        }

        private void btnAddStaff_Click(object sender, EventArgs e)
        {
            con.Open();

            SqlDataAdapter uBalAd = new SqlDataAdapter();
            DataTable udt = new DataTable();
            uBalAd.SelectCommand = new SqlCommand("SELECT Availablebal,TotalExpense FROM Accounts WHERE AccountNumber=@SelectedAc", con);
            uBalAd.SelectCommand.Parameters.AddWithValue("@SelectedAc", Properties.Settings.Default.SelectedAcNum);
            uBalAd.Fill(udt);

            int availBal = Convert.ToInt16(udt.Rows[0].ItemArray[0].ToString());
            int newBal = availBal - Convert.ToInt16(txtAmount.Text.ToString());

            int curExp = Convert.ToInt16(udt.Rows[0].ItemArray[1].ToString());
            int newExp = curExp + Convert.ToInt16(txtAmount.Text.ToString());

            SqlCommand cm = new SqlCommand("UPDATE Accounts SET AvailableBal=@newBal,TotalExpense=@newExp WHERE AccountNumber=@SelectedAc", con);
            cm.Parameters.AddWithValue("@SelectedAc", Properties.Settings.Default.SelectedAcNum);
            cm.Parameters.AddWithValue("@newBal", newBal);
            cm.Parameters.AddWithValue("@newExp", newExp);

            cm.ExecuteNonQuery();

            string sql = "INSERT INTO Transactions(AccountNumber,Category,Date,UserName,TransType,Amount,TransDicsription) VALUES(@AcNum,@Category,@Date,@UserName,'Expense',@Amount,@TransDisc)";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@AcNum", Properties.Settings.Default.SelectedAcNum);
            cmd.Parameters.AddWithValue("@Category", cmbCategry.Text);
            cmd.Parameters.AddWithValue("@Date", dtTransDate.Text);
            cmd.Parameters.AddWithValue("@UserName", Properties.Settings.Default.User);
            cmd.Parameters.AddWithValue("@Amount", Convert.ToInt16(txtAmount.Text));
            cmd.Parameters.AddWithValue("@TransDisc", txtTrnsDisc.Text);

            cmd.ExecuteNonQuery();
            con.Close();

            DialogResult dg = MessageBox.Show("Transaction Successfuly added.", "Succes", MessageBoxButtons.OK);
            if (dg == DialogResult.OK)
            {
                this.Close();
            }

           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dtTransDate.Value = DateTime.Today;
            cmbCategry.Text = string.Empty;
            txtAmount.Text = string.Empty;
            txtTrnsDisc.Text = string.Empty;
            cmbUsers.Text = string.Empty;
        }
    }
}
