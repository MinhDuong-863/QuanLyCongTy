using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCongTy
{
    internal class XemPCNVBUS
    {
        public PhanCong pc;
        public Reload.Flp reLoadF;
        public void FillControl(Label lblTenCV, Label lblNgayBD, Label NgayCl, Guna2ProgressBar prgTienDo, Label lblTienDo)
        {
            lblTenCV.Text = pc.CongViec.TenCV;
            lblNgayBD.Text = pc.NgayBD.Value.ToString("dd/MM/yyyy");
            NgayCl.Text = "Thời hạn: Còn " + pc.DeadLine.Value.Subtract(pc.NgayBD.Value).Days.ToString() + " ngày.";
            prgTienDo.Value = pc.TienDo.Value;
            lblTienDo.Text = pc.TienDo.ToString() + "%";
        }
        public void OpenFCapNhatTienDo()
        {
            FCapNhatTienDo fCapNhatTienDo = new FCapNhatTienDo();
            fCapNhatTienDo.CapNhat(pc, reLoadF);
            fCapNhatTienDo.ShowDialog();
        }
    }
}
