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
    public partial class IncomeStats : Form
    {
        BindingSource bs;
        static string conStr = Properties.Settings.Default.AccountDatabaseConnectionString;
        public static SqlConnection con = new SqlConnection(conStr);
        DataTable dt;

        public IncomeStats()
        {
            InitializeComponent();
        }

        private void IncomeStats_Load(object sender, EventArgs e)
        {

            dtpStInc.Value = DateTime.Today.AddMonths(-1);
            bs = new BindingSource();

            dgvIncSum.DataSource = bs;
            LoadTransactions(dtpStInc.Value, dtpEnInc.Value);


        }

        private void LoadTransactions(DateTime stDt, DateTime enDt)
        {
            lblAcNum.Text = Properties.Settings.Default.SelectedAcNum.ToString();
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = new SqlCommand("SELECT Category,Date,UserName,TransDicsription,Amount FROM Transactions WHERE AccountNumber=@selectedAc AND TransType='Income' AND Date >= @stDt AND Date <=@enDt", con);
            da.SelectCommand.Parameters.AddWithValue("@selectedAc", Properties.Settings.Default.SelectedAcNum);
            da.SelectCommand.Parameters.AddWithValue("@stDt", stDt);
            da.SelectCommand.Parameters.AddWithValue("@enDt", enDt);

            dt = new DataTable();
            da.Fill(dt);
            bs.DataSource = dt;
            con.Close();

            string[] xAxis = new string[dt.Rows.Count];
            int[] yAxis = new int[dt.Rows.Count];

            DataTable cdt = new DataTable();
            DataView dv = new DataView(dt);
            cdt = dv.ToTable("Category,Amount");

            chart1.DataSource = cdt;
            chart1.Series[0].XValueMember = "Category";
            chart1.Series[0].YValueMembers = "Amount";
            chart1.DataBind();


        }

        private void btnFilterInc_Click(object sender, EventArgs e)
        {
            LoadTransactions(dtpStInc.Value, dtpEnInc.Value);
        }

        private void IncomeStats_FormClosing(object sender, FormClosingEventArgs e)
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
