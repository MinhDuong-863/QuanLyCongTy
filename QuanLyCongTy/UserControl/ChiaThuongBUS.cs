using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCongTy
{
    internal class ChiaThuongBUS
    {
        public DuAn da;
        QLCTContext db = new QLCTContext();

        public void FillCaNhan(FlowLayoutPanel flp, Label TongTien)
        {
            da = db.DuAns.Where(da1 => da1.MaDA == da.MaDA).First();
            flp.Controls.Clear();
            double TienThuong = da.Thuong.Value;
            List<PhanCong> list = da.PhanCongs.ToList();
            foreach (PhanCong pc in list)
            {
                UCThuongCaNhan uc = new UCThuongCaNhan();
                uc.CapNhat(pc);
                flp.Controls.Add(uc);
                TienThuong -= (double)pc.TienThuong;
            }
            TongTien.Text = TienThuong.ToString();
        }

        public void XacNhan(FlowLayoutPanel flp)
        {
            foreach (Control ctr in flp.Controls)
            {
                if (ctr is UCThuongCaNhan)
                {
                    UCThuongCaNhan ucThuongCaNhan = (UCThuongCaNhan)ctr;
                    ucThuongCaNhan.Luu();
                }
            }
        }
    }
}
