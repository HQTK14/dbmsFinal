using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;

namespace UI
{
    public partial class MAINFORM : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public string MF_StudentID { get; set; }
        public int role { get; set; }
        public string MF_Studentname { get; set; }
        public MAINFORM(string ID, string userName)
        {
            InitializeComponent();
            this.MF_StudentID = ID;
            
            this.MF_Studentname = userName;
            MessageBox.Show(this.MF_StudentID + this.MF_Studentname);
            labelControl1.Text = "Hi " + this.MF_Studentname + " !";
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void barButtonItem6_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void pictureEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void barHeaderItem1_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void barButtonItem17_ItemClick(object sender, ItemClickEventArgs e)
        {
            DANGNHAP lg = new DANGNHAP();
            //lg.MdiParent = this;
            lg.Show();
        }

        private void barButtonItem19_ItemClick(object sender, ItemClickEventArgs e)
        {
            //DANGNHAP lg = new DANGNHAP();
            ////lg.MdiParent = this;
            //lg.Show();
            //username = lg.studentName;
            //labelControl1.Text = "HELLO " + username;
            //labelControl1.Text = "HELLO " + lg.studentName;
        }

        private void barButtonItem9_ItemClick(object sender, ItemClickEventArgs e)
        {
            TKSV adstCtrl = new TKSV();
            adstCtrl.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void barButtonItem12_ItemClick(object sender, ItemClickEventArgs e)
        {
            //DANGNHAP dn = new DANGNHAP();
            //dn.Show();
            //this.ID = dn.studentID;
            //dn.Close();
            //if(this.ID != "")
            {
                //MessageBox.Show(this.ID);
                KQDKDA stRes = new KQDKDA("1311325");
                stRes.Show();
                MessageBox.Show(stRes.mssv);
            }
            
        }

        private void ribbon_Click(object sender, EventArgs e)
        {

        }

        private void barButtonItem20_ItemClick(object sender, ItemClickEventArgs e)
        {
            DANGNHAP dn = new DANGNHAP();
            Application.Exit();
           
        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }
    }
}