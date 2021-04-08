
namespace Dairy
{
    partial class Daily_Milk
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Daily_Milk));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtdt = new System.Windows.Forms.DateTimePicker();
            this.txtuserid = new System.Windows.Forms.ComboBox();
            this.txtdat = new System.Windows.Forms.Label();
            this.txtft = new System.Windows.Forms.TextBox();
            this.txtcattype = new System.Windows.Forms.TextBox();
            this.txtfat = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtdid = new System.Windows.Forms.TextBox();
            this.txtqty = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btndelete = new System.Windows.Forms.Button();
            this.btncancel = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btnrefresh = new System.Windows.Forms.Button();
            this.txtdd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(84, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(774, 117);
            this.panel1.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(412, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(171, 38);
            this.label5.TabIndex = 1;
            this.label5.Text = "Daily Milk";
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
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Controls.Add(this.txtdt);
            this.panel2.Controls.Add(this.txtuserid);
            this.panel2.Controls.Add(this.txtdat);
            this.panel2.Controls.Add(this.txtft);
            this.panel2.Controls.Add(this.txtcattype);
            this.panel2.Controls.Add(this.txtfat);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtdid);
            this.panel2.Controls.Add(this.txtqty);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btndelete);
            this.panel2.Controls.Add(this.btncancel);
            this.panel2.Controls.Add(this.btnupdate);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(12, 427);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(916, 208);
            this.panel2.TabIndex = 23;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // txtdt
            // 
            this.txtdt.Location = new System.Drawing.Point(683, 71);
            this.txtdt.Name = "txtdt";
            this.txtdt.Size = new System.Drawing.Size(171, 27);
            this.txtdt.TabIndex = 42;
            // 
            // txtuserid
            // 
            this.txtuserid.FormattingEnabled = true;
            this.txtuserid.Location = new System.Drawing.Point(393, 7);
            this.txtuserid.Name = "txtuserid";
            this.txtuserid.Size = new System.Drawing.Size(124, 28);
            this.txtuserid.TabIndex = 41;
            // 
            // txtdat
            // 
            this.txtdat.AutoSize = true;
            this.txtdat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtdat.Location = new System.Drawing.Point(598, 74);
            this.txtdat.Name = "txtdat";
            this.txtdat.Size = new System.Drawing.Size(51, 23);
            this.txtdat.TabIndex = 15;
            this.txtdat.Text = "Date";
            this.txtdat.Click += new System.EventHandler(this.txtdat_Click);
            // 
            // txtft
            // 
            this.txtft.Location = new System.Drawing.Point(393, 73);
            this.txtft.Name = "txtft";
            this.txtft.Size = new System.Drawing.Size(124, 27);
            this.txtft.TabIndex = 14;
            this.txtft.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtft_KeyPress);
            // 
            // txtcattype
            // 
            this.txtcattype.Location = new System.Drawing.Point(120, 70);
            this.txtcattype.Name = "txtcattype";
            this.txtcattype.Size = new System.Drawing.Size(134, 27);
            this.txtcattype.TabIndex = 13;
            // 
            // txtfat
            // 
            this.txtfat.AutoSize = true;
            this.txtfat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtfat.Location = new System.Drawing.Point(305, 74);
            this.txtfat.Name = "txtfat";
            this.txtfat.Size = new System.Drawing.Size(38, 23);
            this.txtfat.TabIndex = 12;
            this.txtfat.Text = "Fat";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(0, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 23);
            this.label7.TabIndex = 11;
            this.label7.Text = "Cattle Type";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(583, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 23);
            this.label6.TabIndex = 10;
            this.label6.Text = "Quantity";
            // 
            // txtdid
            // 
            this.txtdid.Location = new System.Drawing.Point(120, 7);
            this.txtdid.Name = "txtdid";
            this.txtdid.Size = new System.Drawing.Size(134, 27);
            this.txtdid.TabIndex = 9;
            this.txtdid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdid_KeyPress);
            // 
            // txtqty
            // 
            this.txtqty.Location = new System.Drawing.Point(683, 7);
            this.txtqty.Name = "txtqty";
            this.txtqty.Size = new System.Drawing.Size(125, 27);
            this.txtqty.TabIndex = 8;
            this.txtqty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtqty_KeyPress);
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(296, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 23);
            this.label4.TabIndex = 1;
            this.label4.Text = "User_ID";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(29, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "D ID";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(24, 169);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 29;
            this.dataGridView2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView2.Size = new System.Drawing.Size(894, 234);
            this.dataGridView2.TabIndex = 22;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // btnrefresh
            // 
            this.btnrefresh.BackColor = System.Drawing.Color.Gray;
            this.btnrefresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnrefresh.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnrefresh.Location = new System.Drawing.Point(540, 134);
            this.btnrefresh.Name = "btnrefresh";
            this.btnrefresh.Size = new System.Drawing.Size(94, 29);
            this.btnrefresh.TabIndex = 21;
            this.btnrefresh.Text = "Refresh";
            this.btnrefresh.UseVisualStyleBackColor = false;
            this.btnrefresh.Click += new System.EventHandler(this.btnrefresh_Click);
            // 
            // txtdd
            // 
            this.txtdd.Location = new System.Drawing.Point(382, 134);
            this.txtdd.Name = "txtdd";
            this.txtdd.Size = new System.Drawing.Size(137, 27);
            this.txtdd.TabIndex = 20;
            this.txtdd.TextChanged += new System.EventHandler(this.txtdd_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(253, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 23);
            this.label2.TabIndex = 19;
            this.label2.Text = "D ID Search";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Gray;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(369, 644);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(189, 29);
            this.button2.TabIndex = 25;
            this.button2.Text = "Add New Record";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Daily_Milk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(940, 685);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.btnrefresh);
            this.Controls.Add(this.txtdd);
            this.Controls.Add(this.label2);
            this.Name = "Daily_Milk";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Daily_Milk";
            this.Load += new System.EventHandler(this.Daily_Milk_Load);
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

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtft;
        private System.Windows.Forms.TextBox txtcattype;
        private System.Windows.Forms.Label txtfat;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtdid;
        private System.Windows.Forms.TextBox txtqty;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btnrefresh;
        private System.Windows.Forms.TextBox txtdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label txtdat;
        private System.Windows.Forms.TextBox txt;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox txtuserid;
        private System.Windows.Forms.DateTimePicker txtregdt;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker txtdt;
    }
}