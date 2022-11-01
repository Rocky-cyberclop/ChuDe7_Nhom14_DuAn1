using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChuDe7_Nhom14_DuAn1
{


    public partial class frmThanhVien : Form
    {
        DataTable dtDoiTuong = new DataTable("DoiTuong");
        DataTable dtHoGiaDinh = new DataTable("HoGiaDinh");
        DataTable dtKhomAp = new DataTable("KhomAp");
        DataTable dtNgheNghiep = new DataTable("NgheNghiep");
        DataTable dtThanhVien = new DataTable("ThanhVien");
        DataTable dtTrinhDo = new DataTable("TrinhDo");
        DataTable dtQuyenSD = new DataTable("QuyenSD");
        bool blnThem = false;

        public frmThanhVien()
        {
            InitializeComponent();
        }

        void GanDuLieu()
        {
            if (dtThanhVien.Rows.Count > 0)
            {
                cbDiaChiNha.SelectedValue = dgvThanhVien[0, dgvThanhVien.CurrentRow.Index].Value.ToString();
                txtSTT.Text = dgvThanhVien[1, dgvThanhVien.CurrentRow.Index].Value.ToString();
                txtHoTen.Text = dgvThanhVien[2, dgvThanhVien.CurrentRow.Index].Value.ToString();

                if (dgvThanhVien[3, dgvThanhVien.CurrentRow.Index].Value.ToString() == "True")
                    rdoNam.Checked = true;
                else
                    rdoNu.Checked = true;

                dtpNgaySinh.Value = DateTime.Parse(dgvThanhVien[4, dgvThanhVien.CurrentRow.Index].Value.ToString());
                txtQuanHe.Text = dgvThanhVien[5, dgvThanhVien.CurrentRow.Index].Value.ToString();
                cbNgheNghiep.SelectedValue = dgvThanhVien[6, dgvThanhVien.CurrentRow.Index].Value.ToString();
                cbTrinhDo.SelectedValue = dgvThanhVien[7, dgvThanhVien.CurrentRow.Index].Value.ToString();
                cbDoiTuong.SelectedValue = dgvThanhVien[8, dgvThanhVien.CurrentRow.Index].Value.ToString();

                cbQuyenSD.SelectedValue = dgvThanhVien[10, dgvThanhVien.CurrentRow.Index].Value.ToString();
            }
            else
            {
                btnChinhSua.Enabled = false;
                btnXoa.Enabled = false;
                txtHoTen.Clear();
                txtQuanHe.Clear();
                txtSTT.Clear();
                rdoNam.Checked = true;
                dtpNgaySinh.Value = DateTime.Today;
                cbDoiTuong.SelectedIndex = -1;
                cbDiaChiNha.SelectedIndex = -1;
                cbNgheNghiep.SelectedIndex = -1;
                cbQuyenSD.SelectedIndex = -1;
                cbTrinhDo.SelectedIndex = -1;



            }
        }

        private void frmThanhVien_Load(object sender, EventArgs e)
        {
            string strSelect = "Select * From ThanhVien";
            MyPublics.OpenData(strSelect, dtThanhVien);


            strSelect = "Select MaHo, DiaChiNha From HoGiaDinh";
            MyPublics.OpenData(strSelect, dtHoGiaDinh);
            cbDiaChiNha.DataSource = dtHoGiaDinh;
            cbDiaChiNha.DisplayMember = "DiaChiNha";
            cbDiaChiNha.ValueMember = "MaHo";
            cbDiaChiNha.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbDiaChiNha.AutoCompleteSource = AutoCompleteSource.ListItems;

            dtQuyenSD.Columns.Add("QuyenSD");
            dtQuyenSD.Rows.Add("User");
            dtQuyenSD.Rows.Add("Admin");
            cbQuyenSD.DataSource = dtQuyenSD;
            cbQuyenSD.DisplayMember = "QuyenSD";
            cbQuyenSD.ValueMember = "QuyenSD";

            strSelect = "Select MaNgheNghiep , TenNgheNghiep From NgheNghiep";
            MyPublics.OpenData(strSelect, dtNgheNghiep);
            cbNgheNghiep.DataSource = dtNgheNghiep;
            cbNgheNghiep.DisplayMember = "TenNgheNghiep";
            cbNgheNghiep.ValueMember = "MaNgheNghiep";
            cbNgheNghiep.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbNgheNghiep.AutoCompleteSource = AutoCompleteSource.ListItems;

            strSelect = "Select MaTrinhDo, DienGiai From TrinhDo";
            MyPublics.OpenData(strSelect, dtTrinhDo);
            cbTrinhDo.DataSource = dtTrinhDo;
            cbTrinhDo.DisplayMember = "DienGiai";
            cbTrinhDo.ValueMember = "MaTrinhDo";
            cbTrinhDo.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbTrinhDo.AutoCompleteSource = AutoCompleteSource.ListItems;


            strSelect = "Select MaDoiTuong , TenDoiTuong From DoiTuong";
            MyPublics.OpenData(strSelect, dtDoiTuong);
            cbDoiTuong.DataSource = dtDoiTuong;
            cbDoiTuong.DisplayMember = "TenDoiTuong";
            cbDoiTuong.ValueMember = "MaDoiTuong";
            cbDoiTuong.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbDoiTuong.AutoCompleteSource = AutoCompleteSource.ListItems;

            dgvThanhVien.DataSource = dtThanhVien;
            dgvThanhVien.Width = 1100;
            dgvThanhVien.AllowUserToAddRows = false;
            dgvThanhVien.AllowUserToDeleteRows = false;
            dgvThanhVien.Columns[0].Width = 85;
            dgvThanhVien.Columns[0].HeaderText = "Mã hộ";

            dgvThanhVien.Columns[1].Width = 85;
            dgvThanhVien.Columns[1].HeaderText = "Thành viên thứ";

            dgvThanhVien.Columns[2].Width = 200;
            dgvThanhVien.Columns[2].HeaderText = "Họ Tên ";

            dgvThanhVien.Columns[3].Width = 60;
            dgvThanhVien.Columns[3].HeaderText = "Phái";

            dgvThanhVien.Columns[4].Width = 100;
            dgvThanhVien.Columns[4].HeaderText = "Ngày sinh";

            dgvThanhVien.Columns[5].Width = 100;
            dgvThanhVien.Columns[5].HeaderText = "Vai trò";

            dgvThanhVien.Columns[6].Width = 100;
            dgvThanhVien.Columns[6].HeaderText = "Nghề nghiệp";

            dgvThanhVien.Columns[7].Width = 100;
            dgvThanhVien.Columns[7].HeaderText = "Trình Độ";

            dgvThanhVien.Columns[8].Width = 100;
            dgvThanhVien.Columns[8].HeaderText = "Đối tượng";

            dgvThanhVien.Columns[6].Visible = false;

            dgvThanhVien.Columns[10].Width = 100;
            dgvThanhVien.Columns[10].HeaderText = "Quyền SD";
            dgvThanhVien.EditMode = DataGridViewEditMode.EditProgrammatically;
            GanDuLieu();
            DieuKhienKhiBinhThuong();
        }




        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            blnThem = true;
            DieuKhienKhiThem();
        }



        private void btnChinhSua_Click(object sender, EventArgs e)
        {
            DieuKhienKhiChinhSua();
        }


        void ThucThiLuu()
        {
            string strSql, strPhai = "True", strMatKhau = "", strQuyenSD, strMaHo, strMaNN, strMaTrinhDo, strMaDoiTuong;

            if (blnThem)
            {
                strSql = "Insert Into ThanhVien Values (@MaHo, @SttThanhVien,@HoTenThanhVien, @Phai,  @NgaySinh, @QuanHeVoiChuHo, @MaNgheNghiep, @MaTrinhDo, @MaDoiTuong, @MatKhau, @QuyenSD)";

            }
            else
                strSql = "Update ThanhVien Set HoTenThanhVien= @HoTenThanhVien, Phai=@Phai,  NgaySinh= @NgaySinh, QuanHeVoiChuHo= @QuanHeVoiChuHo, MaNgheNghiep=@MaNgheNghiep,MaTrinhDo=@MaTrinhDo, MaDoiTuong=@MaDoiTuong, QuyenSD= @QuyenSD Where MaHo=@MaHo And SttThanhVien= @SttThanhVien";

            if (MyPublics.conMyConnection.State == ConnectionState.Closed)
                MyPublics.conMyConnection.Open();

            SqlCommand cmdCommand = new SqlCommand(strSql, MyPublics.conMyConnection);

            strMaHo = cbDiaChiNha.SelectedValue.ToString();
            cmdCommand.Parameters.AddWithValue("@MaHo", strMaHo);
            cmdCommand.Parameters.AddWithValue("@SttThanhVien", txtSTT.Text);
            cmdCommand.Parameters.AddWithValue("@HoTenThanhVien", txtHoTen.Text);

            if (rdoNu.Checked)
                strPhai = "False";
            cmdCommand.Parameters.AddWithValue("@Phai", strPhai);
            cmdCommand.Parameters.AddWithValue("@NgaySinh", dtpNgaySinh.Value);
            cmdCommand.Parameters.AddWithValue("@QuanHeVoiChuHo", txtQuanHe.Text);
            strMaNN = cbNgheNghiep.SelectedValue.ToString();
            cmdCommand.Parameters.AddWithValue("@MaNgheNghiep", strMaNN);
            strMaTrinhDo = cbTrinhDo.SelectedValue.ToString();
            cmdCommand.Parameters.AddWithValue("@MaTrinhDo", strMaTrinhDo);
            strMaDoiTuong = cbDoiTuong.SelectedValue.ToString();
            cmdCommand.Parameters.AddWithValue("@MaDoiTuong", strMaDoiTuong);

            strMatKhau = txtSTT.Text;
            cmdCommand.Parameters.AddWithValue("@MatKhau", strMatKhau);
            strQuyenSD = cbQuyenSD.SelectedValue.ToString();
            cmdCommand.Parameters.AddWithValue("@QuyenSD", strQuyenSD);

            cmdCommand.ExecuteNonQuery();
            MyPublics.conMyConnection.Close();


            if (blnThem)
            {
                dtThanhVien.Rows.Add(strMaHo, txtSTT.Text, txtHoTen.Text, strPhai, dtpNgaySinh.Value, txtQuanHe.Text, strMaNN, strMaTrinhDo, strMaDoiTuong, strMatKhau, strQuyenSD);
                GanDuLieu();
                blnThem = false;
            }
            else
            {
                int curRow = dgvThanhVien.CurrentRow.Index;
                //dtThanhVien.Rows[curRow][1] = txtSTT.Text;
                dtThanhVien.Rows[curRow][2] = txtHoTen.Text;
                dtThanhVien.Rows[curRow][3] = strPhai;
                dtThanhVien.Rows[curRow][4] = dtpNgaySinh.Value;
                dtThanhVien.Rows[curRow][5] = txtQuanHe.Text;
                dtThanhVien.Rows[curRow][6] = strMaNN;
                dtThanhVien.Rows[curRow][7] = strMaTrinhDo;
                dtThanhVien.Rows[curRow][8] = strMaDoiTuong;
                dtThanhVien.Rows[curRow][9] = strQuyenSD;
            }
            DieuKhienKhiBinhThuong();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtHoTen.Text == "")
            {
                MessageBox.Show("Lỗi chưa nhập tên thành viên !", "Thông báo");
                txtHoTen.Focus();
                return;
            }
            if (txtQuanHe.Text == "")
            {
                MessageBox.Show("Lỗi chưa nhập quan hệ với chủ hộ !", "Thông báo");
                txtQuanHe.Focus();
                return;
            }
            if (txtSTT.Text == "")
            {
                MessageBox.Show("Lỗi chưa nhập STT thành viên !", "Thông báo");
                txtSTT.Focus();
                return;
            }
            if (cbDiaChiNha.SelectedIndex == -1)
            {
                MessageBox.Show("Lỗi chưa chọn địa chỉ nhà!", "Thông báo");
                cbDiaChiNha.Focus();
                return;
            }

            if (cbDoiTuong.SelectedIndex == -1)
            {
                MessageBox.Show("Lỗi chưa chọn đối tượng !", "Thông báo");
                cbDoiTuong.Focus();
                return;

            }

            if (cbNgheNghiep.SelectedIndex == -1)
            {
                MessageBox.Show("Lỗi chưa chọn nghề nghiệp!", "Thông báo");
                cbNgheNghiep.Focus();
                return;
            }

            if (cbTrinhDo.SelectedIndex == -1)
            {
                MessageBox.Show("Lỗi chưa chọn trình độ!", "Thông báo");
                cbTrinhDo.Focus();
                return;
            }

            if (cbQuyenSD.SelectedIndex == -1)
            {
                MessageBox.Show("Lỗi chưa chọn quyền sủ dụng!", "Thông báo");
                cbQuyenSD.Focus();
                return;
            }


            string strMaHo = cbDiaChiNha.SelectedValue.ToString();
            if (blnThem && MyPublics.TonTaiKhoaChinh(strMaHo, "MaHo", "ThanhVien") && MyPublics.TonTaiKhoaChinh(txtSTT.Text, "SttThanhVien", "ThanhVien"))
            {
                MessageBox.Show("Thành viên này đã tồn tại!", "Thông báo");
                cbDiaChiNha.Focus();
                return;

            }
            else
                ThucThiLuu();
        }

        private void btnKhongLuu_Click(object sender, EventArgs e)
        {
            blnThem = false;
            GanDuLieu();
            DieuKhienKhiBinhThuong();
        }

        void DieuKhienKhiThem()
        {
            btnThem.Enabled = false;
            btnChinhSua.Enabled = false;
            btnLuu.Enabled = true;
            btnKhongLuu.Enabled = true;
            btnXoa.Enabled = false;
            btnDong.Enabled = false;

            txtHoTen.ReadOnly = false;
            txtSTT.ReadOnly = false;
            txtQuanHe.ReadOnly = false;
            dtpNgaySinh.Value = DateTime.Today;
            grpPhai.Enabled = true;
            rdoNam.Checked = true;
            cbDiaChiNha.Enabled = true;
            cbDiaChiNha.SelectedIndex = 0;
            cbDoiTuong.Enabled = true;
            cbDoiTuong.SelectedIndex = 0;
            cbNgheNghiep.Enabled = true;
            cbNgheNghiep.SelectedIndex = 0;
            cbQuyenSD.Enabled = true;
            cbQuyenSD.SelectedIndex = 0;
            cbTrinhDo.Enabled = true;
            cbTrinhDo.SelectedIndex = 0;

            dgvThanhVien.Enabled = false;

            txtHoTen.Clear();
            txtQuanHe.Clear();
            txtSTT.Clear();

            cbDiaChiNha.Focus();
        }

        void DieuKhienKhiBinhThuong()
        {
            if (MyPublics.strQuyenSD == "Admin")
            {
                btnThem.Enabled = true;
                btnChinhSua.Enabled = true;
                btnXoa.Enabled = true;
            }
            else
            {
                btnThem.Enabled = false;
                btnChinhSua.Enabled = false;
                btnXoa.Enabled = false;
            }

            btnLuu.Enabled = false;
            btnKhongLuu.Enabled = false;
            btnDong.Enabled = true;
            txtHoTen.ReadOnly = true;
            txtSTT.ReadOnly = true;
            txtQuanHe.ReadOnly = true;

            grpPhai.Enabled = false;
            cbDiaChiNha.Enabled = false;
            cbDoiTuong.Enabled = false;
            cbNgheNghiep.Enabled = false;
            cbTrinhDo.Enabled = false;
            cbQuyenSD.Enabled = false;
            dgvThanhVien.Enabled = true;
        }

        void DieuKhienKhiChinhSua()
        {
            btnThem.Enabled = false;
            btnChinhSua.Enabled = false;
            btnLuu.Enabled = true;
            btnKhongLuu.Enabled = true;
            btnXoa.Enabled = false;
            btnDong.Enabled = false;

            txtHoTen.ReadOnly = false;
            txtQuanHe.ReadOnly = false;
            grpPhai.Enabled = true;
            cbNgheNghiep.Enabled = true;
            cbDoiTuong.Enabled = true;
            cbTrinhDo.Enabled = true;
            cbQuyenSD.Enabled = true;
            dgvThanhVien.Enabled = false;

            txtHoTen.Focus();

        }

        private void dgvThanhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            GanDuLieu();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string strMaHo = cbDiaChiNha.SelectedValue.ToString();

            DialogResult blnDongY;
            blnDongY = MessageBox.Show("Bạn thật sự muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo);
            if (blnDongY == DialogResult.Yes)
            {
                string strSelect = "Delete ThanhVien Where MaHo=@MaHo And SttThanhVien= @SttThanhVien";
                if (MyPublics.conMyConnection.State == ConnectionState.Closed)
                    MyPublics.conMyConnection.Open();
                SqlCommand cmdCommand = new SqlCommand(strSelect, MyPublics.conMyConnection);
                cmdCommand.Parameters.AddWithValue("@MaHo", strMaHo);
                cmdCommand.Parameters.AddWithValue("@SttThanhVien", txtSTT.Text);

                cmdCommand.ExecuteNonQuery();
                MyPublics.conMyConnection.Close();

                int curRow = dgvThanhVien.CurrentRow.Index;
                dtThanhVien.Rows.RemoveAt(curRow);
                GanDuLieu();
            }
            DieuKhienKhiBinhThuong();

        }

      
    }
}


