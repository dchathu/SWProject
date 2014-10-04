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
            if (Login.usr == 1)
            {
                
            }
            else if (Login.usr == 2)
            {
                
            }

            con.Open();

            da = new SqlDataAdapter("SELECT * FROM Schedule", con);
            DataTable dt = new DataTable();
            dv = new DataView();
            da.Fill(dt);
            dv = dt.DefaultView;

            dgvSch.DataSource = dv;
            
            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            butn = 2;
            combo = 1;
            UpdateRecord s = new UpdateRecord(Convert.ToInt16(dgvSch.SelectedRows[0].Cells[0].Value));
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
                    outInfo = "(Schedule LIKE '%" + word + "%' OR Remarks LIKE '%" + word + "%' OR Venue LIKE '%" + word + "%')";
                }

                else
                {
                    outInfo += " AND (Schedule LIKE '%" + word + "%' OR Remarks LIKE '%" + word + "%' OR Venue LIKE '%" + word + "%')";
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

                butn = 1;
                combo = 1;
                UpdateRecord s = new UpdateRecord(Convert.ToInt16(dgvSch.SelectedRows[0].Cells[0].Value));
                s.Show();
            }

            else if (dgvSch.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select A Row");
            }

            else
            {
                MessageBox.Show("Please select one row");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            butn = combo = 0;
            AddSchedule s = new AddSchedule();
            s.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            butn = 2;
            combo = 1;
            UpdateRecord s = new UpdateRecord(Convert.ToInt16(dgvSch.SelectedRows[0].Cells[0].Value));
            s.Show();
        }

    }
}
