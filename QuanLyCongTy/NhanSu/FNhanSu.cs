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
    public partial class FNhanSu : Form
    {
        QLCTContext db = new QLCTContext();
        NhanSuBUS nhanSuBUS = new NhanSuBUS();
        public FNhanSu(string ma)
        {
            InitializeComponent();
            nhanSuBUS.nv = db.NhanViens.Where(nv1 => nv1.MaNV == ma).First();
            nhanSuBUS.AddPnl(pnlNoiDung);
        }

        private void FNhanSu_Load(object sender, EventArgs e)
        {
            lblTitle.Text = "Thông tin cá nhân";
            nhanSuBUS.Load(lblName);
        }

        private void btnCaNhan_CheckedChanged(object sender, EventArgs e)
        {
            lblTitle.Text = "Thông tin cá nhân";
            nhanSuBUS.OpenFThongTin(imgSlide, btnCaNhan);
        }

        private void btnCheckinout_CheckedChanged(object sender, EventArgs e)
        {
            lblTitle.Text = btnCheckin.Text;
            nhanSuBUS.OpenFCheckIO(imgSlide, btnCheckin);
        }

        private void btnTinhLuong_CheckedChanged(object sender, EventArgs e)
        {
            lblTitle.Text = btnTinhLuong.Text;
            nhanSuBUS.OpenFTinhLuong(imgSlide, btnTinhLuong);
        }

        private void btnDuyetXinNghi_CheckedChanged(object sender, EventArgs e)
        {
            lblTitle.Text = btnDuyetXinNghi.Text;
            nhanSuBUS.OpenFDuyetXinNghi(imgSlide, btnDuyetXinNghi);
        }
        private void lblThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
