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
    public partial class ucNhaCungCap : UserControl
    {
        public ucNhaCungCap()
        {
            InitializeComponent();
            loadDuLieu();
        }
        private void loadDuLieu()
        {
            lvDanhSach.Clear();// xóa mọi thứ trong listview
            ColumnHeader colMaKH = new ColumnHeader() { Text = "Mã" }; // tạo cột mã
            ColumnHeader colTenKH = new ColumnHeader() { Text = "Tên Nhà Phân Phối" };
            ColumnHeader colSDT = new ColumnHeader() { Text = "Số Điện Thoại" };
            ColumnHeader colDiaChi = new ColumnHeader() { Text = "Địa Chỉ" };           
            ColumnHeader colButtonSua = new ColumnHeader() { Text = "Sửa" };
            ColumnHeader colButtonXoa = new ColumnHeader() { Text = "Xóa" };
            lvDanhSach.Columns.Add(colMaKH); // thêm cột mã vào list view
            lvDanhSach.Columns.Add(colTenKH);
            lvDanhSach.Columns.Add(colSDT);
            lvDanhSach.Columns.Add(colDiaChi);            
            lvDanhSach.Columns.Add(colButtonSua);
            lvDanhSach.Columns.Add(colButtonXoa);
            string query = "select * from NhaPhanPhoi";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query); // trả về kết quả
            ListViewExtender extender = new ListViewExtender(lvDanhSach); // nâng cấp listview thành listviewextender- code trên mạng
            ListViewButtonColumn buttonAction = new ListViewButtonColumn(4);// tạo button ở cột 4
            buttonAction.Click += OnButtonActionClick; // thêm sự kiện cho nó
            buttonAction.FixedWidth = true;
            extender.AddColumn(buttonAction);
            ListViewButtonColumn buttonAction1 = new ListViewButtonColumn(5);
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
                // item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = dt.Rows[i][3].ToString() });
                //ListViewItem.ListViewSubItem subitem = new ListViewItem.ListViewSubItem();
                //ListViewExtender
                item.SubItems.Add("them " + i); // 5
                item.SubItems.Add("xoa " + i); //6
                lvDanhSach.Items.Add(item);// thêm hàng vào list view

            }
            //dgv.DataSource = DataProvider.Instance.ExecuteQuery(query);
            colMaKH.Width = 55; // cài đặt kích thước cho 1 cột
            colTenKH.Width = 250;
            colDiaChi.Width = 330;
            colSDT.Width = 150;
            colButtonSua.Width = 40;
            colButtonXoa.Width = 40;
        }
        private void OnButtonActionClick(object sender, ListViewColumnMouseEventArgs e)
        {
            MessageBox.Show(this, @"you clicked " + e.SubItem.Text);
        }
        private void OnButtonActionClick1(object sender, ListViewColumnMouseEventArgs e)
        {
            MessageBox.Show(this, @"you clicked1 " + e.SubItem.Text);
        }
        private void btnNhap_Click(object sender, EventArgs e)
        {
            frmThemKhachHang f = new frmThemKhachHang();
            f.ShowDialog();
            loadDuLieu();
        }


    }
}
