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
    public partial class Inventories : Form
    {
        static string conStr = Properties.Settings.Default.MainConString;
        static SqlConnection con = new SqlConnection(conStr);
        SqlDataAdapter da;

        public int a, b, c;

        public Inventories()
        {
            InitializeComponent();
        }

        private void Inventories_Load(object sender, EventArgs e)
        {    
            LoadItem();
        }

        private void LoadItem()
        {
            con.Open();
            da = new SqlDataAdapter();
            da.SelectCommand = new SqlCommand("SELECT*FROM Inventory",con);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void form_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
           
        }


        public void visible()
        {
        }

        public void Reset()
        {
        }

        private void button6_Click(object sender, EventArgs e)
        {
           
        }


        private void button7_Click(object sender, EventArgs e)
        {
           
        }

        private void Delete_Click(object sender, EventArgs e)
        {
           
        }

        private void button8_Click(object sender, EventArgs e)
        {
           
        }

        private void ovalShape1_MouseLeave(object sender, EventArgs e)
        {

        }

        private void ovalShape1_MouseHover(object sender, EventArgs e)
        {
            ovalShape2.BackColor = Color.Blue;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            AddInventory ai = new AddInventory();
            ai.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UpdateInventory ui = new UpdateInventory();
            ui.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            UpdateInventory ui = new UpdateInventory();
            ui.Show();
        }


    }
}
