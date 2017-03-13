namespace Search_Case
{
    partial class Form1
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
            this.clnm = new System.Windows.Forms.Label();
            this.C = new System.Windows.Forms.Label();
            this.ctyp = new System.Windows.Forms.Label();
            this.cnum = new System.Windows.Forms.Label();
            this.year = new System.Windows.Forms.Label();
            this.client_mobile = new System.Windows.Forms.Label();
            this.cadv = new System.Windows.Forms.Label();
            this.client_name = new System.Windows.Forms.TextBox();
            this.opposite = new System.Windows.Forms.TextBox();
            this.client_code = new System.Windows.Forms.TextBox();
            this.case_type = new System.Windows.Forms.TextBox();
            this.case_number = new System.Windows.Forms.TextBox();
            this.client_mob = new System.Windows.Forms.TextBox();
            this.advcode = new System.Windows.Forms.TextBox();
            this.case_year = new System.Windows.Forms.TextBox();
            this.generate = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBoxECC = new System.Windows.Forms.ComboBox();
            this.opnm = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // clnm
            // 
            this.clnm.AutoSize = true;
            this.clnm.Location = new System.Drawing.Point(34, 38);
            this.clnm.Name = "clnm";
            this.clnm.Size = new System.Drawing.Size(64, 13);
            this.clnm.TabIndex = 0;
            this.clnm.Text = "Client Name";
            // 
            // C
            // 
            this.C.AutoSize = true;
            this.C.Location = new System.Drawing.Point(34, 78);
            this.C.Name = "C";
            this.C.Size = new System.Drawing.Size(61, 13);
            this.C.TabIndex = 1;
            this.C.Text = "Client Code";
            this.C.Click += new System.EventHandler(this.ccod_Click);
            // 
            // ctyp
            // 
            this.ctyp.AutoSize = true;
            this.ctyp.Location = new System.Drawing.Point(34, 126);
            this.ctyp.Name = "ctyp";
            this.ctyp.Size = new System.Drawing.Size(58, 13);
            this.ctyp.TabIndex = 2;
            this.ctyp.Text = "Case Type";
            // 
            // cnum
            // 
            this.cnum.AutoSize = true;
            this.cnum.Location = new System.Drawing.Point(34, 169);
            this.cnum.Name = "cnum";
            this.cnum.Size = new System.Drawing.Size(71, 13);
            this.cnum.TabIndex = 3;
            this.cnum.Text = "Case Number";
            // 
            // year
            // 
            this.year.AutoSize = true;
            this.year.Location = new System.Drawing.Point(34, 291);
            this.year.Name = "year";
            this.year.Size = new System.Drawing.Size(29, 13);
            this.year.TabIndex = 4;
            this.year.Text = "Year";
            // 
            // client_mobile
            // 
            this.client_mobile.AutoSize = true;
            this.client_mobile.Location = new System.Drawing.Point(34, 210);
            this.client_mobile.Name = "client_mobile";
            this.client_mobile.Size = new System.Drawing.Size(87, 13);
            this.client_mobile.TabIndex = 5;
            this.client_mobile.Text = "Client Mobile No:";
            // 
            // cadv
            // 
            this.cadv.AutoSize = true;
            this.cadv.Location = new System.Drawing.Point(34, 254);
            this.cadv.Name = "cadv";
            this.cadv.Size = new System.Drawing.Size(81, 13);
            this.cadv.TabIndex = 6;
            this.cadv.Text = "Advocate Code";
            // 
            // client_name
            // 
            this.client_name.Location = new System.Drawing.Point(154, 38);
            this.client_name.Name = "client_name";
            this.client_name.Size = new System.Drawing.Size(133, 20);
            this.client_name.TabIndex = 7;
            this.client_name.TextChanged += new System.EventHandler(this.client_TextChanged);
            // 
            // opposite
            // 
            this.opposite.Location = new System.Drawing.Point(417, 38);
            this.opposite.Name = "opposite";
            this.opposite.Size = new System.Drawing.Size(158, 20);
            this.opposite.TabIndex = 8;
            // 
            // client_code
            // 
            this.client_code.Location = new System.Drawing.Point(154, 78);
            this.client_code.Name = "client_code";
            this.client_code.Size = new System.Drawing.Size(133, 20);
            this.client_code.TabIndex = 9;
            // 
            // case_type
            // 
            this.case_type.Location = new System.Drawing.Point(154, 119);
            this.case_type.Name = "case_type";
            this.case_type.Size = new System.Drawing.Size(133, 20);
            this.case_type.TabIndex = 10;
            // 
            // case_number
            // 
            this.case_number.Location = new System.Drawing.Point(154, 169);
            this.case_number.MaxLength = 36745;
            this.case_number.Name = "case_number";
            this.case_number.Size = new System.Drawing.Size(133, 20);
            this.case_number.TabIndex = 11;
            // 
            // client_mob
            // 
            this.client_mob.Location = new System.Drawing.Point(154, 210);
            this.client_mob.MaxLength = 13;
            this.client_mob.Name = "client_mob";
            this.client_mob.Size = new System.Drawing.Size(133, 20);
            this.client_mob.TabIndex = 12;
            this.client_mob.TextChanged += new System.EventHandler(this.cmobno_TextChanged);
            // 
            // advcode
            // 
            this.advcode.Location = new System.Drawing.Point(154, 247);
            this.advcode.Name = "advcode";
            this.advcode.Size = new System.Drawing.Size(133, 20);
            this.advcode.TabIndex = 13;
            // 
            // case_year
            // 
            this.case_year.Location = new System.Drawing.Point(154, 291);
            this.case_year.Name = "case_year";
            this.case_year.Size = new System.Drawing.Size(133, 20);
            this.case_year.TabIndex = 14;
            // 
            // generate
            // 
            this.generate.Location = new System.Drawing.Point(37, 332);
            this.generate.Name = "generate";
            this.generate.Size = new System.Drawing.Size(75, 23);
            this.generate.TabIndex = 15;
            this.generate.Text = "Generate";
            this.generate.UseVisualStyleBackColor = true;
            this.generate.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(381, 78);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(218, 198);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // comboBoxECC
            // 
            this.comboBoxECC.FormattingEnabled = true;
            this.comboBoxECC.Items.AddRange(new object[] {
            "L",
            "M",
            "Q"});
            this.comboBoxECC.Location = new System.Drawing.Point(154, 332);
            this.comboBoxECC.Name = "comboBoxECC";
            this.comboBoxECC.Size = new System.Drawing.Size(133, 21);
            this.comboBoxECC.TabIndex = 17;
            // 
            // opnm
            // 
            this.opnm.AutoSize = true;
            this.opnm.Location = new System.Drawing.Point(309, 42);
            this.opnm.Name = "opnm";
            this.opnm.Size = new System.Drawing.Size(80, 13);
            this.opnm.TabIndex = 18;
            this.opnm.Text = "Opposite Name";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(381, 330);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(480, 330);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 20;
            this.button2.Text = "Search";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(575, 332);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 21;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 409);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.case_number);
            this.Controls.Add(this.opnm);
            this.Controls.Add(this.comboBoxECC);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.generate);
            this.Controls.Add(this.case_year);
            this.Controls.Add(this.advcode);
            this.Controls.Add(this.client_mob);
            this.Controls.Add(this.case_type);
            this.Controls.Add(this.client_code);
            this.Controls.Add(this.opposite);
            this.Controls.Add(this.client_name);
            this.Controls.Add(this.cadv);
            this.Controls.Add(this.client_mobile);
            this.Controls.Add(this.year);
            this.Controls.Add(this.cnum);
            this.Controls.Add(this.ctyp);
            this.Controls.Add(this.C);
            this.Controls.Add(this.clnm);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label clnm;
        private System.Windows.Forms.Label C;
        private System.Windows.Forms.Label ctyp;
        private System.Windows.Forms.Label cnum;
        private System.Windows.Forms.Label year;
        private System.Windows.Forms.Label client_mobile;
        private System.Windows.Forms.Label cadv;
        private System.Windows.Forms.TextBox client_name;
        private System.Windows.Forms.TextBox opposite;
        private System.Windows.Forms.TextBox client_code;
        private System.Windows.Forms.TextBox case_type;
        private System.Windows.Forms.TextBox case_number;
        private System.Windows.Forms.TextBox client_mob;
        private System.Windows.Forms.TextBox advcode;
        private System.Windows.Forms.TextBox case_year;
        private System.Windows.Forms.Button generate;
        private System.Windows.Forms.ComboBox comboBoxECC;
        private System.Windows.Forms.Label opnm;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        public System.Windows.Forms.PictureBox pictureBox1;
    }
}

