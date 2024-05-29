using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCongTy
{
    internal class XemXinNghiQLBUS
    {
        QLCTContext db = new QLCTContext();
        FlowLayoutPanel flpListXN;

        public void AddFlpXN(FlowLayoutPanel flpListXN)
        {
            this.flpListXN = flpListXN;
        }

        public void FillXinNghiDaDuyet()
        {
            flpListXN.Controls.Clear();

            List<XinNghi> list = db.XinNghis
                                 .Where(xn1 => xn1.HeSoDuyet > -1)
                                 .ToList();

            foreach (XinNghi xn in list)
            {
                UCXemXinNghiDaDuyet uc = new UCXemXinNghiDaDuyet();
                uc.CapNhat(xn);
                flpListXN.Controls.Add(uc);
            }
        }
    }
}
