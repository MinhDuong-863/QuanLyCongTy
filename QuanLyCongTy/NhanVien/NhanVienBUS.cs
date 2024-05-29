using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QuanLyCongTy
{
    internal class NhanVienBUS
    {
        public NhanVien nv;
        Form currentFormChild;
        DateTime datecal = DateTime.Today;
        Panel pnl;

        private void moveImageBox(PictureBox imgSlide, Guna2Button b)
        {
            imgSlide.Location = new Point(b.Location.X + 166, b.Location.Y - 30);
            imgSlide.BringToFront();
        }
        public void AddPnl(Panel pnl)
        {
            this.pnl = pnl;
        }

        public void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Fill;
            pnl.Controls.Add(childForm);
            pnl.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        public void OpenFCheckIO(PictureBox imgSlide, Guna2Button b)
        {
            FCheckinout fcheckIO = new FCheckinout();
            fcheckIO.CapNhat(nv);
            OpenChildForm(fcheckIO);
            moveImageBox(imgSlide, b);
        }
        public void OpenFKPI(PictureBox imgSlide, Guna2Button b)
        {
            FKPI fKPI = new FKPI();
            fKPI.CapNhat(nv);
            OpenChildForm(fKPI);
            moveImageBox(imgSlide, b);
        }
        public void OpenFThongTin(PictureBox imgSlide, Guna2Button b)
        {
            OpenChildForm(new FThongTin(nv.MaNV));
            moveImageBox(imgSlide, b);
        }
        public void OpenFXinNghi(PictureBox imgSlide, Guna2Button b)
        {
            FXinNghiNV f = new FXinNghiNV();
            f.CapNhat(nv);
            OpenChildForm(f);
            moveImageBox(imgSlide, b);
        }
        public void OpenFLuong(PictureBox imgSlide, Guna2Button b)
        {
            FXemLuong f = new FXemLuong();
            f.CapNhat(nv, datecal);
            OpenChildForm(f);
            moveImageBox(imgSlide, b);
        }
        public void Load(Label lblTen)
        {
            lblTen.Text = nv.HoTenNV;
            OpenChildForm(new FThongTin(nv.MaNV));
        }
    }
}
