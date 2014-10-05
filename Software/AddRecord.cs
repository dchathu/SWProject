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
    public partial class AddRecord : Form
    {
        static string conStr = Properties.Settings.Default.MainConString;
        static SqlConnection con = new SqlConnection(conStr);
        string Event;
        int bstRec;

        public AddRecord()
        {
            InitializeComponent();
        }

        public void Reset()
        {
            comboBox1.Text = "";
            cmbYear.Text = "";
            txtFirst.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            txtRecd.Text = "";
        }

        private void AddRecord_FormClosing(object sender, FormClosingEventArgs e)
        {
            Achivements rc = (Achivements)Application.OpenForms["Achivements"];
            if (rc != null)
            {
                rc.TopMost = true;
                rc.LoadRecords();
            }
        }

        private void btnAddStaff_Click(object sender, EventArgs e)
        {
            
            try
            {
                UpdtRecord();

                con.Open();
                SqlCommand myCommand = new SqlCommand("INSERT INTO Sports (Event,Year,First,Second,Third,Record,BstRecord) VALUES (@Event,@Year,@First,@Second,@Third,@Record,@bstRec)", con);

                myCommand.Parameters.AddWithValue("@Event", comboBox1.SelectedItem.ToString());
                myCommand.Parameters.AddWithValue("@Year", cmbYear.SelectedItem.ToString());
                myCommand.Parameters.AddWithValue("@First", txtFirst.Text.ToString());
                myCommand.Parameters.AddWithValue("@Second", textBox2.Text.ToString());
                myCommand.Parameters.AddWithValue("@Third", textBox3.Text.ToString());
                myCommand.Parameters.AddWithValue("@Record", txtRecd.Text.ToString());
                myCommand.Parameters.AddWithValue("@bstRec", bstRec);

                myCommand.ExecuteNonQuery();

                SqlCommand cupd = new SqlCommand("UPDATE  Sports SET BstRecord=@bstRec WHERE Event=@event", con);
                cupd.Parameters.AddWithValue("@bstRec", bstRec);
                cupd.Parameters.AddWithValue("@event", Event);
                cupd.ExecuteNonQuery();

                SqlCommand cmd = new SqlCommand("UPDATE BestRecord SET Record=@Record,Owner=@Name,Year=@Year WHERE Event=@Event", con);
                cmd.Parameters.AddWithValue("@Event", Event);
                cmd.Parameters.AddWithValue("@Name", txtFirst.Text.ToString());
                cmd.Parameters.AddWithValue("@Year", cmbYear.Text.ToString());
                cmd.Parameters.AddWithValue("@Record", txtRecd.Text.ToString());

                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Successfully added!!!");
                
                Reset();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UpdtRecord()
        {
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = new SqlCommand("SELECT*FROM BestRecord WHERE Event=@event", con);
            da.SelectCommand.Parameters.AddWithValue("@event", Event);
            DataTable dt = new DataTable();

            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                if (Event == "High Jump" || Event == "Long Jump" || Event == "Tripple jump" || Event == "disc throw" || Event == "shot put" || Event == "javelin throw")
                {

                    if (Convert.ToInt32(dt.Rows[0].ItemArray[3].ToString()) < Convert.ToInt32(txtRecd.Text.ToString()))
                    {
                        bstRec = Convert.ToInt16(txtRecd.Text.ToString());
                    }
                    else
                    {
                        bstRec = Convert.ToInt16(dt.Rows[0].ItemArray[3].ToString());
                    }
                }

                else
                {
                    if (Convert.ToInt32(dt.Rows[0].ItemArray[3].ToString()) > Convert.ToInt32(txtRecd.Text.ToString()))
                    {
                        bstRec = Convert.ToInt16(txtRecd.Text.ToString());
                    }

                    else
                    {
                        bstRec = Convert.ToInt16(dt.Rows[0].ItemArray[3].ToString());
                    }
                }
            }

            else
            {
                bstRec = Convert.ToInt16(txtRecd.Text.ToString());

                SqlCommand cmd = new SqlCommand("INSERT INTO BestRecord (Event,Owner,Record,Year) VALUES (@event,@owner,@recd,@year)", con);
                cmd.Parameters.AddWithValue("@event",Event);
                cmd.Parameters.AddWithValue("@owner",txtFirst.Text.ToString());
                cmd.Parameters.AddWithValue("@recd",bstRec);
                cmd.Parameters.AddWithValue("@year",cmbYear.Text.ToString());
                cmd.ExecuteNonQuery();               
            }

            con.Close();
            MessageBox.Show("Done");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Event = comboBox1.Text.ToString().Trim();
        }

    }
}
