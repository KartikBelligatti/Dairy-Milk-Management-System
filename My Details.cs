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
    public partial class My_Details : Form
    {
        public My_Details()
        {
            InitializeComponent();
        }

        private void My_Details_Load(object sender, EventArgs e)
        {
            panel2.Visible = true;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=LAPTOP-BADICOOA\\SQLEXPRESS2019;Initial Catalog=db;Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from Staff where Staff_ID='" + Staff.staffid + "'";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            //  rowid = (ds.Tables[0].Rows[0][0].ToString());
            txtsid.Text = ds.Tables[0].Rows[0][0].ToString();
            txtpass.Text = ds.Tables[0].Rows[0][1].ToString();
            txtstname.Text = ds.Tables[0].Rows[0][2].ToString();
            txtgen.Text = ds.Tables[0].Rows[0][3].ToString();
            txtsal.Text = ds.Tables[0].Rows[0][4].ToString();
            txtphn.Text = ds.Tables[0].Rows[0][5].ToString();
            txtregdt.Text = ds.Tables[0].Rows[0][6].ToString();


        }
        String bid;
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
            
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            
        }
    }
}
