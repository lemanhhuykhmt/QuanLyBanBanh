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

namespace QuanLyBanBanh.GUI.UC
{
    public partial class ucBanHang : UserControl
    {
        public ucBanHang()
        {
            InitializeComponent();
            loadDuLieu();
        }
        private void loadDuLieu()
        {
            string query = "SELECT MaLoaiSP,TenSP,dbo.SanPham.MaSP,SUM(dbo.DanhSachBan.Soluong) AS TongSoluong FROM dbo.SanPham INNER JOIN dbo.DanhSachBan ON DanhSachBan.SoLuong = SanPham.SoLuong GROUP BY TenSP,dbo.SanPham.MaSP,MaLoaiSP ORDER BY TongSoluong"; // tất cả các hóa đơn 
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            dgvDanhSach.DataSource = data;
            //MessageBox.Show("ato");
        }
    }
}
