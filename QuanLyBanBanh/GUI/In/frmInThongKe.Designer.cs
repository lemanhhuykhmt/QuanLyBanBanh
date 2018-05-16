namespace QuanLyBanBanh.GUI.In
{
    partial class frmInThongKe
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
            this.rpvThongKe = new Microsoft.Reporting.WinForms.ReportViewer();
            this.thongKeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsThongKe = new QuanLyBanBanh.DataSet.dsThongKe();
            this.thongKeTableAdapter = new QuanLyBanBanh.DataSet.dsThongKeTableAdapters.ThongKeTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.thongKeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsThongKe)).BeginInit();
            this.SuspendLayout();
            // 
            // rpvThongKe
            // 
            this.rpvThongKe.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "InThongKe";
            reportDataSource1.Value = this.thongKeBindingSource;
            this.rpvThongKe.LocalReport.DataSources.Add(reportDataSource1);
            this.rpvThongKe.LocalReport.ReportEmbeddedResource = "QuanLyBanBanh.Report.rpInThongKe.rdlc";
            this.rpvThongKe.Location = new System.Drawing.Point(0, 0);
            this.rpvThongKe.Name = "rpvThongKe";
            this.rpvThongKe.ServerReport.BearerToken = null;
            this.rpvThongKe.Size = new System.Drawing.Size(872, 536);
            this.rpvThongKe.TabIndex = 0;
            // 
            // thongKeBindingSource
            // 
            this.thongKeBindingSource.DataMember = "ThongKe";
            this.thongKeBindingSource.DataSource = this.dsThongKe;
            // 
            // dsThongKe
            // 
            this.dsThongKe.DataSetName = "dsThongKe";
            this.dsThongKe.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // thongKeTableAdapter
            // 
            this.thongKeTableAdapter.ClearBeforeFill = true;
            // 
            // frmInThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 536);
            this.Controls.Add(this.rpvThongKe);
            this.Name = "frmInThongKe";
            this.Text = "frmInThongKe";
            this.Load += new System.EventHandler(this.frmInThongKe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.thongKeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsThongKe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpvThongKe;
        private System.Windows.Forms.BindingSource thongKeBindingSource;
        private DataSet.dsThongKe dsThongKe;
        private DataSet.dsThongKeTableAdapters.ThongKeTableAdapter thongKeTableAdapter;
    }
}