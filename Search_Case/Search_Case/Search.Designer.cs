namespace Search_Case
{
    partial class Search
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBoxECC = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tmob_num = new System.Windows.Forms.TextBox();
            this.tcase_num = new System.Windows.Forms.TextBox();
            this.tcase_type = new System.Windows.Forms.TextBox();
            this.tclient_nm = new System.Windows.Forms.TextBox();
            this.lmobile_num = new System.Windows.Forms.Label();
            this.lcase_num = new System.Windows.Forms.Label();
            this.lcase_type = new System.Windows.Forms.Label();
            this.lclient_nm = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.comboBoxECC);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.tmob_num);
            this.panel1.Controls.Add(this.tcase_num);
            this.panel1.Controls.Add(this.tcase_type);
            this.panel1.Controls.Add(this.tclient_nm);
            this.panel1.Controls.Add(this.lmobile_num);
            this.panel1.Controls.Add(this.lcase_num);
            this.panel1.Controls.Add(this.lcase_type);
            this.panel1.Controls.Add(this.lclient_nm);
            this.panel1.Location = new System.Drawing.Point(7, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(629, 338);
            this.panel1.TabIndex = 1;
            // 
            // comboBoxECC
            // 
            this.comboBoxECC.FormattingEnabled = true;
            this.comboBoxECC.Items.AddRange(new object[] {
            "L",
            "M",
            "Q"});
            this.comboBoxECC.Location = new System.Drawing.Point(374, 280);
            this.comboBoxECC.Name = "comboBoxECC";
            this.comboBoxECC.Size = new System.Drawing.Size(133, 21);
            this.comboBoxECC.TabIndex = 18;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(357, 74);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(211, 176);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(176, 290);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Print";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(53, 290);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tmob_num
            // 
            this.tmob_num.Location = new System.Drawing.Point(154, 219);
            this.tmob_num.Name = "tmob_num";
            this.tmob_num.Size = new System.Drawing.Size(125, 20);
            this.tmob_num.TabIndex = 7;
            // 
            // tcase_num
            // 
            this.tcase_num.Location = new System.Drawing.Point(154, 156);
            this.tcase_num.Name = "tcase_num";
            this.tcase_num.Size = new System.Drawing.Size(125, 20);
            this.tcase_num.TabIndex = 6;
            // 
            // tcase_type
            // 
            this.tcase_type.Location = new System.Drawing.Point(154, 98);
            this.tcase_type.Name = "tcase_type";
            this.tcase_type.Size = new System.Drawing.Size(125, 20);
            this.tcase_type.TabIndex = 5;
            // 
            // tclient_nm
            // 
            this.tclient_nm.Location = new System.Drawing.Point(154, 43);
            this.tclient_nm.Name = "tclient_nm";
            this.tclient_nm.Size = new System.Drawing.Size(125, 20);
            this.tclient_nm.TabIndex = 4;
            // 
            // lmobile_num
            // 
            this.lmobile_num.AutoSize = true;
            this.lmobile_num.Location = new System.Drawing.Point(50, 222);
            this.lmobile_num.Name = "lmobile_num";
            this.lmobile_num.Size = new System.Drawing.Size(78, 13);
            this.lmobile_num.TabIndex = 3;
            this.lmobile_num.Text = "Mobile Number";
            // 
            // lcase_num
            // 
            this.lcase_num.AutoSize = true;
            this.lcase_num.Location = new System.Drawing.Point(50, 159);
            this.lcase_num.Name = "lcase_num";
            this.lcase_num.Size = new System.Drawing.Size(71, 13);
            this.lcase_num.TabIndex = 2;
            this.lcase_num.Text = "Case Number";
            // 
            // lcase_type
            // 
            this.lcase_type.AutoSize = true;
            this.lcase_type.Location = new System.Drawing.Point(50, 98);
            this.lcase_type.Name = "lcase_type";
            this.lcase_type.Size = new System.Drawing.Size(58, 13);
            this.lcase_type.TabIndex = 1;
            this.lcase_type.Text = "Case Type";
            // 
            // lclient_nm
            // 
            this.lclient_nm.AutoSize = true;
            this.lclient_nm.Location = new System.Drawing.Point(50, 43);
            this.lclient_nm.Name = "lclient_nm";
            this.lclient_nm.Size = new System.Drawing.Size(64, 13);
            this.lclient_nm.TabIndex = 0;
            this.lclient_nm.Text = "Client Name";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(374, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 19;
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 404);
            this.Controls.Add(this.panel1);
            this.Name = "Search";
            this.Text = "Search";
            this.Load += new System.EventHandler(this.Search_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBoxECC;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tmob_num;
        private System.Windows.Forms.TextBox tcase_num;
        private System.Windows.Forms.TextBox tcase_type;
        private System.Windows.Forms.TextBox tclient_nm;
        private System.Windows.Forms.Label lmobile_num;
        private System.Windows.Forms.Label lcase_num;
        private System.Windows.Forms.Label lcase_type;
        private System.Windows.Forms.Label lclient_nm;
        private System.Windows.Forms.TextBox textBox1;
    }
}