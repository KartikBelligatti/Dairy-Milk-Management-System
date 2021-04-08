using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Dairy
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void txtUserID_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtUserID.Text == "Admin ID")
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
            if (txtUserID.Text == "" && txtPassword.Text == "")
            {
                MessageBox.Show("Empty Admin ID or Password", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (txtUserID.Text == "8055" && txtPassword.Text == "k")
                {
                    MessageBox.Show("Login Successfully !", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    Dashboard d = new Dashboard();
                    d.Show();
                }
                else
                {
                    MessageBox.Show("Wrong Admin ID or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
