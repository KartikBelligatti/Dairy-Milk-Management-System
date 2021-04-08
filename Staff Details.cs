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
    public partial class Staff_Details : Form
    {
        public Staff_Details()
        {
            InitializeComponent();
        }

        private void txtfat_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Staff_Details_Load(object sender, EventArgs e)
        {
            panel2.Visible = false;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=LAPTOP-BADICOOA\\SQLEXPRESS2019;Initial Catalog=db;Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from Staff";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView2.DataSource = ds.Tables[0];
        }
        Int64 bid;
        Int64 rowid;
        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView2.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                try
                {
                    bid = Int64.Parse(dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString());
                    //MessageBox.Show(dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString());
                }
                catch
                {
                    MessageBox.Show("Empty Credentials!", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            panel2.Visible = true;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=LAPTOP-BADICOOA\\SQLEXPRESS2019;Initial Catalog=db;Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from Staff where Staff_ID='" + bid + "'";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            try
            {

                rowid = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
                txtsid.Text = ds.Tables[0].Rows[0][0].ToString();
                txtpass.Text = ds.Tables[0].Rows[0][1].ToString();
                txtstname.Text = ds.Tables[0].Rows[0][2].ToString();
                txtgend.Text = ds.Tables[0].Rows[0][3].ToString();
                txtsal.Text = ds.Tables[0].Rows[0][4].ToString();
                txtphn.Text = ds.Tables[0].Rows[0][5].ToString();
                txtregdt.Text = ds.Tables[0].Rows[0][6].ToString();
            }
            catch
            {
                //MessageBox.Show("Empty Credentials!", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
        }

        private void txtsidsearch_TextChanged(object sender, EventArgs e)
        {

            if (txtsidsearch.Text != "")
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=LAPTOP-BADICOOA\\SQLEXPRESS2019;Initial Catalog=db;Integrated Security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "select * from Staff where Bill_ID LIKE '" + txtsidsearch.Text + "%'";
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
                cmd.CommandText = "select * from Staff";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView2.DataSource = ds.Tables[0];
            }
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {

            txtsidsearch.Clear();
            panel2.Visible = false;
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Data Will Be Updated. Confirm?", "Success", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {

                //Int64 sid = Int64.Parse(txtsid.Text);
                try
                {
                    String pass = txtpass.Text;
                    String stfnm = txtstname.Text;
                    String gen = txtgend.Text;
                    String sal = txtsal.Text;
                    Int64 phn = Int64.Parse(txtphn.Text);
                    if (txtphn.Text.Length == 10)
                    {
                        String reg = txtregdt.Text;
                        SqlConnection con = new SqlConnection();
                        con.ConnectionString = "Data Source=LAPTOP-BADICOOA\\SQLEXPRESS2019;Initial Catalog=db;Integrated Security=True";
                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = con;
                        cmd.CommandText = "update Staff set Staff_Password='" + pass + "',Staff_Name='" + stfnm + "',Gender='" + gen + "',Salary='" + sal + "',Phone=" + phn + ",Reg_Date='" + reg + "' where Staff_ID=" + rowid + "";
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataSet ds = new DataSet();
                        da.Fill(ds);
                    }
                    else
                    {
                        MessageBox.Show("Please Enter 10 Digit Mobile Number", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
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
                cmd.CommandText = "delete from Staff where Staff_ID=" + rowid + "";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
             Add_Staff ab = new Add_Staff();
             ab.Show();
             this.Hide();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtstname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Only Characters Are Allowed", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtsal_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtphn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Only Numbers Are Allowed", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtsid_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
