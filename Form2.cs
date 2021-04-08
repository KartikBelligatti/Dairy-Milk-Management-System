using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Dairy
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Milk_Rate mr = new Milk_Rate();
            mr.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            My_Details md = new My_Details();
            md.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Seller s = new Seller();
            s.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Daily_Milk d = new Daily_Milk();
            d.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Billing b = new Billing();
            b.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure You want to exit?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Form1 f = new Form1();
                f.Show();
                this.Close();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //txtnm.Text = "select Staff_Name from Staff where Staff_ID='"+Staff.staffid+"'";
        }
    }
}
