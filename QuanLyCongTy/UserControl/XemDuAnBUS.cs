using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCongTy
{
    internal class XemDuAnBUS
    {
        public PhongBan pb;
        FlowLayoutPanel flpListDA;
        QLCTContext db = new QLCTContext();
        public void AddFlp(FlowLayoutPanel flpListDA)
        {
            this.flpListDA = flpListDA;
        }
        public void FillDuAnChuaHT()
        {
            db = new QLCTContext();
            flpListDA.Controls.Clear();
            List<DuAn> listDA = pb.DuAns.Where(da => da.ChamDiem < 0).ToList();
            foreach (DuAn da in listDA)
            {
                UCXemDAChuaHT uc = new UCXemDAChuaHT();
                uc.CapNhat(da, FillDuAnChuaHT);
                flpListDA.Controls.Add(uc);
            }
        }

        public void FillDuAnDaHT()
        {
            db = new QLCTContext();
            flpListDA.Controls.Clear();
            List<DuAn> listDA = pb.DuAns.Where(da => da.ChamDiem >= 0).ToList();
            foreach (DuAn da in listDA)
            {
                UCXemDADaHT uc = new UCXemDADaHT();
                uc.CapNhat(da);
                flpListDA.Controls.Add(uc);
            }
        }
    }
}
