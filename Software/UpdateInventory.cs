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

namespace Software
{
    public partial class UpdateInventory : Form
    {
        static string conStr = Properties.Settings.Default.MainConString;
        static SqlConnection con = new SqlConnection(conStr);
        SqlDataAdapter da;
        DataTable dt;

        public UpdateInventory()
        {
            InitializeComponent();
        }

        private void UpdateInventory_Load(object sender, EventArgs e)
        {
            con.Open();
            da = new SqlDataAdapter();
            da.SelectCommand = new SqlCommand("SELECT*FROM Inventory", con);
            dt = new DataTable();
            da.Fill(dt);

            foreach (DataRow row in dt.Rows)
            {
                comboBox1.Items.Add(row.ItemArray[1].ToString());
            }
            con.Close();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            foreach (DataRow row in dt.Rows)
            {
                if (row.ItemArray[1].ToString().Contains(comboBox1.Text.ToString()))
                {
                    txtCurrentTotal.Text = row.ItemArray[2].ToString();
                    txtNew.Text = row.ItemArray[2].ToString();
                    txtDamaged.Text = row.ItemArray[3].ToString();
                    txtDispoced.Text = row.ItemArray[4].ToString();
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            con.Open();

            da.UpdateCommand = new SqlCommand("UPDATE Inventory SET CurrentTotal=@CrntTtl, New=@New, Damaged=@Dmgd, Disposed=@Disposd", con);
            da.UpdateCommand.Parameters.AddWithValue("@CrntTtl", Convert.ToInt16(txtCurrentTotal.Text));
            da.UpdateCommand.Parameters.AddWithValue("@New", Convert.ToInt16(txtNew.Text));
            da.UpdateCommand.Parameters.AddWithValue("@Dmgd", Convert.ToInt16(txtDamaged.Text));
            da.UpdateCommand.Parameters.AddWithValue("@Disposd", Convert.ToInt16(txtDispoced.Text));

            da.UpdateCommand.ExecuteNonQuery();
            con.Close();


        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure???", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                con.Open();
                SqlCommand myCommand = new SqlCommand("DELETE FROM Inventory WHERE Item=@Item", con);

                myCommand.Parameters.AddWithValue("@Item", comboBox1.Text.ToString());
                myCommand.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record is deleted!!", "confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
        }


    }
}
