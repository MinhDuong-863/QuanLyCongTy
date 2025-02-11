﻿using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCongTy
{
    internal class XemDADaHTQLBUS
    {
        public DuAn da;
        public Reload.Flp HamRL;
        QLCTContext db = new QLCTContext();
        public void FillControls(Label lbl_tenDA, Label lbl_TenPhong, Guna2ProgressBar prgTienDo, Label lblTienDo, Guna2RatingStar ratingStar)
        {
            PhongBan gpb = db.PhongBans
                           .Where(pb => pb.MaPB == da.MaPB)
                           .First();

            lbl_tenDA.Text = da.TenDuAn;
            lbl_TenPhong.Text = gpb.TenPB;
            prgTienDo.Value = 100;
            lblTienDo.Text = "100%";
            ratingStar.Value = (float)da.ChamDiem / 20;
        }
        void OpenForm(Form fnew, UCSailorStar uc)
        {
            uc.Enabled = false;
            fnew.ShowDialog();
            uc.Enabled = true;
            HamRL();
        }
        public void OpenFNhanXet(UCSailorStar uc)
        {
            FNhanXetDA form = new FNhanXetDA();
            form.CapNhat(da);
            OpenForm(form, uc);
        }
    }
}
