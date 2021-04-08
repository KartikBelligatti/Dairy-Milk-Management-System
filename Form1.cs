using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Dairy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static String uid;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Sign_Up su = new Sign_Up();
            su.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtUserID_MouseEnter(object sender, EventArgs e)
        {

        }

        private void txtUserID_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtUserID.Text == "User ID")
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

            cmd.CommandText = "Select * from Seller where User_ID='" + txtUserID.Text + "' and [Password]='" + txtPassword.Text + "'";

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
                uid = txtUserID.Text;
                this.Hide();
                Form3 d = new Form3();
                d.Show();

            }
            else
            {
                MessageBox.Show("Wrong user ID or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
      
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            Staff s = new Staff();
            s.Show();
            this.Visible = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Forgot_Password f = new Forgot_Password();
            f.Show();
           // this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
