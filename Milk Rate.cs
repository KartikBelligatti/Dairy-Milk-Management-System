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
    public partial class Milk_Rate : Form
    {
        public Milk_Rate()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Add_new_milk_rate ad = new Add_new_milk_rate();
            ad.Show();
            this.Hide();
        }

        private void Milk_Rate_Load(object sender, EventArgs e)
        {
            panel2.Visible = false;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=LAPTOP-BADICOOA\\SQLEXPRESS2019;Initial Catalog=db;Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from Daily_Milk_Rate";
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
                try {
                    bid = (dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString());
                    //MessageBox.Show(dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString());
                }
                catch
                {
                    MessageBox.Show("No Data Found", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            if (dataGridView2.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != "")
            {
                panel2.Visible = true;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=LAPTOP-BADICOOA\\SQLEXPRESS2019;Initial Catalog=db;Integrated Security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "select * from Daily_Milk_Rate where Date='" + bid + "'";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                
                    try
                    {
                        rowid = (ds.Tables[0].Rows[0][0].ToString());
                        txtdate.Text = ds.Tables[0].Rows[0][0].ToString();
                        txtbuffalo.Text = ds.Tables[0].Rows[0][1].ToString();
                        txtcow.Text = ds.Tables[0].Rows[0][2].ToString();
                    }
                    catch { MessageBox.Show("No Data Found", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
                
                  
                
            }
            else
            {
                MessageBox.Show("No Data Found!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
        }

        private void txtdatesearch_TextChanged(object sender, EventArgs e)
        {
            if (txtdatesearch.Text != "")
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=LAPTOP-BADICOOA\\SQLEXPRESS2019;Initial Catalog=db;Integrated Security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "select * from Daily_Milk_Rate where Date LIKE '" + txtdatesearch.Text + "%'";
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
                cmd.CommandText = "select * from Daily_Milk_Rate";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView2.DataSource = ds.Tables[0];
            }
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            txtdatesearch.Clear();
            panel2.Visible = false;
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Data Will Be Updated. Confirm?", "Success", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (txtdate.Text != "" && txtbuffalo.Text != "" && txtcow.Text != "") 
                    {
                        String date = txtdate.Text;
                        string buff = txtbuffalo.Text;
                        String cow = txtcow.Text;
                        SqlConnection con = new SqlConnection();
                        con.ConnectionString = "Data Source=LAPTOP-BADICOOA\\SQLEXPRESS2019;Initial Catalog=db;Integrated Security=True";
                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = con;
                        cmd.CommandText = "update Daily_Milk_Rate set Date='" + date + "',Buffalo='" + buff + "',Cow='" + cow + "' where Date='" + rowid + "'";
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataSet ds = new DataSet();

                        try
                        {
                            da.Fill(ds);
                        }
                        catch
                        {
                            MessageBox.Show("Date Already Exist", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                        else {
                    MessageBox.Show("Empty Fields", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                
            } }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Data Will Be Deleted. Confirm?", "Confirmation Dialog", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=LAPTOP-BADICOOA\\SQLEXPRESS2019;Initial Catalog=db;Integrated Security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "delete from Daily_Milk_Rate where Date='" + rowid + "'";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
            }
        }

        private void txtdate_KeyPress(object sender, KeyPressEventArgs e)
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
