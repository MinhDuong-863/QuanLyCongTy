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
    public partial class FTruongPhong : Form
    {
        TruongPhongBUS truongPhongBUS = new TruongPhongBUS();
        QLCTContext db = new QLCTContext();
        public FTruongPhong(string ma)
        {
            InitializeComponent();
            truongPhongBUS.AddPnl(pnlNoiDung);
            truongPhongBUS.nv = db.NhanViens.Where(nv1 => nv1.MaNV == ma).First();
        }

        public void CapNhat(NhanVien nv)
        {
            truongPhongBUS.nv = nv;
        }

        private void FTruongPhong2_Load(object sender, EventArgs e)
        {
            lblTitle.Text = "Thông tin cá nhân";
            truongPhongBUS.Load(lblName);
        }

        private void lblThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCaNhan_CheckedChanged(object sender, EventArgs e)
        {
            lblTitle.Text = "Thông tin cá nhân";
            truongPhongBUS.OpenFThongTin(imgSlide,btnCaNhan);
        } 

        private void btnCheckinout_CheckedChanged(object sender, EventArgs e)
        {
            lblTitle.Text = btnCheckinout.Text;
            truongPhongBUS.OpenFCheckIO(imgSlide, btnCheckinout);
        }

        private void btnDuAn_CheckedChanged(object sender, EventArgs e)
        {
            lblTitle.Text = btnDuAn.Text;
            truongPhongBUS.OpenFXemDuAn(imgSlide, btnDuAn);
        }

        private void btnXinNghi_CheckedChanged(object sender, EventArgs e)
        {
            lblTitle.Text = btnXinNghi.Text;
            truongPhongBUS.OpenFXinNghi(imgSlide, btnXinNghi);
        }

        private void btnLich_CheckedChanged(object sender, EventArgs e)
        {
            lblTitle.Text = btnLich.Text;
            truongPhongBUS.OpenFLich(imgSlide, btnLich);
        }

        private void btnXemLuong_CheckedChanged(object sender, EventArgs e)
        {
            lblTitle.Text = btnXemLuong.Text;
            truongPhongBUS.OpenFLuong(imgSlide, btnXemLuong);
        }
    }
}
