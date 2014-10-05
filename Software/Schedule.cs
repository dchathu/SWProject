using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Software
{
    public partial class Schedule : Form
    {

        static string conStr = Properties.Settings.Default.MainConString;
        static SqlConnection con = new SqlConnection(conStr);
        SqlDataAdapter da;
        DataView dv;

        public static int butn,combo;

        public Schedule()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void Schedule_Load(object sender, EventArgs e)
        {
            dtpEn.Value = DateTime.Today.AddMonths(+1);

            if (Login.usr == 1)
            {
                
            }
            else if (Login.usr == 2)
            {
                
            }

            LoadSchedule(dtpSt.Value,dtpEn.Value);

            
        }

        public void LoadSchedule(DateTime dtSt,DateTime dtEn)
        {
            textBox1.Text = "Start search with what you know...";
            con.Open();

            da = new SqlDataAdapter();
            da.SelectCommand = new SqlCommand("SELECT * FROM Schedule WHERE Date >=@dtSt AND Date <=@dtEn", con);
            da.SelectCommand.Parameters.AddWithValue("@dtSt", dtSt);
            da.SelectCommand.Parameters.AddWithValue("@dtEn", dtEn);
            DataTable dt = new DataTable();
            dv = new DataView();
            da.Fill(dt);
            dv = dt.DefaultView;
            
            dgvSch.DataSource = dv;
            dgvSch.Columns[0].HeaderText = "Schedule Id";
            dgvSch.Columns[0].Width = 100;
            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            butn = 2;
            combo = 1;
            UpdateSchedule s = new UpdateSchedule(Convert.ToInt16(dgvSch.SelectedRows[0].Cells[0].Value));
            s.Show();
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {

            string outInfo = "";
            string[] keywords = textBox1.Text.Split(' ');

            foreach (string word in keywords)
            {
                if (outInfo.Length == 0)
                {
                    outInfo = "(Schedule LIKE '%" + word + "%' OR Remarks LIKE '%" + word + "%' OR Venue LIKE '%" + word + "%' )";
                }

                else
                {
                    outInfo += " AND (Schedule LIKE '%" + word + "%' OR Remarks LIKE '%" + word + "%' OR Venue LIKE '%" + word + "%' )";
                }
            }

            dv.RowFilter = outInfo;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvSch.SelectedRows.Count == 1)
            {
                UpdateSchedule r = (UpdateSchedule)Application.OpenForms["UpdateRecord"];
                if(r!=null){
                    r.TopMost = true;
                }
                else
                {
                    UpdateSchedule s = new UpdateSchedule(Convert.ToInt16(dgvSch.SelectedRows[0].Cells[0].Value));
                    s.Show();
                    
                }
               
            }

            else
            {
                MessageBox.Show("Please select an item to update");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddSchedule ads = (AddSchedule)Application.OpenForms["AddSchedule"];
            if (ads != null)
            {
                ads.TopMost = true;
            }
            else
            {
                AddSchedule s = new AddSchedule();
                s.Show();
            }
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            butn = 2;
            combo = 1;
            UpdateSchedule s = new UpdateSchedule(Convert.ToInt16(dgvSch.SelectedRows[0].Cells[0].Value));
            s.Show();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
        }

        private void dtpEn_ValueChanged(object sender, EventArgs e)
        {
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            
            if((dtpEn.Value - dtpSt.Value).TotalDays<0)
            {
                MessageBox.Show("Set valid range !");
            }
            else            
                LoadSchedule(dtpSt.Value, dtpEn.Value);           
            
            
        }

        private void dtpSt_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            LoadSchedule(dtpSt.Value.AddYears(-10), dtpEn.Value.AddYears(+10));
        }

        private void Schedule_Activated(object sender, EventArgs e)
        {
            this.TopMost = false;
        }

        private void Schedule_FormClosing(object sender, FormClosingEventArgs e)
        {
            CoverPage cs = (CoverPage)Application.OpenForms["CoverPage"];
            if (cs != null)
            {
                cs.TopMost = true;
            }
        }

    }
}
