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
    public partial class Seller : Form
    {
        public Seller()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Seller_Load(object sender, EventArgs e)
        {
            panel2.Visible = false;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=LAPTOP-BADICOOA\\SQLEXPRESS2019;Initial Catalog=db;Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from Seller";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView2.DataSource = ds.Tables[0];
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
            cmd.CommandText = "select * from Seller where User_ID='" + bid + "'";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            try
            {
                rowid = (ds.Tables[0].Rows[0][0].ToString());
                txtuid.Text = ds.Tables[0].Rows[0][0].ToString();
                txtpass.Text = ds.Tables[0].Rows[0][1].ToString();
                txtsellername.Text = ds.Tables[0].Rows[0][2].ToString();
                txtgen.Text = ds.Tables[0].Rows[0][3].ToString();
                txtregdat.Text = ds.Tables[0].Rows[0][4].ToString();
                txtad.Text = ds.Tables[0].Rows[0][5].ToString();
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtsellid_TextChanged(object sender, EventArgs e)
        {
            if (txtuidsr.Text != "")
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=LAPTOP-BADICOOA\\SQLEXPRESS2019;Initial Catalog=db;Integrated Security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "select * from Seller where User_ID LIKE '" + txtuidsr.Text + "%'";
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
                cmd.CommandText = "select * from Seller";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView2.DataSource = ds.Tables[0];
            }
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            txtuidsr.Clear();
            panel2.Visible = false;
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Data Will Be Updated. Confirm?", "Success", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (txtuid.Text != "" && txtpass.Text != "" && txtsellername.Text != "" && txtgen.Text != "" && txtregdat.Text != "" && txtad.Text != "")
                {
                    Int64 uid = Int64.Parse(txtuid.Text);
                    String pass = txtpass.Text;
                    String sname = txtsellername.Text;
                    String gen = txtgen.Text;
                    String regdate = txtregdat.Text;
                    String ad = txtad.Text;
               
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=LAPTOP-BADICOOA\\SQLEXPRESS2019;Initial Catalog=db;Integrated Security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "update Seller set User_ID=" + uid + ",Password='" + pass + "',Seller_Name='"+sname+"',Gender='"+gen+"',Reg_Date='"+regdate+"',Address='"+ad+"' where User_ID='" + rowid + "'";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                }
                else
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
                cmd.CommandText = "delete from Seller where User_ID='" + rowid + "'";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                try
                {
                    da.Fill(ds);
                }
                catch
                {
                    MessageBox.Show("Not Allowed", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Add_new_seller ns = new Add_new_seller();
            ns.Show();
            this.Hide();
        }

        private void txtuid_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtsellername_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Only Characters Are Allowed", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
