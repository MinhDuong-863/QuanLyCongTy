using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Shapes;

namespace QuanLyCongTy
{
    internal class HoanThanhDuAnBUS
    {
        Guna2Panel pnl;
        public DuAn da;
        Form currentFormChild;
        public void AddPnl(Guna2Panel pnl)
        {
            this.pnl = pnl;
        }
        public void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Fill;
            pnl.Controls.Add(childForm);
            pnl.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        public void FillChiaThuong(Guna2Shapes shape)
        {
            shape.FillColor = ColorTranslator.FromHtml("#0076D4");
            FChiaThuong fchiathuong = new FChiaThuong();
            fchiathuong.CapNhat(da);
            OpenChildForm(fchiathuong);
        }

        public void FillNhanXet(Guna2Shapes shape)
        {
            shape.FillColor = ColorTranslator.FromHtml("#6F65BD");
            FNhanXetDA_TruongPhong fnhanxetDATP = new FNhanXetDA_TruongPhong();
            fnhanxetDATP.CapNhat(da);
            OpenChildForm(fnhanxetDATP);
        }
    }
}
