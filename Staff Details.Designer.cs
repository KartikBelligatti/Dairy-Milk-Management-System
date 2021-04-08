
namespace Dairy
{
    partial class Staff_Details
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Staff_Details));
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtregdt = new System.Windows.Forms.DateTimePicker();
            this.txtgend = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtphn = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtsal = new System.Windows.Forms.TextBox();
            this.txtfat = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtsid = new System.Windows.Forms.TextBox();
            this.txtstname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btndelete = new System.Windows.Forms.Button();
            this.btncancel = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtgen = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btnrefresh = new System.Windows.Forms.Button();
            this.txtsidsearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Gray;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(403, 660);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(189, 29);
            this.button2.TabIndex = 38;
            this.button2.Text = "Add New Record";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(123, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(774, 117);
            this.panel1.TabIndex = 37;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(412, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(194, 38);
            this.label5.TabIndex = 1;
            this.label5.Text = "Staff Details";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(236, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(170, 117);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Controls.Add(this.txtregdt);
            this.panel2.Controls.Add(this.txtgend);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.txtphn);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.txtsal);
            this.panel2.Controls.Add(this.txtfat);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtsid);
            this.panel2.Controls.Add(this.txtstname);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btndelete);
            this.panel2.Controls.Add(this.btncancel);
            this.panel2.Controls.Add(this.btnupdate);
            this.panel2.Controls.Add(this.txtpass);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(89, 446);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(838, 208);
            this.panel2.TabIndex = 36;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // txtregdt
            // 
            this.txtregdt.Location = new System.Drawing.Point(195, 151);
            this.txtregdt.Name = "txtregdt";
            this.txtregdt.Size = new System.Drawing.Size(171, 27);
            this.txtregdt.TabIndex = 40;
            // 
            // txtgend
            // 
            this.txtgend.FormattingEnabled = true;
            this.txtgend.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.txtgend.Location = new System.Drawing.Point(120, 76);
            this.txtgend.Name = "txtgend";
            this.txtgend.Size = new System.Drawing.Size(134, 28);
            this.txtgend.TabIndex = 39;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(23, 154);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(160, 23);
            this.label9.TabIndex = 17;
            this.label9.Text = "Registration Date";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // txtphn
            // 
            this.txtphn.Location = new System.Drawing.Point(684, 77);
            this.txtphn.Name = "txtphn";
            this.txtphn.Size = new System.Drawing.Size(124, 27);
            this.txtphn.TabIndex = 16;
            this.txtphn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtphn_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(591, 81);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 23);
            this.label8.TabIndex = 15;
            this.label8.Text = "Phone";
            // 
            // txtsal
            // 
            this.txtsal.Location = new System.Drawing.Point(394, 77);
            this.txtsal.Name = "txtsal";
            this.txtsal.Size = new System.Drawing.Size(124, 27);
            this.txtsal.TabIndex = 14;
            this.txtsal.TextChanged += new System.EventHandler(this.txtsal_TextChanged);
            // 
            // txtfat
            // 
            this.txtfat.AutoSize = true;
            this.txtfat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtfat.Location = new System.Drawing.Point(302, 81);
            this.txtfat.Name = "txtfat";
            this.txtfat.Size = new System.Drawing.Size(64, 23);
            this.txtfat.TabIndex = 12;
            this.txtfat.Text = "Salary";
            this.txtfat.Click += new System.EventHandler(this.txtfat_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(34, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 23);
            this.label7.TabIndex = 11;
            this.label7.Text = "Gender";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(574, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 23);
            this.label6.TabIndex = 10;
            this.label6.Text = "Staff Name";
            // 
            // txtsid
            // 
            this.txtsid.Location = new System.Drawing.Point(120, 7);
            this.txtsid.Name = "txtsid";
            this.txtsid.Size = new System.Drawing.Size(134, 27);
            this.txtsid.TabIndex = 9;
            this.txtsid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsid_KeyPress);
            // 
            // txtstname
            // 
            this.txtstname.Location = new System.Drawing.Point(683, 7);
            this.txtstname.Name = "txtstname";
            this.txtstname.Size = new System.Drawing.Size(125, 27);
            this.txtstname.TabIndex = 8;
            this.txtstname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtstname_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(518, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 23);
            this.label1.TabIndex = 7;
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btndelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btndelete.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btndelete.Location = new System.Drawing.Point(544, 154);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(94, 29);
            this.btndelete.TabIndex = 6;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btncancel
            // 
            this.btncancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btncancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btncancel.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btncancel.Location = new System.Drawing.Point(656, 154);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(94, 29);
            this.btncancel.TabIndex = 5;
            this.btncancel.Text = "Cancel";
            this.btncancel.UseVisualStyleBackColor = false;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnupdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnupdate.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnupdate.Location = new System.Drawing.Point(423, 154);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(94, 29);
            this.btnupdate.TabIndex = 4;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // txtpass
            // 
            this.txtpass.Location = new System.Drawing.Point(393, 7);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(125, 27);
            this.txtpass.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(296, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 23);
            this.label4.TabIndex = 1;
            this.label4.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(29, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "Staff ID";
            // 
            // txtgen
            // 
            this.txtgen.Location = new System.Drawing.Point(772, 229);
            this.txtgen.Name = "txtgen";
            this.txtgen.Size = new System.Drawing.Size(134, 27);
            this.txtgen.TabIndex = 13;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(12, 189);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 29;
            this.dataGridView2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView2.Size = new System.Drawing.Size(986, 230);
            this.dataGridView2.TabIndex = 35;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // btnrefresh
            // 
            this.btnrefresh.BackColor = System.Drawing.Color.Gray;
            this.btnrefresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnrefresh.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnrefresh.Location = new System.Drawing.Point(595, 150);
            this.btnrefresh.Name = "btnrefresh";
            this.btnrefresh.Size = new System.Drawing.Size(94, 29);
            this.btnrefresh.TabIndex = 34;
            this.btnrefresh.Text = "Refresh";
            this.btnrefresh.UseVisualStyleBackColor = false;
            this.btnrefresh.Click += new System.EventHandler(this.btnrefresh_Click);
            // 
            // txtsidsearch
            // 
            this.txtsidsearch.Location = new System.Drawing.Point(437, 150);
            this.txtsidsearch.Name = "txtsidsearch";
            this.txtsidsearch.Size = new System.Drawing.Size(137, 27);
            this.txtsidsearch.TabIndex = 33;
            this.txtsidsearch.TextChanged += new System.EventHandler(this.txtsidsearch_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(290, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 23);
            this.label2.TabIndex = 32;
            this.label2.Text = "Staff ID Search";
            // 
            // Staff_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1010, 697);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.txtgen);
            this.Controls.Add(this.btnrefresh);
            this.Controls.Add(this.txtsidsearch);
            this.Controls.Add(this.label2);
            this.Name = "Staff_Details";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Staff_Details";
            this.Load += new System.EventHandler(this.Staff_Details_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtsal;
        private System.Windows.Forms.TextBox txtgen;
        private System.Windows.Forms.Label txtfat;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtsid;
        private System.Windows.Forms.TextBox txtstname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btnrefresh;
        private System.Windows.Forms.TextBox txtsidsearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtphn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox txtgend;
        private System.Windows.Forms.DateTimePicker txtregdt;
    }
}