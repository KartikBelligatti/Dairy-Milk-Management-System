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
    public partial class Sign_Up : Form
    {
        public Sign_Up()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if(txtnewuserid.Text !=""&& txtnewpassword.Text!="" && txtsname.Text!="" && txtgen.Text!="" && txtregdat.Text!=""&&txtadd.Text!="")
                {
                
                    Int64 uid = Int64.Parse(txtnewuserid.Text);
                    String pass = txtnewpassword.Text;

                    String snam = txtsname.Text;
                    String gen = txtgen.Text;
                    String rd = txtregdat.Text;
                    String ad = txtadd.Text;
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = "Data Source=LAPTOP-BADICOOA\\SQLEXPRESS2019;Initial Catalog=db;Integrated Security=True";
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    con.Open();
                //cmd.CommandText = "insert into Login (User_ID,Password) values('" + uid + "','" + pass + "')";
               try
                {
                    cmd.CommandText = "insert into Seller (User_ID,Password,Seller_Name,Gender,Reg_Date,Address) values(" + uid + ",'" + pass + "','" + snam + "','" + gen + "','" + rd + "','" + ad + "')";
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Credentials Saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtnewuserid.Clear();
                    txtnewpassword.Clear();
                }
                catch
                {
                    MessageBox.Show("User ID Already Exist! ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            this.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtnewpassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtnewuserid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Only Numbers Are Allowed", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtsname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Only Characters Are Allowed", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
