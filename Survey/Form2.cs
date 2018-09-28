using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Survey
{
    public partial class Form2 : Form
    {OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\irizh\Documents\surveydb.mdb");

        public Form2(String text1,String text2,String text3, String topic,DateTime date)
        {
            InitializeComponent();
            n1.Text = text1+" ";
            n2.Text = text2+" ";
            n3.Text = text3;
            hehe.Text = topic;
            dates.Text = date.ToString("dd'-'MM'-'yyyy");
            
        
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

       

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void bunifuTileButton2_Click(object sender, EventArgs e)
        {
            try
            {



                OpenDb();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = conn;

                cmd.CommandText = "INSERT INTO Report ([Names],Topic,Dates,Grade) VALUES(@Names,@Topic,@Dates,@Grade)";
                cmd.Parameters.AddWithValue("@Names", n1.Text + n2.Text + n3.Text);
                cmd.Parameters.AddWithValue("@Topic", hehe.Text);
                cmd.Parameters.AddWithValue("@Dates", dates.Text);
                cmd.Parameters.AddWithValue("@Grade", "4");




                cmd.ExecuteNonQuery();
                thankyou.ShowDialog("Thank You!");
                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Tag = this;
            form1.Show(this); 

        }
        public void OpenDb()
        {
            conn.Open();
        }
        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {
            try
            { 
             


                OpenDb();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = conn;

                cmd.CommandText = "INSERT INTO Report ([Names],Topic,Dates,Grade) VALUES(@Names,@Topic,@Dates,@Grade)";
                cmd.Parameters.AddWithValue("@Names", n1.Text + n2.Text+n3.Text);
                 cmd.Parameters.AddWithValue("@Topic", hehe.Text);
                 cmd.Parameters.AddWithValue("@Dates", dates.Text);
                cmd.Parameters.AddWithValue("@Grade", "5");




                cmd.ExecuteNonQuery();
                thankyou.ShowDialog("Thank You!");
                conn.Close();
             
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
         
                Environment.Exit(1);
        }

        private void bunifuImageButton1_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void bunifuTileButton3_Click(object sender, EventArgs e)
        {
            try
            {



                OpenDb();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = conn;

                cmd.CommandText = "INSERT INTO Report ([Names],Topic,Dates,Grade) VALUES(@Names,@Topic,@Dates,@Grade)";
                cmd.Parameters.AddWithValue("@Names", n1.Text + n2.Text + n3.Text);
                cmd.Parameters.AddWithValue("@Topic", hehe.Text);
                cmd.Parameters.AddWithValue("@Dates", dates.Text);
                cmd.Parameters.AddWithValue("@Grade", "3");




                cmd.ExecuteNonQuery();
                thankyou.ShowDialog("Thank You!");
                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }

        private void bunifuTileButton4_Click(object sender, EventArgs e)
        {
            try
            {



                OpenDb();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = conn;

                cmd.CommandText = "INSERT INTO Report ([Names],Topic,Dates,Grade) VALUES(@Names,@Topic,@Dates,@Grade)";
                cmd.Parameters.AddWithValue("@Names", n1.Text + n2.Text + n3.Text);
                cmd.Parameters.AddWithValue("@Topic", hehe.Text);
                cmd.Parameters.AddWithValue("@Dates", dates.Text);
                cmd.Parameters.AddWithValue("@Grade", "2");




                cmd.ExecuteNonQuery();
                thankyou.ShowDialog("Thank You!");
                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }
        public static void close()
        {
            Application.Exit();
        }
        private void bunifuTileButton5_Click(object sender, EventArgs e)
        {
            thankyou.ShowDialog("Thank You!"
                       );
            try
            {



                OpenDb();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = conn;

                cmd.CommandText = "INSERT INTO Report ([Names],Topic,Dates,Grade) VALUES(@Names,@Topic,@Dates,@Grade)";
                cmd.Parameters.AddWithValue("@Names", n1.Text + n2.Text + n3.Text);
                cmd.Parameters.AddWithValue("@Topic", hehe.Text);
                cmd.Parameters.AddWithValue("@Dates", dates.Text);
                cmd.Parameters.AddWithValue("@Grade", "1");




                cmd.ExecuteNonQuery();
                
                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
           
        }

        private void n3_Click(object sender, EventArgs e)
        {

        }

        private void n2_Click(object sender, EventArgs e)
        {

        }

        private void dates_Click(object sender, EventArgs e)
        {

        }
    }
}
