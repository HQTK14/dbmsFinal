namespace UI
{
    partial class QLMH
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewMH = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_MaMon = new System.Windows.Forms.TextBox();
            this.txt_TenMon = new System.Windows.Forms.TextBox();
            this.dateTimePickerNgayDB = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerDisfrom = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerDisTo = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerNgayKT = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxSTC = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMH)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewMH
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.MenuBar;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewMH.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewMH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewMH.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.GreenYellow;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewMH.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewMH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMH.Location = new System.Drawing.Point(28, 12);
            this.dataGridViewMH.Name = "dataGridViewMH";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LawnGreen;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewMH.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewMH.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewMH.Size = new System.Drawing.Size(666, 292);
            this.dataGridViewMH.TabIndex = 0;
            this.dataGridViewMH.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMH_CellContentClick);
            this.dataGridViewMH.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.dataGridViewMH_RowStateChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã môn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên môn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Số tín chỉ";
            // 
            // txt_MaMon
            // 
            this.txt_MaMon.Location = new System.Drawing.Point(100, 18);
            this.txt_MaMon.Name = "txt_MaMon";
            this.txt_MaMon.Size = new System.Drawing.Size(100, 20);
            this.txt_MaMon.TabIndex = 5;
            // 
            // txt_TenMon
            // 
            this.txt_TenMon.Location = new System.Drawing.Point(100, 48);
            this.txt_TenMon.Name = "txt_TenMon";
            this.txt_TenMon.Size = new System.Drawing.Size(222, 20);
            this.txt_TenMon.TabIndex = 6;
            this.txt_TenMon.TextChanged += new System.EventHandler(this.txt_TenMon_TextChanged);
            // 
            // dateTimePickerNgayDB
            // 
            this.dateTimePickerNgayDB.Location = new System.Drawing.Point(100, 109);
            this.dateTimePickerNgayDB.Name = "dateTimePickerNgayDB";
            this.dateTimePickerNgayDB.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerNgayDB.TabIndex = 8;
            this.dateTimePickerNgayDB.ValueChanged += new System.EventHandler(this.dateTimePickerNgayDB_ValueChanged);
            // 
            // dateTimePickerDisfrom
            // 
            this.dateTimePickerDisfrom.Location = new System.Drawing.Point(460, 18);
            this.dateTimePickerDisfrom.Name = "dateTimePickerDisfrom";
            this.dateTimePickerDisfrom.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerDisfrom.TabIndex = 9;
            // 
            // dateTimePickerDisTo
            // 
            this.dateTimePickerDisTo.Location = new System.Drawing.Point(460, 51);
            this.dateTimePickerDisTo.Name = "dateTimePickerDisTo";
            this.dateTimePickerDisTo.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerDisTo.TabIndex = 10;
            // 
            // dateTimePickerNgayKT
            // 
            this.dateTimePickerNgayKT.Location = new System.Drawing.Point(100, 137);
            this.dateTimePickerNgayKT.Name = "dateTimePickerNgayKT";
            this.dateTimePickerNgayKT.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerNgayKT.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxSTC);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.dateTimePickerNgayKT);
            this.groupBox1.Controls.Add(this.dateTimePickerDisfrom);
            this.groupBox1.Controls.Add(this.dateTimePickerDisTo);
            this.groupBox1.Controls.Add(this.dateTimePickerNgayDB);
            this.groupBox1.Controls.Add(this.txt_MaMon);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_TenMon);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(28, 321);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(666, 171);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // comboBoxSTC
            // 
            this.comboBoxSTC.FormattingEnabled = true;
            this.comboBoxSTC.Location = new System.Drawing.Point(100, 82);
            this.comboBoxSTC.Name = "comboBoxSTC";
            this.comboBoxSTC.Size = new System.Drawing.Size(60, 21);
            this.comboBoxSTC.TabIndex = 19;
            this.comboBoxSTC.SelectedIndexChanged += new System.EventHandler(this.comboBoxSTC_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(51, 163);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(639, 95);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(361, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 17);
            this.label8.TabIndex = 15;
            this.label8.Text = "Vô hiệu đến";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(361, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Vô hiệu từ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(4, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "ngày kết thúc";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "ngày bắt đầu";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(28, 514);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(117, 35);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "THÊM";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(151, 514);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(142, 35);
            this.btnUpdate.TabIndex = 15;
            this.btnUpdate.Text = "CẬP NHẬT";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Location = new System.Drawing.Point(454, 514);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(117, 35);
            this.btnRemove.TabIndex = 16;
            this.btnRemove.Text = "XÓA";
            this.btnRemove.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(577, 514);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(117, 35);
            this.btnReset.TabIndex = 17;
            this.btnReset.Text = "RESET";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(299, 514);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 35);
            this.button1.TabIndex = 18;
            this.button1.Text = "VÔ HIỆU";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // QLMH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 584);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridViewMH);
            this.Name = "QLMH";
            this.Text = "QLMH";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMH)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewMH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_MaMon;
        private System.Windows.Forms.TextBox txt_TenMon;
        private System.Windows.Forms.DateTimePicker dateTimePickerNgayDB;
        private System.Windows.Forms.DateTimePicker dateTimePickerDisfrom;
        private System.Windows.Forms.DateTimePicker dateTimePickerDisTo;
        private System.Windows.Forms.DateTimePicker dateTimePickerNgayKT;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBoxSTC;
        private System.Windows.Forms.Button button1;
    }
}