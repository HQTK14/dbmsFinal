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
    public partial class KQDKDA : Form
    {
        public string mssv { get; set; }
        public KQDKDA(string mssv)
        {
            InitializeComponent();
            this.mssv = mssv;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView vrow = (DataRowView)comboBoxMon.SelectedItem;
            DataRow row = vrow.Row;
            label5.Text = row["TenMon"].ToString();
            label6.Text = row["SoTinChi"].ToString();
            label7.Text = row["NgayDB"].ToString();
            label8.Text = row["NgayKT"].ToString();
        }

        private void STUDENT_REGISTER_RESULT_Load(object sender, EventArgs e)
        {
            comboBoxMon.DataSource = MONHOCBUS._LAYDSMONHOC(this.mssv);
            comboBoxMon.DisplayMember = "TenMon";
            comboBoxMon.ValueMember = "MaMon";
        }

        private void dataGridViewDA_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataRowView vrow = (DataRowView)comboBoxMon.SelectedItem;
            DataRow row = vrow.Row;
            string mamon = row["MaMon"].ToString();
            int option=-1;
            if (radioBtnALL.Checked)
                option = 0;
            if (radioBntGK.Checked)
                option = 2;
            else if (radioBtnCK.Checked)
                option = 3;
            else if (radioBtnPM.Checked)
                option = 1;
            dataGridViewDA.DataSource = DOANBUS.LocDSDA(mamon, this.mssv, option);
        }
    }
}
