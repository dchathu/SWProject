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
    public partial class UpdateStudent : Form
    {
        static string conStr = Properties.Settings.Default.MainConString;
        static SqlConnection con = new SqlConnection(conStr);

        public UpdateStudent()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand myCommand = new SqlCommand("UPDATE StudentDetails SET Title=@title,FirstName=@first_name,LastName=@last_name,religion=@religion,Language=@mother_language,PermanantAddress=@permenent_address,Gender=@gender,NIC_No=@nic_num,ContactNumber=@contact_num,DateofBirth=@date_of_birth,AcedemicCourse=@academic_course,AcedemicYear=@academic_year,Hostel=@hostel_facilities,IndoorGames=@indoor_game,Athletics=@athletics,MajorGames=@major_games,Cultural=@cultural,EmailAddress=@email_address,FacebookId=@facebook_id,Status=@status WHERE RegNo=@reg_no", con);

            myCommand.Parameters.AddWithValue("@title", comboBox7.Text.ToString());
            myCommand.Parameters.AddWithValue("@first_name", txtFirstName.Text.ToString());
            myCommand.Parameters.AddWithValue("@last_name", txtLastName.Text.ToString());
            myCommand.Parameters.AddWithValue("@religion", comboBox8.Text.ToString());
            myCommand.Parameters.AddWithValue("@mother_language", comboBox9.Text.ToString());
            myCommand.Parameters.AddWithValue("@reg_no", comboBox2.Text.ToString());
            myCommand.Parameters.AddWithValue("@permenent_address", txtAddress.Text.ToString());
            myCommand.Parameters.AddWithValue("@gender", comboBox10.Text.ToString());
            myCommand.Parameters.AddWithValue("@nic_num", txtNIC.Text.ToString());
            myCommand.Parameters.AddWithValue("@contact_num", txtContactNo.Text.ToString());
            myCommand.Parameters.AddWithValue("@date_of_birth", dateTimePicker1.Text.ToString());
            myCommand.Parameters.AddWithValue("@academic_course", comboBox11.Text.ToString());
            myCommand.Parameters.AddWithValue("@academic_year", comboBox12.Text.ToString());
            if (radioButton1.Checked)
                myCommand.Parameters.AddWithValue("@hostel_facilities", txtRoomNo.Text.ToString());
            else if (radioButton2.Checked)
                myCommand.Parameters.AddWithValue("@hostel_facilities", radioButton2.Text.ToString());
            myCommand.Parameters.AddWithValue("@indoor_game", richTextBox1.Text.ToString());
            myCommand.Parameters.AddWithValue("@athletics", richTextBox2.Text.ToString());
            myCommand.Parameters.AddWithValue("@major_games", richTextBox3.Text.ToString());
            myCommand.Parameters.AddWithValue("@cultural", richTextBox4.Text.ToString());
            myCommand.Parameters.AddWithValue("@email_address", textBox57.Text.ToString());
            myCommand.Parameters.AddWithValue("@facebook_id", textBox56.Text.ToString());
            myCommand.Parameters.AddWithValue("@status", comboBox1.Text.ToString());
           

            myCommand.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Successfully Updated!!!");
            Reset();
        }
                     
        private void UpdateStudent_Load(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Select RegNo from StudentDetails", con);
            SqlDataReader rdr = cmd.ExecuteReader();
            

            while (rdr.Read())
            {
                comboBox2.Items.Add(rdr.GetValue(0).ToString());
            }
            rdr.Close();
            rdr.Dispose();
            con.Close();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT*FROM StudentDetails WHERE RegNo=@reg_no", con);
            cmd.Parameters.AddWithValue("@reg_no", comboBox2.Text.ToString());

            SqlDataReader myReader = cmd.ExecuteReader();

            while (myReader.Read())
            {
                comboBox2.Text = myReader.GetValue(5).ToString();
                comboBox7.Text = myReader.GetValue(1).ToString();
                txtFirstName.Text = myReader.GetValue(2).ToString();
                txtLastName.Text = myReader.GetValue(3).ToString();
                comboBox8.Text = myReader.GetValue(18).ToString();
                comboBox9.Text = myReader.GetValue(17).ToString();
                comboBox10.Text = myReader.GetValue(6).ToString();
                txtAddress.Text = myReader.GetValue(4).ToString();
                txtNIC.Text = myReader.GetValue(7).ToString();
                txtContactNo.Text = myReader.GetValue(12).ToString();
                dateTimePicker1.Text = myReader.GetValue(9).ToString();
                comboBox12.Text = myReader.GetValue(6).ToString();
                comboBox11.Text = myReader.GetValue(10).ToString();

                if (myReader.GetValue(22).ToString() != "N/A" && myReader.GetValue(22).ToString()=="Yes")
                {
                    radioButton1.Checked = true;
                    lblRoomNo.Visible = true;
                    txtRoomNo.Visible = true;
                    //txtRoomNo.Text = myReader.GetValue(13).ToString();
                }
                else
                    radioButton2.Checked = true;

                richTextBox1.Text = myReader.GetValue(23).ToString();
                richTextBox2.Text = myReader.GetValue(24).ToString();
                richTextBox3.Text = myReader.GetValue(25).ToString();
                richTextBox4.Text = myReader.GetValue(19).ToString();
                textBox57.Text = myReader.GetValue(14).ToString();
                textBox56.Text = myReader.GetValue(15).ToString();
            }
            myReader.Close();
            myReader.Dispose();
            con.Close();
        }

        public void Reset()
        {
            comboBox2.Text="";
            comboBox7.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            comboBox8.Text = "";
            comboBox9.Text = "";
            comboBox10.Text = "";
            txtAddress.Text = "";
            txtNIC.Text = "";
            txtContactNo.Text = "";
            dateTimePicker1.Text = "";
            comboBox12.Text = "";
            comboBox11.Text = "";
           
            radioButton1.Checked = false;
            radioButton2.Checked = false;         
            richTextBox1.Text = "";
            richTextBox2.Text = "";
            richTextBox3.Text = "";
            richTextBox4.Text = "";
            textBox57.Text = "";
            textBox56.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UpdateStudent_FormClosing(object sender, FormClosingEventArgs e)
        {
            ReportStudents rs = (ReportStudents)Application.OpenForms["ReportStudents"];
            if (rs != null)
            {
                rs.TopMost = true;
            }
        }

    }
}
