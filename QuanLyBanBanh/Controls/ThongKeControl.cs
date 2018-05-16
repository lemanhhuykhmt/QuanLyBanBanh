using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanBanh.Controls
{
    class ThongKeControl
    {
        public static DataTable ThongKeSanPham(DateTime tu, DateTime den)
        {
            string query = "select sp.MaSP, sp.TenSP, b.SoLuong, b.TongTien " 
                + " from SanPham as sp, (select a.MaSP, sum(a.SoLuong) as SoLuong, " 
                + " sum(a.TongTien) as TongTien from (select MaSP, SoLuong, GiaTien, " 
                + " SoLuong * GiaTien as TongTien from DanhSachBan where MaHDB in (select " 
                + " hdb.MaHDB from HoaDonBan as hdb where (DATEDIFF(DAYOFYEAR, " 
                + " @tu , hdb.NgayLap) >= 0) and (DATEDIFF(DAYOFYEAR, hdb.NgayLap, @den ) >= 0))) " 
                + " as a group by a.MaSP) as b where sp.MaSP = b.MaSP";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { tu.ToShortDateString(), den.ToShortDateString()});
        }
    }
}
