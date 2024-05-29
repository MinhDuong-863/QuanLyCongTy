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
    public partial class UCTienDoCaNhan : UserControl
    {
        XemTienDoPCBUS xemTienDoPCBUS = new XemTienDoPCBUS();
        public UCTienDoCaNhan()
        {
            InitializeComponent();
        }

        public void CapNhat(PhanCong pc)
        {
            xemTienDoPCBUS.pc = pc;
        }

        private void UCTienDoCaNhan_Load(object sender, EventArgs e)
        {
            xemTienDoPCBUS.FillControl(lblTen, prgTD, lblTD);
        }
    }
}
