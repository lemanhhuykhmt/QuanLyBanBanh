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
using QuanLyBanBanh.GUI.In;

namespace QuanLyBanBanh.GUI.UC
{
    public partial class ucThongKe : UserControl
    {
        public ucThongKe()
        {
            InitializeComponent();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            dgvDanhSach.Rows.Clear();
            long tongTien = 0;
            DateTime tu = dtpTu.Value;
            DateTime den = dtpDen.Value;
            DataTable dt = ThongKeControl.ThongKeSanPham(tu, den);
            for(int i = 0; i < dt.Rows.Count; ++i)
            {
                dgvDanhSach.Rows.Add(dt.Rows[i]["TenSP"], dt.Rows[i]["SoLuong"], dt.Rows[i]["TongTien"]);
                tongTien += long.Parse(dt.Rows[i]["TongTien"].ToString());
            }
            lbTongTien.Text = tongTien.ToString();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            frmInThongKe f = new frmInThongKe(dtpTu.Value, dtpDen.Value);
            f.ShowDialog();
        }
    }
}
