using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCongTy
{
    internal class XemDAChuaHTQLBUS
    {
        public DuAn da;
        public Reload.Flp HamRL;
        QLCTContext db = new QLCTContext();
        public void FillControls(Label lbl_tenDA,Label lbl_TenPhong, Label lbl_NgayCL,Guna2ProgressBar prgTienDo, Label lblTienDo)
        {
            PhongBan gpb = db.PhongBans
                           .Where(pb => pb.MaPB == da.MaPB)
                           .First();

            lbl_tenDA.Text = da.TenDuAn;
            lbl_TenPhong.Text = gpb.TenPB;
            lbl_NgayCL.Text = "Thời hạn: Còn " + da.DeadLine.Value.Subtract(da.NgayBD.Value).Days.ToString() + " ngày.";
            var pcda = db.PhanCongs.Where(pc => pc.MaDA == da.MaDA).Select(pc => pc.TienDo);
            if (pcda.Count() == 0) prgTienDo.Value = 0;
            else prgTienDo.Value = (int)pcda.Average(td => td);
            lblTienDo.Text = prgTienDo.Value.ToString() + "%";
        }
        void OpenForm(Form fnew,UCTienDoDA uc)
        {
            uc.Enabled = false;
            fnew.ShowDialog();
            uc.Enabled = true;
            HamRL();
        }
        public void OpenFSuaDA(UCTienDoDA uc)
        {
            FSuaDA form = new FSuaDA();
            form.CapNhat(da);
            OpenForm(form, uc);
        }
        public void OpenFThongBao(UCTienDoDA uc)
        {
            FThongBao form = new FThongBao();
            form.CapNhat(da);
            OpenForm(form, uc);
        }
    }
}
