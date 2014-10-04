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
    public partial class Achievement : Form
    {

        static string conStr = Properties.Settings.Default.MainConString;
        static SqlConnection con = new SqlConnection(conStr);

        public Achievement()
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

        private void button3_Click(object sender, EventArgs e)
        {
           this.Close();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand myCommand = new SqlCommand("SELECT * FROM Sports WHERE Event=@Event AND Year=@year", con);
                myCommand.Parameters.AddWithValue("@Event", comboBox1.SelectedItem.ToString());
                myCommand.Parameters.AddWithValue("@Year", comboBox2.SelectedItem.ToString());

                SqlDataReader myReader = myCommand.ExecuteReader();
                while (myReader.Read())
                {
                    textBox1.Text = myReader.GetValue(2).ToString();
                    textBox2.Text = myReader.GetValue(3).ToString();
                    textBox3.Text = myReader.GetValue(4).ToString();
                    textBox4.Text = myReader.GetValue(5).ToString();
                }
                myReader.Close();
                myReader.Dispose();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                SqlCommand myCommand = new SqlCommand("UPDATE Sports SET First=@First,Second=@Second,Third=@Third,Record=@Record WHERE Event=@Event AND Year=@Year", con);
                myCommand.Parameters.AddWithValue("@Event", comboBox1.SelectedItem.ToString());
                myCommand.Parameters.AddWithValue("@year", comboBox2.SelectedItem.ToString());
                myCommand.Parameters.AddWithValue("@first", textBox1.Text.ToString());
                myCommand.Parameters.AddWithValue("@Second", textBox2.Text.ToString());
                myCommand.Parameters.AddWithValue("@Third", textBox3.Text.ToString());
                myCommand.Parameters.AddWithValue("@Record", textBox4.Text.ToString());

                myCommand.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Successfully Updated!!!");
                Reset();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
             
    }
}
