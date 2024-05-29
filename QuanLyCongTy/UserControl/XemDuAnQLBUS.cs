using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCongTy
{
    internal class XemDuAnQLBUS
    {
        QLCTContext db = new QLCTContext();
        FlowLayoutPanel flpListDA;
        public void AddFlp(FlowLayoutPanel flpListDA)
        {
            this.flpListDA = flpListDA;
        }
        public void FillDuAnChuaHT()
        {
            flpListDA.Controls.Clear();
            List<DuAn> listDA = db.DuAns
                                .Where(da1 => da1.ChamDiem == -1)
                                .ToList();

            foreach (DuAn da in listDA)
            {
                UCTienDoDA uc = new UCTienDoDA();
                uc.CapNhat(da, FillDuAnChuaHT);
                flpListDA.Controls.Add(uc);
            }
        }
        public void FillDuAnDaHT()
        {
            flpListDA.Controls.Clear();
            List<DuAn> listDA = db.DuAns
                                .Where(da1 => da1.ChamDiem >= 0)
                                .ToList();
            foreach (DuAn da in listDA)
            {
                UCSailorStar uc = new UCSailorStar();
                uc.CapNhat(da, FillDuAnDaHT);
                flpListDA.Controls.Add(uc);
            }
        }
        public void OpenFThemDA(Form fthis)
        {
            FThemDA form = new FThemDA();
            fthis.Enabled = false;
            form.ShowDialog();
            fthis.Enabled = true;
            FillDuAnChuaHT();
        }
    }
}
