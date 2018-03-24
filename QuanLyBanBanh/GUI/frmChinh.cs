﻿using QuanLyBanBanh.Controls;
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
        public delegate void delGuiThoat(bool thoatLuon);
        public delGuiThoat guiThoat;
        private bool dangXuat = false;
        public frmChinh()
        {
            InitializeComponent();
            loadData();
        }
        public frmChinh(int loai)
        {
            InitializeComponent();
            if (loai == 1) // admin
            {
               
            }
            else if (loai == 2) // bán hàng
            {
                pnAdmin.Enabled = false;
                pnKho.Enabled = false;
            }
            else if (loai == 3) // nhập kho
            {
                pnAdmin.Enabled = false;
                pnBanHang.Enabled = false;
            }
        }
        public void loadData()
        {

            string query = "select * from NhanVien";
            //dgvData.DataSource = DataProvider.Instance.ExecuteQuery(query);
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
                ucBanHang frm = new ucBanHang();
                //frm.TopLevel = false;

                //frm.Parent = tc1.Controls[tc1.SelectedIndex];
                frm.Size = new Size(tc1.Controls[tc1.SelectedIndex].Width, tc1.Controls[tc1.SelectedIndex].Height);
                frm.Visible = true;
                tpBanHang.Controls.Add(frm);
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

        }
    }
}
