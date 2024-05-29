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
    public partial class FTaoXinNghi : Form
    {
        TaoXinNghiBUS taoXinNghiBUS = new TaoXinNghiBUS();
        public FTaoXinNghi()
        {
            InitializeComponent();
        }

        public void CapNhat(NhanVien nv)
        {
            taoXinNghiBUS.nv = nv;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbKhac.Checked)
            {
                txtLyDo.Enabled = true;
                cboLyDo.Enabled = false;
            }
            else
            {
                txtLyDo.Enabled = false;
                cboLyDo.Enabled = true;
            }
        }

        private void btnTaoXN_Click(object sender, EventArgs e)
        {
            taoXinNghiBUS.TaoXinNghi(dtpNgayNghi, txtSoNN, cboLyDo, ckbKhac, txtLyDo);
        }

        private void FTaoXinNghi_Load(object sender, EventArgs e)
        {
            dtpNgayNghi.Value = DateTime.Now;
        }
    }
}
