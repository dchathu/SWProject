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
    public partial class AddInventory : Form
    {
        static string conStr = Properties.Settings.Default.MainConString;
        static SqlConnection con = new SqlConnection(conStr);
        SqlDataAdapter da;

        public AddInventory()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            da = new SqlDataAdapter();
            da.InsertCommand = new SqlCommand("INSERT INTO Inventory (Item,CurrentTotal,New,Damaged,Disposed) VALUES (@Itm,@crntTotal,@New,@Damaged,@Disposed)", con);
            da.InsertCommand.Parameters.AddWithValue("@Itm", txtItem.Text.ToString());
            da.InsertCommand.Parameters.AddWithValue("@crntTotal", Convert.ToInt16(txtCurrentTotal.Text));
            da.InsertCommand.Parameters.AddWithValue("@New", Convert.ToInt16(txtNew.Text));
            da.InsertCommand.Parameters.AddWithValue("@Damaged", Convert.ToInt16(txtDamaged.Text));
            da.InsertCommand.Parameters.AddWithValue("@Disposed", Convert.ToInt16(txtDispoced.Text));

            da.InsertCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Done");
        }
    }
}
