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
    public partial class UCPhanCongDaHT : UserControl
    {
        public UCPhanCongDaHT()
        {
            InitializeComponent();
        }
        public void CapNhat(PhanCong pc)
        {
            lblTenDA.Text = pc.DuAn.TenDuAn;
            lblTenCV.Text = pc.CongViec.TenCV;
            lblThuong.Text = pc.TienThuong.ToString();
            lblTienDo.Text = "100%";
            prgTienDo.Value = 100;
            RatingStar.Value = (float)pc.ChamDiem / 20;
        }
    }
}
