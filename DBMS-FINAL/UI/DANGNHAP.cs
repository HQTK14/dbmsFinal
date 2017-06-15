using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using DAO;
using BUS;

namespace UI
{
    public partial class DANGNHAP : Form
    {
        public string DN_StudentName { get; set; }
        public string DN_StudentID { get; set; }
        public int attempt { get; set; }
        public DANGNHAP()
        {
            InitializeComponent();
            this.attempt = 0;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(this.attempt==3)
            {
                MessageBox.Show("too many login failures So the Program terminated!");
                Application.Exit();
            }
                if(radioSV.Checked)
            {
                string mssv = txt_mssv.Text;
                string pwd = txt_pwd.Text;
                SINHVIENDTO svDTO = null;
                svDTO = SINHVIEN_BUS.laySinhVien(mssv, pwd);
                if (svDTO == null)
                {
                    this.attempt++;
                    MessageBox.Show("INVALID LOGIN");
                    return;
                }
                else
                {
                    //SINHVIEN rb = new SINHVIEN();
                    //this.Hide();
                    //rb.Show();
           
                    this.DN_StudentID = txt_mssv.Text;
                    this.DN_StudentName = svDTO.TenSV;
                    MessageBox.Show("Đăng nhập thành công "+this.DN_StudentID + " " + this.DN_StudentName);

                    MAINFORM mfr = new MAINFORM(this.DN_StudentID, this.DN_StudentName);
                    this.Hide();
                    mfr.Show();
                    
                }

                

            }
            else if (radioGV.Checked)
            {
                //lacking
            }
                else if (radioQTV.Checked)
            {
                //lacking
            }
                else
            {
                MessageBox.Show("Ban chua chon loai nguoi dung!");
                return;
            }

        }

        private void LOGIN_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
