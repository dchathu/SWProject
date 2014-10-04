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
    public partial class Gallery : Form
    {
        public static string name;
        Button[] lbl;
        public static Image ig;
        static string conStr = Properties.Settings.Default.GalleryConStr;
        static SqlConnection con = new SqlConnection(conStr);

        public Gallery()
        {
            InitializeComponent();
        }
         

        private void Gallery_Load(object sender, EventArgs e)
        {
            con.Open();

            SqlCommand myCommand = new SqlCommand("Select * from Albums", con);
            SqlDataAdapter myAdapter = new SqlDataAdapter(myCommand);
            DataTable myTable = new DataTable();//create a table 
            myAdapter.Fill(myTable);//fill da table using adapter
            // dataGridView1.DataSource = myTable;
            albumsDataGridView.DataSource = myTable;
            int x = 165, y = 13, kk = 1;
            PictureBox[] pic = new PictureBox[albumsDataGridView.Rows.Count - 1];


            //Button[] lbl = new Button[albumsDataGridView.Rows.Count - 1];
            lbl = new Button[albumsDataGridView.Rows.Count - 1];
            for (int i = 0; i < albumsDataGridView.Rows.Count - 1; i++)
            {
                string RowType = albumsDataGridView.Rows[i].Cells[0].Value.ToString();
                // textBox1.Text = RowType;
                MemoryStream stream = new MemoryStream();
                
                SqlCommand command = new SqlCommand("select Image from Albums where AlbumName='" + RowType.Trim() + "'", con);
                byte[] image = (byte[])command.ExecuteScalar();
                stream.Write(image, 0, image.Length);
                
                Bitmap bitmap = new Bitmap(stream);

                pic[i] = new PictureBox();
                lbl[i] = new Button();
                pic[i].Image = bitmap;
                // pic[i].Click += new EventHandler(pic_Click);
                /*  PictureBox pic = new PictureBox();
                  pic.Click+=new EventHandler(pic_Click);*/

                lbl[i].Click += new EventHandler(lbl_Click);
                //MessageBox.Show(lbl[i].Name);
                //pic.Visible = true;
                this.Controls.Add(pic[i]);
                this.Controls.Add(lbl[i]);
                pic[i].BorderStyle = BorderStyle.Fixed3D;
                pic[i].Location = new Point(x, y);
                lbl[i].Location = new Point(x, y + 140);

                pic[i].Size = new Size(110, 130);
                kk++;
                pic[i].SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                lbl[i].Text = RowType;
                lbl[i].Name = RowType;
                if (kk < 4)
                {
                    x += 152;
                }
                else
                {
                    kk = 0;
                    x = 13;
                    y += 163;
                }
            }
            con.Close();
        }


        
        private void button1_Click(object sender, EventArgs e)
        {
            AddPhoto s = new AddPhoto();
            s.Show();

        }

        private void form_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }


        private void lbl_Click(object sender, EventArgs e)
        {
            Button vb = (Button)sender;
            // MessageBox.Show(vb.Text);
            name = vb.Text;
            PhotoViewer s = new PhotoViewer();
            s.FormClosed += new FormClosedEventHandler(form_FormClosed);
            s.Show();
            this.Hide();
        }

    }
}
