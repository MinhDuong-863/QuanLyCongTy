using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCongTy
{ 
    internal class ThuongCaNhanBUS
    {
        public PhanCong pc;
        QLCTContext db = new QLCTContext();
        public void FillControls(Label Ten, Label CongViec, Guna2TextBox Thuong, Guna2RatingStar ratingStar)
        {
            Ten.Text = pc.NhanVien.HoTenNV;
            CongViec.Text = pc.CongViec.TenCV;
            Thuong.Text = pc.TienThuong.ToString();
            ratingStar.Value = (float)pc.ChamDiem / 20;
        }

        public void XacNhan(Guna2TextBox Thuong, Guna2RatingStar ratingStar)
        {
            PhanCong pcSua = db.PhanCongs.Where(pc1 => pc1.MaCV == pc.MaCV && pc1.MaDA == pc.MaDA).First();
            pcSua.TienThuong = int.Parse(Thuong.Text);
            pcSua.ChamDiem = (int)ratingStar.Value * 20;
            db.PhanCongs.AddOrUpdate(pcSua);
            db.SaveChanges();
        }
    }
}
