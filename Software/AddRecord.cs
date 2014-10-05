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
    public partial class AddRecord : Form
    {
        static string conStr = Properties.Settings.Default.MainConString;
        static SqlConnection con = new SqlConnection(conStr);

        public AddRecord()
        {
            InitializeComponent();
        }

        public void Reset()
        {
            comboBox1.Text = "";
            comboBox2.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }

        private void AddRecord_FormClosing(object sender, FormClosingEventArgs e)
        {
            Achivements rc = (Achivements)Application.OpenForms["Record"];
            if (rc != null)
            {
                rc.TopMost = true;
                rc.LoadRecords();
            }
        }

        private void btnAddStaff_Click(object sender, EventArgs e)
        {
            
            try
            {
                con.Open();
                SqlCommand myCommand = new SqlCommand("INSERT INTO Sports (Event,Year,First,Second,Third,Record) VALUES (@Event,@Year,@First,@Second,@Third,@Record)", con);

                myCommand.Parameters.AddWithValue("@Event", comboBox1.SelectedItem.ToString());
                myCommand.Parameters.AddWithValue("@Year", comboBox2.SelectedItem.ToString());
                myCommand.Parameters.AddWithValue("@First", textBox1.Text.ToString());
                myCommand.Parameters.AddWithValue("@Second", textBox2.Text.ToString());
                myCommand.Parameters.AddWithValue("@Third", textBox3.Text.ToString());
                myCommand.Parameters.AddWithValue("@Record", textBox4.Text.ToString());

                myCommand.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Successfully added!!!");
                
                Reset();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
