namespace QuanLyBanBanh.GUI
{
    partial class frmChinh
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuAdmin = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAdmin_QuanLyNV = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTaiKhoan = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTaiKhoan_ThongTin = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuTaiKhoan_DoiMK = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.lbChaoMung = new System.Windows.Forms.Label();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.tpThongKe = new System.Windows.Forms.TabPage();
            this.tpNhaCungCap = new System.Windows.Forms.TabPage();
            this.tpKhachHang = new System.Windows.Forms.TabPage();
            this.tpNhapKho = new System.Windows.Forms.TabPage();
            this.tpHangHoa = new System.Windows.Forms.TabPage();
            this.tpBanHang = new System.Windows.Forms.TabPage();
            this.tpHome = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb1 = new System.Windows.Forms.Label();
            this.tc1 = new System.Windows.Forms.TabControl();
            this.menuStrip1.SuspendLayout();
            this.tpHome.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tc1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAdmin,
            this.mnuTaiKhoan});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1227, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuAdmin
            // 
            this.mnuAdmin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAdmin_QuanLyNV});
            this.mnuAdmin.Name = "mnuAdmin";
            this.mnuAdmin.Size = new System.Drawing.Size(65, 24);
            this.mnuAdmin.Text = "Admin";
            this.mnuAdmin.Visible = false;
            // 
            // mnuAdmin_QuanLyNV
            // 
            this.mnuAdmin_QuanLyNV.Name = "mnuAdmin_QuanLyNV";
            this.mnuAdmin_QuanLyNV.Size = new System.Drawing.Size(201, 26);
            this.mnuAdmin_QuanLyNV.Text = "Quản lý nhân viên";
            this.mnuAdmin_QuanLyNV.Click += new System.EventHandler(this.mnuAdmin_QuanLyNV_Click);
            // 
            // mnuTaiKhoan
            // 
            this.mnuTaiKhoan.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuTaiKhoan_ThongTin,
            this.toolStripMenuItem1,
            this.mnuTaiKhoan_DoiMK,
            this.mnuDangXuat});
            this.mnuTaiKhoan.Name = "mnuTaiKhoan";
            this.mnuTaiKhoan.Size = new System.Drawing.Size(83, 24);
            this.mnuTaiKhoan.Text = "Tài khoản";
            // 
            // mnuTaiKhoan_ThongTin
            // 
            this.mnuTaiKhoan_ThongTin.Name = "mnuTaiKhoan_ThongTin";
            this.mnuTaiKhoan_ThongTin.Size = new System.Drawing.Size(202, 26);
            this.mnuTaiKhoan_ThongTin.Text = "Thông tin cá nhân";
            this.mnuTaiKhoan_ThongTin.Click += new System.EventHandler(this.mnuTaiKhoan_ThongTin_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(199, 6);
            // 
            // mnuTaiKhoan_DoiMK
            // 
            this.mnuTaiKhoan_DoiMK.Name = "mnuTaiKhoan_DoiMK";
            this.mnuTaiKhoan_DoiMK.Size = new System.Drawing.Size(202, 26);
            this.mnuTaiKhoan_DoiMK.Text = "Đổi mật khẩu";
            this.mnuTaiKhoan_DoiMK.Click += new System.EventHandler(this.mnuTaiKhoan_DoiMK_Click);
            // 
            // mnuDangXuat
            // 
            this.mnuDangXuat.Name = "mnuDangXuat";
            this.mnuDangXuat.Size = new System.Drawing.Size(202, 26);
            this.mnuDangXuat.Text = "Đăng xuất";
            this.mnuDangXuat.Click += new System.EventHandler(this.mnuDangXuat_Click);
            // 
            // lbChaoMung
            // 
            this.lbChaoMung.Location = new System.Drawing.Point(949, 32);
            this.lbChaoMung.Name = "lbChaoMung";
            this.lbChaoMung.Size = new System.Drawing.Size(130, 30);
            this.lbChaoMung.TabIndex = 2;
            this.lbChaoMung.Text = "Chào Mừng ....";
            this.lbChaoMung.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.BackColor = System.Drawing.SystemColors.Control;
            this.btnDangXuat.Location = new System.Drawing.Point(1085, 36);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(108, 26);
            this.btnDangXuat.TabIndex = 3;
            this.btnDangXuat.Text = "Đăng Xuất";
            this.btnDangXuat.UseVisualStyleBackColor = false;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // tpThongKe
            // 
            this.tpThongKe.Location = new System.Drawing.Point(4, 25);
            this.tpThongKe.Name = "tpThongKe";
            this.tpThongKe.Padding = new System.Windows.Forms.Padding(3);
            this.tpThongKe.Size = new System.Drawing.Size(1215, 650);
            this.tpThongKe.TabIndex = 7;
            this.tpThongKe.Text = "Thống Kê";
            this.tpThongKe.UseVisualStyleBackColor = true;
            // 
            // tpNhaCungCap
            // 
            this.tpNhaCungCap.Location = new System.Drawing.Point(4, 25);
            this.tpNhaCungCap.Name = "tpNhaCungCap";
            this.tpNhaCungCap.Padding = new System.Windows.Forms.Padding(3);
            this.tpNhaCungCap.Size = new System.Drawing.Size(1215, 650);
            this.tpNhaCungCap.TabIndex = 5;
            this.tpNhaCungCap.Text = "Nhà Cung Cấp";
            this.tpNhaCungCap.UseVisualStyleBackColor = true;
            // 
            // tpKhachHang
            // 
            this.tpKhachHang.Location = new System.Drawing.Point(4, 25);
            this.tpKhachHang.Name = "tpKhachHang";
            this.tpKhachHang.Padding = new System.Windows.Forms.Padding(3);
            this.tpKhachHang.Size = new System.Drawing.Size(1215, 650);
            this.tpKhachHang.TabIndex = 4;
            this.tpKhachHang.Text = "Khách Hàng";
            this.tpKhachHang.UseVisualStyleBackColor = true;
            // 
            // tpNhapKho
            // 
            this.tpNhapKho.Location = new System.Drawing.Point(4, 25);
            this.tpNhapKho.Name = "tpNhapKho";
            this.tpNhapKho.Padding = new System.Windows.Forms.Padding(3);
            this.tpNhapKho.Size = new System.Drawing.Size(1215, 650);
            this.tpNhapKho.TabIndex = 3;
            this.tpNhapKho.Text = "Nhập Kho";
            this.tpNhapKho.UseVisualStyleBackColor = true;
            // 
            // tpHangHoa
            // 
            this.tpHangHoa.Location = new System.Drawing.Point(4, 25);
            this.tpHangHoa.Name = "tpHangHoa";
            this.tpHangHoa.Padding = new System.Windows.Forms.Padding(3);
            this.tpHangHoa.Size = new System.Drawing.Size(1215, 650);
            this.tpHangHoa.TabIndex = 2;
            this.tpHangHoa.Text = "Hàng Hóa";
            this.tpHangHoa.UseVisualStyleBackColor = true;
            // 
            // tpBanHang
            // 
            this.tpBanHang.Location = new System.Drawing.Point(4, 25);
            this.tpBanHang.Name = "tpBanHang";
            this.tpBanHang.Padding = new System.Windows.Forms.Padding(3);
            this.tpBanHang.Size = new System.Drawing.Size(1215, 650);
            this.tpBanHang.TabIndex = 1;
            this.tpBanHang.Text = "Bán Hàng";
            this.tpBanHang.UseVisualStyleBackColor = true;
            // 
            // tpHome
            // 
            this.tpHome.Controls.Add(this.panel2);
            this.tpHome.Controls.Add(this.panel1);
            this.tpHome.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tpHome.Location = new System.Drawing.Point(4, 25);
            this.tpHome.Name = "tpHome";
            this.tpHome.Padding = new System.Windows.Forms.Padding(3);
            this.tpHome.Size = new System.Drawing.Size(1215, 650);
            this.tpHome.TabIndex = 0;
            this.tpHome.Text = "Home";
            this.tpHome.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(3, 144);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1209, 503);
            this.panel2.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.lb1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1209, 120);
            this.panel1.TabIndex = 0;
            // 
            // lb1
            // 
            this.lb1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb1.Location = new System.Drawing.Point(0, 0);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(1209, 120);
            this.lb1.TabIndex = 0;
            this.lb1.Text = "Chào Mừng Đến Với Ứng Dụng Quản Lý Cửa Hàng Bán Bánh";
            this.lb1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tc1
            // 
            this.tc1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tc1.Controls.Add(this.tpHome);
            this.tc1.Controls.Add(this.tpBanHang);
            this.tc1.Controls.Add(this.tpHangHoa);
            this.tc1.Controls.Add(this.tpNhapKho);
            this.tc1.Controls.Add(this.tpKhachHang);
            this.tc1.Controls.Add(this.tpNhaCungCap);
            this.tc1.Controls.Add(this.tpThongKe);
            this.tc1.Location = new System.Drawing.Point(0, 65);
            this.tc1.Name = "tc1";
            this.tc1.SelectedIndex = 0;
            this.tc1.Size = new System.Drawing.Size(1223, 679);
            this.tc1.TabIndex = 1;
            this.tc1.SelectedIndexChanged += new System.EventHandler(this.tc1_SelectedIndexChanged);
            // 
            // frmChinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1227, 739);
            this.Controls.Add(this.btnDangXuat);
            this.Controls.Add(this.lbChaoMung);
            this.Controls.Add(this.tc1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmChinh";
            this.Text = "frmChinh";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmChinh_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tpHome.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tc1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuTaiKhoan;
        private System.Windows.Forms.ToolStripMenuItem mnuTaiKhoan_ThongTin;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mnuTaiKhoan_DoiMK;
        private System.Windows.Forms.ToolStripMenuItem mnuDangXuat;
        private System.Windows.Forms.Label lbChaoMung;
        private System.Windows.Forms.Button btnDangXuat;
        private System.Windows.Forms.ToolStripMenuItem mnuAdmin;
        private System.Windows.Forms.ToolStripMenuItem mnuAdmin_QuanLyNV;
        private System.Windows.Forms.TabPage tpThongKe;
        private System.Windows.Forms.TabPage tpNhaCungCap;
        private System.Windows.Forms.TabPage tpKhachHang;
        private System.Windows.Forms.TabPage tpNhapKho;
        private System.Windows.Forms.TabPage tpHangHoa;
        private System.Windows.Forms.TabPage tpBanHang;
        private System.Windows.Forms.TabPage tpHome;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.TabControl tc1;
    }
}