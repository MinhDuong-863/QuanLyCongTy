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
    public partial class FXemLuong : Form
    {
        XemLuongBUS xemLuongBUS = new XemLuongBUS();
        public FXemLuong()
        {
            InitializeComponent();
        }

        public void CapNhat(NhanVien nv, DateTime date)
        {
            xemLuongBUS.nv = nv;
        }

        private void FXemLuong_Load(object sender, EventArgs e)
        {
            xemLuongBUS.FillControls(lblChucVu, lblMucLuong, lblThuong, lblNgayDiLam, lblTreSom, lblTongLuong, lblThang);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            xemLuongBUS.NextMonth(lblChucVu, lblMucLuong, lblThuong, lblNgayDiLam, lblTreSom, lblTongLuong, lblThang);
        }

        private void btnPast_Click(object sender, EventArgs e)
        {
            xemLuongBUS.PreMonth(lblChucVu, lblMucLuong, lblThuong, lblNgayDiLam, lblTreSom, lblTongLuong, lblThang);
        }
    }
}
