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
    public partial class FDangNhap : Form
    {
        DangNhapBUS dangNhapBUS = new DangNhapBUS();
        public FDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            dangNhapBUS.DangNhap(txtTaiKhoan, txtMatKhau, this);
        }

        private void ckbMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            dangNhapBUS.ckbMatKhau_CheckedChanged(ckbMatKhau, txtMatKhau);
        }
    }
}
