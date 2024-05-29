using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCongTy
{
    internal class CapNhatTienDoBUS
    {
        public PhanCong pc;
        public Reload.Flp reLoadF;
        QLCTContext db = new QLCTContext();
        public void FillControl(Label lblCV, Label lblMoTa, Guna2TrackBar trackBar, Label lblTienDo, Label lblNgayCL)
        {
            lblCV.Text = pc.CongViec.TenCV;
            lblMoTa.Text = pc.MoTa;
            trackBar.Value = pc.TienDo.Value;
            lblTienDo.Text = pc.TienDo.ToString() + "%";
            int NgayCL = pc.DeadLine.Value.Subtract(pc.NgayBD.Value).Days;
            if (NgayCL <= 10)
            {
                lblNgayCL.ForeColor = ColorTranslator.FromHtml("#F44336");
            }
            lblNgayCL.Text = NgayCL.ToString() + " ngày.";
        }
        public void UpdateLbl(Guna2TrackBar trackBar, Label lblTienDo)
        {
            lblTienDo.Text = trackBar.Value + "%";
            pc.TienDo = trackBar.Value;
        }
        public void CapNhatPC()
        {
            db.PhanCongs.AddOrUpdate(pc);
            db.SaveChanges();
            reLoadF();
        }
    }
}
