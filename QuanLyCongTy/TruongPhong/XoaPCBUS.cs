using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCongTy
{
    internal class XoaPCBUS
    {
        public PhanCong pc;
        public Reload.Flp reLoadF;
        QLCTContext db = new QLCTContext();
        public void XoaPC()
        {
            PhanCong pcXoa = db.PhanCongs.Where(pc1 => pc1.MaDA == pc.MaDA && pc1.MaCV == pc.MaCV).First();
            db.PhanCongs.Remove(pcXoa);
            db.SaveChanges();
            reLoadF();
        }
    }
}
