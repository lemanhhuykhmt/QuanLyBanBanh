using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyBanBanh.GUI;
namespace QuanLyBanBanh
{
    static class Program
    {
        //branch huy
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);// taolahuy
            Application.Run(new frmDangNhap());
        }
    }
}
