using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyBanBanh.Extender;
using QuanLyBanBanh.Controls;
using QuanLyBanBanh.GUI.Sua;
using QuanLyBanBanh.GUI.NhapLieu;

namespace QuanLyBanBanh.GUI.UC
{
    public partial class ucHoaDonBan : UserControl
    {
        private int idNV;
        private ListViewExtender extender;
        public ucHoaDonBan(int id)
        {
            InitializeComponent();
            extender = new ListViewExtender(lvDanhSach);
            loadDuLieu();
            idNV = id;
        }
        public ucHoaDonBan()
        {
            InitializeComponent();
            extender = new ListViewExtender(lvDanhSach);
            loadDuLieu();

        }
        private void loadDuLieu()
        {
            lvDanhSach.Clear();
            ColumnHeader colMaKH = new ColumnHeader() { Text = "Mã" };
            ColumnHeader colTenKH = new ColumnHeader() { Text = "Tên Khách Hàng" };
            ColumnHeader colTenNV = new ColumnHeader() { Text = "Tên Nhân Viên" };
            ColumnHeader colNgayLap = new ColumnHeader() { Text = "Ngày Lập" };
            ColumnHeader colTrangThai = new ColumnHeader() { Text = "Trạng Thái" };
            ColumnHeader colButtonSua = new ColumnHeader() { Text = "Sửa" };
            ColumnHeader colButtonXoa = new ColumnHeader() { Text = "Xóa" };
            lvDanhSach.Columns.Add(colMaKH);
            lvDanhSach.Columns.Add(colTenKH);
            lvDanhSach.Columns.Add(colTenNV);
            lvDanhSach.Columns.Add(colNgayLap);
            lvDanhSach.Columns.Add(colTrangThai);
            lvDanhSach.Columns.Add(colButtonSua);
            lvDanhSach.Columns.Add(colButtonXoa);
            DataTable dt = HoaDonBanControl.layDanhSach();
            ListViewButtonColumn btnSua = new ListViewButtonColumn(5);
            btnSua.Click += OnButtonActionClick;
            btnSua.FixedWidth = true;
            extender.AddColumn(btnSua);
            ListViewButtonColumn btnXoa = new ListViewButtonColumn(6);
            btnXoa.Click += OnButtonActionClick1;
            btnXoa.FixedWidth = true;
            extender.AddColumn(btnXoa);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem item = new ListViewItem(dt.Rows[i][0].ToString());
                ListViewItem.ListViewSubItem subitem = new ListViewItem.ListViewSubItem(item, dt.Rows[i][0].ToString());
                //ListViewItem status = new ListViewItem(dt.Rows[i][2].ToString());

                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = dt.Rows[i][1].ToString() });
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = dt.Rows[i][2].ToString() });
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = dt.Rows[i][3].ToString() });
                // thêm trạng thái vào cột
                int trangthai = Convert.ToInt16(dt.Rows[i][4].ToString());
                if(trangthai == 1)
                {
                    item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = "Đã Thanh Toán" });
                } else if(trangthai == 2)
                {
                    item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = "Đang Giao" });
                } else if (trangthai == 3)
                {
                    item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = "Chưa Đặt Tiền" });
                } else if (trangthai == 4)
                {
                    item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = "Hoàn Trả" });
                }
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = "sửa", Tag = dt.Rows[i][0].ToString() });
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = "xoá", Tag = dt.Rows[i][0].ToString() });
                lvDanhSach.Items.Add(item);

            }
            colMaKH.Width = 60;
            colTenKH.Width = 200;
            colTenNV.Width = 200;
            colNgayLap.Width = 150;
            colTrangThai.Width = 150;
            colButtonSua.Width = 40;
            colButtonXoa.Width = 40;
        }
        private void OnButtonActionClick(object sender, ListViewColumnMouseEventArgs e)
        {
            // lấy về id khách hàng
            int id = Convert.ToInt32(e.SubItem.Tag);
            // mở frm sửa
            frmThemHDB f = new frmThemHDB(id);
            f.ShowDialog();
            loadDuLieu();
        }
        private void OnButtonActionClick1(object sender, ListViewColumnMouseEventArgs e)
        {
            int id = Convert.ToInt32(e.SubItem.Tag);
            int ketQua = KhachHangControl.xoaThongTin(id);
            if (ketQua <= 0)
            {
                MessageBox.Show("Thực hiện thất bại");
            }
            else
            {
                loadDuLieu();
            }
        }
        private void btnNhap_Click(object sender, EventArgs e)
        {
            frmThemHDB f = new frmThemHDB(idNV, true);
            f.ShowDialog();
            loadDuLieu();
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            // lấy ra id của các kh cần xóa
            int ketQua = 0;
            for (int i = 0; i < lvDanhSach.CheckedIndices.Count; ++i)
            {
                ketQua += KhachHangControl.xoaThongTin(Convert.ToInt32(lvDanhSach.Items[lvDanhSach.CheckedIndices[i]].Text));
            }
            if (ketQua > 0)
            {
                MessageBox.Show("xóa thành công " + ketQua);
                loadDuLieu();
            }
            else
            {
                MessageBox.Show("xóa thất bại");
            }
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            // get text
            string value = txtTimKiem.Text;
            if (value.Length == 0)
            {
                loadDuLieu();
                return;
            }
            lvDanhSach.Clear();
            ColumnHeader colMaKH = new ColumnHeader() { Text = "Mã" };
            ColumnHeader colTenKH = new ColumnHeader() { Text = "Tên Khách Hàng" };
            ColumnHeader colTenNV = new ColumnHeader() { Text = "Tên Nhân Viên" };
            ColumnHeader colNgayLap = new ColumnHeader() { Text = "Ngày Lập" };
            ColumnHeader colTrangThai = new ColumnHeader() { Text = "Trạng Thái" };
            ColumnHeader colButtonSua = new ColumnHeader() { Text = "Sửa" };
            ColumnHeader colButtonXoa = new ColumnHeader() { Text = "Xóa" };
            lvDanhSach.Columns.Add(colMaKH);
            lvDanhSach.Columns.Add(colTenKH);
            lvDanhSach.Columns.Add(colTenNV);
            lvDanhSach.Columns.Add(colNgayLap);
            lvDanhSach.Columns.Add(colTrangThai);
            lvDanhSach.Columns.Add(colButtonSua);
            lvDanhSach.Columns.Add(colButtonXoa);
            DataTable dt = HoaDonBanControl.layDanhSach();// tìm kiếm

            ListViewButtonColumn btnSua = new ListViewButtonColumn(5);
            btnSua.Click += OnButtonActionClick;
            btnSua.FixedWidth = true;
            extender.AddColumn(btnSua);
            ListViewButtonColumn btnXoa = new ListViewButtonColumn(6);
            btnXoa.Click += OnButtonActionClick1;
            btnXoa.FixedWidth = true;
            extender.AddColumn(btnXoa);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem item = new ListViewItem(dt.Rows[i][0].ToString());
                ListViewItem.ListViewSubItem subitem = new ListViewItem.ListViewSubItem(item, dt.Rows[i][0].ToString());
                //ListViewItem status = new ListViewItem(dt.Rows[i][2].ToString());

                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = dt.Rows[i][1].ToString() });
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = dt.Rows[i][2].ToString() });
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = dt.Rows[i][3].ToString() });
                // thêm trạng thái vào cột
                int trangthai = Convert.ToInt16(dt.Rows[i][4].ToString());
                if (trangthai == 1)
                {
                    item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = "Đã Thanh Toán" });
                }
                else if (trangthai == 2)
                {
                    item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = "Đang Giao" });
                }
                else if (trangthai == 3)
                {
                    item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = "Chưa Đặt Tiền" });
                }
                else if (trangthai == 4)
                {
                    item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = "Hoàn Trả" });
                }
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = "sửa", Tag = dt.Rows[i][0].ToString() });
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = "xoá", Tag = dt.Rows[i][0].ToString() });
                lvDanhSach.Items.Add(item);

            }
            colMaKH.Width = 60;
            colTenKH.Width = 200;
            colTenNV.Width = 200;
            colNgayLap.Width = 150;
            colTrangThai.Width = 150;
            colButtonSua.Width = 40;
            colButtonXoa.Width = 40;
            //
        }
    }
}
