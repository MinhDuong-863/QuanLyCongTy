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
    public partial class FThongBao : Form
    {
        DuAn da;
        XoaDABUS xoaDABUS = new XoaDABUS();

        public FThongBao()
        {
            InitializeComponent();
        }
        public void CapNhat(DuAn da)
        {
            this.da = da;
        }
        private void btnCo_Click(object sender, EventArgs e)
        {
            xoaDABUS.XoaDA(da);
            Close();
        }
        private void btnKhong_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
