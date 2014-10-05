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
    public partial class viewBestSprtRecords : Form
    {
        static string conStr = Properties.Settings.Default.MainConString;
        static SqlConnection con = new SqlConnection(conStr);

        public viewBestSprtRecords()
        {
            InitializeComponent();
        }

        private void viewBestSprtRecords_Load(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = new SqlCommand("SELECT Event FROM BestRecord", con);
            da.SelectCommand.Parameters.AddWithValue("@event", comboBox1.Text.ToString().Trim());
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    comboBox1.Items.Add(row.ItemArray[0].ToString().Trim());
                }
            }
            else
            {
                MessageBox.Show("No records in database");
            }
            

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter daa = new SqlDataAdapter();
            daa.SelectCommand = new SqlCommand("SELECT*FROM BestRecord WHERE Event=@event", con);
            daa.SelectCommand.Parameters.AddWithValue("@event", comboBox1.Text.ToString().Trim());
            DataTable dtt = new DataTable();
            daa.Fill(dtt);

            txtOwner.Text = dtt.Rows[0].ItemArray[2].ToString();
            txtRecord.Text = dtt.Rows[0].ItemArray[3].ToString();
            txtYear.Text = dtt.Rows[0].ItemArray[4].ToString();

            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void viewBestSprtRecords_FormClosing(object sender, FormClosingEventArgs e)
        {
            Achivements ac = (Achivements)Application.OpenForms["Achivements"];
            if (ac != null)
            {
                ac.TopMost = true;
            }
        }
    }
}
