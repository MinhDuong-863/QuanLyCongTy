using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCongTy
{
    internal class XinNghiDaDuyetBUS
    {
        public XinNghi xn;
        QLCTContext db = new QLCTContext();
        public void FillConstrols( Label HoTen, Label NgayNghi, Label SoNN, Label LyDo, Label TT )
        {
            NhanVien gnv = db.NhanViens
                            .Where(nv => nv.MaNV == xn.MaNV)
                            .First();

            HoTen.Text = gnv.HoTenNV;
            NgayNghi.Text = xn.NgayNghi.ToShortDateString();
            SoNN.Text = xn.SoNgayNghi.ToString();
            LyDo.Text = xn.LyDo.ToString();

            if (xn.HeSoDuyet == 1)
            {
                TT.Text = "Chấp nhận";
                TT.ForeColor = ColorTranslator.FromHtml("#128C7E");
            }
            else if (xn.HeSoDuyet == 0)
            {
                TT.Text = "Không chấp nhận";
                TT.ForeColor = ColorTranslator.FromHtml("#F44336");
            }
        }
    }
}
