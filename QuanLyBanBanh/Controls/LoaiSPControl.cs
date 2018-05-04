using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanBanh.Controls
{
    class LoaiSPControl
    {
        private static LoaiSPControl instance;
        public LoaiSPControl Instance
        {
            private set { if (instance == null) instance = new LoaiSPControl(); instance = value; }
            get { return instance; }
        }
        private LoaiSPControl()
        {

        } 
        public static DataTable layDSMH()
        {
            string query = "select MaMH, TenMH from MatHang";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public static DataTable layDSLoai(int id)
        {
            string query = "select MaLoaiSP, TenLoaiSP from LoaiSP where MaMH = @mamh";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { id});
        }
    }
}
