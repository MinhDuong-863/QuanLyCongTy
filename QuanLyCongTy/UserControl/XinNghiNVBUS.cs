using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Shapes;

namespace QuanLyCongTy
{
    internal class XinNghiNVBUS
    {
        FlowLayoutPanel flp;
        public NhanVien nv;
        QLCTContext db = new QLCTContext();
        Form currentFormChild;
        public void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Fill;
            flp.Controls.Add(childForm);
            flp.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        public void FillDonXN(Guna2Shapes shape, FlowLayoutPanel flp)
        {
            this.flp = flp;
            shape.FillColor = ColorTranslator.FromHtml("#0076D4");

            flp.Controls.Clear();
            FTaoXinNghi f = new FTaoXinNghi();
            f.CapNhat(nv);
            f.TopLevel = false;
            flp.Controls.Add(f);
            flp.Tag = f;
            f.BringToFront();
            f.Show();
        }

        public void FillTrangThai(Guna2Shapes shape, FlowLayoutPanel flp)
        {
            this.flp = flp;
            shape.FillColor = ColorTranslator.FromHtml("#128C7E");
            flp.Controls.Clear();
            List<XinNghi> list = db.XinNghis
                                 .Where(xn1 => xn1.HeSoDuyet >= 0 && xn1.MaNV == nv.MaNV)
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
