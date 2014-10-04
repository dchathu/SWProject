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
    public partial class viewAccounts : Form
    {
        string conStr=Properties.Settings.Default.AccountDatabaseConnectionString;
        int maxRows;
        DataTable dt;
        int pos;
        DataRow drow;

        public viewAccounts()
        {
            InitializeComponent();
        }

        private void viewAccounts_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(conStr);
                SqlDataAdapter da = new SqlDataAdapter("SELECT*FROM Accounts",con);
                dt = new DataTable();
                da.Fill(dt);
                maxRows = dt.Rows.Count;

                navAcData();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void navAcData()
        {
            drow = dt.Rows[pos];

            txtAcName.Text = drow.ItemArray.GetValue(0).ToString();
            txtAcNum.Text = drow.ItemArray.GetValue(1).ToString();
            txtAcType.Text = drow.ItemArray.GetValue(2).ToString();
            txtAcIniBal.Text = drow.ItemArray.GetValue(3).ToString();
            txtAcDisc.Text = drow.ItemArray.GetValue(4).ToString();
            txtAcAvailBal.Text = drow.ItemArray.GetValue(6).ToString();
        }


        private void btnVwNxtAc_Click(object sender, EventArgs e)
        {
            if (pos != maxRows-1)
            {
                pos++;
                navAcData();
            }

            else
                MessageBox.Show("No More Accounts");
        }

        private void btnVwPrvAc_Click(object sender, EventArgs e)
        {
            if (pos != 0)
            {
                pos--;
                navAcData();
            }
            else
                MessageBox.Show("No More Accounts");

        }

        private void btnVwExit_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void viewAccounts_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1 mf = (Form1)Application.OpenForms["Form1"];
            if (mf != null)
            {
                mf.LoadAccounts();
                mf.LoadTransactions(mf.dtpSt.Value, mf.dtpEn.Value);
                mf.TopMost = true;
            }
        }

    }
}
