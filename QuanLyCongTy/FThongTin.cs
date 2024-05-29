using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCongTy
{
    public partial class FThongTin : Form
    {
        ThongTinBUS thongTinBUS = new ThongTinBUS();
        QLCTContext db = new QLCTContext();
        public FThongTin(string MaNV)
        {   
            InitializeComponent();
            thongTinBUS.nv = db.NhanViens.Where(nv1 => nv1.MaNV == MaNV).First();
        }

        private void FThongTin_Load(object sender, EventArgs e)
        {
            thongTinBUS.FillControls(label11, label12, label13, label14, label15, label16, label22, label17, label18, label19);
        }
    }
}
