using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCongTy
{
    internal class TaoXinNghiBUS
    {
        QLCTContext db = new QLCTContext();
        public NhanVien nv;
        public void TaoXinNghi(Guna2DateTimePicker dtp, Guna2TextBox txt, Guna2ComboBox cbo, Guna2CustomCheckBox chk, Guna2TextBox txtLyDo)
        {
            XinNghi xn;
            if (chk.Checked) xn = new XinNghi
            {
                MaNV = nv.MaNV,
                NgayNghi = dtp.Value.Date,
                SoNgayNghi = int.Parse(txt.Text),
                LyDo = txtLyDo.Text,
                HeSoDuyet = -1
            };
            else xn = new XinNghi
            {
                MaNV = nv.MaNV,
                NgayNghi = dtp.Value.Date,
                SoNgayNghi = int.Parse(txt.Text),
                LyDo = cbo.Text,
                HeSoDuyet = -1
            };

            try
            {
                db.XinNghis.Add(xn);
                db.SaveChanges();
                MessageBox.Show("Thêm thành công!");
            }
            catch
            {
                MessageBox.Show("Thêm thất bại!");
            }
        }
    }
}
