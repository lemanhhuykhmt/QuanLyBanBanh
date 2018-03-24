using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanBanh.Controls
{
    public class NhanVienControl
    {
        public static NhanVienControl instance;
        public static NhanVienControl Instance
        {
            get { if (instance == null) instance = new NhanVienControl();  return instance; }
            private set { instance = value; }
        }
    }
}
