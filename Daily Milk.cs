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
    public partial class Daily_Milk : Form
    {
        public Daily_Milk()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Daily_Milk_Load(object sender, EventArgs e)
        {
            panel2.Visible = false;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=LAPTOP-BADICOOA\\SQLEXPRESS2019;Initial Catalog=db;Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select D_ID,User_ID,Quantity,Cattle_Type,Fat,Date from Daily_Milk";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView2.DataSource = ds.Tables[0];

            con.Open();
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

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

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
            cmd.CommandText = "select  D_ID,User_ID,Quantity,Cattle_Type,Fat,Date from Daily_Milk where D_ID='" + bid + "'";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            try
            {
                rowid = (ds.Tables[0].Rows[0][0].ToString());
                txtdid.Text = ds.Tables[0].Rows[0][0].ToString();
                txtuserid.Text = ds.Tables[0].Rows[0][1].ToString();
                txtqty.Text = ds.Tables[0].Rows[0][2].ToString();
                txtcattype.Text = ds.Tables[0].Rows[0][3].ToString();
                txtft.Text = ds.Tables[0].Rows[0][4].ToString();
                txtdt.Text = ds.Tables[0].Rows[0][5].ToString();
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

        private void txtdd_TextChanged(object sender, EventArgs e)
        {
            if (txtdd.Text != "")
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=LAPTOP-BADICOOA\\SQLEXPRESS2019;Initial Catalog=db;Integrated Security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "select D_ID,User_ID,Quantity,Cattle_Type,Fat,Date from Daily_Milk where D_ID LIKE '" + txtdd.Text + "%'";
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
                cmd.CommandText = "select  D_ID,User_ID,Quantity,Cattle_Type,Fat,Date from Daily_Milk";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView2.DataSource = ds.Tables[0];
            }
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {

            txtdd.Clear();
            panel2.Visible = false;
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Data Will Be Updated. Confirm?", "Success", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                String did = txtdid.Text;
                try
                {
                    Int64 uid = Int64.Parse(txtuserid.Text);
                
                    float qty = float.Parse(txtqty.Text);
                    String cy = txtcattype.Text;
                    float ft = float.Parse(txtft.Text);
                    String dt = txtdt.Text;
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = "Data Source=LAPTOP-BADICOOA\\SQLEXPRESS2019;Initial Catalog=db;Integrated Security=True";
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandText = "update Daily_Milk set D_ID='" + did + "',Quantity=" + qty + ",Cattle_Type='" + cy + "',Fat=" + ft + ",Date='" + dt + "' where  D_ID='" + rowid + "'";
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
                cmd.CommandText = "delete from Daily_Milk where D_ID='" + rowid + "'";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtdat_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Add_Daily_Milk ad = new Add_Daily_Milk();
            ad.Show();
            this.Hide();
        }

        private void txtdid_KeyPress(object sender, KeyPressEventArgs e)
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
