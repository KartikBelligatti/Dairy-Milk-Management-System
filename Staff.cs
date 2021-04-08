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
    public partial class Staff : Form
    {
        public Staff()
        {
            InitializeComponent();
        }
        public static String staffid;
        public static String pass;
        private void btnClose_Click(object sender, EventArgs e)
        {
           
            Form1 f = new Form1();
            f.Show();
            this.Close();
        }

        private void txtUserID_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtUserID.Text == "Staff ID")
            {
                txtUserID.Clear();
            }
        }

        private void txtPassword_MouseClick(object sender, MouseEventArgs e)
        {

            if (txtPassword.Text == "Password")
            {
                txtPassword.Clear();
                txtPassword.PasswordChar = '*';
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=LAPTOP-BADICOOA\\SQLEXPRESS2019;Initial Catalog=db;Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "Select * from Staff where Staff_ID='" + txtUserID.Text + "' and Staff_Password='" + txtPassword.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            try
            {
                da.Fill(ds);
            }
            catch
            {
                MessageBox.Show("Empty Credentials!", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (ds.Tables[0].Rows.Count != 0)
            {
                MessageBox.Show("Login Successfully !", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                staffid = txtUserID.Text;
                pass = txtPassword.Text;

                this.Hide();
                Form2 f2 = new Form2();
                f2.Show();
            }
            else
            {
                MessageBox.Show("Wrong Staff ID or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin a = new Admin();
            a.Show();
        }

        private void Staff_Load(object sender, EventArgs e)
        {
            staffid = txtUserID.Text;
        }

        private void txtstaffid_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Staff_Forgot_Password s = new Staff_Forgot_Password();
            s.Show();
            //this.Hide();
        }
    }
}
