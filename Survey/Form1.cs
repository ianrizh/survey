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
    public partial class Form1 : Form
    { OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\irizh\Documents\surveydb.mdb");
        public Form1()
        {
            InitializeComponent();
            try
            {
                conn.Open();
                txtCheck.Text = "Connection Yehey";
            }
            catch(Exception e)
            {
                MessageBox.Show("Error Connection: " + e);
            }
            finally
            {
                conn.Close();
            }
        }
     
       

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuImageButton1_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {   
            this.ActiveControl = txtName1;
        

        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(txtName1.Text,txtName2.Text,txtName3.Text,bnDropdown.selectedValue,bnDatepicker.Value);

            base.Hide();
            form2.ShowDialog();

        }



        private void txtNames_OnValueChanged(object sender, EventArgs e)
        {
          
        }
        

        private void bnDropdown_onItemSelected(object sender, EventArgs e)
        {if (bnDropdown.selectedIndex==0)
            {
                label5.Text = "IAN";
            }
        if  (bnDropdown.selectedIndex==1)
                    {
                label5.Text = "HEHE";
            }
            
        }

        private void txtTopic_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
