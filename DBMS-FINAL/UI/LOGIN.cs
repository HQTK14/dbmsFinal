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
    public partial class LOGIN : Form
    {
        public LOGIN()
        {
            InitializeComponent();
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
            if(radioSV.Checked)
            {
                string mssv = txt_mssv.Text;
                string pwd = txt_pwd.Text;
                SINHVIENDTO svDTO = null;
                svDTO = SINHVIEN_BUS.laySinhVien(mssv, pwd);
                if (svDTO == null)
                {
                    MessageBox.Show("INVALID LOGIN");
                }
                else
                {
                    SINHVIEN rb = new SINHVIEN();
                    this.Hide();
                    rb.Show();
                }
                   
                

            }

        }

        private void LOGIN_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
