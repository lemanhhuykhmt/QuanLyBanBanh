using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanBanh.Controls
{
    class KhuyenMaiControl
    {
        private static KhuyenMaiControl instance;
        public KhuyenMaiControl Instance
        {
            private set { if (instance == null) instance = new KhuyenMaiControl(); instance = value; }
            get { return instance; }
        }
        private KhuyenMaiControl()
        {

        }

        public static DataTable layDanhSach()
        {
            string query = "select MaKM, TenKM from KhuyenMai ";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public static double layGiaTri(string ten)
        {
            if(ten.Equals("-----none-----"))
            {
                return 0;
            }
            string query = "select GiaTri from KhuyenMai where TenKM = @makm";
            return (double)DataProvider.Instance.ExecuteScalar(query,new object[]{ ten});
        }
        public static int layLoaiKhuyenMai(string ten)
        {
            if(ten.Equals("-----none-----"))
            {
                return 0;
            }
            string query = "select LoaiKM from KhuyenMai where TenKM = @makm";
            return (int) DataProvider.Instance.ExecuteScalar(query, new object[] { ten });
        }
    }
}
