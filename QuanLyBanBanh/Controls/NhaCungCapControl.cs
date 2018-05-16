﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanBanh.Controls
{
    class NhaCungCapControl
    {
        private static NhaCungCapControl instance;
        public NhaCungCapControl Instance
        {
            private set { instance = value; }
            get { if (instance == null) instance = new NhaCungCapControl(); return instance; }
        }
        private NhaCungCapControl()
        {

        }
        public static int themDuLieu(string ten, string diachi, string sdt)
        {
            string query = "exec themnpp @ten , @diachi , @sdt";
            return DataProvider.Instance.ExecuteNonQuery(query, new String[] { ten, diachi, sdt });
        }
        public static DataTable layDanhSach() // lấy thông tin ncc
        {
            string query = "select * from NhaPhanPhoi";//lấy ra thông tin khách hàng có mã
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            return dt;
        }
        public static DataTable layThongTin(int id) // lấy thông tin khách hàng có id là ..
        {
            string query = "select * from NhaPhanPhoi where MaNPP = @manpp";//lấy ra thông tin khách hàng có mã
            DataTable dt = DataProvider.Instance.ExecuteQuery(query, new object[] { id });
            return dt;
        }
        public static int suaThongTin(int id, string ten, string diachi, string sdt) // sửa thông tin của khách hàng
        {
            string query = "exec suanpp @id , @ten , @diachi , @sdt";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { id, ten, diachi, sdt });
        }
        public static int xoaThongTin(int id)
        {
            string query = "exec xoanpp @makh";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { id });
        }
        public static DataTable timKiem(object obj)
        {
            string str = "%" + obj.ToString() + "%";
            string query = "select * from NhaPhanPhoi where TenNPP like @ten or DiaChi like @diachi or SDT like @sdt";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { str, str, str });
        }
    }
}
