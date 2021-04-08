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
    public partial class Add_new_milk_rate : Form
    {
        public Add_new_milk_rate()
        {
            InitializeComponent();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (txtdate.Text != "" && txtbuffalo.Text != "" && txtcow.Text != "")
            {
                String dt = txtdate.Text;
                String buf = txtbuffalo.Text;
                String cw = txtcow.Text;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=LAPTOP-BADICOOA\\SQLEXPRESS2019;Initial Catalog=db;Integrated Security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                con.Open();
                cmd.CommandText = "insert into Daily_Milk_Rate (Date,Buffalo,Cow) values('" + dt + "','" + buf + "','" + cw + "')";
                try
                {
                    cmd.ExecuteNonQuery();


                    con.Close();
                    MessageBox.Show("Credentials Saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   // txtdate.Clear();
                    txtbuffalo.Clear();
                    txtcow.Clear();
                }
                catch
                {
                    MessageBox.Show("Date Already Exist", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
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
               // txtdate.Clear();
                txtbuffalo.Clear();
                txtcow.Clear();


            }
        }
            private void btnback_Click(object sender, EventArgs e)
            {
                Milk_Rate mr = new Milk_Rate();
                mr.Show();
                this.Close();
            }

        private void Add_new_milk_rate_Load(object sender, EventArgs e)
        {

        }
    }
    }

