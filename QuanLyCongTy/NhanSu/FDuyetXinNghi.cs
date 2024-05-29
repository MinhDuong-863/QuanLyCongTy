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
    public partial class FDuyetXinNghi : Form
    {
        QLCTContext db = new QLCTContext();
        DuyetXinNghiBUS duyetXinNghiBUS = new DuyetXinNghiBUS();
        public FDuyetXinNghi()
        {
            InitializeComponent();
        }
        public void CapNhat(NhanVien nv)
        {
            duyetXinNghiBUS.nv = nv;
            duyetXinNghiBUS.flp = flp;
            duyetXinNghiBUS.shape = shape;
        }
        private void FXinNghi_Load(object sender, EventArgs e)
        {
            duyetXinNghiBUS.XNChuaDuyet();
        }

        public delegate void FReload();

        private void btnDaDuyet_CheckedChanged(object sender, EventArgs e)
        {
            duyetXinNghiBUS.XNDaDuyet();
        }

        private void btnChuaDuyet_CheckedChanged(object sender, EventArgs e)
        {
            duyetXinNghiBUS.XNChuaDuyet();
        }
    }
}
