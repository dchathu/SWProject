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
    public partial class LoginRegister : Form
    {
        static string conStr = Properties.Settings.Default.MainConString;
        public static SqlConnection con = new SqlConnection(conStr);
        SqlDataAdapter da;

        public LoginRegister()
        {
            InitializeComponent();
        }
       
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            con.Open();

            SqlCommand myCommand = new SqlCommand("INSERT INTO LoginDetails (Username,Password,Name,Contact_No,Email,Date_of_joining,Usertype)VALUES (@Username,@Password,@Name,@Contact_No,@Email,@Date_of_joining,@Usertype)", con);

            myCommand.Parameters.AddWithValue("@Username",textBox1.Text.ToString());
            myCommand.Parameters.AddWithValue("@Password",textBox2.Text.ToString());
            myCommand.Parameters.AddWithValue("@Name", textBox3.Text.ToString());
            myCommand.Parameters.AddWithValue("@Contact_No", textBox4.Text.ToString());
            myCommand.Parameters.AddWithValue("@Email", textBox5.Text.ToString());
            myCommand.Parameters.AddWithValue("@Date_of_joining", textBox6.Text.ToString());
            myCommand.Parameters.AddWithValue("@Usertype", comboBox1.SelectedItem.ToString());

            myCommand.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Successfully added!!!");
            Reset();                       
        }

        public void Reset()
        {
            comboBox1.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
        }
        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            System.Text.RegularExpressions.Regex rEMail = new System.Text.RegularExpressions.Regex("^[a-zA-Z0-9_]");
            if (textBox1.Text.Length > 0)
            {
                if (!rEMail.IsMatch(textBox1.Text))
                {
                    MessageBox.Show("only letters,numbers and underscore is allowed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox1.SelectAll();
                    e.Cancel = true;
                }
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT Username FROM LoginDetails where Username=@find", con);
                cmd.Parameters.Add(new SqlParameter("@find", System.Data.SqlDbType.NChar, 30, "Username"));
                cmd.Parameters["@find"].Value = textBox1.Text;

                SqlDataReader rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    MessageBox.Show("Username Already Exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox1.Text = "";
                    textBox1.Focus();

                    if ((rdr != null))
                    {
                        rdr.Close();
                    }
                    return;
                }
                rdr.Close();
                rdr.Dispose();
                con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
