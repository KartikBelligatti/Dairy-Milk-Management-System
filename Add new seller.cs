using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Dairy
{
    public partial class Add_new_seller : Form
    {
        public Add_new_seller()
        {
            InitializeComponent();
        }
    
        private void btnsave_Click(object sender, EventArgs e)
        {
            if (txtsellerid.Text != "" && txtuserid.Text != "" && txtsellername.Text != "" && txtregdat.Text!="" && txtselmilk.Text !="")
            {
                String sid = txtsellerid.Text;
                Int64 user =Int64.Parse( txtuserid.Text);
                String nm = txtsellername.Text;
                String rd = txtregdat.Text;
                Int64 sm = Int64.Parse(txtselmilk.Text);
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=LAPTOP-BADICOOA\\SQLEXPRESS2019;Initial Catalog=db;Integrated Security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                con.Open();
                cmd.CommandText = "insert into Seller(Seller_ID,User_ID,Seller_Name,Reg_Date,Sell_Milk) values('" + sid + "'," + user + ",'" + nm + "','"+rd+"',"+sm+")";
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Credentials Saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtsellerid.Clear();
               // txtuserid.Clear();
                txtsellername.Clear();
                txtregdat.Clear();
                txtselmilk.Clear();
            }
            else
            {
                MessageBox.Show("Empty field Not Allowed ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("This will DELETE your Unsaved DATA", "Are you sure", MessageBoxButtons.OK, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                txtsellerid.Clear();
               // txtuserid.Clear();
                txtsellername.Clear();
                txtregdat.Clear();
                txtselmilk.Clear();


            }
        }

        private void btnback_Click(object sender, EventArgs e)
        {

            Seller mr = new Seller();
            mr.Show();
            this.Close();
        }

        private void Add_new_seller_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=LAPTOP-BADICOOA\\SQLEXPRESS2019;Initial Catalog=db;Integrated Security=True";
            con.Open();
           // SqlCommand sc = new SqlCommand("select Date_ from Daily_Milk_Rate", con);

            SqlCommand s = new SqlCommand("select User_ID from Login", con);
            SqlDataReader re;
            re = s.ExecuteReader();
            DataTable d = new DataTable();
            d.Columns.Add("User_ID", typeof(String));
            d.Load(re);
            txtuserid.ValueMember = "User_ID";
            txtuserid.DataSource = d;
            con.Close();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
