namespace QuanLyBanBanh.GUI.UC
{
    partial class ucTaiKhoan
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbLoaiTimKiem = new System.Windows.Forms.ComboBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ckbTatCa = new System.Windows.Forms.CheckBox();
            this.lvDanhSach = new System.Windows.Forms.ListView();
            this.btnThem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbLoaiTimKiem
            // 
            this.cbLoaiTimKiem.FormattingEnabled = true;
            this.cbLoaiTimKiem.Items.AddRange(new object[] {
            "Tất cả",
            "Họ Tên",
            "Ngày Sinh",
            "Lương",
            "Số Điện Thoại"});
            this.cbLoaiTimKiem.Location = new System.Drawing.Point(389, 67);
            this.cbLoaiTimKiem.Name = "cbLoaiTimKiem";
            this.cbLoaiTimKiem.Size = new System.Drawing.Size(137, 24);
            this.cbLoaiTimKiem.TabIndex = 24;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(555, 23);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(40, 22);
            this.btnTimKiem.TabIndex = 23;
            this.btnTimKiem.Text = "button2";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(389, 23);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(146, 22);
            this.textBox1.TabIndex = 22;
            // 
            // ckbTatCa
            // 
            this.ckbTatCa.AutoSize = true;
            this.ckbTatCa.Location = new System.Drawing.Point(6, 70);
            this.ckbTatCa.Name = "ckbTatCa";
            this.ckbTatCa.Size = new System.Drawing.Size(102, 21);
            this.ckbTatCa.TabIndex = 21;
            this.ckbTatCa.Text = "Chọn tất cả";
            this.ckbTatCa.UseVisualStyleBackColor = true;
            // 
            // lvDanhSach
            // 
            this.lvDanhSach.CheckBoxes = true;
            this.lvDanhSach.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvDanhSach.FullRowSelect = true;
            this.lvDanhSach.GridLines = true;
            this.lvDanhSach.Location = new System.Drawing.Point(6, 96);
            this.lvDanhSach.Name = "lvDanhSach";
            this.lvDanhSach.Size = new System.Drawing.Size(944, 491);
            this.lvDanhSach.TabIndex = 20;
            this.lvDanhSach.UseCompatibleStateImageBehavior = false;
            this.lvDanhSach.View = System.Windows.Forms.View.Details;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(738, 14);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(107, 40);
            this.btnThem.TabIndex = 19;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 68);
            this.label1.TabIndex = 18;
            this.label1.Text = "Danh Sách Tài Khoản";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ucTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cbLoaiTimKiem);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ckbTatCa);
            this.Controls.Add(this.lvDanhSach);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label1);
            this.Name = "ucTaiKhoan";
            this.Size = new System.Drawing.Size(962, 591);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbLoaiTimKiem;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox ckbTatCa;
        private System.Windows.Forms.ListView lvDanhSach;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label1;
    }
}
