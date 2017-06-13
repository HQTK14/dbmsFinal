using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUS
{
    public partial class CREATE_STUDENT : Form
    {
        public string mssv { get; set; }
        public string tensv { get; set; }
        public CREATE_STUDENT(string mssv, string tensv)
        {
            InitializeComponent();
            this.mssv = mssv;
            this.tensv = tensv;
        }

        private void CREATE_STUDENT_Load(object sender, EventArgs e)
        {
            label4.Text = this.mssv;
            labelHT.Text = this.tensv;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
