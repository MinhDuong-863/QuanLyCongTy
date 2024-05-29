using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCongTy
{
    internal class XemDAChuaHTTPBUS
    {
        public DuAn da;
        public Reload.Flp rl;
        public void FillControl(Label lblTenDA, Label lblTenPhong, Guna2ProgressBar prgTienDo, Label lblNgayCL, Label lblTienDo)
        {
            lblTenDA.Text = da.TenDuAn;
            lblTenPhong.Text = da.PhongBan.TenPB;
            if (da.PhanCongs.Count > 0)
            {
                prgTienDo.Value = (int)da.PhanCongs.Average(pc => pc.TienDo);
            }
            else
            {
                prgTienDo.Value = 0;
            }
            lblNgayCL.Text = "Thời hạn: Còn " + da.DeadLine.Value.Subtract(da.NgayBD.Value).Days.ToString() + " ngày.";
            lblTienDo.Text = prgTienDo.Value.ToString() + "%";
        }

        public void OpenFThongTin()
        {
            FThongTinDA form = new FThongTinDA();
            form.CapNhat(da, rl);
            form.ShowDialog();
        }
    }
}
