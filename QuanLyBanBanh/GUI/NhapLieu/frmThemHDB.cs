using QuanLyBanBanh.Controls;
using QuanLyBanBanh.Extender;
using QuanLyBanBanh.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanBanh.GUI.NhapLieu
{
    public partial class frmThemHDB : Form
    {
        private ListViewExtender extender;
        private HoaDonBan HDB;
        private int idNV = 0;
        public frmThemHDB()
        {
            InitializeComponent();
            loadDSKhuyenMai();
            //isNew = true;
            extender = new ListViewExtender(lvDanhSach);
            HDB = new HoaDonBan();
            loadDanhSachSP();
            loadTongTien();
        }
        public frmThemHDB(int idnv, bool x)
        {
            InitializeComponent();
            loadDSKhuyenMai();
            idNV = idnv;
            extender = new ListViewExtender(lvDanhSach);
            HDB = new HoaDonBan();
            loadDanhSachSP();
            loadTongTien();
            loadNhanVien();
        }
        public frmThemHDB(int id)
        {
            InitializeComponent();
            loadDSKhuyenMai();
            //isNew = false;
            extender = new ListViewExtender(lvDanhSach);
            loadDanhSachSP();
            HDB = new HoaDonBan(id);
            loadChiTietHDB();
            loadKhachHang();
            loadNhanVien();
            loadTrangThai();
            loadKhuyenMai();
            loadTongTien();
            loadThanhToan();
           
        }
        private void loadDanhSachSP()
        {
            lvDanhSach.Clear();
            ColumnHeader colMaSP = new ColumnHeader() { Text = "Mã" };
            ColumnHeader colTenSP = new ColumnHeader() { Text = "Tên Sản Phẩm" };
            ColumnHeader colDonGia = new ColumnHeader() { Text = "Giá" };
            ColumnHeader colDonViDo = new ColumnHeader() { Text = "ĐVĐ" };
            ColumnHeader colConLai = new ColumnHeader() { Text = "Còn" };
            ColumnHeader colButtonChon = new ColumnHeader() { Text = "Chọn" };
            lvDanhSach.Columns.Add(colMaSP);
            lvDanhSach.Columns.Add(colTenSP);
            lvDanhSach.Columns.Add(colDonGia);
            lvDanhSach.Columns.Add(colDonViDo);
            lvDanhSach.Columns.Add(colConLai);
            lvDanhSach.Columns.Add(colButtonChon);
            DataTable dt = SanPhamControl.layDanhSach();
            ListViewButtonColumn btnChon = new ListViewButtonColumn(5);
            btnChon.Click += OnButtonActionClick;
            btnChon.FixedWidth = true;
            extender.AddColumn(btnChon);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem item = new ListViewItem(dt.Rows[i][0].ToString());
                ListViewItem.ListViewSubItem subitem = new ListViewItem.ListViewSubItem(item, dt.Rows[i][0].ToString());
                //ListViewItem status = new ListViewItem(dt.Rows[i][2].ToString());

                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = dt.Rows[i][1].ToString() });
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = dt.Rows[i][3].ToString() });
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = dt.Rows[i][4].ToString() });
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = dt.Rows[i][7].ToString() });
                
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = "+", Tag = dt.Rows[i][0].ToString() });
                lvDanhSach.Items.Add(item);

            }
            colMaSP.Width = 30;
            colTenSP.Width = 140;
            colDonGia.Width = 60;
            colDonViDo.Width = 50;
            colConLai.Width = 40;
            colButtonChon.Width = 40;

        }

        private void loadChiTietHDB()
        {
            dgvChiTiet.Rows.Clear();
            dgvChiTiet.AutoGenerateColumns = false;
            for(int i = 0; i < HDB.ChiTiet.ListSanPham.Count; ++i)
            {
                dgvChiTiet.Rows.Add(new object[] { HDB.ChiTiet.ListSanPham[i].TenSP, HDB.ChiTiet.ListSanPham[i].SoLuong, HDB.ChiTiet.ListSanPham[i].DonGia, HDB.ChiTiet.ListSanPham[i].DonGia * HDB.ChiTiet.ListSanPham[i].SoLuong });
                dgvChiTiet.Rows[dgvChiTiet.Rows.Count - 2].Tag = HDB.ChiTiet.ListSanPham[i].IdSP;
                //dgvChiTiet.Rows.Add()
            }

        }
        private void loadKhachHang()
        {
            if (HDB.TenKH.Length == 0)
            {
                lbTenKH.Text = "Khách vãng lai";
            }
            else
            {
                lbTenKH.Text = HDB.TenKH;
            }
        }
        private void loadNhanVien()
        {
            if(HDB.Id == 0)
            {
                HDB.TenNV = NhanVienControl.layTenNV(idNV);
            }
            if (HDB.TenNV.Length == 0)
            {
                lbTenNV.Text = "";
            }
            else
            {
                lbTenNV.Text = HDB.TenNV;
            }

        }
        private void loadTrangThai()
        {
            cbTrangThai.SelectedIndex = HDB.TrangThai - 1;
        }
        private void loadTongTien()
        {
            float tongTien = HDB.ChiTiet.tinhTongTien();
            //lbTongTien.Text = "" + string.Format("{}",tongTien);
            lbTongTien.Text = "" + tongTien;
        }
        private void loadDSKhuyenMai()
        {
            DataTable ds = KhuyenMaiControl.layDanhSach();
            for(int i = 0; i < ds.Rows.Count; ++i)
            {
                cbKhuyenMai.Items.Add(ds.Rows[i][1]);
            }
            cbKhuyenMai.Items.Add("-----none-----");
        }
        private void loadKhuyenMai()
        {
            if(HDB.TenKM.Length > 0)
            {
                cbKhuyenMai.SelectedItem = HDB.TenKM;
                return;
            }
            cbKhuyenMai.SelectedItem = "-----none-----";
        }
        private void loadThanhToan() 
        {
            // nếu cũ -> lấy trong bảng load lên
            lbThanhToan.Text = HDB.ThanhToan.ToString();
            // 
        }
        private void OnButtonActionClick(object sender, ListViewColumnMouseEventArgs e)
        {
            int id = Convert.ToInt32(e.SubItem.Tag);// lấy ra id sp được chọn
            HDB.ChiTiet.ThemSP(id);// thêm sp vào chi tiết sp

            loadChiTietHDB();
            loadTongTien();
        }

        private void dgvChiTiet_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex == -1)
            {
                return;
            }
            HDB.ChiTiet.xoaSP(Convert.ToInt32(dgvChiTiet.Rows[e.RowIndex].Tag));
            loadChiTietHDB();

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            
        }
    }
}
