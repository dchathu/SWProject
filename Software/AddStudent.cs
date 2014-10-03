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
    public partial class AddStudent : Form
    {
        static string conStr = Properties.Settings.Default.MainConString;
        static SqlConnection con = new SqlConnection(conStr);
        SqlDataAdapter da,daf;

        //SqlConnection myConnection = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\Student_personal1.mdf;Integrated Security=True;User Instance=True");
        public static string hostelfacility="N/A";
        public static string mt="N/A";

        public AddStudent()
        {
            InitializeComponent();
            this.tabPage1.Text = "page 1";
            this.tabPage2.Text = "page 2";
            this.tabPage3.Text = "page 3";
            this.tabPage5.Text = "page 4"; 
            this.tabPage6.Text = "page 5";
        }


        #region Add Details
        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
                hostelfacility = radioButton1.Text.ToString();
            else if (radioButton2.Checked)
                hostelfacility = radioButton2.Text.ToString();

            if (radioButton6.Checked)
                mt = radioButton6.Text.ToString();
            else if (radioButton5.Checked)
                mt = radioButton5.Text.ToString();
            try
            {
                con.Open();

                da = new SqlDataAdapter();
                daf = new SqlDataAdapter();
                da.InsertCommand = new SqlCommand("INSERT INTO StudentDetails (Title,FirstName,LastName,Religion,Language,RegNo,PermanantAddress,Gender,NIC_No,ContactNumber,DateofBirth,AcedemicCourse,AcedemicYear,Hostel,School,AL_Results,IndoorGames,Athletics,MajorGames,Cultural,District,EmailAddress,FacebookId,MedicalTreatment,Status)VALUES (@title,@first_name,@last_name,@religion,@mother_language,@reg_no,@permenent_address,@gender,@nic_num,@contact_num,@date_of_birth,@academic_course,@academic_year,@hostel_facilities,@school_attended,@al_results,@indoor_game,@athletics,@major_games,@cultural,@district,@email_address,@facebook_id,@medical_treatment,@status)", con);

                da.InsertCommand.Parameters.AddWithValue("@title", comboBox7.Text.ToString());
                da.InsertCommand.Parameters.AddWithValue("@first_name", txtFirstName.Text.ToString());
                da.InsertCommand.Parameters.AddWithValue("@last_name", txtLastName.Text.ToString());
                da.InsertCommand.Parameters.AddWithValue("@religion", comboBox8.SelectedItem.ToString());
                da.InsertCommand.Parameters.AddWithValue("@mother_language", comboBox9.SelectedItem.ToString());
                da.InsertCommand.Parameters.AddWithValue("@reg_no", txtRegNo.Text.ToString());
                da.InsertCommand.Parameters.AddWithValue("@permenent_address", txtAddress.Text.ToString());
                da.InsertCommand.Parameters.AddWithValue("@gender", comboBox10.SelectedItem.ToString());
                da.InsertCommand.Parameters.AddWithValue("@nic_num", txtNIC.Text.ToString());
                da.InsertCommand.Parameters.AddWithValue("@contact_num", txtContactNo.Text.ToString());
                da.InsertCommand.Parameters.AddWithValue("@date_of_birth", dateTimePicker1.Text.ToString());
                da.InsertCommand.Parameters.AddWithValue("@academic_course", comboBox11.Text.ToString());
                da.InsertCommand.Parameters.AddWithValue("@academic_year", comboBox12.SelectedItem.ToString());
                da.InsertCommand.Parameters.AddWithValue("@hostel_facilities", hostelfacility);
                da.InsertCommand.Parameters.AddWithValue("@school_attended", textBox1.Text.ToString());
                da.InsertCommand.Parameters.AddWithValue("@al_results", comboBox1.SelectedItem.ToString() + comboBox5.SelectedItem.ToString() + comboBox3.SelectedItem.ToString() + comboBox4.SelectedItem.ToString() + comboBox2.SelectedItem.ToString() + comboBox6.SelectedItem.ToString());
                da.InsertCommand.Parameters.AddWithValue("@indoor_game", richTextBox1.Text.ToString());
                da.InsertCommand.Parameters.AddWithValue("@athletics", richTextBox2.Text.ToString());
                da.InsertCommand.Parameters.AddWithValue("@major_games", richTextBox3.Text.ToString());
                da.InsertCommand.Parameters.AddWithValue("@cultural", richTextBox4.Text.ToString());
                da.InsertCommand.Parameters.AddWithValue("@district", textBox59.Text.ToString());
                da.InsertCommand.Parameters.AddWithValue("@email_address", textBox57.Text.ToString());
                da.InsertCommand.Parameters.AddWithValue("@facebook_id", textBox56.Text.ToString());
                da.InsertCommand.Parameters.AddWithValue("@medical_treatment", mt);
                da.InsertCommand.Parameters.AddWithValue("@status", "Following");

                da.InsertCommand.ExecuteNonQuery();

                daf.InsertCommand = new SqlCommand("INSERT INTO FamilyDetails (RegNo,Name,Age,Relationship,Job,Salery) VALUES(@reg_no,@name,@age,@relationship,@job,@salary)", con);

                daf.InsertCommand.Parameters.AddWithValue("@reg_no", txtRegNo.Text.ToString());
                daf.InsertCommand.Parameters.AddWithValue("@name", txtNameFam.Text.ToString());
                daf.InsertCommand.Parameters.AddWithValue("@age", txtAgeFam.Text.ToString());
                daf.InsertCommand.Parameters.AddWithValue("@relationship", cmbRelation.Text.ToString());
                daf.InsertCommand.Parameters.AddWithValue("@job", txtJobFam.Text.ToString());
                daf.InsertCommand.Parameters.AddWithValue("@salary", txtSalaryFam.Text.ToString());
                con.Close();
                MessageBox.Show("Successfully added!!!");
                Reset();
            }
            catch (Exception ex)
            { MessageBox.Show("Input Error", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        #endregion

        #region Add More Relations

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
               
                daf.InsertCommand = new SqlCommand("INSERT INTO FamilyDetails (RegNo,Name,Age,Relationship,Job,Salery) VALUES(@reg_no,@name,@age,@relationship,@job,@salary)", con);

                daf.InsertCommand.Parameters.AddWithValue("@reg_no", txtRegNo.Text.ToString());
                daf.InsertCommand.Parameters.AddWithValue("@name", txtNameFam.Text.ToString());
                daf.InsertCommand.Parameters.AddWithValue("@age", txtAgeFam.Text.ToString());
                daf.InsertCommand.Parameters.AddWithValue("@relationship", cmbRelation.Text.ToString());
                daf.InsertCommand.Parameters.AddWithValue("@job", txtJobFam.Text.ToString());
                daf.InsertCommand.Parameters.AddWithValue("@salary", txtSalaryFam.Text.ToString());
                con.Open();
                daf.InsertCommand.ExecuteNonQuery();
                con.Close();

                txtNameFam.Text = "";
                txtAgeFam.Text = "";
                cmbRelation.Text = "";
                txtJobFam.Text = "";
                txtSalaryFam.Text = "";
            }
            catch(Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        #endregion

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            txtRoomNo.Visible = true;
            lblRoomNo.Visible = true;
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            textBox55.Visible = true;
        }

        public void Reset()
        {
            comboBox2.Text = "";
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
            txtRegNo.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton5.Checked = false;
            radioButton6.Checked = false;
            richTextBox1.Text = "";
            richTextBox2.Text = "";
            richTextBox3.Text = "";
            richTextBox4.Text = "";
            textBox57.Text = "";
            textBox55.Visible = false;
            textBox56.Text = "";
            dateTimePicker1.Text = "";
            txtRoomNo.Visible = false;
            lblRoomNo.Visible = false;
            comboBox1.Text = "";
            comboBox3.Text = "";
            comboBox4.Text = "";
            comboBox5.Text = "";
            comboBox6.Text = "";
            textBox1.Text = "";
            txtNameFam.Text = "";
            txtAgeFam.Text = "";
            cmbRelation.Text = "";
            txtJobFam.Text = "";
            txtSalaryFam.Text = "";
            textBox59.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

     
        private void txtRegNo_Validated(object sender, EventArgs e)
        {
            if (txtRegNo.TextLength < 11)
                errorProvider1.SetError(txtRegNo, "enter corect format");
            else if (txtRegNo.Text != "")
            {
                string x = txtRegNo.Text;
                if (!Check_year(x))
                {
                    errorProvider1.SetError(txtRegNo, "enter year code corectly");
                }
                if (!Check_course(x))
                {
                    errorProvider1.SetError(txtRegNo, "enter course code corectly");
                }
                else
                    errorProvider1.Clear();
            }
            else
            errorProvider1.Clear();
        }

        private Boolean Check_course(string s)
        {
            bool a = false;
            if (s.Substring(5, 3) == "ICT" || s.Substring(5, 3) == "ASE" || s.Substring(5, 3) == "ASP")
            {
                a = true;
            }
            else
            {
                a = false;
            }
            return a;
        }

        private Boolean Check_year(string s)
        {
            bool a = false;
            if (s.Substring(0, 4) == "2007" || s.Substring(0, 4) == "2008" || s.Substring(0, 4) == "2009" || s.Substring(0, 4) == "2010" || s.Substring(0, 4) == "2011" || s.Substring(0, 4) == "2012" || s.Substring(0, 4) == "2013" || s.Substring(0, 4) == "2014" || s.Substring(0, 4) == "2015" || s.Substring(0, 4) == "2016")
            {
                a = true;
            }
            else
            {
                a = false;
            }
            return a;
        }

        private Boolean Check_format(string s)
        {
            bool a = false;
            if (s.Substring(4, 1) == "/" || s.Substring(8, 1) == "/" )
            {
                a = true;
            }
            else
            {
                a = false;
            }
            return a;
        }

        private Boolean Check_subject(string s)
        {
            bool c = false;
            for (int i = 3; i < s.Length; i++)
            {
                if (Char.IsNumber(s[i]))
                {
                    c = true;
                }
                else
                {
                    c = false;
                    break;
                }
            }
            return c;
        }

        private void txtRegNo_Leave(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                SqlCommand cmd = new SqlCommand("SELECT RegNo FROM StudentDetails where RegNo=@find", con);
                cmd.Parameters.AddWithValue("@find", txtRegNo.Text);

                SqlDataReader rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    MessageBox.Show("Registration Number Already Exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtRegNo.Text = "";
                    txtRegNo.Focus();

                    if ((rdr != null))
                    {
                        rdr.Close();
                    }
                    return;
                }
                con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox57_Validating(object sender, CancelEventArgs e)
        {
            System.Text.RegularExpressions.Regex rEMail = new System.Text.RegularExpressions.Regex(@"^[a-zA-Z][\w\.-]{2,28}[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$");
            if (textBox57.Text.Length > 0)
            {
                if (!rEMail.IsMatch(textBox57.Text))
                {
                    MessageBox.Show("invalid email address", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox57.SelectAll();
                    e.Cancel = true;
                }
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            txtRoomNo.Visible = false;
            lblRoomNo.Visible = false;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            textBox55.Visible = false;
        }

        private void AddStudent_FormClosing(object sender, FormClosingEventArgs e)
        {
            ReportStudents rs = (ReportStudents)Application.OpenForms["ReportStudents"];
            if (rs != null)
            {
                rs.TopMost = true;
            }
        }

        private void txtRegNo_TextChanged(object sender, EventArgs e)
        {
            btnAddAnother.Enabled = true;
        }

        private void AddStudent_Load(object sender, EventArgs e)
        {
            tabPage1.Text = "Page 1";
            tabPage2.Text = "Page 2";
            tabPage3.Text = "Page 3";
            tabPage5.Text = "Page 4";
            tabPage6.Text = "Page 5";

            btnAddAnother.Enabled = false;
            button2.Enabled = false;
        }

        private void txtContactNo_Validated(object sender, EventArgs e)
        {
            string wrd = txtContactNo.Text.ToString();
            Boolean flag = true;
            foreach (char c in wrd)
            {
                if (char.IsLetter(c))
                {
                    flag = false;
                    break;
                }

            }

            if (txtContactNo.TextLength < 10)
            {
                errorProvider2.SetError(txtContactNo, "enter correct Number ");

            }
            if (flag == false)
            {
                errorProvider2.SetError(txtContactNo, "enter digits");
            }

            else
            {
                errorProvider2.Clear();
            }
        }

        private void tabPage6_Click(object sender, EventArgs e)
        {
            
        }

        private void txtNameFam_TextChanged(object sender, EventArgs e)
        {
            button2.Enabled = true;
        }

        private void tabPage5_Click(object sender, EventArgs e)
        {

        }
    }
}
