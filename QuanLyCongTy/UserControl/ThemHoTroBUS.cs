using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCongTy
{
    internal class ThemHoTroBUS
    {
        public PhanCong pc;
        public Reload.Flp reLoadF;
        QLCTContext db = new QLCTContext();
        public void Fillgv(DataGridView gv)
        {
            gv.DataSource = db.NhanViens
                .Where(nv => nv.PhongBan.LoaiPhongBan.MaLPB == pc.DuAn.PhongBan.LoaiPhongBan.MaLPB && nv.MaNV != nv.PhongBan.MaTrPhong
                && nv.PhanCongs
                    .Where(pc1 => pc1.MaDA != pc.MaDA && pc1.MaCV != pc.MaCV)
                    .All(pc1 => pc1.DeadLine < pc.NgayBD || pc1.NgayBD > pc.DeadLine))
                .Select(nv => new { NV = nv, nv.HoTenNV, nv.PhongBan.TenPB })
                .ToList();
            gv.Columns[0].Visible = false;
        }
        public void AddListBox(DataGridView gv, ListBox lb)
        {
            NhanVien nv = (NhanVien)gv.CurrentRow.Cells[0].Value;
            foreach (NhanVien nvlb in lb.Items)
                if (nv.Equals(nvlb))
                    return;
            lb.Items.Add(nv);
            lb.DisplayMember = "HoTenNV";
        }
        public void ThemHoTro(ListBox lb)
        {
            foreach (object obj in lb.Items)
            {
                if (obj is NhanVien)
                {
                    NhanVien nv = (NhanVien)obj;
                    pc.NhanViens.Add(nv);
                }
            }
            db.SaveChanges();
            reLoadF();
        }
    }
}
