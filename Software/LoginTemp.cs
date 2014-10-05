using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Data.SqlClient;

namespace Software
{
    public partial class LoginTemp : Form
    {
        static string conStr = Properties.Settings.Default.MainConString;
        static SqlConnection con = new SqlConnection(conStr);

        public LoginTemp()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string getuser = txtUser.Text.ToString().Trim();
            string getpass = txtPass.Text.ToString().Trim();

            con.Open();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            da.SelectCommand=new SqlCommand("SELECT*FROM Login WHERE Username=@getuser AND Password=@encPass", con);
            da.SelectCommand.Parameters.AddWithValue("@getuser", getuser);
            da.SelectCommand.Parameters.AddWithValue("@encPass", hashPass(getpass, getuser));
            da.Fill(dt);
            con.Close();

            if (dt.Rows.Count == 1)
            {
                Properties.Settings.Default.User = getuser;
                Properties.Settings.Default.UserType = dt.Rows[0].ItemArray[3].ToString().Trim();
                MessageBox.Show(Properties.Settings.Default.UserType.ToString());
                CoverPage cs = new CoverPage();
                cs.Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show("Invalid username or password!");
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if(txtUser.Text=="Username")
                txtUser.Text = string.Empty;
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if(txtPass.Text=="Password")
            txtPass.Text = string.Empty;
        }

        private void LoginTemp_Load(object sender, EventArgs e)
        {
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
            
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (txtUser.Text == string.Empty)
                txtUser.Text = "Username";
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (txtPass.Text == string.Empty)
                txtPass.Text = "Password";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private string hashPass(string pass,string user)
        {
            SHA256 sha = new SHA256CryptoServiceProvider();
            sha.ComputeHash(ASCIIEncoding.ASCII.GetBytes(pass + user));
            byte[] result = sha.Hash;

            StringBuilder stb = new StringBuilder();
            for (int i = 0; i < result.Length; i++)
            {
                stb.Append(result[i].ToString("X2"));
            }

            return stb.ToString();
        }

    }
}
