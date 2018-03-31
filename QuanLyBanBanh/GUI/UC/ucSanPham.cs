using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyBanBanh.Controls;
using QuanLyBanBanh.Extender;
using QuanLyBanBanh.GUI.Sua;
using QuanLyBanBanh.GUI.NhapLieu;

namespace QuanLyBanBanh.GUI.UC
{
    public partial class ucSanPham : UserControl
    {
        private ListViewExtender extender;
        public ucSanPham()
        {
            InitializeComponent();
            extender = new ListViewExtender(lvDanhSach);
            loadDuLieu();
        }
        private void loadDuLieu()
        {
            lvDanhSach.Clear();
            ColumnHeader colMa = new ColumnHeader() { Text = "Mã" };
            ColumnHeader colTen = new ColumnHeader() { Text = "Tên Sản Phẩm" };
            ColumnHeader colLoai = new ColumnHeader() { Text = "Loại Sản Phẩm" };
            ColumnHeader colDonGia = new ColumnHeader() { Text = "Đơn Giá" };
            ColumnHeader colDonViDo = new ColumnHeader() { Text = "Đơn Vị" };
            ColumnHeader colHSD = new ColumnHeader() { Text = "HSD" };
            ColumnHeader colNSX = new ColumnHeader() { Text = "NSX" };
            ColumnHeader colSoLuong = new ColumnHeader() { Text = "SL" };
            ColumnHeader colButtonSua = new ColumnHeader() { Text = "Sửa" };
            ColumnHeader colButtonXoa = new ColumnHeader() { Text = "Xóa" };
            lvDanhSach.Columns.Add(colMa);
            lvDanhSach.Columns.Add(colTen);
            lvDanhSach.Columns.Add(colLoai);
            lvDanhSach.Columns.Add(colDonGia);
            lvDanhSach.Columns.Add(colDonViDo);
            lvDanhSach.Columns.Add(colHSD);
            lvDanhSach.Columns.Add(colNSX);
            lvDanhSach.Columns.Add(colSoLuong);
            lvDanhSach.Columns.Add(colButtonSua);
            lvDanhSach.Columns.Add(colButtonXoa);
            DataTable dt = SanPhamControl.layDanhSach();
            ListViewButtonColumn btnSua = new ListViewButtonColumn(8);
            btnSua.Click += OnButtonActionClick;
            btnSua.FixedWidth = true;
            extender.AddColumn(btnSua);
            ListViewButtonColumn btnXoa = new ListViewButtonColumn(9);
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
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = dt.Rows[i][4].ToString() });
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = String.Format("{0:dd/MM/yyyy}", dt.Rows[0][5]) });
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = String.Format("{0:dd/MM/yyyy}", dt.Rows[0][6]) });
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = dt.Rows[i][7].ToString() });

                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = "sửa", Tag = dt.Rows[i][0].ToString() });
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = "xoá", Tag = dt.Rows[i][0].ToString() });
                lvDanhSach.Items.Add(item);

            }
            colMa.Width = 40;
            colTen.Width = 160;
            colLoai.Width = 100;
            colDonGia.Width = 50;
            colDonViDo.Width = 40;
            colHSD.Width = 80;
            colNSX.Width = 80;
            colSoLuong.Width = 40;
            colButtonSua.Width = 40;
            colButtonXoa.Width = 40;
        }
        private void OnButtonActionClick(object sender, ListViewColumnMouseEventArgs e)
        {
            // lấy về id khách hàng
            int id = Convert.ToInt32(e.SubItem.Tag);
            // mở frm sửa
            frmSuaSP f = new frmSuaSP(id);//id
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
            frmThemSP f = new frmThemSP();
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
            ColumnHeader colMa = new ColumnHeader() { Text = "Mã" };
            ColumnHeader colTen = new ColumnHeader() { Text = "Tên Sản Phẩm" };
            ColumnHeader colLoai = new ColumnHeader() { Text = "Loại Sản Phẩm" };
            ColumnHeader colDonGia = new ColumnHeader() { Text = "Đơn Giá" };
            ColumnHeader colDonViDo = new ColumnHeader() { Text = "Đơn Vị" };
            ColumnHeader colHSD = new ColumnHeader() { Text = "HSD" };
            ColumnHeader colNSX = new ColumnHeader() { Text = "NSX" };
            ColumnHeader colSoLuong = new ColumnHeader() { Text = "Số Lượng" };
            ColumnHeader colButtonSua = new ColumnHeader() { Text = "Sửa" };
            ColumnHeader colButtonXoa = new ColumnHeader() { Text = "Xóa" };
            lvDanhSach.Columns.Add(colMa);
            lvDanhSach.Columns.Add(colTen);
            lvDanhSach.Columns.Add(colLoai);
            lvDanhSach.Columns.Add(colDonGia);
            lvDanhSach.Columns.Add(colDonViDo);
            lvDanhSach.Columns.Add(colHSD);
            lvDanhSach.Columns.Add(colNSX);
            lvDanhSach.Columns.Add(colSoLuong);
            lvDanhSach.Columns.Add(colButtonSua);
            lvDanhSach.Columns.Add(colButtonXoa);
            DataTable dt = SanPhamControl.layDanhSach();
            ListViewButtonColumn btnSua = new ListViewButtonColumn(8);
            btnSua.Click += OnButtonActionClick;
            btnSua.FixedWidth = true;
            extender.AddColumn(btnSua);
            ListViewButtonColumn btnXoa = new ListViewButtonColumn(9);
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
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = dt.Rows[i][4].ToString() });
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = dt.Rows[i][5].ToString() });
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = dt.Rows[i][6].ToString() });
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = dt.Rows[i][7].ToString() });

                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = "sửa", Tag = dt.Rows[i][0].ToString() });
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = "xoá", Tag = dt.Rows[i][0].ToString() });
                lvDanhSach.Items.Add(item);

            }
            colMa.Width = 60;
            colTen.Width = 200;
            colLoai.Width = 370;
            colDonGia.Width = 150;
            colDonViDo.Width = 60;
            colHSD.Width = 200;
            colNSX.Width = 370;
            colSoLuong.Width = 150;
            colButtonSua.Width = 40;
            colButtonXoa.Width = 40;
            //
        }
    }
}
