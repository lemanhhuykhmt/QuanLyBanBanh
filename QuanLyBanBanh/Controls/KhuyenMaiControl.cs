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

    }
}
