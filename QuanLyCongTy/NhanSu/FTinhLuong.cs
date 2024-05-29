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
    public partial class FTinhLuong : Form
    {
        TinhLuongBUS tinhLuongBUS = new TinhLuongBUS();
        public FTinhLuong()
        {
            InitializeComponent();
        }
        private void FTinhLuong_Load(object sender, EventArgs e)
        {
            tinhLuongBUS.FillControl(lblThang, flpLuong, cbo);
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            tinhLuongBUS.NextMonth(lblThang, flpLuong, cbo, chk);
        }
        private void btnPast_Click(object sender, EventArgs e)
        {
            tinhLuongBUS.PreMonth(lblThang, flpLuong, cbo, chk);
        }
        private void guna2CustomCheckBox1_Click(object sender, EventArgs e)
        {
            tinhLuongBUS.CheckChange(chk, flpLuong);
        }
        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            tinhLuongBUS.Loadfpl(flpLuong, cbo);
        }
        private void btnPhatLuong_Click(object sender, EventArgs e)
        {
            tinhLuongBUS.PhatLuong(flpLuong, cbo);
        }
    }
}
