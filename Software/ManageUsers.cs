using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;


namespace Software
{
    public partial class ManageUsers : Form
    {
        static string conStr = Properties.Settings.Default.MainConString;
        static SqlConnection con = new SqlConnection(conStr);


        public ManageUsers()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string user = txtUser.Text.ToString().Trim();
            string pass = txtPass.Text.ToString().Trim();

            string encrypted = hashPass(pass, user);

            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO Login (Username,Password,UserType) VALUES (@user,@passEnc,'Admin')", con);
            cmd.Parameters.AddWithValue("@user", user);
            cmd.Parameters.AddWithValue("@passEnc", encrypted);

            cmd.ExecuteNonQuery();
            con.Close();
        }

        private string hashPass(string pass, string user)
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
