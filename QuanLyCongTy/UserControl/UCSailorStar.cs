using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCongTy
{
    public partial class UCSailorStar : UserControl
    {
        XemDADaHTQLBUS xemDADaHTQLBUS = new XemDADaHTQLBUS();
        QLCTContext db = new QLCTContext();
        public UCSailorStar()
        {
            InitializeComponent();
        }
        public void CapNhat(DuAn da, Reload.Flp HamRL)
        {
            xemDADaHTQLBUS.da = db.DuAns.Where(da1 => da1.MaDA == da.MaDA).First();
            xemDADaHTQLBUS.HamRL = HamRL;
        }
        private void UCSailorStar_Load(object sender, EventArgs e)
        {
            xemDADaHTQLBUS.FillControls(lbl_tenDA, lbl_TenPhong, prgTienDo, lblTienDo, RatingStar);
        }

        private void ptbBG_Click(object sender, EventArgs e)
        {
            xemDADaHTQLBUS.OpenFNhanXet(this);
        }
    }
}
