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
    public partial class ucTaiKhoan : UserControl
    {
        public ucTaiKhoan()
        {
            InitializeComponent();
            loadDuLieu();
        }
        private void loadDuLieu()
        {
            lvDanhSach.Clear();// xóa mọi thứ trong listview
            ColumnHeader colMa = new ColumnHeader() { Text = "Tên Đăng Nhập" }; // tạo cột mã
            ColumnHeader colTen = new ColumnHeader() { Text = "Tên Nhân Viên" };
            ColumnHeader colQuyen = new ColumnHeader() { Text = "Loại Truy Cập" };
            ColumnHeader colButtonSua = new ColumnHeader() { Text = "Sửa" };
            ColumnHeader colButtonXoa = new ColumnHeader() { Text = "Xóa" };
            lvDanhSach.Columns.Add(colMa); // thêm cột mã vào list view
            lvDanhSach.Columns.Add(colTen);
            lvDanhSach.Columns.Add(colQuyen);
            lvDanhSach.Columns.Add(colButtonSua);
            lvDanhSach.Columns.Add(colButtonXoa);
            string query = "select TenDangNhap, TenNV, Quyen from Account, NhanVien where Account.MaNV = NhanVien.MaNV";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query); // trả về kết quả
            ListViewExtender extender = new ListViewExtender(lvDanhSach); // nâng cấp listview thành listviewextender- code trên mạng
            ListViewButtonColumn buttonAction = new ListViewButtonColumn(3);// tạo button ở cột 4
            buttonAction.Click += OnButtonActionClick; // thêm sự kiện cho nó
            buttonAction.FixedWidth = true;
            extender.AddColumn(buttonAction);
            ListViewButtonColumn buttonAction1 = new ListViewButtonColumn(4);
            buttonAction1.Click += OnButtonActionClick1;
            buttonAction1.FixedWidth = true;
            extender.AddColumn(buttonAction1);
            for (int i = 0; i < dt.Rows.Count; i++) // với mỗi hàng 
            {
                ListViewItem item = new ListViewItem(dt.Rows[i][0].ToString()); // tạo 1 hàng, giá trị ô đầu là ...
                //ListViewItem.ListViewSubItem subitem = new ListViewItem.ListViewSubItem(item, dt.Rows[i][0].ToString());
                //ListViewItem status = new ListViewItem(dt.Rows[i][2].ToString());

                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = dt.Rows[i][1].ToString() });// giá trị cột 2

                int quyen = Convert.ToInt32(dt.Rows[i][2].ToString());
                string tenQuyen = "";
                if (quyen == 1) tenQuyen = "Admin";
                else if (quyen == 2) tenQuyen = "Bán Hàng";
                else if (quyen == 3) tenQuyen = "Nhập Kho";

                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = tenQuyen }); //3
                //item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = dt.Rows[i][3].ToString() }); //4
                //item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = dt.Rows[i][4].ToString() }); //5
                //item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = dt.Rows[i][5].ToString() }); //6
                // item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = dt.Rows[i][3].ToString() });
                //ListViewItem.ListViewSubItem subitem = new ListViewItem.ListViewSubItem();
                //ListViewExtender
                item.SubItems.Add("sua " + i); // 7
                item.SubItems.Add("xoa " + i); //8
                lvDanhSach.Items.Add(item);// thêm hàng vào list view

            }
            //dgv.DataSource = DataProvider.Instance.ExecuteQuery(query);
            colMa.Width = 200; // cài đặt kích thước cho 1 cột
            colTen.Width = 240;
            colQuyen.Width = 150;
            colButtonSua.Width = 60;
            colButtonXoa.Width = 60;
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
