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
    public partial class frmInThongKe : Form
    {
        private DateTime TuNgay;
        private DateTime DenNgay;
        public frmInThongKe()
        {
            InitializeComponent();
        }
        public frmInThongKe(DateTime tu, DateTime den)
        {
            InitializeComponent();
            TuNgay = tu;
            DenNgay = den;
        }
        private void frmInThongKe_Load(object sender, EventArgs e)
        {
            ReportParameter[] rp = new ReportParameter[2];
            rp[0] = new ReportParameter("TuNgay");
            rp[0].Values.Add(TuNgay.ToShortDateString());
            rp[1] = new ReportParameter("DenNgay");
            rp[1].Values.Add(DenNgay.ToShortDateString());
            rpvThongKe.LocalReport.SetParameters(rp);
            this.thongKeTableAdapter.Fill(dsThongKe.ThongKe, TuNgay, DenNgay);
            this.rpvThongKe.RefreshReport();
        }
    }
}
