using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace Software
{
    public partial class UpdateRecord : Form
    {

        static string conStr = Properties.Settings.Default.MainConString;
        static SqlConnection con = new SqlConnection(conStr);
        int recordId;
        string Event;
        int bstRec;

        public UpdateRecord(int Id)
        {
            InitializeComponent();
            this.recordId = Id;
        }
     
        public void Reset()
        {
          
           txtFirst.Text = "";
           txtScnd.Text = "";
           txtThrd.Text = "";
           txtRecd.Text = "";
       }

       
        private void Achievement_Load(object sender, EventArgs e)
        {
            
            try
            {
                con.Open();
                SqlCommand myCommand = new SqlCommand("SELECT * FROM Sports WHERE RecordId=@rId", con);
                myCommand.Parameters.AddWithValue("@rId", recordId);

                SqlDataReader myReader = myCommand.ExecuteReader();
                while (myReader.Read())
                {
                    txtYear.Text = myReader.GetValue(2).ToString();
                    txtEvent.Text = myReader.GetValue(1).ToString();
                    txtFirst.Text = myReader.GetValue(3).ToString();
                    txtScnd.Text = myReader.GetValue(4).ToString();
                    txtThrd.Text = myReader.GetValue(5).ToString();
                    txtRecd.Text = myReader.GetValue(6).ToString();
                    Event = myReader.GetValue(1).ToString();
                }
                myReader.Close();
                myReader.Dispose();
                con.Close();
            }
            catch (Exception ex)
            {
               
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
        private void UpdtRecord()
        {
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = new SqlCommand("SELECT*FROM BestRecord WHERE Event=@event",con);
            da.SelectCommand.Parameters.AddWithValue("@event", Event);
            DataTable dt = new DataTable();

            da.Fill(dt);

            MessageBox.Show("first");

            if (dt.Rows.Count > 0)
            {
                if (Event == "High Jump" || Event == "Long Jump" || Event == "Tripple jump" || Event == "disc throw" || Event == "shot put" || Event == "javelin throw")
                {

                    if (Convert.ToInt32(dt.Rows[0].ItemArray[3].ToString()) < Convert.ToInt32(txtRecd.Text.ToString()))
                    {
                        da.UpdateCommand = new SqlCommand("UPDATE BestRecord SET Record=@Record,Owner=@Name,Year=@Yea WHERE Event=@Event", con);
                        da.UpdateCommand.Parameters.AddWithValue("@Event", Event);
                        da.UpdateCommand.Parameters.AddWithValue("@Name", txtFirst.Text.ToString());
                        da.UpdateCommand.Parameters.AddWithValue("@Year", txtYear.Text.ToString());
                        da.UpdateCommand.Parameters.AddWithValue("@Record", txtRecd.Text.ToString());
                        da.UpdateCommand.ExecuteNonQuery();
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
                        da.UpdateCommand = new SqlCommand("UPDATE BestRecord SET Record=@Record,Owner=@Name,Year=@Yea WHERE Event=@Event", con);
                        da.UpdateCommand.Parameters.AddWithValue("@Event", txtEvent.Text.ToString());
                        da.UpdateCommand.Parameters.AddWithValue("@Name", txtFirst.Text.ToString());
                        da.UpdateCommand.Parameters.AddWithValue("@Year", txtYear.Text.ToString());
                        da.UpdateCommand.Parameters.AddWithValue("@Record", txtRecd.Text.ToString());
                        da.UpdateCommand.ExecuteNonQuery();
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
            }

            con.Close();
            MessageBox.Show("Done");
        }

        private void Achievement_FormClosing(object sender, FormClosingEventArgs e)
        {
            Achivements rc = (Achivements)Application.OpenForms["Record"];
            if (rc != null)
            {
                rc.TopMost = true;
            }
        }

        private void btnAddStaff_Click_1(object sender, EventArgs e)
        {
            try
            {
                
                UpdtRecord();
                MessageBox.Show("second");
                con.Open();
                SqlCommand myCommand = new SqlCommand("UPDATE Sports SET First=@First,Second=@Second,Third=@Third,Record=@Record,BstRecord=@bstRec WHERE RecordId=@rId", con);
                myCommand.Parameters.AddWithValue("@rId", recordId);
                myCommand.Parameters.AddWithValue("@first", txtFirst.Text.ToString());
                myCommand.Parameters.AddWithValue("@Second", txtScnd.Text.ToString());
                myCommand.Parameters.AddWithValue("@Third", txtThrd.Text.ToString());
                myCommand.Parameters.AddWithValue("@Record", txtRecd.Text.ToString());
                myCommand.Parameters.AddWithValue("@bstRec", bstRec);
                myCommand.ExecuteNonQuery();

                con.Close();

                MessageBox.Show("Successfully Updated!!!");
                Reset();
            }
            catch (Exception ex)
            {

            }
        }
             
    }
}
