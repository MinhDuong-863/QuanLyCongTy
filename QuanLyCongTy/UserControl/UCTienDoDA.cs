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
    public partial class UCTienDoDA : UserControl
    {
        XemDAChuaHTQLBUS xemDAChuaHTQLBUS = new XemDAChuaHTQLBUS();
        QLCTContext db = new QLCTContext();
        public UCTienDoDA()
        {
            InitializeComponent();
        }
        public void CapNhat(DuAn da, Reload.Flp HamRL)
        {
            xemDAChuaHTQLBUS.da = db.DuAns.Where(da1 => da1.MaDA == da.MaDA).First();
            xemDAChuaHTQLBUS.HamRL = HamRL;
        }
        private void UCTienDoDA_Load(object sender, EventArgs e)
        {
            xemDAChuaHTQLBUS.FillControls(lblTenDA, lblTenPhong, lblNgayConLai, prgTienDo, lblTienDo);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            xemDAChuaHTQLBUS.OpenFThongBao(this);
        }

        private void ptbBG_Click(object sender, EventArgs e)
        {
            xemDAChuaHTQLBUS.OpenFSuaDA(this);
        }
    }
}
