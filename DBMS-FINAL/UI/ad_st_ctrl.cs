using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;

namespace UI
{
    public partial class ad_st_ctrl : Form
    {
        public ad_st_ctrl()
        {
            InitializeComponent();
        }

        private void LayTC()
        {
            DataTable dt = new DataTable();
            dt = SINHVIEN_BUS.laytatcaSV();
            dataGridViewSV.DataSource = dt;
        }
        private void ad_st_ctrl_Load(object sender, EventArgs e)
        {
            LayTC();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Search_Click(object sender, EventArgs e)
        {
            DataTable dt1 = new DataTable();
            dt1 = SINHVIEN_BUS.laySV(textBox1.Text);
            MessageBox.Show(textBox1.Text);
            dataGridViewSV.DataSource = dt1;
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LayTC();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridViewSV.SelectedRows.Count == 0)
            {
                MessageBox.Show("Chưa chọn sinh viên");
                return;
            }
            DataGridViewRow r1 = dataGridViewSV.SelectedRows[0];
            string mssv = r1.Cells[0].Value.ToString().Trim();
            string tensv = r1.Cells[1].Value.ToString().Trim();
            CREATE_STUDENT cr_St = new CREATE_STUDENT(mssv, tensv);
            cr_St.Show();

        }
    }
}
