using QuanLyBanBanh.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyBanBanh.GUI.UC;

namespace QuanLyBanBanh.GUI
{
    public partial class frmChinh : Form
    {
        private int idNV;
        public delegate void delGuiThoat(bool thoatLuon);
        public delGuiThoat guiThoat;
        private bool dangXuat = false;
        public frmChinh()
        {
            InitializeComponent();
        }
        public frmChinh(string tenDangNhap)
        {
            InitializeComponent();
            lbChaoMung.Text = "Xin chào: " + tenDangNhap;
            // lấy id thông qua tenDangNhap
            idNV = (int) DataProvider.Instance.ExecuteScalar("select MaNV from Account where TenDangNhap = @tendangnhap", new object[] { tenDangNhap });
        }


        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            dangXuat = true;
            this.Close();
        }
        private void frmChinh_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (dangXuat == false)// thoát hẳn chương trình
            {
                DialogResult dr = MessageBox.Show("Bạn thực sự có muốn thoát?", "Thông báo!", MessageBoxButtons.OKCancel);
                if (dr == DialogResult.OK)
                {
                    guiThoat.Invoke(true);
                    dangXuat = true; // dùng tạm :v (đừng cố hiểu)
                    Application.Exit();
                }
                else
                {
                    e.Cancel = true;
                }      
            }
        }


        private void tc1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int tab = tc1.SelectedIndex;
            if (tab == 1)

            {
                ucHoaDonBan frm = new ucHoaDonBan(idNV);
                //frm.TopLevel = false;

                //frm.Parent = tc1.Controls[tc1.SelectedIndex];
                frm.Size = new Size(tc1.Controls[tc1.SelectedIndex].Width, tc1.Controls[tc1.SelectedIndex].Height);
                frm.Visible = true;
                tpBanHang.Controls.Add(frm);
            }
            if (tab == 2)

            {
                ucSanPham frm = new ucSanPham();
                //frm.TopLevel = false;

                //frm.Parent = tc1.Controls[tc1.SelectedIndex];
                frm.Size = new Size(tc1.Controls[tc1.SelectedIndex].Width, tc1.Controls[tc1.SelectedIndex].Height);
                frm.Visible = true;
                tpHangHoa.Controls.Add(frm);
            }
            else if (tab == 4)
            {
                ucKhachHang frm = new ucKhachHang();
                frm.Size = new Size(tc1.Controls[tab].Width, tc1.Controls[tab].Height);
                frm.Visible = true;
                tpKhachHang.Controls.Add(frm);
            }
            else if (tab == 5)
            {
                ucNhaCungCap frm = new ucNhaCungCap();
                frm.Size = new Size(tc1.Controls[tab].Width, tc1.Controls[tab].Height);
                frm.Visible = true;
                tpNhaCungCap.Controls.Add(frm);
            }
        }

        private void mnuAdminQuanLyNV_Click(object sender, EventArgs e)
        {
            frmAdmin f = new frmAdmin();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
    }
}
