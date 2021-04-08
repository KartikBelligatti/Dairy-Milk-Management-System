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
    public partial class Add_Staff : Form
    {
        public Add_Staff()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Add_Staff_Load(object sender, EventArgs e)
        {

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (txtsid.Text != "" && txtpass.Text != ""  && txtstname.Text != "" && txtgen.Text != "" && txtsal.Text != "" && txtphn.Text!="" && txtregdt.Text!="")
            {

                Int64 sid =Int64.Parse( txtsid.Text);
                String pass = txtpass.Text;
                String nm = txtstname.Text;
                String gen = txtgen.Text;
                String sal = txtsal.Text;
                Int64 sm = Int64.Parse(txtphn.Text);
                if (txtphn.Text.Length == 10)
                {
                    String dt = txtregdt.Text;
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = "Data Source=LAPTOP-BADICOOA\\SQLEXPRESS2019;Initial Catalog=db;Integrated Security=True";
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    con.Open();
                    cmd.CommandText = "insert into Staff(Staff_ID,Staff_Password,Staff_Name,Gender,Salary,Phone,Reg_Date) values(" + sid + ",'" + pass + "','" + nm + "','" + gen + "','" + sal + "'," + sm + ",'" + dt + "')";
                    try
                    {
                        cmd.ExecuteNonQuery();

                        con.Close();
                        MessageBox.Show("Credentials Saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtsid.Clear();
                        txtpass.Clear();
                        txtstname.Clear();
                        txtsal.Clear();
                        // txtgen.Clear();
                        txtphn.Clear();
                        //txtregdt.Clear();
                    }
                    catch
                    {
                        MessageBox.Show("Staff_ID Already Exist", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Please Enter 10 Digit Mobile Number", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                txtsid.Clear();
                txtpass.Clear();
                txtstname.Clear();
                txtsal.Clear();
                //txtgen.Clear();
                txtphn.Clear();
               // txtregdt.Clear();


            }
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            Staff_Details mr = new Staff_Details();
            mr.Show();
            this.Close();
        }

        private void txtphn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
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
                MessageBox.Show("Only Numbers Are Allowed", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtstname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Only Characters Are Allowed", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
