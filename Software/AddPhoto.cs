using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace Software
{

    public partial class AddPhoto : Form
    {

        static string conStr = Properties.Settings.Default.GalleryConStr;
        static SqlConnection con = new SqlConnection(conStr);

        public static string albumName;
        public AddPhoto()
        {
            InitializeComponent();
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                pictureBox1.Visible = true;
            }
        }



        private void btnAddMore_Click(object sender, EventArgs e)
        {
            byte[] img;

            pictureBox1.Image = null;
            pictureBox2.Image = null;
            pictureBox3.Image = null;
            pictureBox4.Image = null;
            pictureBox5.Image = null;
            pictureBox6.Image = null;
            pictureBox7.Image = null;
            pictureBox8.Image = null;
            pictureBox9.Image = null;
            pictureBox10.Image = null;
            pictureBox11.Image = null;
            pictureBox12.Image = null;


            SqlCommand command = new SqlCommand("INSERT INTO AddPhotos (AlbumName,Image) VALUES(@AlbumName,@Image)", con);
            img = File.ReadAllBytes(pictureBox1.ImageLocation);
            command.Parameters.AddWithValue("@Image", img);
            command.Parameters.AddWithValue("@AlbumName", textBox1.Text.ToString());

            SqlCommand command1 = new SqlCommand("INSERT INTO AddPhotos (AlbumName,Image) VALUES(@AlbumName,@Image)", con);
            img = File.ReadAllBytes(pictureBox2.ImageLocation);
            command1.Parameters.AddWithValue("@Image", img);
            command1.Parameters.AddWithValue("@AlbumName", textBox1.Text.ToString());


            SqlCommand command2 = new SqlCommand("INSERT INTO AddPhotos (AlbumName,Image) VALUES(@AlbumName1,@Photos)", con);
            img = File.ReadAllBytes(pictureBox3.ImageLocation);
            command2.Parameters.AddWithValue("@Photos", img);
            command2.Parameters.AddWithValue("@AlbumName1", textBox1.Text.ToString());

            SqlCommand command3 = new SqlCommand("INSERT INTO AddPhotos (AlbumName,Image) VALUES(@AlbumName2,@Image2)", con);
            img = File.ReadAllBytes(pictureBox4.ImageLocation);
            command3.Parameters.AddWithValue("@Image2", img);
            command3.Parameters.AddWithValue("@AlbumName2", textBox1.Text.ToString());

            SqlCommand command4 = new SqlCommand("INSERT INTO AddPhotos (AlbumName,Image) VALUES(@AlbumName3,@Image3)", con);
            img = File.ReadAllBytes(pictureBox5.ImageLocation);
            command4.Parameters.AddWithValue("@Image3", img);
            command4.Parameters.AddWithValue("@AlbumName3", textBox1.Text.ToString());

            SqlCommand command5 = new SqlCommand("INSERT INTO AddPhotos (AlbumName,Image) VALUES(@AlbumName4,@Image4)", con);
            img = File.ReadAllBytes(pictureBox6.ImageLocation);
            command5.Parameters.AddWithValue("@Image4", img);
            command5.Parameters.AddWithValue("@AlbumName4", textBox1.Text.ToString());


            SqlCommand command6 = new SqlCommand("INSERT INTO AddPhotos (AlbumName,Image) VALUES(@AlbumName5,@Image5)", con);
            img = File.ReadAllBytes(pictureBox7.ImageLocation);
            command6.Parameters.AddWithValue("@Image5", img);
            command6.Parameters.AddWithValue("@AlbumName5", textBox1.Text.ToString());


            SqlCommand command7 = new SqlCommand("INSERT INTO AddPhotos (AlbumName,Image) VALUES(@AlbumName6,@Image6)", con);
            img = File.ReadAllBytes(pictureBox8.ImageLocation);
            command7.Parameters.AddWithValue("@Image6", img);
            command7.Parameters.AddWithValue("@AlbumName6", textBox1.Text.ToString());


            SqlCommand command8 = new SqlCommand("INSERT INTO AddPhotos (AlbumName,Image) VALUES(@AlbumName7,@Image7)", con);
            img = File.ReadAllBytes(pictureBox9.ImageLocation);
            command8.Parameters.AddWithValue("@Image7", img);
            command8.Parameters.AddWithValue("@AlbumName7", textBox1.Text.ToString());


            SqlCommand command9 = new SqlCommand("INSERT INTO AddPhotos (AlbumName,Image) VALUES(@AlbumName8,@Image8)", con);
            img = File.ReadAllBytes(pictureBox10.ImageLocation);
            command9.Parameters.AddWithValue("@Image8", img);
            command9.Parameters.AddWithValue("@AlbumName8", textBox1.Text.ToString());


            SqlCommand command10 = new SqlCommand("INSERT INTO AddPhotos (AlbumName,Image) VALUES(@AlbumName9,@Image9)", con);
            img = File.ReadAllBytes(pictureBox11.ImageLocation);
            command10.Parameters.AddWithValue("@Image9", img);
            command10.Parameters.AddWithValue("@AlbumName9", textBox1.Text.ToString());

            SqlCommand command11 = new SqlCommand("INSERT INTO AddPhotos (AlbumName,Image) VALUES(@AlbumName10,@Image10)", con);
            img = File.ReadAllBytes(pictureBox12.ImageLocation);
            command11.Parameters.AddWithValue("@Image10", img);
            command11.Parameters.AddWithValue("@AlbumName10", textBox1.Text.ToString());

            con.Open();

            command.ExecuteNonQuery();
            command1.ExecuteNonQuery();
            command2.ExecuteNonQuery();
            command3.ExecuteNonQuery();
            command4.ExecuteNonQuery();
            command5.ExecuteNonQuery();
            command6.ExecuteNonQuery();
            command7.ExecuteNonQuery();
            command8.ExecuteNonQuery();
            command9.ExecuteNonQuery();
            command10.ExecuteNonQuery();
            command11.ExecuteNonQuery();

            con.Close();
            // MessageBox.Show("Successfully updated!");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "Image files (*.jpg)|*.jpg|All files(*.*)|*.*";
            if (file.ShowDialog() == DialogResult.OK)
            {
                pictureBox2.ImageLocation = file.FileName;
            }

            if (pictureBox1.Image != null)
            {
                pictureBox3.Visible = true;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "Image files (*.jpg)|*.jpg|All files(*.*)|*.*";
            if (file.ShowDialog() == DialogResult.OK)
            {
                pictureBox3.ImageLocation = file.FileName;
            }

            if (pictureBox1.Image != null)
            {
                pictureBox4.Visible = true;
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "Image files (*.jpg)|*.jpg|All files(*.*)|*.*";
            if (file.ShowDialog() == DialogResult.OK)
            {
                pictureBox4.ImageLocation = file.FileName;
            }

            if (pictureBox1.Image != null)
            {
                pictureBox5.Visible = true;
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "Image files (*.jpg)|*.jpg|All files(*.*)|*.*";
            if (file.ShowDialog() == DialogResult.OK)
            {
                pictureBox5.ImageLocation = file.FileName;
            }

            if (pictureBox1.Image != null)
            {
                pictureBox6.Visible = true;
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "Image files (*.jpg)|*.jpg|All files(*.*)|*.*";
            if (file.ShowDialog() == DialogResult.OK)
            {
                pictureBox6.ImageLocation = file.FileName;
            }

            if (pictureBox1.Image != null)
            {
                pictureBox7.Visible = true;
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "Image files (*.jpg)|*.jpg|All files(*.*)|*.*";
            if (file.ShowDialog() == DialogResult.OK)
            {
                pictureBox7.ImageLocation = file.FileName;
            }

            if (pictureBox1.Image != null)
            {
                pictureBox8.Visible = true;
            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "Image files (*.jpg)|*.jpg|All files(*.*)|*.*";
            if (file.ShowDialog() == DialogResult.OK)
            {
                pictureBox8.ImageLocation = file.FileName;
            }

            if (pictureBox1.Image != null)
            {
                pictureBox9.Visible = true;
            }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "Image files (*.jpg)|*.jpg|All files(*.*)|*.*";
            if (file.ShowDialog() == DialogResult.OK)
            {
                pictureBox9.ImageLocation = file.FileName;
            }

            if (pictureBox1.Image != null)
            {
                pictureBox10.Visible = true;
            }
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "Image files (*.jpg)|*.jpg|All files(*.*)|*.*";
            if (file.ShowDialog() == DialogResult.OK)
            {
                pictureBox10.ImageLocation = file.FileName;
            }

            if (pictureBox1.Image != null)
            {
                pictureBox11.Visible = true;
            }
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "Image files (*.jpg)|*.jpg|All files(*.*)|*.*";
            if (file.ShowDialog() == DialogResult.OK)
            {
                pictureBox11.ImageLocation = file.FileName;
            }

            if (pictureBox1.Image != null)
            {
                pictureBox12.Visible = true;
            }
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "Image files (*.jpg)|*.jpg|All files(*.*)|*.*";
            if (file.ShowDialog() == DialogResult.OK)
            {
                pictureBox12.ImageLocation = file.FileName;
            }


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "Image files (*.jpg)|*.jpg|All files(*.*)|*.*";
            if (file.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = file.FileName;
            }


            pictureBox2.Visible = true;


        }


        private void btnSave_Click_1(object sender, EventArgs e)
        {
            
            byte[] img1;
            albumName = this.textBox1.Text.ToString();

            try
            {
                con.Open();
                SqlCommand command = new SqlCommand("INSERT INTO AddPhotos(AlbumName,Image) VALUES(@AlbumName,@Image)", con);
                
                if (pictureBox1.Image != null)
                {
                    img1 = File.ReadAllBytes(pictureBox1.ImageLocation);
                    command.Parameters.AddWithValue("@Image", img1);
                    command.Parameters.AddWithValue("@AlbumName", albumName);
                    command.ExecuteNonQuery();
                }

                SqlCommand command1 = new SqlCommand("INSERT INTO AddPhotos (AlbumName,Image) VALUES(@AlbumName,@Image)", con);
                if (pictureBox2.Image != null)
                {
                    img1 = File.ReadAllBytes(pictureBox2.ImageLocation);
                    command1.Parameters.AddWithValue("@Image", img1);
                    command1.Parameters.AddWithValue("@AlbumName", albumName);

                    command1.ExecuteNonQuery();
                }

                SqlCommand command2 = new SqlCommand("INSERT INTO AddPhotos (AlbumName,Image) VALUES(@AlbumName,@Image3)", con);

                if (pictureBox3.Image != null)
                {
                    img1 = File.ReadAllBytes(pictureBox3.ImageLocation);
                    command2.Parameters.AddWithValue("@Image3", img1);
                    command2.Parameters.AddWithValue("@AlbumName", albumName);

                    command2.ExecuteNonQuery();
                }

                SqlCommand command3 = new SqlCommand("INSERT INTO AddPhotos (AlbumName,Image) VALUES(@AlbumName,@Image4)", con);
                if (pictureBox4.Image != null)
                {
                    img1 = File.ReadAllBytes(pictureBox4.ImageLocation);
                    command3.Parameters.AddWithValue("@Image4", img1);
                    command3.Parameters.AddWithValue("@AlbumName", albumName);

                    command3.ExecuteNonQuery();
                }

                SqlCommand command4 = new SqlCommand("INSERT INTO AddPhotos (AlbumName,Image) VALUES(@AlbumName,@Image5)", con);
                if (pictureBox5.Image != null)
                {
                    img1 = File.ReadAllBytes(pictureBox5.ImageLocation);
                    command4.Parameters.AddWithValue("@Image5", img1);
                    command4.Parameters.AddWithValue("@AlbumName", textBox1.Text.ToString());

                    command4.ExecuteNonQuery();
                }

                SqlCommand command5 = new SqlCommand("INSERT INTO AddPhotos (AlbumName,Image) VALUES(@AlbumName,@Image6)", con);
                if (pictureBox6.Image != null)
                {
                    img1 = File.ReadAllBytes(pictureBox6.ImageLocation);
                    command5.Parameters.AddWithValue("@Image6", img1);
                    command5.Parameters.AddWithValue("@AlbumName", textBox1.Text.ToString());

                    command5.ExecuteNonQuery();
                }


                SqlCommand command6 = new SqlCommand("INSERT INTO AddPhotos (AlbumName,Image) VALUES(@AlbumName,@Image7)", con);
                if (pictureBox7.Image != null)
                {
                    img1 = File.ReadAllBytes(pictureBox7.ImageLocation);
                    command6.Parameters.AddWithValue("@Image7", img1);
                    command6.Parameters.AddWithValue("@AlbumName", textBox1.Text.ToString());

                    command6.ExecuteNonQuery();
                }


                SqlCommand command7 = new SqlCommand("INSERT INTO AddPhotos (AlbumName,Image) VALUES(@AlbumName,@Image8)", con);
                if (pictureBox8.Image != null)
                {
                    img1 = File.ReadAllBytes(pictureBox8.ImageLocation);
                    command7.Parameters.AddWithValue("@Image8", img1);
                    command7.Parameters.AddWithValue("@AlbumName", textBox1.Text.ToString());

                    command7.ExecuteNonQuery();
                }


                SqlCommand command8 = new SqlCommand("INSERT INTO AddPhotos (AlbumName,Image) VALUES(@AlbumName,@Image9)", con);
                if (pictureBox9.Image != null)
                {
                    img1 = File.ReadAllBytes(pictureBox9.ImageLocation);
                    command8.Parameters.AddWithValue("@Image9", img1);
                    command8.Parameters.AddWithValue("@AlbumName", textBox1.Text.ToString());

                    command8.ExecuteNonQuery();
                }


                SqlCommand command9 = new SqlCommand("INSERT INTO AddPhotos (AlbumName,Image) VALUES(@AlbumName,@Image10)", con);
                if (pictureBox10.Image != null)
                {
                    img1 = File.ReadAllBytes(pictureBox10.ImageLocation);
                    command9.Parameters.AddWithValue("@Image10", img1);
                    command9.Parameters.AddWithValue("@AlbumName", textBox1.Text.ToString());
                    command9.ExecuteNonQuery();
                }


                SqlCommand command10 = new SqlCommand("INSERT INTO AddPhotos (AlbumName,Image) VALUES(@AlbumName,@Image11)", con);
                if (pictureBox11.Image != null)
                {
                    img1 = File.ReadAllBytes(pictureBox11.ImageLocation);
                    command10.Parameters.AddWithValue("@Image11", img1);
                    command10.Parameters.AddWithValue("@AlbumName", textBox1.Text.ToString());
                    command10.ExecuteNonQuery();

                }

                SqlCommand command11 = new SqlCommand("INSERT INTO AddPhotos (AlbumName,Image) VALUES(@AlbumName,@Image12)", con);
                if (pictureBox12.Image != null)
                {
                    img1 = File.ReadAllBytes(pictureBox12.ImageLocation);
                    command11.Parameters.AddWithValue("@Image12", img1);
                    command11.Parameters.AddWithValue("@AlbumName", textBox1.Text.ToString());
                    command11.ExecuteNonQuery();
                }

                
                MessageBox.Show("Successfully uploaded!");
                
                SqlCommand comm = new SqlCommand("INSERT INTO Albums (AlbumName,Image) VALUES (@AlbumName,@Image)", con);
               
                img1 = File.ReadAllBytes(pictureBox1.ImageLocation);
                comm.Parameters.AddWithValue("@Image", img1);
                comm.Parameters.AddWithValue("@AlbumName", textBox1.Text.ToString());
                comm.ExecuteNonQuery();
                con.Close();


                Gallery glr = (Gallery)Application.OpenForms["Gallery"];
                if (glr != null){
                    glr.TopMost = true;
                    this.Close();
                }
                    
                else
                {
                    Gallery s = new Gallery();
                    s.Show();
                    this.Close();
                }
                
            }

            catch (System.Exception a)
            {
                MessageBox.Show(a.Message);
            }                       
        }

    }
}
