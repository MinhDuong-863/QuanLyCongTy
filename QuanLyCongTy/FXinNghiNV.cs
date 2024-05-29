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
    public partial class FXinNghiNV : Form
    {
        XinNghiNVBUS xinNghiNVBUS = new XinNghiNVBUS();
        QLCTContext db = new QLCTContext();

        public FXinNghiNV()
        {
            InitializeComponent();
        }

        public void CapNhat(NhanVien nv)
        {
            xinNghiNVBUS.nv = nv;
        }

        private void btnTT_CheckedChanged(object sender, EventArgs e)
        {
            xinNghiNVBUS.FillTrangThai(shape, flp);
        }

        private void btnTaoXN_CheckedChanged(object sender, EventArgs e)
        {
            xinNghiNVBUS.FillDonXN(shape, flp);
        }

        private void FXinNghiNV_Load(object sender, EventArgs e)
        {
            xinNghiNVBUS.FillDonXN(shape, flp);
        }
    }
}
