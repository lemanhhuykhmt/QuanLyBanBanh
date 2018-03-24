﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanBanh.Controls
{
    class KhachHangControl
    {
        private static KhachHangControl instance;
        public KhachHangControl Instance
        {
            private set { if (instance == null) instance = new KhachHangControl(); instance = value; }
            get { return instance; }
        }
        private KhachHangControl()
        {

        }
        public static DataTable layDanhSachKH() // lấy thông tin khách hàng có id là ..
        {
            string query = "select * from KhachHang";//lấy ra thông tin khách hàng có mã
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            return dt;
        }
        public static DataTable layThongTinKH(int id) // lấy thông tin khách hàng có id là ..
        {
            string query = "select * from KhachHang where MaKH = @makh";//lấy ra thông tin khách hàng có mã
            DataTable dt = DataProvider.Instance.ExecuteQuery(query, new object[] { id });
            return dt;
        }
        public static int suaThongTinKH(int id, string ten, string diachi, string sdt) // sửa thông tin của khách hàng
        {
            string query = "exec suakh @id , @ten , @diachi , @sdt";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { id, ten, diachi, sdt});
        }
        public static int xoaThongTinKH(int id)
        {
            string query = "exec xoakh @makh";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { id });
        }
        public static DataTable timKH(object obj)
        {
            string str = "%" + obj.ToString() + "%";
            string query = "select * from KhachHang where TenKH like @ten or DiaChi like @diachi or SDT like @sdt";
            return DataProvider.Instance.ExecuteQuery(query,new object[] { str, str, str});
        }
    }
}
