using QuanLyBanBanh.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanBanh.GUI.Sua
{
    public partial class frmDoiMK : Form
    {
        private string tenDangNhap;
        public frmDoiMK()
        {
            InitializeComponent();
        }
        public frmDoiMK(string ten)
        {
            InitializeComponent();
            tenDangNhap = ten;
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            string matKhauCu = txtMatKhauCu.Text;
            string matKhauMoi = txtMatKhauMoi.Text;
            string xacNhan = txtXacNhan.Text;
            int ketqua = kiemTraDuLieu(matKhauCu, matKhauMoi, xacNhan);
            if(ketqua == 1) // cu = moi
            {
                lbThongBao.Text = "Mật khẩu mới trùng mật khẩu cũ";
            }
            else if(ketqua == 2)
            {
                lbThongBao.Text = "Nhập lại mật khẩu khônng chính xác";
            }
            else
            {
                int r = AccountControl.suaMatKhau(tenDangNhap, matKhauMoi);
                if(r > 0)
                {
                    MessageBox.Show("Sửa Thành Công");
                    this.Close();
                }
                else
                {
                    lbThongBao.Text = "Lỗi hệ thống";
                }
            }
        }
        private int kiemTraDuLieu(string cu, string moi, string xacthuc)
        {
            if (cu.Equals(moi))
            {
                return 1; // cũ trùng mới
            }
            else if (!moi.Equals(xacthuc))
            {
                return 2;
            }

            return 0;
        }
        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
