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
using DAO;
using DTO;
namespace UI
{
    public partial class QLMH : Form
    {
        private List<int> STC;
        private void taoComboBoxSTC()
        {
            for (int i = 1; i <= 6; i++)
                STC.Add(i);
        }
        private void ConsistencyValue(string val)
        {
            int index = comboBoxSTC.FindString(val);
            comboBoxSTC.SelectedIndex = index;
        }
        //private string normalizeStringDateFormat(string src)
        //{
        //    return src.Replace('/', '-');
        //}
        private DateTime RetrieveDateFromStringDate(string dtsrc)
        {
            DateTime dt = DateTime.Parse(dtsrc);
            return dt;
        }
        private void SetupModeView()
        {
            txt_MaMon.ReadOnly = true;
            txt_TenMon.ReadOnly = true;
            comboBoxSTC.Enabled = false;
            dateTimePickerNgayDB.Enabled = false;
            dateTimePickerNgayKT.Enabled = false;
            dateTimePickerDisfrom.Enabled = false;
            dateTimePickerDisTo.Enabled = false;
        }
        private void SetupModeEditable()
        {
            txt_MaMon.ReadOnly = false;
            txt_TenMon.ReadOnly = false;
            comboBoxSTC.Enabled = true;
            dateTimePickerNgayDB.Enabled = true;
            dateTimePickerNgayKT.Enabled = true;
            dateTimePickerDisfrom.Enabled = true;
            dateTimePickerDisTo.Enabled = true;
            clearOldData();
        }
        private void clearOldData()
        {
            txt_MaMon.Clear();
            txt_TenMon.Clear();
            comboBoxSTC.ResetText();
            dateTimePickerNgayDB.Format = DateTimePickerFormat.Custom;
            dateTimePickerNgayDB.CustomFormat = " ";
            dateTimePickerNgayKT.Format = DateTimePickerFormat.Custom;
            dateTimePickerNgayKT.CustomFormat = " ";
            dateTimePickerDisfrom.Format = DateTimePickerFormat.Custom;
            dateTimePickerDisfrom.CustomFormat = " ";
            dateTimePickerDisTo.Format = DateTimePickerFormat.Custom;
            dateTimePickerDisTo.CustomFormat = " ";
        }
        public QLMH()
        {
            InitializeComponent();
            STC = new List<int>();
            taoComboBoxSTC();
            comboBoxSTC.DataSource = STC;
            dataGridViewMH.DataSource = MONHOCBUS.GET_ALL_SUBJECT();
        }

        private void dataGridViewMH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewMH_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (dataGridViewMH.SelectedRows.Count == 1)
            {
                dateTimePickerNgayDB.Format = DateTimePickerFormat.Custom;
                dateTimePickerNgayDB.CustomFormat = "dd-MMM-yyyy";

                dateTimePickerNgayKT.Format = DateTimePickerFormat.Custom;
                dateTimePickerNgayKT.CustomFormat = "dd-MMM-yyyy";

                dateTimePickerDisfrom.Format = DateTimePickerFormat.Custom;
                dateTimePickerDisfrom.CustomFormat = "dd-MMM-yyyy";

                dateTimePickerDisTo.Format = DateTimePickerFormat.Custom;
                dateTimePickerDisTo.CustomFormat = "dd-MMM-yyyy";

                DataGridViewRow r1 = dataGridViewMH.SelectedRows[0];

                txt_MaMon.Text = r1.Cells["MaMon"].Value.ToString().Trim();
                txt_TenMon.Text = r1.Cells[1].Value.ToString().Trim();
                dateTimePickerNgayDB.Value = RetrieveDateFromStringDate(r1.Cells["NgayDB"].Value.ToString().Trim());
                dateTimePickerNgayKT.Value = RetrieveDateFromStringDate(r1.Cells["NgayKT"].Value.ToString().Trim());
                string dis_start = r1.Cells["DisableFrom"].Value.ToString().Trim();
                if(dis_start == "")
                {
                    dateTimePickerDisfrom.Format = DateTimePickerFormat.Custom;
                    dateTimePickerDisfrom.CustomFormat = " ";
                }
                else
                {
                    dateTimePickerDisfrom.Value = RetrieveDateFromStringDate("dis_start");
                }
                string dis_last = r1.Cells["DisableTo"].Value.ToString().Trim();
                if (dis_last == "")
                {
                    dateTimePickerDisTo.Format = DateTimePickerFormat.Custom;
                    dateTimePickerDisTo.CustomFormat = " ";
                }
                else
                {
                    dateTimePickerDisfrom.Value = RetrieveDateFromStringDate("dis_last");
                }
                ConsistencyValue(r1.Cells["SoTinChi"].Value.ToString().Trim());

                SetupModeView();

            }
           
        }

        private void txt_TenMon_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxSTC_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //FIRST OF ALL
            SetupModeEditable();
            //THEN
           // bool RES = MONHOCBUS.
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //FIRST OF ALL
            SetupModeEditable();
            //THEN
        }

        private void dateTimePickerNgayDB_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
