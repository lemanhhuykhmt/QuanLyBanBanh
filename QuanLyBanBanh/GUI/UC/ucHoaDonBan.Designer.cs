namespace QuanLyBanBanh.GUI.UC
{
    partial class ucHoaDonBan
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
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.lvDanhSach = new System.Windows.Forms.ListView();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnNhap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(253, 14);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(97, 23);
            this.btnTimKiem.TabIndex = 11;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(49, 14);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(198, 22);
            this.txtTimKiem.TabIndex = 10;
            // 
            // lvDanhSach
            // 
            this.lvDanhSach.AllowColumnReorder = true;
            this.lvDanhSach.CheckBoxes = true;
            this.lvDanhSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvDanhSach.FullRowSelect = true;
            this.lvDanhSach.GridLines = true;
            this.lvDanhSach.Location = new System.Drawing.Point(8, 69);
            this.lvDanhSach.MultiSelect = false;
            this.lvDanhSach.Name = "lvDanhSach";
            this.lvDanhSach.Size = new System.Drawing.Size(1119, 491);
            this.lvDanhSach.TabIndex = 9;
            this.lvDanhSach.UseCompatibleStateImageBehavior = false;
            this.lvDanhSach.View = System.Windows.Forms.View.Details;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(818, 15);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 7;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnNhap
            // 
            this.btnNhap.Location = new System.Drawing.Point(724, 14);
            this.btnNhap.Name = "btnNhap";
            this.btnNhap.Size = new System.Drawing.Size(88, 23);
            this.btnNhap.TabIndex = 8;
            this.btnNhap.Text = "Thêm";
            this.btnNhap.UseVisualStyleBackColor = true;
            this.btnNhap.Click += new System.EventHandler(this.btnNhap_Click);
            // 
            // ucHoaDonBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.lvDanhSach);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnNhap);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ucHoaDonBan";
            this.Size = new System.Drawing.Size(1138, 594);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.ListView lvDanhSach;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnNhap;
    }
}
