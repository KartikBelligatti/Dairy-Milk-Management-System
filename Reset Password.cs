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
    public partial class Reset_Password : Form
    {
        public Reset_Password()
        {
            InitializeComponent();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
           

                if (MessageBox.Show("Password Changed. Confirm?", "Success", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (txtnewpass.Text != "" && txtconfirm.Text != "")
                {

                    String pass = txtnewpass.Text;
                    String conf = txtconfirm.Text;
                    if (pass == conf)
                    {
                        SqlConnection con = new SqlConnection();
                        con.ConnectionString = "Data Source=LAPTOP-BADICOOA\\SQLEXPRESS2019;Initial Catalog=db;Integrated Security=True";
                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = con;
                        cmd.CommandText = "update Seller set Password='" + pass + "' where User_ID='" + Forgot_Password.uid + "'";
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataSet ds = new DataSet();
                        try
                        {
                            da.Fill(ds);
                        }
                        catch { }

                    }
                    else
                    {
                        MessageBox.Show("Enter the same Password in both Fields", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Empty Fields", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {

            }
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();

        }

        private void Reset_Password_Load(object sender, EventArgs e)
        {
            txtnm.Text = Forgot_Password.nm;
        }
    }
}
