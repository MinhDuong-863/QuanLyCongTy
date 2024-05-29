using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCongTy
{
    internal class XoaDABUS
    {
        QLCTContext db = new QLCTContext();
        public void XoaDA(DuAn da)
        {
            DuAn daXoa = db.DuAns.Where(da1 => da1.MaDA == da.MaDA).First();
            db.DuAns.Remove(daXoa);
            db.SaveChanges();
        }
    }
}
