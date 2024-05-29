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
    public partial class FQuanLy : Form
    {
        QLCTContext db = new QLCTContext();
        QuanLyBUS quanLyBUS = new QuanLyBUS();
        public FQuanLy(string ma)
        {
            InitializeComponent();
            quanLyBUS.nv = db.NhanViens.Where(nv1 => nv1.MaNV == ma).First();
            quanLyBUS.AddPnl(pnlNoiDung);
        }

        private void FQuanLy2_Load(object sender, EventArgs e)
        {
            lblTitle.Text = "Thông tin cá nhân";
            quanLyBUS.Load(lblName);
        }

        private void btnCaNhan_CheckedChanged(object sender, EventArgs e)
        {
            lblTitle.Text = "Thông tin cá nhân";
            quanLyBUS.OpenFThongTin(imgSlide, btnCaNhan);
        }

        private void btnCheckin_CheckedChanged(object sender, EventArgs e)
        {
            lblTitle.Text = btnCheckin.Text;
            quanLyBUS.OpenFCheckIO(imgSlide, btnCheckin);
        }

        private void btnDuAn_CheckedChanged(object sender, EventArgs e)
        {
            lblTitle.Text = btnDuAn.Text;
            quanLyBUS.OpenFDuAn(imgSlide, btnDuAn);
        }

        private void btnXinNghi_CheckedChanged(object sender, EventArgs e)
        {
            lblTitle.Text = btnXinNghi.Text;
            quanLyBUS.OpenFXinNghi(imgSlide, btnXinNghi);
        }

        private void lblThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnXemLuong_CheckedChanged(object sender, EventArgs e)
        {
            lblTitle.Text = btnXemLuong.Text;
            quanLyBUS.OpenFLuong(imgSlide, btnXemLuong);
        }
    }
}
