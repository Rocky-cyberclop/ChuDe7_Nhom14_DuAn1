
namespace ChuDe7_Nhom14_DuAn1
{
    partial class frmNgheNghiep
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
            this.lblMaNN = new System.Windows.Forms.Label();
            this.lblTenNN = new System.Windows.Forms.Label();
            this.txtMaNN = new System.Windows.Forms.TextBox();
            this.txtTenNN = new System.Windows.Forms.TextBox();
            this.dgvNgheNghiep = new System.Windows.Forms.DataGridView();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnChinhSua = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnKhongLuu = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNgheNghiep)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieuDe.Location = new System.Drawing.Point(302, 9);
            this.lblTieuDe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(200, 37);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "Nghề Nghiệp";
            // 
            // lblMaNN
            // 
            this.lblMaNN.AutoSize = true;
            this.lblMaNN.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaNN.Location = new System.Drawing.Point(131, 91);
            this.lblMaNN.Name = "lblMaNN";
            this.lblMaNN.Size = new System.Drawing.Size(155, 23);
            this.lblMaNN.TabIndex = 1;
            this.lblMaNN.Text = "Mã nghề nghiệp: ";
            // 
            // lblTenNN
            // 
            this.lblTenNN.AutoSize = true;
            this.lblTenNN.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenNN.Location = new System.Drawing.Point(132, 145);
            this.lblTenNN.Name = "lblTenNN";
            this.lblTenNN.Size = new System.Drawing.Size(154, 23);
            this.lblTenNN.TabIndex = 2;
            this.lblTenNN.Text = "Tên nghề nghiệp:";
            // 
            // txtMaNN
            // 
            this.txtMaNN.Location = new System.Drawing.Point(309, 91);
            this.txtMaNN.Name = "txtMaNN";
            this.txtMaNN.Size = new System.Drawing.Size(204, 30);
            this.txtMaNN.TabIndex = 3;
            // 
            // txtTenNN
            // 
            this.txtTenNN.Location = new System.Drawing.Point(309, 145);
            this.txtTenNN.Name = "txtTenNN";
            this.txtTenNN.Size = new System.Drawing.Size(204, 30);
            this.txtTenNN.TabIndex = 4;
            // 
            // dgvNgheNghiep
            // 
            this.dgvNgheNghiep.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNgheNghiep.Location = new System.Drawing.Point(198, 216);
            this.dgvNgheNghiep.Name = "dgvNgheNghiep";
            this.dgvNgheNghiep.RowHeadersWidth = 51;
            this.dgvNgheNghiep.RowTemplate.Height = 24;
            this.dgvNgheNghiep.Size = new System.Drawing.Size(367, 225);
            this.dgvNgheNghiep.TabIndex = 5;
            this.dgvNgheNghiep.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNgheNghiep_CellClick);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(59, 234);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(108, 46);
            this.btnThem.TabIndex = 6;
            this.btnThem.Text = "Thêm ";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnChinhSua
            // 
            this.btnChinhSua.Location = new System.Drawing.Point(59, 300);
            this.btnChinhSua.Name = "btnChinhSua";
            this.btnChinhSua.Size = new System.Drawing.Size(108, 46);
            this.btnChinhSua.TabIndex = 7;
            this.btnChinhSua.Text = "Chỉnh Sửa";
            this.btnChinhSua.UseVisualStyleBackColor = true;
            this.btnChinhSua.Click += new System.EventHandler(this.btnChinhSua_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(581, 216);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(108, 46);
            this.btnLuu.TabIndex = 8;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(59, 377);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(108, 46);
            this.btnXoa.TabIndex = 9;
            this.btnXoa.Text = "Xóa ";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnKhongLuu
            // 
            this.btnKhongLuu.Location = new System.Drawing.Point(581, 300);
            this.btnKhongLuu.Name = "btnKhongLuu";
            this.btnKhongLuu.Size = new System.Drawing.Size(108, 46);
            this.btnKhongLuu.TabIndex = 10;
            this.btnKhongLuu.Text = "Không Lưu";
            this.btnKhongLuu.UseVisualStyleBackColor = true;
            this.btnKhongLuu.Click += new System.EventHandler(this.btnKhongLuu_Click);
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(581, 377);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(108, 46);
            this.btnDong.TabIndex = 11;
            this.btnDong.Text = "Đóng Form ";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // frmNgheNghiep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 496);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnKhongLuu);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnChinhSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dgvNgheNghiep);
            this.Controls.Add(this.txtTenNN);
            this.Controls.Add(this.txtMaNN);
            this.Controls.Add(this.lblTenNN);
            this.Controls.Add(this.lblMaNN);
            this.Controls.Add(this.lblTieuDe);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmNgheNghiep";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nghề nghiệp";
            this.Load += new System.EventHandler(this.frmNgheNghiep_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNgheNghiep)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Label lblMaNN;
        private System.Windows.Forms.Label lblTenNN;
        private System.Windows.Forms.TextBox txtMaNN;
        private System.Windows.Forms.TextBox txtTenNN;
        private System.Windows.Forms.DataGridView dgvNgheNghiep;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnChinhSua;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnKhongLuu;
        private System.Windows.Forms.Button btnDong;
    }
}