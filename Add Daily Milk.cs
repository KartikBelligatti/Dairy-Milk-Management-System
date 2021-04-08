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
    public partial class Add_Daily_Milk : Form
    {
        public Add_Daily_Milk()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnback_Click(object sender, EventArgs e)
        {

            Daily_Milk mr = new Daily_Milk();
            mr.Show();
            this.Close();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (txtdid.Text != "" && txtuserid.Text != "" && txtqty.Text != "" && txtcattype.Text != "" && txtfat.Text != "" && txtdt.Text != "")
            {
                String sid = txtdid.Text;
                Int64 user = Int64.Parse(txtuserid.Text);
                float qty =float.Parse( txtqty.Text);
                String ct = txtcattype.Text;
                float ft = float.Parse(txtft.Text);
                String dt = txtdt.Text;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=LAPTOP-BADICOOA\\SQLEXPRESS2019;Initial Catalog=db;Integrated Security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                con.Open();
                cmd.CommandText = "insert into Daily_Milk(D_ID,User_ID,Quantity,Cattle_Type,Fat,Date) values('" + sid + "'," + user + "," + qty + ",'" + ct + "'," + ft + ",'"+dt+"')";
                try
                {
                    cmd.ExecuteNonQuery();


                    con.Close();
                    MessageBox.Show("Credentials Saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtdid.Clear();
                    //txtuserid.Clear();
                    txtqty.Clear();
                    txtcattype.Clear();
                    txtft.Clear();
                    //txtdt.Clear();
                }
                catch
                {
                    MessageBox.Show("D_ID Already Exist ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Empty field Not Allowed ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btncancel_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("This will DELETE your Unsaved DATA", "Are you sure", MessageBoxButtons.OK, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                txtdid.Clear();
               // txtuserid.Clear();
                txtqty.Clear();
                txtcattype.Clear();
                txtft.Clear();
               // txtdt.Clear();
            }
        }

        private void Add_Daily_Milk_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=LAPTOP-BADICOOA\\SQLEXPRESS2019;Initial Catalog=db;Integrated Security=True";
            con.Open();
            // SqlCommand sc = new SqlCommand("select Date_ from Daily_Milk_Rate", con);

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

        private void txtdid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Only Numbers Are Allowed", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtqty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Only Numbers Are Allowed", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtft_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Only Numbers Are Allowed", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
