using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanBanh.Controls
{
    class SanPhamControl
    {
        private static SanPhamControl instance;
        public SanPhamControl Instance
        {
            private set { if (instance == null) instance = new SanPhamControl(); instance = value; }
            get { return instance; }
        }
        private SanPhamControl()
        {

        }
        public static int themDuLieu(string ten, int loai, float dongia, string donvido, DateTime hsd, DateTime nsx, int soluong)
        {
            string query = "exec themsp @tensp , @loaisp , @dongia , @donvido , @hsd , @nsx , @soluong";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { ten, loai, dongia, donvido, hsd, nsx, soluong});
        }
        public static DataTable layDanhSach() // lấy danh sách sản phẩm
        {
            string query = "select MaSP, TenSP, TenLoaiSP, DonGia, DonViDo, HSD, NSX, SoLuong from SanPham as sp, LoaiSP as loai where ConDung = 1 and sp.MaLoaiSP = loai.MaLoaiSP";//lấy ra thông tin khách hàng có mã
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            return dt;
        }
        public static DataTable layThongTin(int id) // lấy thông tin khách hàng có id là ..
        {
            string query = "select MaSP, TenSP, TenLoaiSP, DonGia, DonViDo, HSD, NSX, SoLuong from SanPham, LoaiSP where MaSP = @masp and SanPham.MaLoaiSP = LoaiSP.MaLoaiSP";//lấy ra thông tin khách hàng có mã
            DataTable dt = DataProvider.Instance.ExecuteQuery(query, new object[] { id });
            return dt;
        }
        public static int suaThongTin(int id, string ten, int loai, float dongia, string donvido, DateTime hsd, DateTime nsx, int soluong) // sửa thông tin của khách hàng
        {
            string query = "exec suakh @id , @ten , @loai , @dongia , @donvi , @hsd , @nsx , @soluong";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { id, ten, loai, dongia, donvido, hsd, nsx, soluong });
        }
        public static int xoaThongTin(int id)
        {
            string query = "exec xoasp @ma";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { id });
        }
        public static DataTable timKiem(object obj)
        {
            string str = "%" + obj.ToString() + "%";
            string query = "select * from (select MaSP, TenSP, TenLoaiSP, DonGia, DonViDo, HSD, NSX SoLuong from SanPham as sp, LoaiSP as loai where ConDung = 1 and sp.MaLoaiSP = loai.MaLoaiSP)" + 
                " where MaSP like @ma or TenSP like @ten or TenLoaiSP like @loai or DonViDo like @donvido";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { str, str, str, str });
        }
        public static DataTable layDanhSachLoaiSP()
        {
            string query = "select MaLoaiSP, TenLoaiSP from LoaiSP";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public static int layIDLoaiSP(string ten)
        {
            string query = "select MaLoaiSP from LoaiSP where TenLoaiSP like @ten";
            return (int) DataProvider.Instance.ExecuteScalar(query, new object[] { ten});
        }
    }
}
