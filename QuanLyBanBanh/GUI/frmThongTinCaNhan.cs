using QuanLyBanBanh.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanBanh.GUI
{
    public partial class frmThongTinCaNhan : Form
    {
        private int idNV;
        public frmThongTinCaNhan()
        {
            InitializeComponent();
        }
        public frmThongTinCaNhan(int id)
        {
            InitializeComponent();
            idNV = id;
        }
        private void loadDuLieu()
        {
            DataTable dt = NhanVienControl.layThongTin(idNV);
            txtTen.Text = dt.Rows[0][1].ToString();
            //dtpNgaySinh.Value = DateTime.Parse(String.Format("{0:dd/MM/yyyy}", dt.Rows[0][4]));
            dtpNgaySinh.Value = DateTime.Parse(dt.Rows[0][4].ToString());

            txtSDT.Text = dt.Rows[0][2].ToString();
            if(dt.Rows[0][3].ToString().Equals("Nam"))
            {
                cbGioiTinh.SelectedIndex = 0;
            }
            else
            {
                cbGioiTinh.SelectedIndex = 1;
            }
        }
        private void frmThongTinCaNhan_Load(object sender, EventArgs e)
        {

            loadDuLieu();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            string ten = txtTen.Text;
            string gioitinh = cbGioiTinh.Text;
            string ngaysinh = dtpNgaySinh.Text;
            string sdt = txtSDT.Text;
           // ngaysinh = String.Format("{0:yyyy/MM/dd}", ngaysinh);

            int ketQua = 0;
            ketQua = NhanVienControl.suaThongTin(idNV, ten, gioitinh, ngaysinh, sdt, 0);
            if (ketQua > 0)
            {
                MessageBox.Show("thay đổi thành công");
                loadDuLieu();
            }
        
        }
    }
}
