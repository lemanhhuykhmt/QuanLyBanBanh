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
    public partial class frmDangNhap : Form
    {
        private bool thoatLuon = false; // để kiểm tra xem frm này thoát luôn hay không (false - hỏi trước khi thoát)
        public frmDangNhap()
        {
            InitializeComponent();
            
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmDangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (thoatLuon == false) // nếu k cần thoát luôn
            {
                if (MessageBox.Show("Bạn thực sự có muốn thoát?", "Thông báo!", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
                {
                    e.Cancel = true; // hủy đóng
                }
            }      
        }       
        private void btnDangNhap_Click(object sender, EventArgs e)
        { // cần thêm xử lý khi lấy string
            string tenDangNhap = txtDangNhap.Text;
            string matKhau = txtMatKhau.Text;
            int kiemTraDangNhap = KiemTraChuoiHopLe(tenDangNhap);
            int kiemTraMatKhau = KiemTraChuoiHopLe(matKhau);
            if ((kiemTraDangNhap + kiemTraMatKhau) == 0)
            {
                int loai = 0; // loại quyền hạn của acc
                if ((loai = AccountControl.Login(tenDangNhap, matKhau)) > 0) // kiểm tra trùng tên đn và mk không? và trả về quyền
                {
                    MoFormChinh(tenDangNhap); // gọi hàm mở frm chính
                }
                else
                {
                    //MessageBox.Show("đăng nhập sai!", "thông báo");
                    lbThongBao.Text = "Tên đăng nhập hoặc mật khẩu không chính xác!";
                    lbDangNhap.Text = "";
                    lbMatKhau.Text = "";
                    // hàm thực hiện khi đăng nhập sai
                }
            }
            else
            {
                string str = "";
                if(kiemTraDangNhap == 1)
                {
                    str = "Độ dài tên đăng nhập chuỗi không hợp lệ";
                    lbDangNhap.Text = "Vui lòng sử dụng từ 6 đến 30 ký tự";
                }
                else if(kiemTraDangNhap == 2)
                {
                    str = "Tên đăng nhập chứa chuỗi không hợp lệ";
                    lbDangNhap.Text = "Vui lòng chỉ sử dụng chữ cái (a-z), số và dấu chấm";
                }
                else if (kiemTraMatKhau == 1)
                {
                    str = "Độ dài mật khẩu kí tự không hợp lệ";
                    lbMatKhau.Text = "Vui lòng sử dụng từ 6 đến 30 ký tự";
                }
                else if (kiemTraMatKhau == 2)
                {
                    str = "Mật khẩu chứa kí tự không hợp lệ";
                    lbMatKhau.Text = "Vui lòng chỉ sử dụng chữ cái (a-z), số và dấu chấm";
                }
                lbThongBao.Text = str;
            }
            
        }
        private void MoFormChinh(string tenDangNhap)
        {
            this.Hide(); // ẩn frm đăng nhập
            frmChinh f = new frmChinh(tenDangNhap); // truyển loại quyền hạn acc cho frm Chính
            f.guiThoat = new frmChinh.delGuiThoat(doiThoatLuon); // gửi hàm "đổi thoát luôn" để closing của Chính có thể thay đổi
            f.ShowDialog(); // mở Chính
            this.Show(); // xong thì show lại
        }

        //////////////////////////////////////////////////////////////////////////
        private void doiThoatLuon(bool thoatNgay)
        {
            thoatLuon = thoatNgay;
        }
        private int KiemTraChuoiHopLe(string s)
        {
            s.Trim();
            if(s.Length < 3 || s.Length > 20)
            {
                return 1;
            }
            if (s.Contains("*") || s.Contains("!") || s.Contains("#"))
            {
                return 2;
            }
            return 0;
        }
    }
}
