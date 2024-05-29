using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCongTy
{
    internal class XemTienDoPCBUS
    {
        public PhanCong pc;
        public Reload.Flp reLoadF;
        public void FillControl(Label lblTen, Guna2ProgressBar prg, Label lblTD)
        {

            lblTen.Text = pc.NhanVien.HoTenNV;
            prg.Value = pc.TienDo.Value;
            lblTD.Text = prg.Value.ToString() + "%";
        }
    }
}
