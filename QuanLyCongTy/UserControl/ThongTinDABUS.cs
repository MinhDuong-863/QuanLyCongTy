using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static QuanLyCongTy.FXemDuAn;

namespace QuanLyCongTy
{
    internal class ThongTinDABUS
    {
        public DuAn da;
        public Reload.Flp rl;
        FlowLayoutPanel flp;
        QLCTContext db = new QLCTContext();

        public void FillControl(Label lblTen, Label lblDiaDiem, Label lblNgayBD, Label lblThoiHan, Label lblMoTa, FlowLayoutPanel flp)
        {
            lblTen.Text = da.TenDuAn;
            lblDiaDiem.Text = da.DiaDiem;
            lblNgayBD.Text = da.NgayBD.Value.ToShortDateString();
            lblThoiHan.Text = da.DeadLine.Value.ToShortDateString();
            lblMoTa.Text = da.MoTa;
            this.flp = flp;
            Fillflp();

        }
        public void Fillflp()
        {
            flp.Controls.Clear();
            db = new QLCTContext();
            List<PhanCong> listPCChuaHTTheoDA = db.DuAns.Where(da1 => da1.MaDA == da.MaDA).First().PhanCongs.OrderBy(pc => pc.TienDo).ToList();
            foreach (PhanCong pc in listPCChuaHTTheoDA)
            {
                UCXemPhanCong uc = new UCXemPhanCong();
                uc.CapNhat(pc, Fillflp);
                uc.Margin = new Padding(10, 10, 0, 0);
                flp.Controls.Add(uc);
            }
        }
        public void OpenFThem()
        {
            FPhanCong fPhanCong = new FPhanCong();
            fPhanCong.CapNhat(da, Fillflp);
            fPhanCong.ShowDialog();
        }
        public void OpenFChartDA()
        {
            flp.Controls.Clear();
            FChartDA fChartDA = new FChartDA();
            fChartDA.CapNhat(da);
            fChartDA.TopLevel = false;
            flp.Controls.Add(fChartDA);
            flp.Tag = fChartDA;
            fChartDA.BringToFront();
            fChartDA.Show();
        }
        public void Finished()
        {
            bool kt = da.PhanCongs.Count > 0 && da.PhanCongs.All(pc => pc.TienDo == 100);
            if (kt)
            {
                da.ChamDiem = 0;
                db.DuAns.AddOrUpdate(da);
                db.SaveChanges();
            }
            else MessageBox.Show("Có task chưa hoàn thành!!!");
        }
    }
}
