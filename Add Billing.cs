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
    public partial class Add_Billing : Form
    {
        public Add_Billing()
        {
            InitializeComponent();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (txtbid.Text != "" && txtuserid.Text != "" && txtttlmilk.Text != "" && txtttlamt.Text != "" && txtbildt.Text != "")
            {
                String bid = txtbid.Text;
                Int64 uid = Int64.Parse(txtuserid.Text);
                float tmilk = float.Parse(txtttlmilk.Text);
                String tamt = txtttlamt.Text;
                String dat = txtbildt.Text;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=LAPTOP-BADICOOA\\SQLEXPRESS2019;Initial Catalog=db;Integrated Security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "insert into Billing(Bill_ID,User_ID,Total_Milk,Total_Amt,Bill_Date) values('" + bid + "'," + uid + "," + tmilk + ",'" + tamt + "','" + dat + "' )";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                try
                {
                    da.Fill(ds);



                    MessageBox.Show("Credentials Saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtbid.Clear();
                    //txtuserid.Clear();
                    txtttlmilk.Clear();
                    txtttlamt.Clear();
                }
                catch
                {
                    MessageBox.Show("Bill ID Already Exist", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }


                //txtbildt.Clear();

            }
            else
            {
                MessageBox.Show("Empty field Not Allowed ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Add_Billing_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=LAPTOP-BADICOOA\\SQLEXPRESS2019;Initial Catalog=db;Integrated Security=True";
            con.Open();

            SqlCommand sc = new SqlCommand("select Date from Daily_Milk_Rate", con);
            SqlDataReader red;
            red = sc.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("Date", typeof(String));
            dt.Load(red);
            txtbildt.ValueMember = "Date";
            txtbildt.DataSource = dt;

            SqlCommand s = new SqlCommand("select User_ID from Seller", con);
            SqlDataReader re;
            re = s.ExecuteReader();
            DataTable d = new DataTable();
            d.Columns.Add("User_ID", typeof(String));
            d.Load(re);
            txtuserid.ValueMember = "User_ID";
            txtuserid.DataSource = d;
            con.Close();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("This will DELETE your Unsaved DATA", "Are you sure", MessageBoxButtons.OK, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                txtbid.Clear();
                //txtuserid.Clear();
                txtttlmilk.Clear();
                txtttlamt.Clear();
                //txtbildt.Clear();
            }
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            Billing mr = new Billing();
            mr.Show();
            this.Close();
        }

        private void txtbildt_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            txtbildt.SelectedItem = "select Date from Daily_Milk_Rate";
        }

        private void txtbid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Only Numbers Are Allowed", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtttlmilk_TextChanged(object sender, EventArgs e)
        {

        }

     

        private void txtttlmilk_KeyPress_1(object sender, KeyPressEventArgs e)
        {

            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Only Numbers Are Allowed", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
