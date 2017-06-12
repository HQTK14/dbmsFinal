using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class SINHVIEN : Form
    {
        //List<Panel> listPanel = new List<Panel>();
        public SINHVIEN()
        {
            InitializeComponent();
        }

        private void SINHVIEN_Load(object sender, EventArgs e)
        {
            //listPanel.Add(panel3);
            //listPanel.Add(panel4);
            // TODO: This line of code loads data into the 'project_registrationDataSet1.SINHVIEN_MONHOC' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'project_registrationDataSet.SINHVIEN_MONHOC' table. You can move, or remove it, as needed.
           // this.sINHVIEN_MONHOCTableAdapter.Fill(this.project_registrationDataSet.SINHVIEN_MONHOC);

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            panel3.BringToFront();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            panel4.BringToFront();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {

        }
    }
}
