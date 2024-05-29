using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCongTy
{
    internal class KPIBUS
    {
        public NhanVien nv;
        FlowLayoutPanel flp;
        QLCTContext db = new QLCTContext();
        public void AddFlp(FlowLayoutPanel flp)
        {
            this.flp = flp;
        }
        public void FillflpChuaHT()
        {
            flp.Controls.Clear();
            db = new QLCTContext();
            List<PhanCong> list = db.PhanCongs.Where(pc => pc.MaNV == nv.MaNV && pc.TienDo < 100).ToList();
            foreach (PhanCong pc in list)
            {
                UCXemPhanCong_NhanVien uc = new UCXemPhanCong_NhanVien();
                uc.CapNhat(pc, FillflpChuaHT);
                flp.Controls.Add(uc);
            }
        }

        public void FillFlpDaHT()
        {
            flp.Controls.Clear();
            db = new QLCTContext();
            List<PhanCong> list = db.PhanCongs.Where(pc => pc.MaNV == nv.MaNV && pc.TienDo == 100).ToList();
            foreach (PhanCong pc in list)
            {
                UCPhanCongDaHT uc = new UCPhanCongDaHT();
                uc.CapNhat(pc);
                flp.Controls.Add(uc);
            }
        }
    }
}
