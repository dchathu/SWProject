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
    public partial class Champion : Form
    {
        public Champion()
        {
            InitializeComponent();
        }

        private void txtyear_Leave(object sender, EventArgs e)
        {
           
            string champ="";
            
            SqlConnection myConnection = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\admin\Desktop\Software\Software\Achievement.mdf;Integrated Security=True;User Instance=True");
            try
            {
                SqlCommand myCommand = new SqlCommand("SELECT First FROM Sports WHERE Year='" + txtyear.Text.Trim() + "'", myConnection);
                SqlDataAdapter myAdapter = new SqlDataAdapter(myCommand);
                DataTable myTable = new DataTable();//create a table 
                myAdapter.Fill(myTable);//fill da table using adapter
                this.dataGridView1.DataSource = myTable;

                int x = 0;

                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    int y = 0;
                    for (int j = dataGridView1.Rows.Count - 1 - i; j > 0; j--)
                    {
                        if (dataGridView1.Rows[i].Cells[2].Value.ToString() == dataGridView1.Rows[j].Cells[2].Value.ToString())
                            y++;
                    }
                    if (x < y)
                    {
                        x = y;
                        champ = dataGridView1.Rows[i].Cells[2].Value.ToString();
                    }
                }
                label2.Text = champ;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
