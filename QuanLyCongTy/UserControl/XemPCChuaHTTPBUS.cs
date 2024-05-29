using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCongTy
{
    internal class XemPCChuaHTTPBUS
    {
        public PhanCong pc;
        public Reload.Flp reLoadF;
        public void FillControl(Label lblTenCV, Label lblGTBatDauLam, Label lblTGConLai, Guna2ProgressBar ucTienDo1, TextBox textBox1, Label lblTienDo)
        {

            lblTenCV.Text = pc.CongViec.TenCV;
            lblGTBatDauLam.Text = "Ngày bắt đầu: " + pc.NgayBD.Value.ToString("dd/MM/yyyy");
            lblTGConLai.Text = "Còn " + (pc.DeadLine.Value.Subtract(DateTime.Now)).Days.ToString() + " Ngày";
            ucTienDo1.Value = pc.TienDo.Value;
            lblTienDo.Text = pc.TienDo.ToString() + "%";
            textBox1.Text = pc.NhanVien.HoTenNV;
        }
        public void OpenFPCXoa()
        {
            FXoaPC fXoaPC = new FXoaPC();
            fXoaPC.CapNhat(pc, reLoadF);
            fXoaPC.ShowDialog();
        }

        public void OpenFThemPC()
        {
            FThemTroGiup fThemTroGiup = new FThemTroGiup();
            fThemTroGiup.CapNhat(pc, reLoadF);
            fThemTroGiup.ShowDialog();
        }
    }
}
