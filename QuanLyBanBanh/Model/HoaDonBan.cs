using QuanLyBanBanh.Controls;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanBanh.Model
{
    class HoaDonBan
    {
        private ChiTietHDB chiTiet;
        private int id;
        private DateTime ngayLap;
        private int idNV;
        private int idKH;
        private int trangThai;
        private string tenKM;
        private double thanhToan;

        public ChiTietHDB ChiTiet
        {
            set { }
            get { if (chiTiet == null) chiTiet = new ChiTietHDB(); return chiTiet; }
        }
        public int Id
        {
            set { }
            get { return id; }
        }
        public DateTime NgayLap
        {
            set { ngayLap = value; }
            get { return ngayLap; }
        }
        public int IdNV
        {
            set { idNV = value; }
            get { return idNV; }
        }
        public int IdKH
        {
            set { idKH = value; }
            get { return idKH; }
        }
        public string TenKM
        {
            set { tenKM = value; }
            get { return tenKM; }
        }
        public double ThanhToan
        {
            set { }
            get { return thanhToan; }
        }
        public int TrangThai
        {
            set { trangThai = value; }
            get { return trangThai; }
        }


        public HoaDonBan()
        {
            chiTiet = new ChiTietHDB();
            id = 0;
            ngayLap = DateTime.Now;
            idNV = 0;
            idKH = 0;
            tenKM = "-----none-----";
            thanhToan = 0;
            trangThai = 0;
        }
        public HoaDonBan(int id)
        {
            chiTiet = new ChiTietHDB(id);
            this.id = id;
            idKH = HoaDonBanControl.layIDKhachHang(id);
            idNV = HoaDonBanControl.layIDNhanVien(id);
            trangThai = HoaDonBanControl.layTrangThai(id);
            tenKM = HoaDonBanControl.layKhuyenMai(id);
            thanhToan = HoaDonBanControl.layThanhToan(id);
            ngayLap = HoaDonBanControl.layNgayLap(id);
        }

        public void Luu()
        {

        }

        public void tinhThanhToan()
        {
            int loaiKM = KhuyenMaiControl.layLoaiKhuyenMai(tenKM);
            double giaTri = KhuyenMaiControl.layGiaTri(tenKM);

            if(loaiKM == 0)
            {
                thanhToan = chiTiet.tinhTongTien();
            }
            else if(loaiKM == 1) // %
            {
                thanhToan = chiTiet.tinhTongTien() - chiTiet.tinhTongTien() * giaTri / 100;
            }
            else if(loaiKM == 2) // trừ thẳng
            {
                thanhToan = chiTiet.tinhTongTien() - giaTri;
                if (thanhToan < 0) thanhToan = 0;
            }
        }
        public string layTenNV()
        {
            return NhanVienControl.layTenNV(idNV);
        }
        public string layTenKH()
        {
            return KhachHangControl.layTenKH(idKH);
        }
    }
}
