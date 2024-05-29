using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCongTy
{
    internal class ThongTinBUS
    {
        public NhanVien nv;
        QLCTContext db = new QLCTContext();
        public void FillControls(Label lbl1, Label lbl2, Label lbl3, Label lbl4, Label lbl5, Label lbl6, Label lbl7,
            Label lbl8, Label lbl9, Label lbl10)
        {
            NhanVien gnv = db.NhanViens
                           .Where(nv1 => nv1.MaNV == nv.MaNV)
                           .First();
            lbl1.Text = gnv.MaNV;
            lbl2.Text = gnv.HoTenNV;
            lbl3.Text = gnv.DiaChi;
            lbl4.Text = gnv.Sdt;
            lbl5.Text = gnv.NgaySinh.Value.ToString("dd/MM/yyyy");
            lbl6.Text = gnv.Phai;
            lbl7.Text = gnv.Cccd;
            lbl8.Text = gnv.Email;
            lbl9.Text = gnv.MaPB;
            lbl10.Text = gnv.PhongBan.TenPB;
        }
    }
}
