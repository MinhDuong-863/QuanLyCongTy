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
    public partial class FNhanVien : Form
    {
        NhanVienBUS nhanVienBUS = new NhanVienBUS();
        QLCTContext db = new QLCTContext();
        public FNhanVien(string ma)
        {
            InitializeComponent();
            nhanVienBUS.nv = db.NhanViens.Where(nv1 => nv1.MaNV == ma).First();
            nhanVienBUS.AddPnl(pnlNoiDung);
        }

        private void FNhanVien2_Load(object sender, EventArgs e)
        {
            lblTitle.Text = "Thông tin cá nhân";
            nhanVienBUS.Load(lblName);
        }

        private void btnCaNhan_CheckedChanged(object sender, EventArgs e)
        {
            lblTitle.Text = "Thông tin cá nhân";
            nhanVienBUS.OpenFThongTin(imgSlide, btnCaNhan);
        }

        private void btnCheckinout_CheckedChanged(object sender, EventArgs e)
        {
            lblTitle.Text = btnCheckinout.Text;
            nhanVienBUS.OpenFCheckIO(imgSlide, btnCheckinout);
        }

        private void btnPhanCong_CheckedChanged(object sender, EventArgs e)
        {
            lblTitle.Text = btnPhanCong.Text;
            nhanVienBUS.OpenFKPI(imgSlide, btnPhanCong);
        }

        private void btnXinNghi_CheckedChanged(object sender, EventArgs e)
        {
            lblTitle.Text = btnXinNghi.Text;
            nhanVienBUS.OpenFXinNghi(imgSlide, btnXinNghi);
        }

        private void lblThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnXemLuong_CheckedChanged(object sender, EventArgs e)
        {
            lblTitle.Text = btnXemLuong.Text;
            nhanVienBUS.OpenFLuong(imgSlide, btnXemLuong);
        }
    }
}
