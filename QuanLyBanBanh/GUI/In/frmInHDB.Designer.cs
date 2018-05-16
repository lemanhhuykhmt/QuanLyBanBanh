namespace QuanLyBanBanh.GUI.In
{
    partial class frmInHDB
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.thongTinHDBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsHDB = new QuanLyBanBanh.DataSet.dsHDB();
            this.thongTinHDBTableAdapter = new QuanLyBanBanh.DataSet.dsHDBTableAdapters.ThongTinHDBTableAdapter();
            this.chiTietHDBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chiTietHDBTableAdapter = new QuanLyBanBanh.DataSet.dsHDBTableAdapters.ChiTietHDBTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.thongTinHDBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsHDB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chiTietHDBBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "dsThongTin";
            reportDataSource1.Value = this.thongTinHDBBindingSource;
            reportDataSource2.Name = "dsChiTiet";
            reportDataSource2.Value = this.chiTietHDBBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLyBanBanh.Report.rpInHDB.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(890, 582);
            this.reportViewer1.TabIndex = 0;
            // 
            // thongTinHDBBindingSource
            // 
            this.thongTinHDBBindingSource.DataMember = "ThongTinHDB";
            this.thongTinHDBBindingSource.DataSource = this.dsHDB;
            // 
            // dsHDB
            // 
            this.dsHDB.DataSetName = "dsHDB";
            this.dsHDB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // thongTinHDBTableAdapter
            // 
            this.thongTinHDBTableAdapter.ClearBeforeFill = true;
            // 
            // chiTietHDBBindingSource
            // 
            this.chiTietHDBBindingSource.DataMember = "ChiTietHDB";
            this.chiTietHDBBindingSource.DataSource = this.dsHDB;
            // 
            // chiTietHDBTableAdapter
            // 
            this.chiTietHDBTableAdapter.ClearBeforeFill = true;
            // 
            // frmInHDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 582);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmInHDB";
            this.Text = "frmInHDB";
            this.Load += new System.EventHandler(this.frmInHDB_Load);
            ((System.ComponentModel.ISupportInitialize)(this.thongTinHDBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsHDB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chiTietHDBBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DataSet.dsHDB dsHDB;
        private System.Windows.Forms.BindingSource thongTinHDBBindingSource;
        private DataSet.dsHDBTableAdapters.ThongTinHDBTableAdapter thongTinHDBTableAdapter;
        private System.Windows.Forms.BindingSource chiTietHDBBindingSource;
        private DataSet.dsHDBTableAdapters.ChiTietHDBTableAdapter chiTietHDBTableAdapter;
    }
}