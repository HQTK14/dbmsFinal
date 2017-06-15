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
using DTO;
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
        private int laymaDoAn()
        {
            DataGridViewRow row = dataGridViewDA.SelectedRows[0];
            int MaDA = Convert.ToInt32(row.Cells[0].Value.ToString());
            return MaDA;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            //DataGridViewRow row = dataGridViewDA.SelectedRows[0];
            //int MaDA = Convert.ToInt32(row.Cells[0].Value.ToString());
            int MaDA = laymaDoAn();
            //MessageBox.Show(string.Format("{0}", MaDA));
            comboBoxNHOM.DataSource = NHOMBUS.layDSNhom(MaDA);
            comboBoxNHOM.DisplayMember = "TENNHOM";
            comboBoxNHOM.ValueMember = "MaNhom";
        }

        private int laymanhom()
        {
            DataRowView vrow = (DataRowView)comboBoxNHOM.SelectedItem;
            DataRow row = vrow.Row;
            int manhom = Convert.ToInt32(row["MaNhom"].ToString());
            return manhom;
        }
        private void comboBoxNHOM_SelectedIndexChanged(object sender, EventArgs e)
        {
            int manhom = laymanhom();
            dataGridViewCTN.DataSource = CHITIETNHOMBUS.layCTNhom(manhom);
            int madoan = laymaDoAn();
            string Truongnhom = NHOMBUS.Laytruongnhom(madoan, manhom);
            //for (int i = 0; i < dataGridView.RowCount; i++)
            //{
            //    string Value0 = dataGridViewCTN.Rows[i].Cells[0];
            //    string Value1 = dataGridViewCTN.Rows[i].Cells[1];
            //    string Value2 = dataGridViewCTN.Rows[i].Cells[2];
            //}
            foreach (DataGridViewRow row in dataGridViewCTN.Rows)
            {
                //if (row.Cells["MSSV"].Value.ToString() == Truongnhom)
                    if (row.Cells["MSSV"].Value.ToString() == "1311325")
                {
                    row.Cells["TruongNhom"].Value = true;
                    break;
                }
                    
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int madoan = laymaDoAn();
            int exceeded = NHOMBUS.maxnhom(madoan);
            //MessageBox.Show(string.Format("Mã đồ án là: {0}", madoan));
            if (exceeded == 1)
            {
                MessageBox.Show("Số lượng nhóm đã đạt giới hạn");
                return;
            }

            else if (exceeded == 2)
                MessageBox.Show("Cho phép tạo nhóm mới");
            else if (exceeded == -2)
                MessageBox.Show("ĐM catching");
            else if (exceeded == -1)
                MessageBox.Show("wthell");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int madoan = laymaDoAn();
            int manhom = laymanhom();
            int KQ = CHITIETNHOMBUS.maxMemberNhom(manhom, madoan);
            if(KQ == 2)
            {
                MessageBox.Show("Nhóm đã full thành viên");
                return;
            }
            else
            {
                //insert operation here
                MessageBox.Show("Join successfully");
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            int maDA = laymaDoAn();
            int maNhom = laymanhom();
            CHITIETNHOMDTO ctnh = new CHITIETNHOMDTO();
            ctnh.MSSV = "1311325";
            ctnh.MaNhom = maNhom;
            ctnh.MaDA = maDA;
            int KQ = CHITIETNHOMBUS.dangkiNhom(ctnh);
            if (KQ == 2)
            {
                MessageBox.Show("JOINED!");
            }
            else
            {
                MessageBox.Show("FAILED!");
            }
        }
    }
}
