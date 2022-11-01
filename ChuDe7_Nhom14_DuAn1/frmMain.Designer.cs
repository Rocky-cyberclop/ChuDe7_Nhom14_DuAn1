namespace ChuDe7_Nhom14_DuAn1
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.mnuQuanLyHoGiaDinh = new System.Windows.Forms.MenuStrip();
            this.mnuQuanLy = new System.Windows.Forms.ToolStripMenuItem();
            this.khómẤpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hộGiaĐìnhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thànhViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQuanTri = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDangNhap = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDoiMK = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHoTro = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGioiThieu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNgheNghiep = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQuanLyHoGiaDinh.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuQuanLyHoGiaDinh
            // 
            this.mnuQuanLyHoGiaDinh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.mnuQuanLyHoGiaDinh.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuQuanLyHoGiaDinh.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuQuanLyHoGiaDinh.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuQuanLy,
            this.mnuQuanTri,
            this.mnuHoTro});
            this.mnuQuanLyHoGiaDinh.Location = new System.Drawing.Point(0, 0);
            this.mnuQuanLyHoGiaDinh.Name = "mnuQuanLyHoGiaDinh";
            this.mnuQuanLyHoGiaDinh.Size = new System.Drawing.Size(945, 40);
            this.mnuQuanLyHoGiaDinh.TabIndex = 1;
            this.mnuQuanLyHoGiaDinh.Text = "menuStrip1";
            // 
            // mnuQuanLy
            // 
            this.mnuQuanLy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.mnuQuanLy.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.khómẤpToolStripMenuItem,
            this.hộGiaĐìnhToolStripMenuItem,
            this.thànhViênToolStripMenuItem,
            this.mnuNgheNghiep});
            this.mnuQuanLy.ForeColor = System.Drawing.Color.Navy;
            this.mnuQuanLy.Name = "mnuQuanLy";
            this.mnuQuanLy.Size = new System.Drawing.Size(126, 36);
            this.mnuQuanLy.Text = "Quản lý";
            // 
            // khómẤpToolStripMenuItem
            // 
            this.khómẤpToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.khómẤpToolStripMenuItem.Name = "khómẤpToolStripMenuItem";
            this.khómẤpToolStripMenuItem.Size = new System.Drawing.Size(224, 32);
            this.khómẤpToolStripMenuItem.Text = "Khóm ấp";
            this.khómẤpToolStripMenuItem.Click += new System.EventHandler(this.mnuHamlet_Click);
            // 
            // hộGiaĐìnhToolStripMenuItem
            // 
            this.hộGiaĐìnhToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hộGiaĐìnhToolStripMenuItem.Name = "hộGiaĐìnhToolStripMenuItem";
            this.hộGiaĐìnhToolStripMenuItem.Size = new System.Drawing.Size(224, 32);
            this.hộGiaĐìnhToolStripMenuItem.Text = "Hộ gia đình";
            this.hộGiaĐìnhToolStripMenuItem.Click += new System.EventHandler(this.mnuFamilies_Click);
            // 
            // thànhViênToolStripMenuItem
            // 
            this.thànhViênToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thànhViênToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.thànhViênToolStripMenuItem.Name = "thànhViênToolStripMenuItem";
            this.thànhViênToolStripMenuItem.Size = new System.Drawing.Size(224, 32);
            this.thànhViênToolStripMenuItem.Text = "Thành viên";
            this.thànhViênToolStripMenuItem.Click += new System.EventHandler(this.thànhViênToolStripMenuItem_Click);
            // 
            // mnuQuanTri
            // 
            this.mnuQuanTri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.mnuQuanTri.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDangNhap,
            this.mnuDangXuat,
            this.mnuDoiMK});
            this.mnuQuanTri.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.mnuQuanTri.Name = "mnuQuanTri";
            this.mnuQuanTri.Size = new System.Drawing.Size(133, 36);
            this.mnuQuanTri.Text = "Quản trị";
            // 
            // mnuDangNhap
            // 
            this.mnuDangNhap.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuDangNhap.Name = "mnuDangNhap";
            this.mnuDangNhap.Size = new System.Drawing.Size(231, 32);
            this.mnuDangNhap.Text = "Đăng nhập";
            this.mnuDangNhap.Click += new System.EventHandler(this.mnuDangNhap_Click);
            // 
            // mnuDangXuat
            // 
            this.mnuDangXuat.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuDangXuat.Name = "mnuDangXuat";
            this.mnuDangXuat.Size = new System.Drawing.Size(231, 32);
            this.mnuDangXuat.Text = "Đăng xuất";
            this.mnuDangXuat.Click += new System.EventHandler(this.mnuDangXuat_Click);
            // 
            // mnuDoiMK
            // 
            this.mnuDoiMK.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuDoiMK.Name = "mnuDoiMK";
            this.mnuDoiMK.Size = new System.Drawing.Size(231, 32);
            this.mnuDoiMK.Text = "Đổi mật khẩu";
            this.mnuDoiMK.Click += new System.EventHandler(this.mnuDoiMK_Click);
            // 
            // mnuHoTro
            // 
            this.mnuHoTro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.mnuHoTro.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuGioiThieu,
            this.mnuThoat});
            this.mnuHoTro.ForeColor = System.Drawing.Color.Red;
            this.mnuHoTro.Name = "mnuHoTro";
            this.mnuHoTro.Size = new System.Drawing.Size(109, 36);
            this.mnuHoTro.Text = "Hỗ trợ";
            // 
            // mnuGioiThieu
            // 
            this.mnuGioiThieu.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuGioiThieu.Name = "mnuGioiThieu";
            this.mnuGioiThieu.Size = new System.Drawing.Size(224, 32);
            this.mnuGioiThieu.Text = "Giới thiệu";
            this.mnuGioiThieu.Click += new System.EventHandler(this.mnuGioiThieu_Click);
            // 
            // mnuThoat
            // 
            this.mnuThoat.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuThoat.Name = "mnuThoat";
            this.mnuThoat.Size = new System.Drawing.Size(224, 32);
            this.mnuThoat.Text = "Thoát";
            this.mnuThoat.Click += new System.EventHandler(this.mnuThoat_Click);
            // 
            // mnuNgheNghiep
            // 
            this.mnuNgheNghiep.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuNgheNghiep.Name = "mnuNgheNghiep";
            this.mnuNgheNghiep.Size = new System.Drawing.Size(224, 32);
            this.mnuNgheNghiep.Text = "Nghề nghiệp";
            this.mnuNgheNghiep.Click += new System.EventHandler(this.mnuNgheNghiep_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ChuDe7_Nhom14_DuAn1.Properties.Resources.giadinh_background1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(945, 553);
            this.Controls.Add(this.mnuQuanLyHoGiaDinh);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mnuQuanLyHoGiaDinh;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.Text = "Quản lý hộ gia đình";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.mnuQuanLyHoGiaDinh.ResumeLayout(false);
            this.mnuQuanLyHoGiaDinh.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuQuanLyHoGiaDinh;
        public System.Windows.Forms.ToolStripMenuItem mnuQuanLy;
        public System.Windows.Forms.ToolStripMenuItem mnuQuanTri;
        public System.Windows.Forms.ToolStripMenuItem mnuDangNhap;
        public System.Windows.Forms.ToolStripMenuItem mnuDangXuat;
        public System.Windows.Forms.ToolStripMenuItem mnuDoiMK;
        public System.Windows.Forms.ToolStripMenuItem mnuHoTro;
        public System.Windows.Forms.ToolStripMenuItem mnuGioiThieu;
        public System.Windows.Forms.ToolStripMenuItem mnuThoat;
        public System.Windows.Forms.ToolStripMenuItem khómẤpToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem hộGiaĐìnhToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem thànhViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuNgheNghiep;
    }
}

