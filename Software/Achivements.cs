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

    public partial class Achivements : Form
    {
        static string conStr = Properties.Settings.Default.MainConString;
        static SqlConnection con = new SqlConnection(conStr);
        SqlDataAdapter da;
        DataView dv;

        public Achivements()
        {
            InitializeComponent();
        }

        private void Record_Load(object sender, EventArgs e)
        {

            LoadRecords();
            

        }

        public void LoadRecords()
        {
            try
            {
                con.Open();
                da = new SqlDataAdapter("SELECT RecordId,Year,Event,First,Second,Third,Record,BstRecord FROM Sports", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                con.Close();
                dv = dt.DefaultView;
                dv.Sort = "Year";
                dgvAch.DataSource = dv;
                dgvAch.Columns[0].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddRecord s = new AddRecord();
            s.Show();
        }

        private void Record_FormClosing(object sender, FormClosingEventArgs e)
        {
            CoverPage cs = (CoverPage)Application.OpenForms["CoverPage"];
            if(cs!=null)
            {
                cs.TopMost = true;
            }
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            if (dgvAch.SelectedRows.Count == 1)
            {
                UpdateRecord ur = (UpdateRecord)Application.OpenForms["Achievement"];
                if (ur != null)
                {
                    ur.TopMost = true;
                }

                else
                {

                    UpdateRecord s = new UpdateRecord(Convert.ToInt16(dgvAch.SelectedRows[0].Cells[0].Value));
                    s.Show();
                }
            }
            else
            {
                MessageBox.Show("Please select a row to update");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            string outInfo = "";
            string[] keywords = textBox1.Text.Split(' ');

            foreach (string word in keywords)
            {
                if (outInfo.Length == 0)
                {
                    outInfo = "(Event LIKE '%" + word + "%' OR Year LIKE '%" + word + "%' OR First LIKE '%" + word + "%'OR Second LIKE '%" + word + "%'OR Third LIKE '%" + word + "%' )";
                }

                else
                {
                    outInfo += " AND (Event LIKE '%" + word + "%' OR Year LIKE '%" + word + "%' OR First LIKE '%" + word + "%'OR Second LIKE '%" + word + "%'OR Third LIKE '%" + word + "%' )";
                }
            }

            dv.RowFilter = outInfo;
        }

        private void Record_Activated(object sender, EventArgs e)
        {
            this.TopMost = false;
        }

    }
}
