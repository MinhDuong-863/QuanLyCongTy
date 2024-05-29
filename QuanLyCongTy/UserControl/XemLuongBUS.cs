using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCongTy
{
    internal class XemLuongBUS
    {
        public NhanVien nv;
        //public DateTime date;
        DateTime datecal = DateTime.Today;

        public void FillControls(Label lblChucVu, Label lblMucLuong, Label lblThuong, Label lblNgayDiLam, Label lblTreSom, Label lblTongLuong, Label lblThang)
        {
            lblThang.Text = "Tháng " + datecal.Month.ToString() + " Năm " + datecal.Year.ToString();
            int MucLuong = nv.MucLuong.MucLuong1;

            int? Thuong = nv.PhanCongs
                            .Where(pc => pc.DuAn.DeadLine.Value.Month == datecal.Month && pc.DuAn.DeadLine.Value.Year == datecal.Year)
                            .Sum(pc => pc.TienThuong);
            if (Thuong is null) Thuong = 0;

            int NgayDiLam = nv.Checkouts
                                .Where(co => co.NgayCheckout.Month == datecal.Month && co.NgayCheckout.Year == datecal.Year)
                                .Count();
            int NgayViPhamCI = nv.Checkins
                                .Where(ci => ci.GioCheckin < TimeSpan.Parse("08:00:00") && ci.NgayCheckin.Month == datecal.Month && ci.NgayCheckin.Year == datecal.Year)
                                .Count();
            int NgayViPhamCO = nv.Checkouts
                                .Where(co => co.GioCheckout < TimeSpan.Parse("08:00:00") && co.NgayCheckout.Month == datecal.Month && co.NgayCheckout.Year == datecal.Year)
                                .Count();
            int NgayViPham = (NgayViPhamCI + NgayViPhamCO) / 2;

            bool ktluong = nv.Luongs
                            .Any(lg => lg.ThangNam.Month == datecal.Month && lg.ThangNam.Year == datecal.Year);
            if(ktluong)
            {
                Luong glg = nv.Luongs
                        .Where(lg => lg.ThangNam.Month == datecal.Month && lg.ThangNam.Year == datecal.Year)
                        .First();
                lblTongLuong.Text = glg.Luong1.ToString();
                lblTongLuong.ForeColor = Color.Black;
            }
            else
            {
                lblTongLuong.Text = "Chưa có lương";
                lblTongLuong.ForeColor = ColorTranslator.FromHtml("#F44336");
            }

            lblChucVu.Text = nv.MucLuong.ChucVu;
            lblMucLuong.Text = MucLuong.ToString();
            lblThuong.Text = Thuong.ToString();
            lblNgayDiLam.Text = NgayDiLam.ToString();
            lblTreSom.Text = NgayViPham.ToString();
        }
        public void PreMonth(Label lblChucVu, Label lblMucLuong, Label lblThuong, Label lblNgayDiLam, Label lblTreSom, Label lblTongLuong, Label lblThang)
        {
            datecal = datecal.AddMonths(-1);
            lblThang.Text = "Tháng " + datecal.Month.ToString() + " Năm " + datecal.Year.ToString();
            FillControls(lblChucVu, lblMucLuong, lblThuong, lblNgayDiLam, lblTreSom, lblTongLuong, lblThang);
        }
        public void NextMonth(Label lblChucVu, Label lblMucLuong, Label lblThuong, Label lblNgayDiLam, Label lblTreSom, Label lblTongLuong, Label lblThang)
        {
            datecal = datecal.AddMonths(1);
            lblThang.Text = "Tháng " + datecal.Month.ToString() + " Năm " + datecal.Year.ToString();
            FillControls(lblChucVu, lblMucLuong, lblThuong, lblNgayDiLam, lblTreSom, lblTongLuong, lblThang);
        }
    }
}
