using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCongTy
{
    internal class LuongCNBUS
    {
        public NhanVien nv;
        public DateTime date;
        public void FillControl(Label lblTen, Label lblChucVu, Label lblMucLuong,
            Label lblThuong, Label lblNgayDiLam, Label lblTreSom, Label lblTongLuong)
        {
            int MucLuong = nv.MucLuong.MucLuong1;

            int? Thuong = nv.PhanCongs
                         .Where(pc => pc.DuAn.DeadLine.Value.Month == date.Month && pc.DuAn.DeadLine.Value.Year == date.Year)
                         .Sum(pc => pc.TienThuong);
            if (Thuong is null) Thuong = 0;

            int NgayDiLam = nv.Checkouts
                            .Where(co => co.MaNV == nv.MaNV && co.NgayCheckout.Month == date.Month && co.NgayCheckout.Year == date.Year)
                            .Count();
            int NgayViPhamCI = nv.Checkins
                             .Where(ci => ci.MaNV == nv.MaNV && ci.GioCheckin < TimeSpan.Parse("08:00:00") && ci.NgayCheckin.Month == date.Month && ci.NgayCheckin.Year == date.Year)
                             .Count();
            int NgayViPhamCO = nv.Checkouts
                             .Where(co => co.MaNV == nv.MaNV && co.GioCheckout < TimeSpan.Parse("08:00:00") && co.NgayCheckout.Month == date.Month && co.NgayCheckout.Year == date.Year)
                             .Count();
            int NgayViPham = (NgayViPhamCI + NgayViPhamCO) / 2; 

            lblTen.Text = nv.HoTenNV;
            lblChucVu.Text = nv.MucLuong.ChucVu;
            lblMucLuong.Text = MucLuong.ToString();
            lblThuong.Text = Thuong.ToString();
            lblNgayDiLam.Text = NgayDiLam.ToString();
            lblTreSom.Text = NgayViPham.ToString();
            lblTongLuong.Text = ((int)((MucLuong / 30) * (NgayDiLam - NgayViPham / 2) + Thuong)).ToString();
        }
        public Luong getLuong()
        {
            int MucLuong = nv.MucLuong.MucLuong1;

            int? Thuong = nv.PhanCongs
                         .Where(pc => pc.DuAn.DeadLine.Value.Month == date.Month && pc.DuAn.DeadLine.Value.Year == date.Year)
                         .Sum(pc => pc.TienThuong);
            if (Thuong is null) Thuong = 0;

            int NgayDiLam = nv.Checkouts
                            .Where(co => co.MaNV == nv.MaNV && co.NgayCheckout.Month == date.Month && co.NgayCheckout.Year == date.Year)
                            .Count();
            int NgayViPhamCI = nv.Checkins
                             .Where(ci => ci.MaNV == nv.MaNV && ci.GioCheckin < TimeSpan.Parse("08:00:00") && ci.NgayCheckin.Month == date.Month && ci.NgayCheckin.Year == date.Year)
                             .Count();
            int NgayViPhamCO = nv.Checkouts
                             .Where(co => co.MaNV == nv.MaNV && co.GioCheckout < TimeSpan.Parse("08:00:00") && co.NgayCheckout.Month == date.Month && co.NgayCheckout.Year == date.Year)
                             .Count();
            int NgayViPham = (NgayViPhamCI + NgayViPhamCO) / 2;
            int TongLuong = (int)((MucLuong / 30) * (NgayDiLam - NgayViPham / 2) + Thuong);

            return new Luong()
            {
                MaNV = nv.MaNV,
                ThangNam = date,
                Luong1 = TongLuong
            };
        }
    }
}
