using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCongTy
{
    partial class FCapNhatTienDo : Form
    {
        CapNhatTienDoBUS capNhatTienDoBUS = new CapNhatTienDoBUS();
        public FCapNhatTienDo()
        {
            InitializeComponent();
        }
        public void CapNhat(PhanCong pc, Reload.Flp reLoadF)
        {
            capNhatTienDoBUS.pc = pc;
            capNhatTienDoBUS.reLoadF = reLoadF;
        }

        private void FCapNhatTienDo_Load(object sender, EventArgs e)
        {
            capNhatTienDoBUS.FillControl(label1, label4, trackBar, label2, lblNgayCL);
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            capNhatTienDoBUS.CapNhatPC();
            Close();
        }

        private void guna2HScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            capNhatTienDoBUS.UpdateLbl(trackBar, label2);
        }

        private void trackBar_ValueChanged(object sender, EventArgs e)
        {
            capNhatTienDoBUS.UpdateLbl(trackBar, label2);
        }
    }
}

