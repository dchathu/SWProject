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
        DataTable dtTE;
        int iNum = 0;
        public static string st,ap,d;
        public System.Windows.Forms.Timer ti = new System.Windows.Forms.Timer();

        public CoverPage()
        {
            InitializeComponent();   
        }

        private void ti_Tick(object sender, EventArgs e)
        {
            checkTodayEvents();
        }

        private void checkTodayEvents()
        {
            if (dtTE.Rows.Count > 0 && dtTE.Rows.Count>=iNum)
            {
                lblToday.Text = dtTE.Rows[iNum].ItemArray[1].ToString() + " Is scheduled to today!!!";
                iNum++;

                if (iNum == dtTE.Rows.Count)
                {
                    iNum = 0;
                }
            }
        }
        
        private void CoverPage_Load(object sender, EventArgs e)
        {
            

            if (Properties.Settings.Default.UserType == "Admin")
                lnkManageusers.Visible = true;
            lblUserName.Text = Properties.Settings.Default.User.ToString();
            dtpEn.Value = DateTime.Today.AddMonths(+1);
            dtpSt.Value = DateTime.Today.AddDays(-1);
            LoadEvents(dtpSt.Value, dtpEn.Value);
            if (dtTE.Rows.Count > 0)
            {
                ti.Tick += ti_Tick;
                ti.Interval = 5000;
                ti.Enabled = true;
            }

            else
            {
                lblToday.Text = "No any event scheduled to today";
            }
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
            dtTE = new DataTable();
            dtUE = dt.Clone();
            dtTE = dt.Clone();

            foreach (DataRow row in dt.Rows)
            {
                if (Convert.ToDateTime(row.ItemArray[0]).ToShortDateString() == DateTime.Today.ToShortDateString())
                {
                    dtTE.ImportRow(row);
                }
                
                dtUE.ImportRow(row);
            }

            dataGridView3.DataSource = dtUE;
            dataGridView2.DataSource = dtTE;

        }
        #endregion


        private void CoverPage_Activated(object sender, EventArgs e)
        {
            this.TopMost = false;
        }

       

        private void dtpEn_ValueChanged(object sender, EventArgs e)
        {
          
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

        private void lnkManageusers_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ManageUsers mu = (ManageUsers)Application.OpenForms["ManageUsers"];
            if (mu != null)
            {
                mu.TopMost = true;
            }
            else
            {
                ManageUsers mun = new ManageUsers();
                mun.Show();
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login l = new Login();
            l.Show();
        }

        private void btnAchvmnt_Click(object sender, EventArgs e)
        {

            Record rc = (Record)Application.OpenForms["Record"];
            if (rc != null)
            {
                rc.TopMost = true;
            }
            else
            {
                Record rcn = new Record();
                rcn.Show();
            }
        }

        private void btnStudents_Click(object sender, EventArgs e)
        {
            Students st = (Students)Application.OpenForms["Students"];
            if (st != null)
            {
                st.TopMost = true;
            }
            else
            {
                Students s = new Students();
                s.Show();
            }
        }

        private void btnStaff_Click(object sender, EventArgs e)
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

        private void btnInventory_Click(object sender, EventArgs e)
        {
            Inventories iv = (Inventories)Application.OpenForms["Inventories"];
            if (iv != null)
            {
                iv.TopMost = true;
            }

            else
            {
                Inventories ivn = new Inventories();
                ivn.Show();
            }
        }

        private void btnSchedule_Click(object sender, EventArgs e)
        {
            Schedule sc = (Schedule)Application.OpenForms["Schedule"];
            if (sc != null)
            {
                sc.TopMost = true;
            }

            else
            {
                Schedule s = new Schedule();
                s.Show();
            }
        }

        private void btnManageUsers_Click(object sender, EventArgs e)
        {
            ManageUsers lg = (ManageUsers)Application.OpenForms["ManageUsers"];
            if (lg != null)
            {
                lg.TopMost = true;
            }
            else
            {
                ManageUsers lgn = new ManageUsers();
                lgn.Show();
            }
        }

        private void btnGallery_Click(object sender, EventArgs e)
        {
            Gallery gl = (Gallery)Application.OpenForms["Gallery"];
            if (gl != null)
            {
                gl.TopMost = true;
            }
            else
            {
                Gallery gln = new Gallery();
                gln.Show();
            }
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            Form1 ac = (Form1)Application.OpenForms["Form1"];
            if (ac != null)
            {
                ac.TopMost = true;
            }
            else
            {
                Form1 acn = new Form1();
                acn.Show();
            }
        }       
    }
}
