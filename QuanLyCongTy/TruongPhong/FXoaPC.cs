using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static QuanLyCongTy.FXemDuAn;

namespace QuanLyCongTy
{
    public partial class FXoaPC : Form
    {
        XoaPCBUS xoaPCBUS = new XoaPCBUS();
        public FXoaPC()
        {
            InitializeComponent();
        }

        public void CapNhat(PhanCong pc, Reload.Flp reLoadF)
        {
            xoaPCBUS.pc = pc;
            xoaPCBUS.reLoadF = reLoadF;
        }

        private void btnCo_Click(object sender, EventArgs e)
        {
            xoaPCBUS.XoaPC();
            Close();
        }

        private void btnKhong_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
