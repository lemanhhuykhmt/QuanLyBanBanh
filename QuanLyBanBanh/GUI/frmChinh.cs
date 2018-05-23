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
using QuanLyBanBanh.GUI.Sua;

namespace QuanLyBanBanh.GUI
{
    public partial class frmChinh : Form
    {
        private string tenDangNhap;
        private int Quyen;
        private int idNV;
        public delegate void delGuiThoat(bool thoatLuon);
        public delGuiThoat guiThoat;
        private bool dangXuat = false;
        public frmChinh()
        {
            InitializeComponent();
        }
        public frmChinh(string ten)
        {
            InitializeComponent();
            tenDangNhap = ten;
            lbChaoMung.Text = "Xin chào: " + ten;
            // lấy id thông qua tenDangNhap
            idNV = (int) DataProvider.Instance.ExecuteScalar("select MaNV from Account where TenDangNhap = @tendangnhap", new object[] { tenDangNhap });
            
            PhanQuyen();
        }
        private void PhanQuyen()
        {
            // lấy quyền 
            Quyen = AccountControl.layQuyen(tenDangNhap);
            if(Quyen == 1) // admin
            {
                mnuAdmin.Visible = true;
            }
            else if(Quyen == 2) // ban hang
            {
                ((Control)tpThongKe).Enabled = false;
                ((Control)tpNhapKho).Enabled = false;
                tc1.TabPages.Remove(tpThongKe);
                tc1.TabPages.Remove(tpNhapKho);


            }
            else if (Quyen == 3) //kho
            {
                ((Control)tpThongKe).Enabled = false;
                ((Control)tpBanHang).Enabled = false;
                tc1.TabPages.Remove(tpThongKe);
                tc1.TabPages.Remove(tpBanHang);
            }
            else
            {

            }
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
            if (tc1.SelectedTab == tpBanHang)
            {
                if(Quyen == 3)
                {
                    return;
                }
                ucHoaDonBan frm = new ucHoaDonBan(idNV);
                //frm.TopLevel = false;

                //frm.Parent = tc1.Controls[tc1.SelectedIndex];
                frm.Size = new Size(tc1.Controls[tc1.SelectedIndex].Width, tc1.Controls[tc1.SelectedIndex].Height);
                frm.Visible = true;
                tpBanHang.Controls.Add(frm);
            }
            if (tc1.SelectedTab == tpHangHoa)
            {
                ucSanPham frm = new ucSanPham();
                //frm.TopLevel = false;

                //frm.Parent = tc1.Controls[tc1.SelectedIndex];
                frm.Size = new Size(tc1.Controls[tc1.SelectedIndex].Width, tc1.Controls[tc1.SelectedIndex].Height);
                frm.Visible = true;
                tpHangHoa.Controls.Add(frm);
            }
            else if (tc1.SelectedTab == tpKhachHang)
            {
                ucKhachHang frm = new ucKhachHang();
                frm.Size = new Size(tc1.Controls[tc1.SelectedIndex].Width, tc1.Controls[tc1.SelectedIndex].Height);
                frm.Visible = true;
                tpKhachHang.Controls.Add(frm);
            }
            else if (tc1.SelectedTab == tpBanHang)
            {
                ucNhaCungCap frm = new ucNhaCungCap();
                frm.Size = new Size(tc1.Controls[tc1.SelectedIndex].Width, tc1.Controls[tc1.SelectedIndex].Height);
                frm.Visible = true;
                tpNhaCungCap.Controls.Add(frm);
            }
            else if (tc1.SelectedTab == tpThongKe)
            {
                ucThongKe frm = new ucThongKe();
                frm.Size = new Size(tc1.Controls[tc1.SelectedIndex].Width, tc1.Controls[tc1.SelectedIndex].Height);
                frm.Visible = true;
                tpThongKe.Controls.Add(frm);
            }
        }

        private void mnuAdmin_QuanLyNV_Click(object sender, EventArgs e)
        {
            frmAdmin f = new frmAdmin();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void mnuDangXuat_Click(object sender, EventArgs e)
        {
            dangXuat = true;
            this.Close();
        }

        private void mnuTaiKhoan_ThongTin_Click(object sender, EventArgs e)
        {
            frmThongTinCaNhan frm = new frmThongTinCaNhan(idNV);
            frm.ShowDialog();
        }

        private void mnuTaiKhoan_DoiMK_Click(object sender, EventArgs e)
        {
            frmDoiMK frm = new frmDoiMK(tenDangNhap);
            frm.ShowDialog();
        }
    }
}
