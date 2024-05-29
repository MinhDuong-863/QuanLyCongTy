using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCongTy
{
    internal class NhanXetDATPBUS
    {
        public DuAn da;
        QLCTContext db = new QLCTContext();
        string[] list = { " ", "Tệ", "Tệ", "Chưa tốt", "Chưa Tốt", "Tốt", "Tốt", "Rất tốt", "Rất tốt", "Xuất sắc", "Xuất sắc" };
        public void FillControls(Label Ten, Guna2TextBox NhanXet, Guna2RatingStar ratingStar, Label XepLoai, Label TienThuong)
        {
            da = db.DuAns.Where(da1 => da1.MaDA == da.MaDA).First();
            Ten.Text = da.TenDuAn;
            NhanXet.Text = da.DanhGia;
            ratingStar.Value = da.ChamDiem.Value / 20;
            TienThuong.Text = da.Thuong.ToString();
            XepLoai.Text = list[(int)ratingStar.Value * 2];
        }
    }
}
