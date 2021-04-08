using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Dairy
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void menuStrip2_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void menuStrip2_ItemClicked_2(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure You want to exit?","Confirm",MessageBoxButtons.YesNo,MessageBoxIcon.Warning)==DialogResult.Yes)
            {
                Form1 f = new Form1();
                f.Show();
                this.Close();
            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login_Details ld = new Login_Details();
            ld.Show();


        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            Billing b = new Billing();
            b.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Milk_Rate dm = new Milk_Rate();
            dm.Show();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Seller s = new Seller();
            s.Show();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            Daily_Milk dm = new Daily_Milk();
            dm.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Staff_Details sd = new Staff_Details();
            sd.Show();
        }
    }
}
