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
    public partial class AddSchedule : Form
    {
        static string conStr = Properties.Settings.Default.MainConString;
        static SqlConnection con = new SqlConnection(conStr);
        
        public AddSchedule()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand myCommand = new SqlCommand("INSERT INTO Schedule (Date,Schedule,Remarks,Time,Venue)VALUES (@Date,@Schedule,@Remarks,@Time,@Venue)", con);

                myCommand.Parameters.AddWithValue("@Date", dateTimePicker1.Text.ToString());
                myCommand.Parameters.AddWithValue("@Schedule", textBox2.Text.ToString());
                if(radioButton1.Checked)
                    myCommand.Parameters.AddWithValue("@Remarks", "Event");
                else if (radioButton2.Checked)
                    myCommand.Parameters.AddWithValue("@Remarks", "Important Day");
                myCommand.Parameters.AddWithValue("@Time", textBox1.Text.ToString());
                myCommand.Parameters.AddWithValue("@Venue", textBox3.Text.ToString());
               
                myCommand.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Successfully added!!!");
                Reset();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void Reset()
        {
            dateTimePicker1.Text = "";
            textBox2.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
                         
            textBox1.Text = "";
            textBox3.Text = "";
             
        }

        

        private void form_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddSchedule_Load(object sender, EventArgs e)
        {

        }              
       
    }
}
