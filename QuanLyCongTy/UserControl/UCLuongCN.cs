using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Navigation;

namespace QuanLyCongTy
{
    public partial class UCLuongCN : UserControl
    {
        LuongCNBUS luongCNBUS = new LuongCNBUS();
        public bool Checked { get => chkCheck.Checked; set => chkCheck.Checked = value; }
        public UCLuongCN()
        {
            InitializeComponent();
        }
        public void CapNhat(NhanVien nv, DateTime date)
        {
            luongCNBUS.date = date;
            luongCNBUS.nv = nv;
        }

        private void UCLuongCN_Load(object sender, EventArgs e)
        {
            luongCNBUS.FillControl(lblTen, lblChucVu, lblMucLuong, lblThuong, lblNgayDiLam, lblTreSom, lblTongLuong);
        }
        public Luong GetLuong()
        {
            return luongCNBUS.getLuong();
        }

    }
}
