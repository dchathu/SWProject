using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

using Software;

namespace Software
{
    public partial class CoverPage : Form
 
    {
        static string conStr = Properties.Settings.Default.MainConString;
        public static SqlConnection con = new SqlConnection(conStr);
        SqlDataAdapter da;
        public static string st,ap,d;



        public CoverPage()
        {
            InitializeComponent();            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Students s = new Students();
            s.Show();
        }

        private void form_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Staff st = (Staff)Application.OpenForms["Staff"];
            if (st != null)
                st.TopMost = true;
            else
            {
                Staff s = new Staff();
                s.Show();
            }
            
        }

       
        private void button3_Click(object sender, EventArgs e)
        {
            Inventories s = new Inventories();
            s.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Schedule s= new Schedule();
            s.Show();
        }
        
        private void CoverPage_Load(object sender, EventArgs e)
        {
            dtpEn.Value = DateTime.Today.AddMonths(+1);
            dtpSt.Value = DateTime.Today.AddDays(-1);
            LoadEvents(dtpSt.Value, dtpEn.Value);
        }

        #region Load Events
        private void LoadEvents(DateTime dtSt, DateTime dtEn)
        {
            con.Open();

            da = new SqlDataAdapter();
            da.SelectCommand = new SqlCommand("SELECT Date,Schedule,Remarks,Time,Venue FROM Schedule WHERE Date >= @stDt AND Date <=@enDt", con);
            da.SelectCommand.Parameters.AddWithValue("@stDt", dtSt);
            da.SelectCommand.Parameters.AddWithValue("@enDt", dtEn);

            DataTable dt = new DataTable();
            dt.Clear();
            da.Fill(dt);
            con.Close();
            DataTable dtUE = new DataTable();
            DataTable dtUID = new DataTable();
            dtUE = dt.Clone();
            dtUID = dt.Clone();

            foreach (DataRow row in dt.Rows)
            {
                
                if (Convert.ToDateTime(row.ItemArray[0]).ToShortDateString() == DateTime.Today.ToShortDateString())
                {
                    lblToday.Text = row.ItemArray[1].ToString() + " Is scheduled to today!!!";
                }

                if (row.ItemArray[2].ToString() == "Event")
                {
                    dtUE.ImportRow(row);
                }

                else if (row.ItemArray[2].ToString() == "Important Day")
                {
                    dtUID.ImportRow(row);
                }
            }
            dgv1.DataSource = dtUE;
            dgvUID.DataSource = dtUID;
        }
        #endregion

        private void button5_Click(object sender, EventArgs e)
        {
            Record s = new Record();
            s.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            LoginRegister s = new LoginRegister();
            s.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Gallery s = new Gallery();
            s.Show();
        }

        private void CoverPage_Activated(object sender, EventArgs e)
        {
            this.TopMost = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form1 ac = new Form1();
            ac.Show();
        }

        private void dtpEn_ValueChanged(object sender, EventArgs e)
        {
          
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
           
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            l.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ResetPassword re = new ResetPassword();
            re.Show();
        }

        private void dtpSt_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void CoverPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            LoadEvents(dtpSt.Value, dtpEn.Value);
        }       
    }
}
