﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyBanBanh.GUI;
namespace QuanLyBanBanh
{
    static class Program
    {


        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);// taolahuy1612
            Application.Run(new frmDangNhap());
        }
    }
}
