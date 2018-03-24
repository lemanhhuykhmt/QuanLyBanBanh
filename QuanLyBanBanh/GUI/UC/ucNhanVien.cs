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
using QuanLyBanBanh.GUI.NhapLieu;

namespace QuanLyBanBanh.GUI.UC
{
    public partial class ucNhanVien : UserControl
    {
        public ucNhanVien()
        {
            InitializeComponent();
            loadDuLieu();
        }
        private void loadDuLieu()
        {
            lvDanhSach.Clear();// xóa mọi thứ trong listview
            ColumnHeader colMa = new ColumnHeader() { Text = "Mã" }; // tạo cột mã
            ColumnHeader colTen = new ColumnHeader() { Text = "Tên Nhân Viên" };
            ColumnHeader colSDT = new ColumnHeader() { Text = "Số Điện Thoại" };
            ColumnHeader colGioiTinh = new ColumnHeader() { Text = "Giới Tính" };
            ColumnHeader colNgaySinh = new ColumnHeader() { Text = "Ngày Sinh" };
            ColumnHeader colLuong = new ColumnHeader() { Text = "Lương" };
            ColumnHeader colButtonSua = new ColumnHeader() { Text = "Sửa" };
            ColumnHeader colButtonXoa = new ColumnHeader() { Text = "Xóa" };
            lvDanhSach.Columns.Add(colMa); // thêm cột mã vào list view
            lvDanhSach.Columns.Add(colTen);
            lvDanhSach.Columns.Add(colSDT);
            lvDanhSach.Columns.Add(colGioiTinh);
            lvDanhSach.Columns.Add(colNgaySinh);
            lvDanhSach.Columns.Add(colLuong);
            lvDanhSach.Columns.Add(colButtonSua);
            lvDanhSach.Columns.Add(colButtonXoa);
            string query = "select * from NhanVien";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query); // trả về kết quả
            ListViewExtender extender = new ListViewExtender(lvDanhSach); // nâng cấp listview thành listviewextender- code trên mạng
            ListViewButtonColumn buttonAction = new ListViewButtonColumn(6);// tạo button ở cột 5
            buttonAction.Click += OnButtonActionClick; // thêm sự kiện cho nó
            buttonAction.FixedWidth = true;
            extender.AddColumn(buttonAction);
            ListViewButtonColumn buttonAction1 = new ListViewButtonColumn(7);
            buttonAction1.Click += OnButtonActionClick1;
            buttonAction1.FixedWidth = true;
            extender.AddColumn(buttonAction1);
            for (int i = 0; i < dt.Rows.Count; i++) // với mỗi hàng 
            {
                ListViewItem item = new ListViewItem(dt.Rows[i][0].ToString()); // tạo 1 hàng, giá trị ô đầu là ...
                //ListViewItem.ListViewSubItem subitem = new ListViewItem.ListViewSubItem(item, dt.Rows[i][0].ToString());
                //ListViewItem status = new ListViewItem(dt.Rows[i][2].ToString());

                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = dt.Rows[i][1].ToString() });// giá trị cột 2
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = dt.Rows[i][2].ToString() }); //3
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = dt.Rows[i][3].ToString() }); //4
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = dt.Rows[i][4].ToString() }); //5
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = dt.Rows[i][5].ToString() }); //6
                // item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = dt.Rows[i][3].ToString() });
                //ListViewItem.ListViewSubItem subitem = new ListViewItem.ListViewSubItem();
                //ListViewExtender
                item.SubItems.Add("sua " + i); // 7
                item.SubItems.Add("xoa " + i); //8
                lvDanhSach.Items.Add(item);// thêm hàng vào list view

            }
            //dgv.DataSource = DataProvider.Instance.ExecuteQuery(query);
            colMa.Width = 45; // cài đặt kích thước cho 1 cột
            colTen.Width = 180;
            colGioiTinh.Width = 50;
            colSDT.Width = 130;
            colNgaySinh.Width = 100;
            colLuong.Width = 70;
            colButtonSua.Width = 40;
            colButtonXoa.Width = 40;
        }
        private void OnButtonActionClick(object sender, ListViewColumnMouseEventArgs e)
        {
            MessageBox.Show("you clicked " + e.SubItem.Text);
        }
        private void OnButtonActionClick1(object sender, ListViewColumnMouseEventArgs e)
        {
            MessageBox.Show("you clicked1 " + e.SubItem.Text);
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            frmThemNV f = new frmThemNV();
            f.ShowDialog();
            loadDuLieu();
        }
    }
}
