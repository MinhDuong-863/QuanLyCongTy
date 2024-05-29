using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCongTy
{
    internal class XemXinNghiChuaDuyetQLBUS
    {
        public XinNghi xn;
        public Reload.Flp HamRL;
        QLCTContext db = new QLCTContext();

        public void FillControls( Label lb_HovaTen, Label lb_NgayNghi, Label lb_SoNgayNghi, Label lb_LyDo)
        {
            NhanVien gnv = db.NhanViens
                          .Where(nv => nv.MaNV == xn.MaNV)
                          .First();
            lb_HovaTen.Text = gnv.HoTenNV;
            lb_NgayNghi.Text = xn.NgayNghi.ToShortDateString();
            lb_SoNgayNghi.Text = xn.SoNgayNghi.ToString();
            lb_LyDo.Text = xn.LyDo.ToString();
        }
        public void DuyetXN()
        {
            xn.HeSoDuyet = 1;
            db.XinNghis.AddOrUpdate(xn);
            db.SaveChanges();
            HamRL();
        }

        public void KhongDuyetXN()
        {
            xn.HeSoDuyet = 0;
            db.XinNghis.AddOrUpdate(xn);
            db.SaveChanges();
            HamRL();
        }
    }
}
