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
    public partial class Billing : Form
    {
        public Billing()
        {
            InitializeComponent();
        }

        private void Billing_Load(object sender, EventArgs e)
        {

            panel2.Visible = false;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=LAPTOP-BADICOOA\\SQLEXPRESS2019;Initial Catalog=db;Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select Bill_ID,User_ID,Total_Milk,Total_Amt,Bill_Date from Billing";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView2.DataSource = ds.Tables[0];

            //SqlConnection con = new SqlConnection();
            //con.ConnectionString = "Data Source=LAPTOP-BADICOOA\\SQLEXPRESS2019;Initial Catalog=db;Integrated Security=True";
            con.Open();
            SqlCommand s = new SqlCommand("select User_ID from Seller", con);
            SqlDataReader re;
            re = s.ExecuteReader();
            DataTable d = new DataTable();
            d.Columns.Add("User_ID", typeof(String));
            d.Load(re);
            txtuserid.ValueMember = "User_ID";
            txtuserid.DataSource = d;

            SqlCommand sc = new SqlCommand("select Date from Daily_Milk_Rate", con);
            SqlDataReader red;
            red = sc.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("Date", typeof(String));
            dt.Load(red);
            txtbildt.ValueMember = "Date";
            txtbildt.DataSource = dt;
            con.Close();
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

        private void btncancel_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
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
                cmd.CommandText = "select  Bill_ID,User_ID,Total_Milk,Total_Amt,Bill_Date from Billing";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView2.DataSource = ds.Tables[0];
            }
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            txtbidsearch.Clear();
            panel2.Visible = false;
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Data Will Be Updated. Confirm?", "Success", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                String bid = txtbid.Text;
                try
                {
                    Int64 uid = Int64.Parse(txtuserid.Text);
                    float tmilk = float.Parse(txtttlmilk.Text);
                    String tamt = txtttlamt.Text;
                    String dat = txtbildt.Text;
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = "Data Source=LAPTOP-BADICOOA\\SQLEXPRESS2019;Initial Catalog=db;Integrated Security=True";
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandText = "update Billing set Bill_ID='" + bid + "',Total_Milk=" + tmilk + ",Total_Amt='" + tamt + "' where Bill_ID='" + rowid + "'";
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                }
                catch
                {
                    MessageBox.Show("Empty Fields", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Data Will Be Deleted. Confirm?", "Confirmation Dialog", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=LAPTOP-BADICOOA\\SQLEXPRESS2019;Initial Catalog=db;Integrated Security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "delete from Billing where Bill_ID='" + rowid + "'";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Add_Billing ab = new Add_Billing();
            ab.Show();
            this.Hide();
        }

        private void txtbid_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Update Not Allowed In this Field", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Update Not Allowed In this Field", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtttlmilk_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Only Numbers Are Allowed", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtbildt_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtuserid_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
