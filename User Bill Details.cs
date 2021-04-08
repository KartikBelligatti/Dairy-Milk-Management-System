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
    public partial class User_Bill_Details : Form
    {
        public User_Bill_Details()
        {
            InitializeComponent();
        }

        private void User_Bill_Details_Load(object sender, EventArgs e)
        {

            panel2.Visible = false;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=LAPTOP-BADICOOA\\SQLEXPRESS2019;Initial Catalog=db;Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from Billing Where User_ID = '"+Form1.uid+"'";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView2.DataSource = ds.Tables[0];
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void txtbidsearch_TextChanged(object sender, EventArgs e)
        {
            if (txtbidsearch.Text != "")
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=LAPTOP-BADICOOA\\SQLEXPRESS2019;Initial Catalog=db;Integrated Security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "select * from Billing where Bill_ID LIKE '" + txtbidsearch.Text + "%'";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView2.DataSource = ds.Tables[0];
            }
            else
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=LAPTOP-BADICOOA\\SQLEXPRESS2019;Initial Catalog=db;Integrated Security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "select * from Billing Where User_ID = '" + Form1.uid + "'";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView2.DataSource = ds.Tables[0];
            }
        }
        String bid;
        String rowid;
        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dataGridView2.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                bid = (dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString());
                //MessageBox.Show(dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
            panel2.Visible = true;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=LAPTOP-BADICOOA\\SQLEXPRESS2019;Initial Catalog=db;Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from Billing where Bill_ID='" + bid + "'";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            try
            {
                rowid = (ds.Tables[0].Rows[0][0].ToString());
                txtbid.Text = ds.Tables[0].Rows[0][0].ToString();
                txtuserid.Text = ds.Tables[0].Rows[0][1].ToString();
                txtttlmilk.Text = ds.Tables[0].Rows[0][2].ToString();
                txtttlamt.Text = ds.Tables[0].Rows[0][3].ToString();
                txtbildt.Text = ds.Tables[0].Rows[0][4].ToString();
            }
            catch
            {
                MessageBox.Show("No Data Found", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {

            txtbidsearch.Clear();
            panel2.Visible = false;
        }
    }
}
