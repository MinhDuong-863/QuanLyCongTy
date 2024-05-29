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
    internal class CheckIOBUS
    {
        QLCTContext db = new QLCTContext();
        public NhanVien nv;
        public void FillDataGrid(Guna2DataGridView gvCheckIO)
        {
            gvCheckIO.DataSource = nv.Checkins
                                    .Select(ci => new
                                    {
                                        ci.NgayCheckin,
                                        ci.GioCheckin,
                                        nv.Checkouts.Where(co => co.NgayCheckout == ci.NgayCheckin).First().GioCheckout,
                                    })
                                    .Select(cio => new
                                    {
                                        cio.NgayCheckin,
                                        cio.GioCheckin,
                                        cio.GioCheckout,
                                        TrangThai = (cio.GioCheckin > TimeSpan.Parse("08:00:00") && cio.GioCheckout < TimeSpan.Parse("17:00:00")) ? "Trễ, Về sớm" :
                                             cio.GioCheckin > TimeSpan.Parse("08:00:00") ? "Trễ" :
                                             cio.GioCheckout < TimeSpan.Parse("17:00:00") ? "Về Sớm" :
                                             "Đúng giờ"
                                    }).ToList();
        }

        public void CheckIN()
        {
            DateTime current = DateTime.Now;
            bool kt = db.Checkins
                      .Where(ci => ci.MaNV == nv.MaNV)
                      .Any(ci => ci.NgayCheckin.Equals(current.Date));
            if(!kt)
            {
                Checkin ci1 = new Checkin()
                {
                    MaNV = nv.MaNV,
                    NgayCheckin = current.Date,
                    GioCheckin = TimeSpan.Parse(current.ToString("HH:mm:ss"))
                };
                db.Checkins.AddOrUpdate(ci1);
                db.SaveChanges();
            }
            else MessageBox.Show("Bạn đã checkin rồi!!!");
        }

        public void CheckOUT()
        {
            DateTime current = DateTime.Now;
            bool kt = db.Checkouts
                      .Where(ci => ci.MaNV == nv.MaNV)
                      .Any(ci => ci.NgayCheckout.Equals(current.Date));
            if (!kt)
            {
                Checkout ci1 = new Checkout()
                {
                    MaNV = nv.MaNV,
                    NgayCheckout = current.Date,
                    GioCheckout = TimeSpan.Parse(current.ToString("HH:mm:ss"))
                };
                db.Checkouts.AddOrUpdate(ci1);
                db.SaveChanges();
            }
            else MessageBox.Show("Bạn đã checkout rồi!!!");
        }
    }
}
