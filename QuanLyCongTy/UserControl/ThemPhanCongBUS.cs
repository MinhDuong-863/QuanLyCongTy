using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCongTy
{
    internal class ThemPhanCongBUS
    {
        public DuAn da;
        public Reload.Flp reLoadF;
        QLCTContext db = new QLCTContext();
        public void Fillgv(DataGridView gv, Guna2DateTimePicker NgayBD, Guna2DateTimePicker DeadLine)
        {
            gv.DataSource = db.PhanCongs
                    .Where(pc => pc.NhanVien.MaPB == da.MaPB && pc.DeadLine >= NgayBD.Value && pc.NgayBD <= DeadLine.Value)
                    .Select(pc => new { pc.NhanVien.HoTenNV, pc.NgayBD, pc.DeadLine })
                    .ToList();


        }
        public void FillcboNV(ComboBox cboNV, Guna2DateTimePicker NgayBD, Guna2DateTimePicker DeadLine)
        {
            cboNV.DataSource = da.PhongBan.NhanViens
                .Where(nv => nv.MaNV != nv.PhongBan.MaTrPhong && nv.PhanCongs
                    .All(pc => pc.DeadLine < NgayBD.Value || pc.NgayBD > DeadLine.Value))
                .ToList();
            cboNV.DisplayMember = "HoTenNV";
            cboNV.ValueMember = "MaNV";
        }
        public void FillcboCV(ComboBox cboCV)
        {
            cboCV.DataSource = da.PhongBan.LoaiPhongBan.CongViecs.ToList();
            cboCV.DisplayMember = "TenCV";
            cboCV.ValueMember = "MaCV";
        }
        public void ThemPC(ComboBox cboNhanVien, ComboBox cboCongViec, Guna2TextBox textBox, Guna2TextBox txtMoTa, Guna2CustomCheckBox checkbox, Guna2DateTimePicker dtpDBLam, Guna2DateTimePicker dtpDeadline)
        {
            PhanCong pc = new PhanCong
            {
                MaDA = da.MaDA,
                MaCV = "",
                MaNV = cboNhanVien.SelectedValue.ToString(),
                MoTa = txtMoTa.Text,
                NgayBD = dtpDBLam.Value,
                DeadLine = dtpDeadline.Value,
                TienDo = 0,
                Danhgia = "",
                ChamDiem = -1,
                TienThuong = 0
            };
            if (checkbox.Checked)
            {
                string MaxMaCV = da.PhongBan.LoaiPhongBan.CongViecs.Max(cv_cu => cv_cu.MaCV);
                string MaCVMoi = MaxMaCV.Substring(0, 4) + (int.Parse(MaxMaCV.Substring(4, 3)) + 1).ToString("D3");
                CongViec cv = new CongViec
                {
                    MaCV = MaCVMoi,
                    TenCV = textBox.Text,
                    MaLPB = da.PhongBan.LoaiPhongBan.MaLPB
                };
                db.CongViecs.Add(cv);
                pc.MaCV = MaCVMoi;
            }
            else
            {
                pc.MaCV = cboCongViec.SelectedValue.ToString();
            }
            db.PhanCongs.Add(pc);
            db.SaveChanges();
            reLoadF();
        }
    }
}
