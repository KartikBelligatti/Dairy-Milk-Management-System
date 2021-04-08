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
    public partial class User_My_Details : Form
    {
        public User_My_Details()
        {
            InitializeComponent();
        }
        public static String kartik;
        public static String ud;
        String bid;
        String rowid;
        private void User_My_Details_Load(object sender, EventArgs e)
        {
            panel2.Visible = true;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=LAPTOP-BADICOOA\\SQLEXPRESS2019;Initial Catalog=db;Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from Seller where User_ID='" + Form1.uid + "'";
            kartik = "select Seller_Name from Seller Where User_ID='"+Form1.uid+"'";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            
           // rowid = (ds.Tables[0].Rows[0][0].ToString());
            txtsellerid.Text = ds.Tables[0].Rows[0][0].ToString();
            txtuserid.Text = ds.Tables[0].Rows[0][1].ToString();
            txtsellername.Text = ds.Tables[0].Rows[0][2].ToString();
            txtgen.Text = ds.Tables[0].Rows[0][3].ToString();
            txtregdat.Text = ds.Tables[0].Rows[0][4].ToString();
            txtadd.Text = ds.Tables[0].Rows[0][5].ToString();
            kartik = txtsellername.Text; 
            ud = txtsellerid.Text;
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            
            this.Hide();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
