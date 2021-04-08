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
    public partial class Login_Details : Form
    {
        public Login_Details()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Login_Details_Load(object sender, EventArgs e)
        {
            panel2.Visible = false;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=LAPTOP-BADICOOA\\SQLEXPRESS2019;Initial Catalog=db;Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select User_ID,Password from Seller";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView2.DataSource = ds.Tables[0];
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        int bid;
        Int64 rowid;
        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dataGridView2.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                try
                {
                    bid = int.Parse(dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString());
                    //MessageBox.Show(dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString());
                }
                catch
                {
                    MessageBox.Show("No Data Found", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            panel2.Visible = true;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=LAPTOP-BADICOOA\\SQLEXPRESS2019;Initial Catalog=db;Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select User_ID,Password from Seller where User_ID="+bid+"";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            try
            {


                rowid = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
                txtuserid.Text = ds.Tables[0].Rows[0][0].ToString();
                txtpassword.Text = ds.Tables[0].Rows[0][1].ToString();
            }
            catch
            {
              // MessageBox.Show("No Data Found", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
        }

        private void txtuid_TextChanged(object sender, EventArgs e)
        {
            if(txtuid.Text!="")
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=LAPTOP-BADICOOA\\SQLEXPRESS2019;Initial Catalog=db;Integrated Security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "select User_ID,Password from Seller where User_ID LIKE '"+txtuid.Text+"%'";
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
                cmd.CommandText = "select User_ID,Password from Seller";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView2.DataSource = ds.Tables[0];
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtuid.Clear();
            panel2.Visible = false;
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Data Will Be Updated. Confirm?", "Success", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {

                if (txtuserid.Text != "" && txtpassword.Text != "")
                {
                    Int64 uid = Int64.Parse(txtuserid.Text);
                    string pass = txtpassword.Text;
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = "Data Source=LAPTOP-BADICOOA\\SQLEXPRESS2019;Initial Catalog=db;Integrated Security=True";
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandText = "update Seller set User_ID=" + uid + ",Password='" + pass + "' where User_ID=" + rowid + "";
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                
                try
                {
                    da.Fill(ds);
                }
                catch
                {

                }
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
                cmd.CommandText = "delete from Seller where User_ID="+rowid+"";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
            }

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtuserid_KeyPress(object sender, KeyPressEventArgs e)
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
