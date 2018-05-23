using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanBanh.Controls
{
    class AccountControl
    {
        private static AccountControl instance;
        public static AccountControl Instance
        {
            get { if (instance == null) instance = new AccountControl(); return instance; }
            private set { instance = value; }
        }
        private AccountControl()
        {

        }
        public static int Login(string username, string password)
        {
            string PHAN_BIET_HOA_THUONG = "COLLATE SQL_Latin1_General_CP1_CS_AS";
            string query = "select * from Account where TenDangNhap = '" + username + "' " + PHAN_BIET_HOA_THUONG + " and MatKhau = '" + password + "' " + PHAN_BIET_HOA_THUONG;
            DataTable data = DataProvider.Instance.ExecuteQuery(query); // trả về danh sách acc phù hợp tenD... và matK...
            if (data.Rows.Count > 0) // nếu có acc trùng
            {
                int quyen = 0; // quyền của acc
                query = "exec TimQuyen " + username;
                quyen = (int)DataProvider.Instance.ExecuteScalar(query);
                return quyen;
            }
            return 0; // k có trả về 0
        }

        public static DataTable layDanhSachNhanVien()
        {
            string query = "select nv.MaNV, nv.TenNV, nv.SDT, nv.GioiTinh, nv.NgaySinh, nv.Luong "
                + " from NhanVien as nv, (select MaNV from NhanVien except select MaNV from Account) as b "
                + " where nv.MaNV = b.MaNV";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public static int themDuLieu(string ten, string matkhau, int manv, int quyen)
        {
            string query = "exec themacc @ten , @matkhau , @manv , @quyen";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { ten, matkhau, manv, quyen });
        }
        public static int xoaThongTin(string ten)
        {
            string query = "exec xoaacc @ten";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { ten});
        }
        public static int suaMatKhau(string ten, string matkhau)
        {
            string query = "exec suaacc @ten , @matkhau";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { ten, matkhau});
        }
        public static int layQuyen(string tendangnhap)
        {
            string PHAN_BIET_HOA_THUONG = "COLLATE SQL_Latin1_General_CP1_CS_AS";
            string query = "select * from Account where TenDangNhap = '" + tendangnhap + "' " + PHAN_BIET_HOA_THUONG;
            DataTable data = DataProvider.Instance.ExecuteQuery(query); // trả về danh sách acc phù hợp tenD... và matK...
            if (data.Rows.Count > 0) // nếu có acc trùng
            {
                int quyen = 0; // quyền của acc
                query = "exec TimQuyen " + tendangnhap;
                quyen = (int)DataProvider.Instance.ExecuteScalar(query);
                return quyen;
            }
            return 0;
        }
    }
}
