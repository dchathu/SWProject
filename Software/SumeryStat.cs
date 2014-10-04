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
    public partial class MnthlyAnalyze : Form
    {
        static string conStr = Properties.Settings.Default.AccountDatabaseConnectionString;
        public static SqlConnection con = new SqlConnection(conStr);
      
        DataTable dt;

        BindingSource bsSum;


        public MnthlyAnalyze()
        {
            InitializeComponent();
        }

        private void SumeryStat_Load(object sender, EventArgs e)
        {
            dtpStSum.Value = DateTime.Today.AddMonths(-1);


            bsSum = new BindingSource();

            dgvSum.DataSource = bsSum;
            LoadTransactions(dtpStSum.Value, dtpEnSum.Value);
            
        }

        private void LoadTransactions(DateTime dtSt, DateTime dtEn)
        {
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = new SqlCommand("SELECT Category,Date,TransType,TransDicsription,Amount FROM Transactions WHERE AccountNumber=@selectedAc AND Date>=@dtSt AND Date<=@dtEn",con);
            da.SelectCommand.Parameters.AddWithValue("@selectedAc", Properties.Settings.Default.SelectedAcNum);
            da.SelectCommand.Parameters.AddWithValue("@dtSt", dtSt);
            da.SelectCommand.Parameters.AddWithValue("@dtEn", dtEn);
            dt=new DataTable();
            da.Fill(dt);
            dt.DefaultView.Sort = "Date";
            dt = dt.DefaultView.ToTable();

            bsSum.DataSource = dt;
           
            con.Close();
           

        }
    }
}
