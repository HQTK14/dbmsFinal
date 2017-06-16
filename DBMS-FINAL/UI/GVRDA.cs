using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;
using DTO;
using BUS;
namespace UI
{
    public partial class GVRDA : Form
    {
        public string maGV { get; set; }
        public GVRDA(string magv)
        {
            InitializeComponent();
            this.maGV = magv;
            comboBoxMON.DataSource = GIAOVIEN_DAO.layDSMONPT(this.maGV);
            comboBoxMON.DisplayMember = "TENMON";
            comboBoxMON.ValueMember = "MaMon";
        }
        private string laymamon()
        {
            DataRowView vrow = (DataRowView)comboBoxMON.SelectedItem;
            DataRow row = vrow.Row;
            string manhom = Convert.ToString(row["MaMon"].ToString());
            return manhom;
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string mamon = laymamon();
            dataGridViewDA.DataSource = GIAOVIEN_BUS.layDanhSachDoAnPhuTrach_Mon(maGV, mamon);
        }
    }
}
