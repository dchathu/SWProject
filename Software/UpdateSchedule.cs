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
    public partial class UpdateSchedule : Form
    {
        static string conStr = Properties.Settings.Default.MainConString;
        static SqlConnection con = new SqlConnection(conStr);
        SqlDataAdapter da;
        DataTable dt;
        int id;

        public UpdateSchedule(int Id)
        {
            InitializeComponent();
            this.id = Id;
        }

        private void UpdateRecord_Load(object sender, EventArgs e)
        {
            con.Open();
            da = new SqlDataAdapter();
            da.SelectCommand = new SqlCommand("SELECT*FROM Schedule WHERE SId=@id", con);
            da.SelectCommand.Parameters.AddWithValue("@id", id);
            dt=new DataTable();
            da.Fill(dt);

            txtDate.Text = Convert.ToDateTime(dt.Rows[0].ItemArray[1].ToString()).ToShortDateString();
            txtSchedule.Text = dt.Rows[0].ItemArray[2].ToString();
            txtRemarks.Text = dt.Rows[0].ItemArray[3].ToString();
            txtTime.Text = dt.Rows[0].ItemArray[4].ToString();
            txtVenue.Text = dt.Rows[0].ItemArray[5].ToString();

            con.Close();

        }


        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddStaff_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                SqlCommand myCommand = new SqlCommand("UPDATE Schedule SET Date=@Date,Schedule=@Schedule,Remarks=@Remarks,Time=@Time,Venue=@Venue WHERE SId=@Id", con);
                myCommand.Parameters.AddWithValue("@Date", txtDate.Text.ToString());
                myCommand.Parameters.AddWithValue("@Schedule", txtSchedule.Text.ToString());
                myCommand.Parameters.AddWithValue("@Remarks", txtRemarks.Text.ToString());
                myCommand.Parameters.AddWithValue("@Time", txtTime.Text.ToString());
                myCommand.Parameters.AddWithValue("@Venue", txtVenue.Text.ToString());
                myCommand.Parameters.AddWithValue("@Id", id);

                myCommand.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Successfully Updated!!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure???", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                con.Open();
                SqlCommand myCommand = new SqlCommand("DELETE FROM Schedule WHERE SId=@Id", con);

                myCommand.Parameters.AddWithValue("@Id", id);
                myCommand.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Record is deleted!!");
            }
        }

        private void UpdateRecord_FormClosing(object sender, FormClosingEventArgs e)
        {
            Schedule sc = (Schedule)Application.OpenForms["Schedule"];
            if (sc != null)
            {
                sc.TopMost = true;
                sc.LoadSchedule(sc.dtpSt.Value, sc.dtpEn.Value);
            }
            else
            {
                Schedule s = new Schedule();
                s.Show();
            }
        }

        private void UpdateRecord_Activated(object sender, EventArgs e)
        {
            this.TopMost = false;
        }

    }
}
