using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software
{
    public partial class Form1 : Form
    {
        bool pnAcExpanded = false;
        bool pnTrExpanded = false;
        bool pnStatExpanded = false;
        bool pnMnExpanded = false;

        static string conStr = Properties.Settings.Default.AccountDatabaseConnectionString;
        public static SqlConnection con = new SqlConnection(conStr);
        DataTable dt;
        DataTable dtInc;
        DataTable dtExp;
        BindingSource bsIncome;
        BindingSource bsExpense;

        public Form1()
        {
            InitializeComponent();
            pnDtAccount.Visible = false;
            pnDtTrans.Visible = false;
            pnDtStat.Visible = false;
            pnDtMang.Visible = false;
        }
 
        private void button5_Click(object sender, EventArgs e)
        {
            if (!pnAcExpanded)
            {
                pnAcExpanded = !pnAcExpanded;
                pnDtAccount.Visible = true;
            }
            else
            {
                pnAcExpanded = !pnAcExpanded;
                pnDtAccount.Visible = false;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!pnMnExpanded)
            {
                pnMnExpanded = !pnMnExpanded;
                pnDtMang.Visible = true;
            }
            else
            {
                pnMnExpanded = !pnMnExpanded;
                pnDtMang.Visible = false;
            }
        }

        private void btnTrans_Click(object sender, EventArgs e)
        {
            if (!pnTrExpanded)
            {
                pnTrExpanded = !pnTrExpanded;
                pnDtTrans.Visible = true;
            }

            else
            {
                pnTrExpanded = !pnTrExpanded;
                pnDtTrans.Visible = false;
            }
        }

        private void btnStat_Click(object sender, EventArgs e)
        {
            if (!pnStatExpanded)
            {
                pnStatExpanded = !pnStatExpanded;
                pnDtStat.Visible = true;
            }

            else
            {
                pnStatExpanded = !pnStatExpanded;
                pnDtStat.Visible = false;
            }
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            btnAddAccount.ForeColor = Color.Gray;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            btnAddAccount.ForeColor = Color.Black;
        }

        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            AddAcount ac = (AddAcount)Application.OpenForms["AddAcount"];
            if (ac != null)
            {
                ac.TopMost = true;
            }
            else
            {
                AddAcount adac = new AddAcount();
                adac.Show();
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            viewAccounts va = (viewAccounts)Application.OpenForms["viewAccounts"];
            if (va != null)
            {
                va.TopMost = true;
            }
            else
            {
                viewAccounts vac = new viewAccounts();
                vac.Show();
            }
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dtpSt.Value = DateTime.Today.AddMonths(-1);

            LoadAccounts();
            
            bsIncome = new BindingSource();
            bsExpense = new BindingSource();

            dgvIncm.DataSource = bsIncome;
            dgvExpense.DataSource = bsExpense;
            LoadTransactions(dtpSt.Value,dtpEn.Value);
        }

        public void LoadAccounts()
        {
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT*FROM Accounts",con);
            dt = new DataTable();            
            da.Fill(dt);
            con.Close();
           
            contextMenuStrip1.Items.Clear();
            foreach (DataRow row in dt.Rows)
            {
                contextMenuStrip1.Items.Add(row["AccountName"].ToString());
            }

            dt.Clear();

            if (contextMenuStrip1.Items.Count==1)
            {
                btnSelectAcount.Text = contextMenuStrip1.Items[0].Text;
                Properties.Settings.Default.SelectedAc = contextMenuStrip1.Items[0].Text.Trim();
                getSelectedAcNum();
            }

            else if (contextMenuStrip1.Items.Count > 1)
            {
                if(Properties.Settings.Default.SelectedAc==string.Empty)
                {
                    btnSelectAcount.Text = Properties.Settings.Default.SelectedAc.ToString();
                }
                else
                    btnSelectAcount.Text = contextMenuStrip1.Items[0].Text;
            }
            

            else
            {
                btnSelectAcount.Text = "Select Acount";
            }


            if (contextMenuStrip1.Items.Count == 0)
            {
                lblInfoAc.Text = "No Accounts Available!";
                lblInfoAc.Visible = true;
                lbIncome.Visible = false;
                label2.Visible = false;
            }
            else
            {
                lblInfoAc.Visible = false;
                lbIncome.Visible = true;
                label2.Visible = true;
            }
        }

        public void getSelectedAcNum()
        {
            con.Open();
            SqlDataAdapter daa = new SqlDataAdapter();
            daa.SelectCommand = new SqlCommand("SELECT AccountNumber,TotalIncome,TotalExpense,AvailableBal From Accounts WHERE AccountName = @selectedAcName ", con);
            daa.SelectCommand.Parameters.AddWithValue("@selectedAcName", btnSelectAcount.Text.ToString());
            DataTable dtt = new DataTable();
            daa.Fill(dtt);
            con.Close();

            Properties.Settings.Default.SelectedAcNum=Convert.ToInt64(dtt.Rows[0].ItemArray[0].ToString());

            lbIncome.Text = dtt.Rows[0].ItemArray[3].ToString()+".00";
            
            string[] xAxis = new string[2];
            int[] yAxis=new int[2];

            xAxis[0] = "Income";
            xAxis[1] = "Expense";

            yAxis[0] = Convert.ToInt16(dtt.Rows[0].ItemArray[1].ToString());
            yAxis[1] = Convert.ToInt16(dtt.Rows[0].ItemArray[2].ToString());

            chart1.Series[0].Points.DataBindXY(xAxis, yAxis);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            contextMenuStrip1.Show(btnSelectAcount,new Point(0,btnSelectAcount.Height));
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.SelectedAc.ToString().Trim() == string.Empty)
                MessageBox.Show("No Account selected");
            else
            {
                AddIncome ai = (AddIncome)Application.OpenForms["AddIncome"];
                if (ai != null)
                {
                    ai.TopMost = true;
                }
                else
                {
                    AddIncome adinc = new AddIncome();
                    adinc.Show();
                }
            }
           
           
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.SelectedAc.ToString().Trim() == string.Empty)
                MessageBox.Show("No Account selected");
            else
            {
                AddExpence ae = (AddExpence)Application.OpenForms["AddExpence"];
                if (ae != null)
                {
                    ae.TopMost = true;
                }
                else
                {
                    AddExpence adex = new AddExpence();
                    adex.Show();
                }
            }
           
        }

        public void LoadTransactions(DateTime stDate,DateTime enDate)
        {
            con.Open();
            SqlDataAdapter daInc = new SqlDataAdapter();
            daInc.SelectCommand =new SqlCommand("SELECT Category,Date,TransDicsription,Amount FROM Transactions WHERE TransType='Income' AND AccountNumber=@selectedAc AND Date>=@stDt AND Date<=@enDt", con);
            daInc.SelectCommand.Parameters.AddWithValue("@selectedAc", Properties.Settings.Default.SelectedAcNum);
            daInc.SelectCommand.Parameters.AddWithValue("@stDt", stDate);
            daInc.SelectCommand.Parameters.AddWithValue("@enDt", enDate);

            dtInc = new DataTable();
            daInc.Fill(dtInc);
            bsIncome.DataSource = dtInc;
            con.Close();

            SqlDataAdapter daExp = new SqlDataAdapter();
            daExp.SelectCommand = new SqlCommand("SELECT Category,Date,TransDicsription,Amount FROM Transactions WHERE TransType='Expense' AND AccountNumber=@selectedAc", con);
            daExp.SelectCommand.Parameters.AddWithValue("@selectedAc", Properties.Settings.Default.SelectedAcNum);
            dtExp = new DataTable();
            daExp.Fill(dtExp);
            bsExpense.DataSource = dtExp;

            con.Open();
            SqlDataAdapter dUp = new SqlDataAdapter();
            dUp.SelectCommand=new SqlCommand("SELECT TotalIncome,TotalExpense,AvailableBal FROM Accounts WHERE AccountNumber=@selectedAcNum", con);
            dUp.SelectCommand.Parameters.AddWithValue("@selectedAcNum", Properties.Settings.Default.SelectedAcNum);

            DataTable dtU = new DataTable();
            dUp.Fill(dtU);
            con.Close();

            if(dtU.Rows.Count>0)
            {
                lbIncome.Text = dtU.Rows[0].ItemArray[2].ToString() + ".00";

                string[] xAxis = new string[2];
                int[] yAxis = new int[2];

                xAxis[0] = "Income";
                xAxis[1] = "Expense";

                yAxis[0] = Convert.ToInt16(dtU.Rows[0].ItemArray[0].ToString());
                yAxis[1] = Convert.ToInt16(dtU.Rows[0].ItemArray[1].ToString());

                chart1.Series[0].Points.DataBindXY(xAxis, yAxis);
            }
        }

        private void contextMenuStrip1_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {
            Properties.Settings.Default.SelectedAc = e.ClickedItem.Text;
            btnSelectAcount.Text = Properties.Settings.Default.SelectedAc;
            getSelectedAcNum();
        }

        private void dtpSt_ValueChanged(object sender, EventArgs e)
        {
           
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            LoadTransactions(dtpSt.Value, dtpEn.Value);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            IncomeStats ist=(IncomeStats)Application.OpenForms["IncomeStats"];
            if (ist != null)
            {
                ist.TopMost = true;
            }
            else
            {
                IncomeStats istat = new IncomeStats();
                istat.Show();
            }
            
        }

        private void button10_Click(object sender, EventArgs e)
        {
            ExpenseStats est = (ExpenseStats)Application.OpenForms["ExpenseStats"];
            if (est != null)
            {
                est.TopMost = true;
            }
            else
            {
                ExpenseStats exStat = new ExpenseStats();
                exStat.Show();
            }
            
        }

        private void button11_Click(object sender, EventArgs e)
        {
            MnthlyAnalyze mst = (MnthlyAnalyze)Application.OpenForms["MnthlyAnalyze"];
            if (mst != null)
            {
                mst.TopMost = true;
            }
            else
            {
                MnthlyAnalyze sStat = new MnthlyAnalyze();
                sStat.Show();
            }

            
        }

        private void button12_Click(object sender, EventArgs e)
        {
            AddUsers adusr = new AddUsers();
            adusr.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            AddCategories ac = (AddCategories)Application.OpenForms["AddCategories"];
            if (ac != null)
            {
                ac.TopMost = true;
            }
            else
            {
                AddCategories adCat = new AddCategories();
                adCat.Show();
            }
            
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            this.TopMost = false;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            CoverPage cs = (CoverPage)Application.OpenForms["CoverPage"];
            if (cs != null)
            {
                cs.TopMost = true;
            }
        }

    }
}
