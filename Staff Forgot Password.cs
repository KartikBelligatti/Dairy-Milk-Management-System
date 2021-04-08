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
    public partial class Staff_Forgot_Password : Form
    {
        public Staff_Forgot_Password()
        {
            InitializeComponent();
        }
        public static String uid;
        public static String nm;

        private void btnsave_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=LAPTOP-BADICOOA\\SQLEXPRESS2019;Initial Catalog=db;Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "Select * from Staff where Staff_ID='" + txtuserid.Text + "' and Staff_Name='" + txtname.Text + "'";

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



                // MessageBox.Show("Login Successfully !", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                uid = txtuserid.Text;
                nm = txtname.Text;
                this.Hide();
                staff_Reset_Password d = new staff_Reset_Password();
                d.Show();

            }
            else
            {
                MessageBox.Show("Something Went Wrong!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            Staff s = new Staff();
            s.Show();
            this.Hide();
        }

        private void txtname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Only Characters Are Allowed", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtuserid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Only Numbers Are Allowed", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
