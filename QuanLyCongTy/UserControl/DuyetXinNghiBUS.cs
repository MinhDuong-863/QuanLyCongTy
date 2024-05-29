using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static QuanLyCongTy.Reload;
using System.Windows.Shapes;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace QuanLyCongTy
{
    internal class DuyetXinNghiBUS
    {
        public NhanVien nv;
        QLCTContext db = new QLCTContext();
        public FlowLayoutPanel flp;
        public Guna2Shapes shape;

        public void XNChuaDuyet()
        {
            flp.Controls.Clear();
            shape.FillColor = ColorTranslator.FromHtml("#0076D4");

            List<XinNghi> list = db.XinNghis
                                 .Where(xn1 => xn1.HeSoDuyet == -1)
                                 .ToList();

            foreach (XinNghi xn in list)
            {
                UCXemXinNghiChuaDuyet uc = new UCXemXinNghiChuaDuyet();
                uc.CapNhat(xn, XNChuaDuyet);
                flp.Controls.Add(uc);
            }
        }

        public void XNDaDuyet()
        {
            flp.Controls.Clear();
            shape.FillColor = ColorTranslator.FromHtml("#128C7E");

            List<XinNghi> list = db.XinNghis
                                 .Where(xn1 => xn1.HeSoDuyet >= 0)
                                 .ToList();
            foreach (XinNghi xn in list)
            {
                UCXemXinNghiDaDuyet uc = new UCXemXinNghiDaDuyet();
                uc.CapNhat(xn);
                flp.Controls.Add(uc);
            }
        }
    }
}
