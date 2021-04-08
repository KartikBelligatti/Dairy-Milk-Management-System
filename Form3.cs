using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Dairy
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            User_My_Details um = new User_My_Details();
            um.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            User_Daily_Milk_Rate u = new User_Daily_Milk_Rate();
            u.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            User_Bill_Details b = new User_Bill_Details();
            b.Show();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=LAPTOP-BADICOOA\\SQLEXPRESS2019;Initial Catalog=db;Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from Seller where User_ID='" + Form1.uid + "'";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            //txt.Text = User_My_Details.kartik;
           
        }

        private void label5_Click(object sender, EventArgs e)
        {
           
        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtnm_Click(object sender, EventArgs e)
        {

        }
    }
}
