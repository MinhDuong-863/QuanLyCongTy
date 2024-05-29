using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCongTy
{
    internal class DangNhapBUS
    {
        QLCTContext db = new QLCTContext();
        public void DangNhap(Guna2TextBox txtTaiKhoan, Guna2TextBox txtMatKhau, FDangNhap f)
        {
            bool ktDN = db.TaiKhoans.Any(tk => tk.TK == txtTaiKhoan.Text && tk.MK == txtMatKhau.Text);
            if (ktDN)
            {
                NhanVien nv = db.TaiKhoans
                    .Where(tk => tk.TK == txtTaiKhoan.Text && tk.MK == txtMatKhau.Text)
                    .Select(tk => tk.NhanVien)
                    .First();
                f.Hide();
                txtTaiKhoan.Text = "";
                txtMatKhau.Text = "";
                Form newForm;
                if (nv.PhongBan.LoaiPhongBan.MaLPB == "LPBQL")
                    newForm = new FQuanLy(nv.MaNV);
                else if (nv.PhongBan.LoaiPhongBan.MaLPB == "LPBHR")
                    newForm = new FNhanSu(nv.MaNV);
                else if (nv.MaNV == nv.PhongBan.MaTrPhong)
                    newForm = new FTruongPhong(nv.MaNV);
                else
                    newForm = new FNhanVien(nv.MaNV);
                newForm.ShowDialog();
                f.Show();
            }
            else
            {
                Form form = new FSaiTK();
                f.Enabled = false;
                form.ShowDialog();
                f.Enabled = true;
            }
        }
        public void ckbMatKhau_CheckedChanged(Guna2CustomCheckBox ckb, Guna2TextBox txtMatKhau)
        {
            txtMatKhau.PasswordChar = ckb.Checked ? '\0' : '●';
        }
    }
}
