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
    public partial class UCXemXinNghiDaDuyet : UserControl
    {
        XinNghiDaDuyetBUS xinNghiDaDuyetBUS = new XinNghiDaDuyetBUS();
        public UCXemXinNghiDaDuyet()
        {
            InitializeComponent();
        }

        public void CapNhat(XinNghi xn)
        {
            xinNghiDaDuyetBUS.xn = xn;
        }

        private void UCXinNghi_Load(object sender, EventArgs e)
        {
            xinNghiDaDuyetBUS.FillConstrols(lb_HovaTen, lb_NgayNghi, lb_SoNgayNghi, lb_LyDo, lblTrangThai);
        }
    }
}
