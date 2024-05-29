using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCongTy
{
    public partial class UCXemDAChuaHT : UserControl
    {
        XemDAChuaHTTPBUS xemDAChuaHTTPBUS = new XemDAChuaHTTPBUS();
        QLCTContext db = new QLCTContext();
        public UCXemDAChuaHT()
        {
            InitializeComponent();
        }

        public void CapNhat(DuAn da, Reload.Flp rl)
        {
            xemDAChuaHTTPBUS.da = db.DuAns.Where(da1 => da1.MaDA == da.MaDA).First();
            xemDAChuaHTTPBUS.rl = rl;
        }

        private void UCTienDoDA_Load(object sender, EventArgs e)
        {
            xemDAChuaHTTPBUS.FillControl(lbl_tenDA, lbl_TenPhong, prgTienDo, lbl_NgayCL, lblTienDo);
        }

        private void ptbBG_Click(object sender, EventArgs e)
        {
            xemDAChuaHTTPBUS.OpenFThongTin();
        }
    }
}
