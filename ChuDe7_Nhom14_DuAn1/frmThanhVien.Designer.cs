
namespace ChuDe7_Nhom14_DuAn1
{
    partial class frmThanhVien
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
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDiaChiNha = new System.Windows.Forms.Label();
            this.lblSTT = new System.Windows.Forms.Label();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.lblPhai = new System.Windows.Forms.Label();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.lblQuanHe = new System.Windows.Forms.Label();
            this.lbNgheNghiep = new System.Windows.Forms.Label();
            this.lblTrinhDo = new System.Windows.Forms.Label();
            this.cbDiaChiNha = new System.Windows.Forms.ComboBox();
            this.txtSTT = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.grpPhai = new System.Windows.Forms.GroupBox();
            this.rdoNu = new System.Windows.Forms.RadioButton();
            this.rdoNam = new System.Windows.Forms.RadioButton();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.txtQuanHe = new System.Windows.Forms.TextBox();
            this.lblDoiTuong = new System.Windows.Forms.Label();
            this.cbNgheNghiep = new System.Windows.Forms.ComboBox();
            this.cbTrinhDo = new System.Windows.Forms.ComboBox();
            this.cbDoiTuong = new System.Windows.Forms.ComboBox();
            this.lblQuyenSD = new System.Windows.Forms.Label();
            this.cbQuyenSD = new System.Windows.Forms.ComboBox();
            this.dgvThanhVien = new System.Windows.Forms.DataGridView();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnChinhSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnKhongLuu = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.grpPhai.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThanhVien)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.BackColor = System.Drawing.Color.AliceBlue;
            this.lblTieuDe.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieuDe.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblTieuDe.Location = new System.Drawing.Point(486, 9);
            this.lblTieuDe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(399, 43);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "Thông Tin Thành Viên ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(470, 41);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 22);
            this.label2.TabIndex = 1;
            // 
            // lblDiaChiNha
            // 
            this.lblDiaChiNha.AutoSize = true;
            this.lblDiaChiNha.BackColor = System.Drawing.Color.AliceBlue;
            this.lblDiaChiNha.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiaChiNha.Location = new System.Drawing.Point(212, 80);
            this.lblDiaChiNha.Name = "lblDiaChiNha";
            this.lblDiaChiNha.Size = new System.Drawing.Size(110, 23);
            this.lblDiaChiNha.TabIndex = 2;
            this.lblDiaChiNha.Text = "Địa chỉ nhà:";
            // 
            // lblSTT
            // 
            this.lblSTT.AutoSize = true;
            this.lblSTT.BackColor = System.Drawing.Color.AliceBlue;
            this.lblSTT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSTT.Location = new System.Drawing.Point(678, 82);
            this.lblSTT.Name = "lblSTT";
            this.lblSTT.Size = new System.Drawing.Size(145, 23);
            this.lblSTT.TabIndex = 3;
            this.lblSTT.Text = "STT thành viên:";
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.BackColor = System.Drawing.Color.AliceBlue;
            this.lblHoTen.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoTen.Location = new System.Drawing.Point(212, 130);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(78, 23);
            this.lblHoTen.TabIndex = 4;
            this.lblHoTen.Text = "Họ tên: ";
            // 
            // lblPhai
            // 
            this.lblPhai.AutoSize = true;
            this.lblPhai.BackColor = System.Drawing.Color.AliceBlue;
            this.lblPhai.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhai.Location = new System.Drawing.Point(678, 192);
            this.lblPhai.Name = "lblPhai";
            this.lblPhai.Size = new System.Drawing.Size(47, 23);
            this.lblPhai.TabIndex = 5;
            this.lblPhai.Text = "Phái";
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.BackColor = System.Drawing.Color.AliceBlue;
            this.lblNgaySinh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgaySinh.Location = new System.Drawing.Point(678, 137);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(104, 23);
            this.lblNgaySinh.TabIndex = 6;
            this.lblNgaySinh.Text = "Ngày sinh: ";
            // 
            // lblQuanHe
            // 
            this.lblQuanHe.AutoSize = true;
            this.lblQuanHe.BackColor = System.Drawing.Color.AliceBlue;
            this.lblQuanHe.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuanHe.Location = new System.Drawing.Point(212, 187);
            this.lblQuanHe.Name = "lblQuanHe";
            this.lblQuanHe.Size = new System.Drawing.Size(178, 23);
            this.lblQuanHe.TabIndex = 7;
            this.lblQuanHe.Text = "Quan hệ với chủ hộ:";
            // 
            // lbNgheNghiep
            // 
            this.lbNgheNghiep.AutoSize = true;
            this.lbNgheNghiep.BackColor = System.Drawing.Color.AliceBlue;
            this.lbNgheNghiep.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNgheNghiep.Location = new System.Drawing.Point(212, 245);
            this.lbNgheNghiep.Name = "lbNgheNghiep";
            this.lbNgheNghiep.Size = new System.Drawing.Size(121, 23);
            this.lbNgheNghiep.TabIndex = 8;
            this.lbNgheNghiep.Text = "Nghề nghiệp:";
            // 
            // lblTrinhDo
            // 
            this.lblTrinhDo.AutoSize = true;
            this.lblTrinhDo.BackColor = System.Drawing.Color.AliceBlue;
            this.lblTrinhDo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrinhDo.Location = new System.Drawing.Point(212, 296);
            this.lblTrinhDo.Name = "lblTrinhDo";
            this.lblTrinhDo.Size = new System.Drawing.Size(88, 23);
            this.lblTrinhDo.TabIndex = 9;
            this.lblTrinhDo.Text = "Trình độ:";
            // 
            // cbDiaChiNha
            // 
            this.cbDiaChiNha.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbDiaChiNha.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbDiaChiNha.FormattingEnabled = true;
            this.cbDiaChiNha.Location = new System.Drawing.Point(413, 82);
            this.cbDiaChiNha.Name = "cbDiaChiNha";
            this.cbDiaChiNha.Size = new System.Drawing.Size(216, 30);
            this.cbDiaChiNha.TabIndex = 10;
            // 
            // txtSTT
            // 
            this.txtSTT.Location = new System.Drawing.Point(844, 80);
            this.txtSTT.Name = "txtSTT";
            this.txtSTT.Size = new System.Drawing.Size(216, 30);
            this.txtSTT.TabIndex = 11;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(413, 130);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(216, 30);
            this.txtHoTen.TabIndex = 12;
            // 
            // grpPhai
            // 
            this.grpPhai.BackColor = System.Drawing.Color.AliceBlue;
            this.grpPhai.Controls.Add(this.rdoNu);
            this.grpPhai.Controls.Add(this.rdoNam);
            this.grpPhai.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPhai.Location = new System.Drawing.Point(844, 173);
            this.grpPhai.Name = "grpPhai";
            this.grpPhai.Size = new System.Drawing.Size(216, 58);
            this.grpPhai.TabIndex = 13;
            this.grpPhai.TabStop = false;
            // 
            // rdoNu
            // 
            this.rdoNu.AutoSize = true;
            this.rdoNu.Location = new System.Drawing.Point(126, 18);
            this.rdoNu.Name = "rdoNu";
            this.rdoNu.Size = new System.Drawing.Size(57, 27);
            this.rdoNu.TabIndex = 1;
            this.rdoNu.TabStop = true;
            this.rdoNu.Text = "Nữ";
            this.rdoNu.UseVisualStyleBackColor = true;
            // 
            // rdoNam
            // 
            this.rdoNam.AutoSize = true;
            this.rdoNam.Location = new System.Drawing.Point(23, 19);
            this.rdoNam.Name = "rdoNam";
            this.rdoNam.Size = new System.Drawing.Size(75, 27);
            this.rdoNam.TabIndex = 0;
            this.rdoNam.TabStop = true;
            this.rdoNam.Text = "Nam ";
            this.rdoNam.UseVisualStyleBackColor = true;
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.CustomFormat = "dd/MM/yyyy";
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgaySinh.Location = new System.Drawing.Point(844, 137);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(216, 30);
            this.dtpNgaySinh.TabIndex = 14;
            // 
            // txtQuanHe
            // 
            this.txtQuanHe.Location = new System.Drawing.Point(413, 187);
            this.txtQuanHe.Name = "txtQuanHe";
            this.txtQuanHe.Size = new System.Drawing.Size(216, 30);
            this.txtQuanHe.TabIndex = 15;
            // 
            // lblDoiTuong
            // 
            this.lblDoiTuong.AutoSize = true;
            this.lblDoiTuong.BackColor = System.Drawing.Color.AliceBlue;
            this.lblDoiTuong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoiTuong.Location = new System.Drawing.Point(676, 248);
            this.lblDoiTuong.Name = "lblDoiTuong";
            this.lblDoiTuong.Size = new System.Drawing.Size(106, 23);
            this.lblDoiTuong.TabIndex = 16;
            this.lblDoiTuong.Text = "Đối tượng: ";
            // 
            // cbNgheNghiep
            // 
            this.cbNgheNghiep.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbNgheNghiep.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbNgheNghiep.FormattingEnabled = true;
            this.cbNgheNghiep.Location = new System.Drawing.Point(413, 241);
            this.cbNgheNghiep.Name = "cbNgheNghiep";
            this.cbNgheNghiep.Size = new System.Drawing.Size(216, 30);
            this.cbNgheNghiep.TabIndex = 17;
            // 
            // cbTrinhDo
            // 
            this.cbTrinhDo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbTrinhDo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbTrinhDo.FormattingEnabled = true;
            this.cbTrinhDo.Location = new System.Drawing.Point(413, 296);
            this.cbTrinhDo.Name = "cbTrinhDo";
            this.cbTrinhDo.Size = new System.Drawing.Size(216, 30);
            this.cbTrinhDo.TabIndex = 18;
            // 
            // cbDoiTuong
            // 
            this.cbDoiTuong.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbDoiTuong.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbDoiTuong.FormattingEnabled = true;
            this.cbDoiTuong.Location = new System.Drawing.Point(844, 243);
            this.cbDoiTuong.Name = "cbDoiTuong";
            this.cbDoiTuong.Size = new System.Drawing.Size(216, 30);
            this.cbDoiTuong.TabIndex = 19;
            // 
            // lblQuyenSD
            // 
            this.lblQuyenSD.AutoSize = true;
            this.lblQuyenSD.BackColor = System.Drawing.Color.AliceBlue;
            this.lblQuyenSD.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuyenSD.Location = new System.Drawing.Point(678, 303);
            this.lblQuyenSD.Name = "lblQuyenSD";
            this.lblQuyenSD.Size = new System.Drawing.Size(78, 23);
            this.lblQuyenSD.TabIndex = 20;
            this.lblQuyenSD.Text = "Quyền: ";
            // 
            // cbQuyenSD
            // 
            this.cbQuyenSD.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbQuyenSD.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbQuyenSD.FormattingEnabled = true;
            this.cbQuyenSD.Location = new System.Drawing.Point(844, 296);
            this.cbQuyenSD.Name = "cbQuyenSD";
            this.cbQuyenSD.Size = new System.Drawing.Size(216, 30);
            this.cbQuyenSD.TabIndex = 21;
            // 
            // dgvThanhVien
            // 
            this.dgvThanhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThanhVien.Location = new System.Drawing.Point(99, 347);
            this.dgvThanhVien.Name = "dgvThanhVien";
            this.dgvThanhVien.RowHeadersWidth = 51;
            this.dgvThanhVien.RowTemplate.Height = 24;
            this.dgvThanhVien.Size = new System.Drawing.Size(1111, 357);
            this.dgvThanhVien.TabIndex = 22;
            this.dgvThanhVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvThanhVien_CellClick);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnThem.Location = new System.Drawing.Point(194, 710);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(128, 54);
            this.btnThem.TabIndex = 23;
            this.btnThem.Text = "Thêm ";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnChinhSua
            // 
            this.btnChinhSua.BackColor = System.Drawing.Color.Tomato;
            this.btnChinhSua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChinhSua.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnChinhSua.Location = new System.Drawing.Point(345, 713);
            this.btnChinhSua.Name = "btnChinhSua";
            this.btnChinhSua.Size = new System.Drawing.Size(125, 51);
            this.btnChinhSua.TabIndex = 24;
            this.btnChinhSua.Text = "Chỉnh Sửa";
            this.btnChinhSua.UseVisualStyleBackColor = false;
            this.btnChinhSua.Click += new System.EventHandler(this.btnChinhSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Coral;
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnXoa.Location = new System.Drawing.Point(490, 713);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(127, 51);
            this.btnXoa.TabIndex = 25;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnLuu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLuu.Location = new System.Drawing.Point(664, 715);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(118, 49);
            this.btnLuu.TabIndex = 26;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnKhongLuu
            // 
            this.btnKhongLuu.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnKhongLuu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKhongLuu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnKhongLuu.Location = new System.Drawing.Point(810, 715);
            this.btnKhongLuu.Name = "btnKhongLuu";
            this.btnKhongLuu.Size = new System.Drawing.Size(132, 49);
            this.btnKhongLuu.TabIndex = 27;
            this.btnKhongLuu.Text = "Không Lưu";
            this.btnKhongLuu.UseVisualStyleBackColor = false;
            this.btnKhongLuu.Click += new System.EventHandler(this.btnKhongLuu_Click);
            // 
            // btnDong
            // 
            this.btnDong.BackColor = System.Drawing.Color.SlateGray;
            this.btnDong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDong.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDong.Location = new System.Drawing.Point(961, 715);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(126, 49);
            this.btnDong.TabIndex = 28;
            this.btnDong.Text = "Đóng Form";
            this.btnDong.UseVisualStyleBackColor = false;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // frmThanhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ChuDe7_Nhom14_DuAn1.Properties.Resources.tree;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1283, 776);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnKhongLuu);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnChinhSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dgvThanhVien);
            this.Controls.Add(this.cbQuyenSD);
            this.Controls.Add(this.lblQuyenSD);
            this.Controls.Add(this.cbDoiTuong);
            this.Controls.Add(this.cbTrinhDo);
            this.Controls.Add(this.cbNgheNghiep);
            this.Controls.Add(this.lblDoiTuong);
            this.Controls.Add(this.txtQuanHe);
            this.Controls.Add(this.dtpNgaySinh);
            this.Controls.Add(this.grpPhai);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.txtSTT);
            this.Controls.Add(this.cbDiaChiNha);
            this.Controls.Add(this.lblTrinhDo);
            this.Controls.Add(this.lbNgheNghiep);
            this.Controls.Add(this.lblQuanHe);
            this.Controls.Add(this.lblNgaySinh);
            this.Controls.Add(this.lblPhai);
            this.Controls.Add(this.lblHoTen);
            this.Controls.Add(this.lblSTT);
            this.Controls.Add(this.lblDiaChiNha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTieuDe);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmThanhVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin thành viên";
            this.Load += new System.EventHandler(this.frmThanhVien_Load);
            this.grpPhai.ResumeLayout(false);
            this.grpPhai.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThanhVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDiaChiNha;
        private System.Windows.Forms.Label lblSTT;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.Label lblPhai;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.Label lblQuanHe;
        private System.Windows.Forms.Label lbNgheNghiep;
        private System.Windows.Forms.Label lblTrinhDo;
        private System.Windows.Forms.ComboBox cbDiaChiNha;
        private System.Windows.Forms.TextBox txtSTT;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.GroupBox grpPhai;
        private System.Windows.Forms.RadioButton rdoNam;
        private System.Windows.Forms.RadioButton rdoNu;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.TextBox txtQuanHe;
        private System.Windows.Forms.Label lblDoiTuong;
        private System.Windows.Forms.ComboBox cbNgheNghiep;
        private System.Windows.Forms.ComboBox cbTrinhDo;
        private System.Windows.Forms.ComboBox cbDoiTuong;
        private System.Windows.Forms.Label lblQuyenSD;
        private System.Windows.Forms.ComboBox cbQuyenSD;
        private System.Windows.Forms.DataGridView dgvThanhVien;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnChinhSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnKhongLuu;
        private System.Windows.Forms.Button btnDong;
    }
}