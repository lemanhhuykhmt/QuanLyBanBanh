using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyBanBanh.GUI.UC;

namespace QuanLyBanBanh.GUI
{
    public partial class frmAdmin : Form
    {
        public frmAdmin()
        {
            InitializeComponent();
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            pnlBang.Controls.Clear();
            ucNhanVien uc = new ucNhanVien();
            uc.Size = new Size(pnlBang.Width, pnlBang.Height);
            uc.Visible = true;
            pnlBang.Controls.Add(uc);
        }

        private void btnTaiKhoan_Click(object sender, EventArgs e)
        {
            pnlBang.Controls.Clear();
            ucTaiKhoan uc = new ucTaiKhoan();
            uc.Size = new Size(pnlBang.Width, pnlBang.Height);
            uc.Visible = true;
            pnlBang.Controls.Add(uc);
        }
    }
}
