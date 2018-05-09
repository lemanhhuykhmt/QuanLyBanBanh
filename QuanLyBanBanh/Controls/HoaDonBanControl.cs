using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanBanh.Controls
{
    class HoaDonBanControl
    {
        private static HoaDonBanControl instance;
        public HoaDonBanControl Instance
        {
            private set { if (instance == null) instance = new HoaDonBanControl(); instance = value; }
            get { return instance; }
        }
        private HoaDonBanControl()
        {

        }
        public static int themDuLieu(int makh, int manv, DateTime ngaylap, int makm, int trangthai, double thanhtoan) // thêm dữ liệu vào bảng
        {
            string query = "exec themhdb @makh , @manv , @ngaylap , @makm , @trangthai , @thanhtoan";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { makh, manv, ngaylap, makm, trangthai, thanhtoan });
        }
        public static DataTable layDanhSach()  // lấy ra danh sách hóa đơn có tên nv, tên kh
        {
            string query = "select MaHDB, TenKH, TenNV, NgayLap, TrangThai from HoaDonBan as hdb, NhanVien as nv, KhachHang as kh where hdb.MaNV = nv.MaNV and hdb.MaKH = kh.MaKH";//lấy ra thông tin khách hàng có mã
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            return dt;
        }
        public static DataTable layThongTin(int id) // lấy thông tin hóa đơn có id là
        {
            string query = "select MaHDB, TenKH, TenNV, NgayLap, TrangThai from HoaDonBan as hdb, NhanVien as nv, KhachHang as kh where hdb.MaNV = nv.MaNV and hdb.MaKH = kh.MaKH and MaHDB = @ma";//lấy ra thông tin khách hàng có mã
            DataTable dt = DataProvider.Instance.ExecuteQuery(query, new object[] { id });
            return dt;
        }
        //public static int suaThongTin(int id, string ten, int loai, float dongia, string donvido, DateTime hsd, DateTime nsx, int soluong) // sửa thông tin của hóa đơn
        //{
        //    string query = "exec suakh @id , @ten , @loai , @dongia , @donvi , @hsd , @nsx , @soluong";
        //    return DataProvider.Instance.ExecuteNonQuery(query, new object[] { id, ten, loai, dongia, donvido, hsd, nsx, soluong });
        //}
        public static int xoaThongTin(int id) // xóa thông tin hoa don ban
        {
            string query = "exec xoahdb @ma";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { id });
        }
        public static DataTable layDanhSachSP(int id) // lấy ra danh sach sp (ma, ten, dongia, soluong)
        {
            string query = "select a.MaSP as MaSP, a.TenSP as TenSP, b.gt as DonGia, b.sl as SoLuong, b.gt * b.sl as GiaTien "
                + "from SanPham as a,(select MaSP as ma, GiaTien as gt, SoLuong as sl from DanhSachBan where MaHDB = @ma ) as b "
                + "where a.MaSP = b.ma";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { id });
        }
        public static DataTable timKiem(object obj)
        {
            string str = "%" + obj.ToString() + "%";
            string query = "select * from (select MaHDB, TenKH, TenNV, NgayLap, TrangThai from HoaDonBan as hdb, NhanVien as nv, KhachHang as kh where hdb.MaNV = nv.MaNV and hdb.MaKH = kh.MaKH) as x" +
                " where x.MaHDB like @ma or x.TenKH like @tenkh or x.TenNV like @tennv or x.NgayLap like @ngaylap";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { str, str, str, str });
        }
        //public static DataTable layDanhSachLoaiSP()
        //{
        //    string query = "select MaLoaiSP, TenLoaiSP from LoaiSP";
        //    return DataProvider.Instance.ExecuteQuery(query);
        //}
        //public static int layIDLoaiSP(string ten)
        //{
        //    string query = "select MaLoaiSP from LoaiSP where TenLoaiSP like @ten";
        //    return (int)DataProvider.Instance.ExecuteScalar(query, new object[] { ten });
        //}
        //public static int layIDKhachHang(int idhdb) // lấy ra tên khách hàng có mã hdb
        //{
        //    string query = "select HoaDonBan.MaKH from HoaDonBan, KhachHang where MaHDB = @id and HoaDonBan.MaKH = KhachHang.MaKH";
        //    DataTable dt = DataProvider.Instance.ExecuteQuery(query, new object[] { idhdb});
        //    if (dt.Rows.Count == 0)
        //    {
        //        return 0;
        //    }
        //    return Convert.ToInt32(dt.Rows[0][0].ToString());
        //}
        //public static int layIDNhanVien(int idhdb)
        //{
        //    string query = "select NhanVien.MaNV from HoaDonBan, NhanVien where MaHDB = @id and HoaDonBan.MaNV = NhanVien.MaNV";
        //    DataTable dt = DataProvider.Instance.ExecuteQuery(query, new object[] { idhdb });
        //    if (dt.Rows.Count == 0)
        //    {
        //        return 0;
        //    }
        //    return Convert.ToInt32(dt.Rows[0][0].ToString());
        //}
        //public static int layTrangThai(int idhdb)
        //{
        //    string query = "select TrangThai from HoaDonBan where MaHDB = @id";
        //    return (int) DataProvider.Instance.ExecuteScalar(query, new object[] { idhdb});
        //}
        public static string layKhuyenMai(int idhdb)
        {
            string query = "select TenKm from HoaDonBan, KhuyenMai where MaHDB = @id and HoaDonBan.MaKM = KhuyenMai.MaKM";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query, new object[] { idhdb });
            if (dt.Rows.Count == 0)
            {
                return "";
            }
            return dt.Rows[0][0].ToString();
        }
        //public static double layThanhToan(int idhdb)
        //{
        //    string query = "select ThanhToan from HoaDonBan where MaHDB = @id";
        //    return (double)DataProvider.Instance.ExecuteScalar(query, new object[] { idhdb });
        //}
        //public static DateTime layNgayLap(int idhdb)
        //{
        //    string query = "select NgayLap from HoaDonBan where MaHDB = @id";
        //    return DateTime.Parse(DataProvider.Instance.ExecuteScalar(query, new object[] { idhdb }).ToString());
        //}
        public static DataTable layThongTinHDB(int id)
        {
            string query = "select MaHDB, MaKH, MaNV, NgayLap, TrangThai from HoaDonBan where MaHDB = @id";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { id});
        }
        /////////////////////////////////
        public static int themChiTietHD(int mahdb, int masp, int soluong, double gia)
        {
            string query = "exec themdsb @mahdb , @masp , @soluong , @gia";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { mahdb, masp, soluong , gia});
        }
    }
}
