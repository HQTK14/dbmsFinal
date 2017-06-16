namespace UI
{
    partial class DANGNHAP
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.radioQTV = new System.Windows.Forms.RadioButton();
            this.radioGV = new System.Windows.Forms.RadioButton();
            this.radioSV = new System.Windows.Forms.RadioButton();
            this.btnSignIn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_pwd = new System.Windows.Forms.TextBox();
            this.txt_mssv = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.btnSignIn);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txt_pwd);
            this.panel1.Controls.Add(this.txt_mssv);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Location = new System.Drawing.Point(37, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(269, 474);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.radioQTV);
            this.panel3.Controls.Add(this.radioGV);
            this.panel3.Controls.Add(this.radioSV);
            this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.panel3.Location = new System.Drawing.Point(46, 76);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(170, 97);
            this.panel3.TabIndex = 9;
            // 
            // radioQTV
            // 
            this.radioQTV.AutoSize = true;
            this.radioQTV.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.radioQTV.ForeColor = System.Drawing.Color.Black;
            this.radioQTV.Location = new System.Drawing.Point(24, 50);
            this.radioQTV.Name = "radioQTV";
            this.radioQTV.Size = new System.Drawing.Size(130, 26);
            this.radioQTV.TabIndex = 2;
            this.radioQTV.TabStop = true;
            this.radioQTV.Text = "Quản trị viên";
            this.radioQTV.UseVisualStyleBackColor = true;
            // 
            // radioGV
            // 
            this.radioGV.AutoSize = true;
            this.radioGV.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.radioGV.ForeColor = System.Drawing.Color.Black;
            this.radioGV.Location = new System.Drawing.Point(24, 27);
            this.radioGV.Name = "radioGV";
            this.radioGV.Size = new System.Drawing.Size(104, 26);
            this.radioGV.TabIndex = 1;
            this.radioGV.TabStop = true;
            this.radioGV.Text = "Giáo viên";
            this.radioGV.UseVisualStyleBackColor = true;
            // 
            // radioSV
            // 
            this.radioSV.AutoSize = true;
            this.radioSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.radioSV.ForeColor = System.Drawing.Color.Black;
            this.radioSV.Location = new System.Drawing.Point(24, 4);
            this.radioSV.Name = "radioSV";
            this.radioSV.Size = new System.Drawing.Size(102, 26);
            this.radioSV.TabIndex = 0;
            this.radioSV.TabStop = true;
            this.radioSV.Text = "Sinh viên";
            this.radioSV.UseVisualStyleBackColor = true;
            // 
            // btnSignIn
            // 
            this.btnSignIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSignIn.BackColor = System.Drawing.SystemColors.MenuText;
            this.btnSignIn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignIn.ForeColor = System.Drawing.Color.White;
            this.btnSignIn.Location = new System.Drawing.Point(46, 378);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(111, 46);
            this.btnSignIn.TabIndex = 8;
            this.btnSignIn.Text = "SIGN IN";
            this.btnSignIn.UseVisualStyleBackColor = false;
            this.btnSignIn.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(124, 438);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 19);
            this.label5.TabIndex = 7;
            this.label5.Text = "Forgot Password ?";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txt_pwd
            // 
            this.txt_pwd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_pwd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_pwd.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pwd.Location = new System.Drawing.Point(46, 318);
            this.txt_pwd.Name = "txt_pwd";
            this.txt_pwd.PasswordChar = '*';
            this.txt_pwd.Size = new System.Drawing.Size(175, 32);
            this.txt_pwd.TabIndex = 5;
            this.txt_pwd.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txt_mssv
            // 
            this.txt_mssv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_mssv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_mssv.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mssv.Location = new System.Drawing.Point(46, 225);
            this.txt_mssv.Name = "txt_mssv";
            this.txt_mssv.Size = new System.Drawing.Size(175, 32);
            this.txt_mssv.TabIndex = 4;
            this.txt_mssv.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(23, 282);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "MẬT KHẨU";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(23, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "TÊN NGƯỜI DÙNG";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.MenuText;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 49);
            this.label1.TabIndex = 0;
            this.label1.Text = "LOGIN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // DANGNHAP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(340, 503);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Cyan;
            this.MaximizeBox = false;
            this.Name = "DANGNHAP";
            this.Text = "ĐĂNG NHẬP";
            this.Load += new System.EventHandler(this.LOGIN_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_pwd;
        private System.Windows.Forms.TextBox txt_mssv;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSignIn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton radioQTV;
        private System.Windows.Forms.RadioButton radioGV;
        private System.Windows.Forms.RadioButton radioSV;
    }
}