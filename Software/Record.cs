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

    public partial class Record : Form
    {
        static string conStr = Properties.Settings.Default.MainConString;
        static SqlConnection con = new SqlConnection(conStr);
        SqlDataAdapter da;

        public Record()
        {
            InitializeComponent();
        }

        private void Record_Load(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                da = new SqlDataAdapter("SELECT*FROM Sports", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                con.Close();

                dgvAch.DataSource = dt;
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

        private void form_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
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
            Achievement s = new Achievement();
            s.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      
    }
}
