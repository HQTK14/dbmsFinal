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
    public partial class DKDA : Form
    {
        public string mssv { get; set; }
        public DKDA(string mssv)
        {
            InitializeComponent();
            this.mssv = mssv;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBoxMON_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DKDA_Load(object sender, EventArgs e)
        {
            //comboBoxMon.DataSource = MONHOCBUS._LAYDSMONHOC(this.mssv);
            //comboBoxMon.DisplayMember = "TenMon";
            //comboBoxMon.ValueMember = "MaMon";
            comboBoxMON.DataSource = MONHOCBUS._LAYDSMONHOC(this.mssv);
            comboBoxMON.DisplayMember = "TENMON";
            comboBoxMON.ValueMember = "MaMon";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //DataRowView vrow = (DataRowView)comboBoxMON.SelectedItem;
            //DataRow row = vrow.Row;
            //string mamon = row["MaMon"].ToString();
            //dataGridViewDA.DataSource = DOANBUS.LocDSDA(mamon, this.mssv, -1);
            DataRowView vrow = (DataRowView)comboBoxMON.SelectedItem;
            DataRow row = vrow.Row;
            string mamon = row["MaMon"].ToString();
            int option = -1;
            if (radioBtnALL.Checked)
                option = 0;
            if (radioBtnGK.Checked)
                option = 2;
            else if (radioBtnCK.Checked)
                option = 3;
            else if (radioBtnPM.Checked)
                option = 1;
            dataGridViewDA.DataSource = DOANBUS.LocDSDA(mamon, this.mssv, option);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridViewDA.SelectedRows[0];
            int MaDA = Convert.ToInt32(row.Cells[0].Value.ToString());
            MessageBox.Show(string.Format("{0}", MaDA));
            comboBoxNHOM.DataSource = NHOMBUS.layDSNhom(MaDA);
            comboBoxNHOM.DisplayMember = "TENNHOM";
            comboBoxNHOM.ValueMember = "MaNhom";
        }

        private void comboBoxNHOM_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView vrow = (DataRowView)comboBoxNHOM.SelectedItem;
            DataRow row = vrow.Row;
            int manhom = Convert.ToInt32(row["MaNhom"].ToString());
            dataGridViewCTN.DataSource = CHITIETNHOMBUS.layCTNhom(manhom);
        }
    }
}
