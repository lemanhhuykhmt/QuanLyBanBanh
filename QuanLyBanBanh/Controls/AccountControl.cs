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
    }
}
