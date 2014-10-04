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
    public partial class Login : Form
    {
        public static int usr;
        string type;
        public Login()
        {
            InitializeComponent();
        }

       

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #region
        private void button1_Click(object sender, EventArgs e)
        {
            
                
           
            if (textBox1.Text == "")
            {
                MessageBox.Show("Please enter user name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Focus();
                return;
            }
            if (textBox2.Text == "")
            {
                MessageBox.Show("Please enter password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox2.Focus();
                return;
            }
            try
            {
                SqlConnection myConnection = default(SqlConnection);
                myConnection = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\admin\Desktop\Software\Software\Login.mdf;Integrated Security=True;User Instance=True");

                SqlCommand myCommand = default(SqlCommand);

                myCommand = new SqlCommand(@"SELECT Usertype,Username,Password FROM LoginRegisterform WHERE Usertype = @Usertype AND Username = @Username AND Password = @Password", myConnection);
                SqlParameter uType = new SqlParameter("@Usertype", SqlDbType.NChar);

                SqlParameter uName = new SqlParameter("@username", SqlDbType.NChar);

                SqlParameter uPassword = new SqlParameter("@Password", SqlDbType.NChar);

                uType.Value = type;
                uName.Value = textBox1.Text.Trim();
                uPassword.Value = textBox2.Text.Trim();

                myCommand.Parameters.Add(uType);
                myCommand.Parameters.Add(uName);
                myCommand.Parameters.Add(uPassword);

                myCommand.Connection.Open();

                SqlDataReader myReader = myCommand.ExecuteReader(CommandBehavior.CloseConnection);

                if (myReader.Read() == true)
                {                   
                        int i;
                        ProgressBar1.Visible = true;
                        ProgressBar1.Maximum = 5000;
                        ProgressBar1.Minimum = 0;
                        ProgressBar1.Value = 4;
                        ProgressBar1.Step = 1;

                        for (i = 0; i <= 5000; i++)
                        {
                            ProgressBar1.PerformStep();
                        }
                        this.Hide();
                        CoverPage s = new CoverPage();
                        s.FormClosed += new FormClosedEventHandler(form_FormClosed);
                        s.Show();
                        this.Hide();
                    }                
                else
                {
                    MessageBox.Show("Login is Failed...Try again !", "Login Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    textBox1.Clear();
                    textBox2.Clear();
                    textBox1.Focus();

                }
                if (myConnection.State == ConnectionState.Open)
                {
                    myConnection.Dispose();
                }              
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        #endregion
        }
        private void form_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void changestyle(object sender, EventArgs e)
        {
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.BorderStyle = BorderStyle.None;
        }

        private void changestyle1(object sender, EventArgs e)
        {
            pictureBox2.BorderStyle = BorderStyle.Fixed3D;
        }
        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.BorderStyle = BorderStyle.None;
        }
        private void changestyle2(object sender, EventArgs e)
        {
            pictureBox3.BorderStyle = BorderStyle.Fixed3D;
        }
        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.BorderStyle = BorderStyle.None;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            type = "Admin";
            usr = 0;
            visible();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            type = "Viewer";
            usr = 2;
            visible();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            type = "User";
            usr = 1;
            visible();
        }

        public void visible()
        {
            pictureBox4.Visible = true;
            label2.Visible = true; ;
            label3.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
            button1.Visible = true;
        }
       
           
}
}
