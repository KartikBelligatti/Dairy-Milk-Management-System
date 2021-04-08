
namespace Dairy
{
    partial class Add_Staff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_Staff));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtregdt = new System.Windows.Forms.DateTimePicker();
            this.txtgen = new System.Windows.Forms.ComboBox();
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
            this.txtpass = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnback = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(821, 139);
            this.panel1.TabIndex = 23;
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
            this.pictureBox1.Location = new System.Drawing.Point(198, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(208, 139);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Controls.Add(this.txtregdt);
            this.panel2.Controls.Add(this.txtgen);
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
            this.panel2.Controls.Add(this.txtpass);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.btndelete);
            this.panel2.Controls.Add(this.btnback);
            this.panel2.Controls.Add(this.btnsave);
            this.panel2.Location = new System.Drawing.Point(12, 236);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(821, 227);
            this.panel2.TabIndex = 22;
            // 
            // txtregdt
            // 
            this.txtregdt.Location = new System.Drawing.Point(188, 122);
            this.txtregdt.Name = "txtregdt";
            this.txtregdt.Size = new System.Drawing.Size(171, 27);
            this.txtregdt.TabIndex = 24;
            // 
            // txtgen
            // 
            this.txtgen.FormattingEnabled = true;
            this.txtgen.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.txtgen.Location = new System.Drawing.Point(113, 68);
            this.txtgen.Name = "txtgen";
            this.txtgen.Size = new System.Drawing.Size(134, 28);
            this.txtgen.TabIndex = 32;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(22, 122);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(160, 23);
            this.label9.TabIndex = 30;
            this.label9.Text = "Registration Date";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // txtphn
            // 
            this.txtphn.Location = new System.Drawing.Point(677, 68);
            this.txtphn.Name = "txtphn";
            this.txtphn.Size = new System.Drawing.Size(124, 27);
            this.txtphn.TabIndex = 29;
            this.txtphn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtphn_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(584, 72);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 23);
            this.label8.TabIndex = 28;
            this.label8.Text = "Phone";
            // 
            // txtsal
            // 
            this.txtsal.Location = new System.Drawing.Point(386, 68);
            this.txtsal.Name = "txtsal";
            this.txtsal.Size = new System.Drawing.Size(124, 27);
            this.txtsal.TabIndex = 27;
            // 
            // txtfat
            // 
            this.txtfat.AutoSize = true;
            this.txtfat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtfat.Location = new System.Drawing.Point(295, 72);
            this.txtfat.Name = "txtfat";
            this.txtfat.Size = new System.Drawing.Size(64, 23);
            this.txtfat.TabIndex = 25;
            this.txtfat.Text = "Salary";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(22, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 23);
            this.label7.TabIndex = 24;
            this.label7.Text = "Gender";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(567, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 23);
            this.label6.TabIndex = 23;
            this.label6.Text = "Staff Name";
            // 
            // txtsid
            // 
            this.txtsid.Location = new System.Drawing.Point(113, 19);
            this.txtsid.Name = "txtsid";
            this.txtsid.Size = new System.Drawing.Size(134, 27);
            this.txtsid.TabIndex = 22;
            this.txtsid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsid_KeyPress);
            // 
            // txtstname
            // 
            this.txtstname.Location = new System.Drawing.Point(676, 19);
            this.txtstname.Name = "txtstname";
            this.txtstname.Size = new System.Drawing.Size(125, 27);
            this.txtstname.TabIndex = 21;
            this.txtstname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtstname_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(511, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 23);
            this.label1.TabIndex = 20;
            // 
            // txtpass
            // 
            this.txtpass.Location = new System.Drawing.Point(386, 19);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(125, 27);
            this.txtpass.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(289, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 23);
            this.label4.TabIndex = 18;
            this.label4.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(22, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 23);
            this.label3.TabIndex = 17;
            this.label3.Text = "Staff ID";
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
            this.btndelete.Text = "Cancel";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnback
            // 
            this.btnback.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnback.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnback.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnback.Location = new System.Drawing.Point(656, 154);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(94, 29);
            this.btnback.TabIndex = 5;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = false;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnsave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnsave.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnsave.Location = new System.Drawing.Point(423, 154);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(94, 29);
            this.btnsave.TabIndex = 4;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // Add_Staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(848, 475);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Add_Staff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add_Staff";
            this.Load += new System.EventHandler(this.Add_Staff_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.TextBox txtphn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtsal;
        private System.Windows.Forms.Label txtfat;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtsid;
        private System.Windows.Forms.TextBox txtstname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox txtgen;
        private System.Windows.Forms.DateTimePicker txtregdt;
    }
}