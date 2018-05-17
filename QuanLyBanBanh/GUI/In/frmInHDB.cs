using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanBanh.GUI.In
{
    public partial class frmInHDB : Form
    {
        private int MaHDB;
        public frmInHDB()
        {
            InitializeComponent();
        }
        public frmInHDB(int id)
        {
            InitializeComponent();
            MaHDB = id;
        }
        private void frmInHDB_Load(object sender, EventArgs e)
        {
            ReportParameter rp = new ReportParameter("MaHDB");
            rp.Values.Add(MaHDB.ToString());
            reportViewer1.LocalReport.SetParameters(rp);
            // TODO: This line of code loads data into the 'dsHDB.ChiTietHDB' table. You can move, or remove it, as needed.
            this.chiTietHDBTableAdapter.Fill(this.dsHDB.ChiTietHDB, MaHDB);
            // TODO: This line of code loads data into the 'dsHDB.ThongTinHDB' table. You can move, or remove it, as needed.
            this.thongTinHDBTableAdapter.Fill(this.dsHDB.ThongTinHDB, MaHDB);

            this.reportViewer1.RefreshReport();
        }
    }
}
