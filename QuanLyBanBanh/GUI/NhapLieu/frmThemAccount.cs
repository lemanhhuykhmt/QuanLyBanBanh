using QuanLyBanBanh.Controls;
using QuanLyBanBanh.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanBanh.GUI.NhapLieu
{
    public partial class frmThemAccount : Form
    {
        public frmThemAccount()
        {
            InitializeComponent();
        }

        private void frmThemAccount_Load(object sender, EventArgs e)
        {
            // load nhanvien chưa có acc
            List<NhanVien> listNV = new List<NhanVien>();
            DataTable dt = AccountControl.layDanhSachNhanVien();
            listNV.Add(new NhanVien
            {
                MaNV = 0,
                TenNV = "---None---"
            });
            for (int i = 0; i < dt.Rows.Count; ++i)
            {
                listNV.Add(new NhanVien {
                    MaNV = Convert.ToInt32(dt.Rows[i][0].ToString()),
                    TenNV = dt.Rows[i][1].ToString()
                });
            }
            cbNhanVien.DataSource = listNV;
            cbNhanVien.DisplayMember = "TenNV";
            cbNhanVien.Text = "chon nhan vien";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string tendangnhap = txtTenDangNhap.Text;
            string matkhau = txtMatKhau.Text;
            string xacnhan = txtXacNhan.Text;
            NhanVien nv = cbNhanVien.SelectedValue as NhanVien;
            int quyen = cbQuyen.SelectedIndex + 1;
            if(kiemTraDuLieu(tendangnhap, matkhau, xacnhan, nv))
            {
                int ketqua = AccountControl.themDuLieu(tendangnhap, matkhau, nv.MaNV, quyen);
                if(ketqua > 0)
                {
                    this.Close();
                }
                else
                {
                    MessageBox.Show("thêm thất bại");
                }
            }
            else
            {
                MessageBox.Show("nhập dữ liệu chưa chính xác");
            }
        }

        private bool kiemTraDuLieu(string tendangnhap, string matkhau, string xacnhan, NhanVien nv)
        {
            if (nv == null) return false;
            if (matkhau.Equals(xacnhan) == false) return false;
            return true;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
