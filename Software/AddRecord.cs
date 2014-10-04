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
        SqlDataAdapter da;

        public AddRecord()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            con.Open();
             try
            {
                SqlCommand myCommand = new SqlCommand("INSERT INTO Sports (Event,Year,First,Second,Third,Record)VALUES (@Event,@Year,@First,@Second,@Third,@Record)", con);

                myCommand.Parameters.AddWithValue("@Event", comboBox1.SelectedItem.ToString());
                myCommand.Parameters.AddWithValue("@Year", comboBox2.SelectedItem.ToString());
                myCommand.Parameters.AddWithValue("@First", textBox1.Text.ToString());
                myCommand.Parameters.AddWithValue("@Second", textBox2.Text.ToString());
                myCommand.Parameters.AddWithValue("@Third", textBox3.Text.ToString());
                myCommand.Parameters.AddWithValue("@Record", textBox4.Text.ToString());

                myCommand.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Successfully added!!!");
                RecordBeat();
                Reset();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
       

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddRecord_FormClosing(object sender, FormClosingEventArgs e)
        {
            Record rc = (Record)Application.OpenForms["Record"];
            if (rc != null)
            {
                rc.TopMost = true;
            }
        }
        public void RecordBeat()
        {
            string name = "";
           
            //SqlConnection cnn = new SqlConnection(connection);
            SqlCommand command = new SqlCommand("SELECT Record FROM Special_records WHERE Event='" + comboBox1.Text.ToString().Trim() + "'", con);
            // myConnection.Open();
            SqlCommand command1 = new SqlCommand("SELECT first_name FROM Students WHERE reg_no='" + textBox1.Text.ToString().Trim() + "'", con);
            /*  command.ExecuteNonQuery();
              myConnection.Close();*/
            try
            {
                 con.Open();
                SqlDataAdapter myAdapter = new SqlDataAdapter(command1);

               
                 SqlDataReader Reader = command1.ExecuteReader();          
                 MessageBox.Show(Reader.GetValue(0).ToString());
                 name = Reader.GetValue(0).ToString();
                 con.Close();
                con.Open();
                SqlDataReader myReader = command.ExecuteReader();
               
                while (myReader.Read())
                {
                    int val = Convert.ToInt32(myReader.GetValue(0).ToString());
                   // MessageBox.Show(comboBox1.Text.ToString().Trim());
                    if (comboBox1.Text.ToString().Trim() == "High Jump" || comboBox1.Text.ToString().Trim() == "Long Jump" || comboBox1.Text.ToString().Trim() == "Tripple jump" || comboBox1.Text.ToString().Trim() == "disc throw" || comboBox1.Text.ToString().Trim() == "shot put" || comboBox1.Text.ToString().Trim() == "javelin throw")
                    {
                       // MessageBox.Show((myReader.GetValue(0).ToString()));
                        if (Convert.ToInt32(myReader.GetValue(0).ToString()) < Convert.ToInt32(textBox4.Text.ToString()))
                        {
                            SqlCommand com = new SqlCommand("Update Special_records SET Record=@Record,Name=@Name,Year=@Year,RegNo=@RegNo where Event=@Event", con);
                            com.Parameters.AddWithValue("@Event", comboBox1.Text.ToString());
                            com.Parameters.AddWithValue("@RegNo", textBox1.Text.ToString());
                            com.Parameters.AddWithValue("@Name", name);
                            com.Parameters.AddWithValue("@Year", comboBox2.Text.ToString());
                            com.Parameters.AddWithValue("@Record", textBox4.Text.ToString());
                            con.Close();
                            con.Open();
                            com.ExecuteNonQuery();
                            MessageBox.Show(comboBox1.Text.ToString() + " Record Broken");
                            con.Close();
                        }
                    }

                    else if (comboBox1.Text.ToString().Trim() == "100M" || comboBox1.Text.ToString().Trim() == "200M" || comboBox1.Text.ToString().Trim() == "400M" || comboBox1.Text.ToString().Trim() == "800M" || comboBox1.Text.ToString().Trim() == "1500M" || comboBox1.Text.ToString().Trim() == "3000M")
                    {
                        MessageBox.Show((myReader.GetValue(0).ToString()));
                        if (Convert.ToInt32(myReader.GetValue(0)) > Convert.ToInt32(textBox4.Text.ToString()))
                        {
                            SqlCommand com = new SqlCommand("Update Special_records SET Record=@Record,Name=@Name,Year=@Year,RegNo=@RegNo where Event=@Event",con);
                            com.Parameters.AddWithValue("@Event", comboBox1.Text.ToString());
                            com.Parameters.AddWithValue("@RegNo", textBox1.Text.ToString());
                            com.Parameters.AddWithValue("@Year", comboBox2.Text.ToString());
                            com.Parameters.AddWithValue("@Name", name);
                            com.Parameters.AddWithValue("@Record", textBox4.Text.ToString());
                            con.Close();
                            con.Open();
                            com.ExecuteNonQuery();
                            MessageBox.Show(comboBox1.Text.ToString() + " Record Broken");
                            con.Close();

                        }

                    }

                }
            }
            catch (Exception ex)
            { }
        }

    }
}
