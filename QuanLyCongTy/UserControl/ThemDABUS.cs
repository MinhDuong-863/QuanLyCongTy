using Guna.UI2.WinForms;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCongTy
{
    internal class ThemDABUS
    {
        QLCTContext db = new QLCTContext();
        public void DSTinhTrangPBTheoLPB(DataGridView gv, Guna2ComboBox cmbLoaiPB, Guna2DateTimePicker dtpNgayBD, Guna2DateTimePicker dtpDeadLine)
        {
            string MaLPB = ((LoaiPhongBan)cmbLoaiPB.SelectedItem).MaLPB;
            gv.DataSource = db.DuAns
                            .Where(da => da.DeadLine >= dtpNgayBD.Value && da.NgayBD <= dtpDeadLine.Value && da.PhongBan.MaLPB == MaLPB)
                            .Select(da => new { da.PhongBan.TenPB, da.TenDuAn, da.DeadLine, da.NgayBD })
                            .ToList();
        }

        public void FillcmbLoaiPB(Guna2ComboBox cmbLoaiPB)
        {
            cmbLoaiPB.DataSource = db.LoaiPhongBans.ToList();
            cmbLoaiPB.ValueMember = "MaLPB";
            cmbLoaiPB.DisplayMember = "TenLPB";
            cmbLoaiPB.SelectedIndex = 0;
        }

        public void FillcmbTenPB(Guna2ComboBox cmbTenPB, Guna2ComboBox cmbLoaiPB, Guna2DateTimePicker dtpNgayBD, Guna2DateTimePicker dtpDeadLine)
        {
            string MaLPB = ((LoaiPhongBan)cmbLoaiPB.SelectedItem).MaLPB;
            cmbTenPB.DataSource = db.PhongBans
                                    .Where(pb => pb.MaLPB == MaLPB)
                                    .ToList();
            cmbTenPB.ValueMember = "MaPB";
            cmbTenPB.DisplayMember = "TenPB";
        }

        public void TaoMaDA(Label lblMaDA)
        {
            string MaxMaDA = db.DuAns.Max(pb => pb.MaDA);
            lblMaDA.Text = MaxMaDA.Substring(0, 2) + (int.Parse(MaxMaDA.Substring(2, 3)) + 1).ToString("D3");

        }

        public void ThemDA(Label lblMaDA, Guna2TextBox txtTenDA, Guna2TextBox txtMoTa, Guna2ComboBox cmbTenPB,
            Guna2TextBox txtDiaDiem, Guna2DateTimePicker dtpNgayBD, Guna2DateTimePicker dtpDeadLine)
        {
            DuAn da = new DuAn
            {
                MaDA = lblMaDA.Text,
                TenDuAn = txtTenDA.Text,
                MoTa = txtMoTa.Text,
                MaPB = cmbTenPB.SelectedValue.ToString(),
                DiaDiem = txtDiaDiem.Text,
                NgayBD = dtpNgayBD.Value,
                DeadLine = dtpDeadLine.Value,
                DanhGia = "",
                ChamDiem = -1,
                Thuong = 0
            };
            try
            {
                db.DuAns.Add(da);
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
            db.SaveChanges();
        }

        
    }
}
