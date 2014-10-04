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
using System.IO;

namespace Software
{
    public partial class PhotoViewer : Form
    {
         public static int btn = 0,ind;
        public static string albm = Gallery.name;
        PictureBox[] list;
        public static PictureBox pi;
        public static ImageList il;
        public static  PictureBox[] pic;
        static string conStr = Properties.Settings.Default.GalleryConStr;
        static SqlConnection con = new SqlConnection(conStr);
        public PhotoViewer()
        {
            InitializeComponent();
        }

       

        private void Photoviewr_Load(object sender, EventArgs e)
        {
            SqlCommand myCommand = new SqlCommand("Select * from AddPhotos WHERE AlbumName='" + albm.ToString().Trim() + "'", con);
            SqlDataAdapter myAdapter = new SqlDataAdapter(myCommand);
            DataTable myTable = new DataTable();//create a table 
            myAdapter.Fill(myTable);//fill da table using adapter          
            // addPhotosDataRepeater.DataSource = myTable;
            addPhotosDataGridView.DataSource = myTable;

            int x = 13, y = 13, kk = 0;
             pic = new PictureBox[addPhotosDataGridView.Rows.Count - 1];
            Button[] lbl;

            //Button[] lbl = new Button[addPhotosDataGridView.Rows.Count - 1];
            lbl = new Button[addPhotosDataGridView.Rows.Count - 1];
           
            for (int i = 0; i < addPhotosDataGridView.Rows.Count - 1; i++)
            {
                string RowType = addPhotosDataGridView.Rows[i].Cells[0].Value.ToString();
                // textBox1.Text = RowType;
                MemoryStream stream = new MemoryStream();
                con.Open();
                SqlCommand command = new SqlCommand("select Image from Albums where AlbumName='" + RowType.Trim() + "'", con);
                byte[] image = (byte[])addPhotosDataGridView.Rows[i].Cells[1].Value;
                
                stream.Write(image, 0, image.Length);
                con.Close();
                Bitmap bitmap = new Bitmap(stream);

                pic[i] = new PictureBox();
                lbl[i] = new Button();
                pic[i].Image = bitmap;
                //il.Images[i] = bitmap;
                pic[i].Click += new EventHandler(pic_Click);
                /*  PictureBox pic = new PictureBox();
                  pic.Click+=new EventHandler(pic_Click);*/

                //  lbl[i].Click += new EventHandler(lbl_Click);
                //MessageBox.Show(lbl[i].Name);
                //pic.Visible = true;
                this.Controls.Add(pic[i]);
                //  this.Controls.Add(lbl[i]);
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

        }

        private void button1_Click(object sender, EventArgs e)
        {
            btn = 1;
            AddPhoto s = new AddPhoto();
            s.FormClosed += new FormClosedEventHandler(form_FormClosed);
            s.Show();
            this.Hide();
        }

        private void form_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void pic_Click(object sender, EventArgs e)
        {
            //Image img = (Image)sender;
            PictureBox p = (PictureBox)sender;
            pi = p;
            int bk = 0;
            for(bk=0;bk<pic.Length;bk++)
            
            {
                if (pic[bk].Image == p.Image)
                {
                    ind = bk;              
                }
            }
            Viewphoto s = new Viewphoto();
            
            s.Show();
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Gallery s = new Gallery();
            s.FormClosed += new FormClosedEventHandler(form_FormClosed);
            s.Show();
            this.Hide();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            Gallery s = new Gallery();
            s.FormClosed += new FormClosedEventHandler(form_FormClosed);
            s.Show();
            this.Hide();
        }

      
    }
}
