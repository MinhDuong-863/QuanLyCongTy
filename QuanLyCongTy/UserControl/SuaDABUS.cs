using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCongTy
{
    internal class SuaDABUS
    {
        public DuAn da;
        QLCTContext db = new QLCTContext();
        public void DSTinhTrangPBTheoLPB(DataGridView gv, Guna2ComboBox cmbTenPB, Guna2DateTimePicker dtpNgayBD, Guna2DateTimePicker dtpDeadLine)
        {
            PhongBan pb = (PhongBan)cmbTenPB.SelectedItem;
            gv.DataSource = db.DuAns
                            .Where(da1 => da1.DeadLine >= dtpNgayBD.Value && da1.NgayBD <= dtpDeadLine.Value && da1.PhongBan.MaLPB == pb.MaLPB && da1.MaDA != da.MaDA)
                            .Select(da1 => new { da1.PhongBan.TenPB, da1.TenDuAn, da1.DeadLine, da1.NgayBD })
                            .ToList();
        }

        public void FillcmbTenPB(Guna2ComboBox cmbTenPB, Guna2DateTimePicker dtpNgayBD, Guna2DateTimePicker dtpDeadLine)
        {
            string MaLPB = db.PhongBans.Where(pb => pb.MaPB == da.MaPB).First().MaLPB;
            cmbTenPB.DataSource = db.PhongBans
                                  .Where(pb => pb.MaLPB == MaLPB)
                                  .ToList();
            cmbTenPB.ValueMember = "MaPB";
            cmbTenPB.DisplayMember = "TenPB";
        }

        public void FillControl(Guna2TextBox txtTenDA, Guna2TextBox txtMoTa, Guna2ComboBox cmbTenPB,
            Guna2TextBox txtDiaDiem, Guna2DateTimePicker dtpNgayBD, Guna2DateTimePicker dtpDeadLine)
        {
            PhongBan gpb = db.PhongBans
                          .Where(pb => pb.MaPB == da.MaPB)
                          .First();

            txtTenDA.Text = da.TenDuAn;
            txtMoTa.Text = da.MoTa;
            txtDiaDiem.Text = da.DiaDiem;
            dtpNgayBD.Text = da.NgayBD.ToString();
            dtpDeadLine.Text = da.DeadLine.ToString();

            FillcmbTenPB(cmbTenPB, dtpNgayBD, dtpDeadLine);
            cmbTenPB.SelectedItem = gpb;
        }

        public void SuaDA(Guna2TextBox txtTenDA, Guna2TextBox txtMoTa, Guna2ComboBox cmbTenPB,
            Guna2TextBox txtDiaDiem, Guna2DateTimePicker dtpNgayBD, Guna2DateTimePicker dtpDeadLine)
        {
            DuAn da1 = new DuAn()
            {
                MaDA = da.MaDA,
                TenDuAn = txtTenDA.Text,
                MoTa = txtMoTa.Text,
                DiaDiem = txtDiaDiem.Text,
                MaPB = cmbTenPB.SelectedValue.ToString(),
                NgayBD = dtpNgayBD.Value,
                DeadLine = dtpDeadLine.Value,
                DanhGia = "",
                ChamDiem = -1,
                Thuong = 0,
            };
            try
            {
                db.DuAns.AddOrUpdate(da1);
            }
            catch
            {
                MessageBox.Show("Sửa thất bại");
            }
            db.SaveChanges();
        }
    }
}
