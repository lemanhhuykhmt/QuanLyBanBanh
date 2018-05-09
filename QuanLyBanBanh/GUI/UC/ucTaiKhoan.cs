using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyBanBanh.Controls;
using QuanLyBanBanh.GUI.NhapLieu;

namespace QuanLyBanBanh.GUI.UC
{
    public partial class ucTaiKhoan : UserControl
    {
        public ucTaiKhoan()
        {
            InitializeComponent();
            loadDuLieu();
        }
        private void loadDuLieu()
        {
            dgvDanhSach.Rows.Clear();
            string query = "select TenDangNhap, TenNV, Quyen from Account, NhanVien where Account.MaNV = NhanVien.MaNV";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query); // trả về kết quả
            for (int i = 0; i < dt.Rows.Count; ++i)
            {
                string tenQuyen = "";
                if (Convert.ToInt32(dt.Rows[i][2].ToString()) == 1) tenQuyen = "Admin";
                else if (Convert.ToInt32(dt.Rows[i][2].ToString()) == 2) tenQuyen = "Bán Hàng";
                else if (Convert.ToInt32(dt.Rows[i][2].ToString()) == 3) tenQuyen = "Nhập Kho";
                dgvDanhSach.Rows.Add(new object[] { dt.Rows[i][0], dt.Rows[i][1], tenQuyen });
            }
        }
        private void dgvDanhSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDanhSach.Rows.Count == e.RowIndex + 1) return;

            string tendangnhap = dgvDanhSach.Rows[e.RowIndex].Cells["colTen"].Value.ToString();
            //if (e.ColumnIndex == dgvDanhSach.Columns["colSua"].Index)
            //{
            //    //frmSuaKH f = new frmSuaKH(id);
            //    //f.ShowDialog();
            //    //loadDuLieu();
            //}
            if (e.ColumnIndex == dgvDanhSach.Columns["colXoa"].Index)
            {
                int ketQua = AccountControl.xoaThongTin(tendangnhap);
                if (ketQua <= 0)
                {
                    MessageBox.Show("Thực hiện thất bại");
                }
                else
                {
                    loadDuLieu();
                }
            }
        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            frmThemAccount f = new frmThemAccount();
            f.ShowDialog();
            loadDuLieu();
        }
    }
}
