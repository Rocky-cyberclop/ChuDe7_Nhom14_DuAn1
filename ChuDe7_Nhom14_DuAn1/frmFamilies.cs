using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ChuDe7_Nhom14_DuAn1
{
    public partial class frmFamilies : Form
    {
        DataTable dtFamilies = new DataTable("HoGiaDinh");
        DataTable dtHamlet = new DataTable("KhomAp");
        bool blnThem = false;
        
        void DieuKhienBinhThuong() {
            if (MyPublics.strQuyenSD == "Admin")
            {
                btnThem.Enabled = true;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
            }
            else {
                btnThem.Enabled = false;
                btnXoa.Enabled = false;
                btnSua.Enabled = false;
            }
            btnLuu.Enabled = false;
            btnKhongLuu.Enabled = false;
            txtAddress.ReadOnly = true;
            dtpDateEstablish.Enabled = false;
            cbHamlet.Enabled = false;
            btnClose.Enabled = true;
            dgvFamilies.Enabled = true;
        }

        void DieuKhienThem() {
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnLuu.Enabled = true;
            btnKhongLuu.Enabled = true;
            btnXoa.Enabled = false;
            btnClose.Enabled = false;
            txtAddress.ReadOnly = false;
            dtpDateEstablish.Enabled = true;
            dtpDateEstablish.Value = DateTime.Today;
            cbHamlet.Enabled = true;
            cbHamlet.SelectedIndex = 0;
            txtAddress.Clear();
            txtAddress.Focus();
            dgvFamilies.Enabled = false;
        }

        void DieuKhienChinhSua() {
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnLuu.Enabled = true;
            btnKhongLuu.Enabled = true;
            btnXoa.Enabled = false;
            btnClose.Enabled = false;
            txtAddress.ReadOnly = false;
            cbHamlet.Enabled = true;
            dtpDateEstablish.Enabled = true;
            txtAddress.Focus();
            dgvFamilies.Enabled = false;
        }

        private void btnThem_Click(object sender, EventArgs e) {
            this.blnThem = true;
            this.DieuKhienThem();
        }

        private void btnSua_Click(object sender, EventArgs e) {
            this.DieuKhienChinhSua();
        }

        void ThucThiLuu() {
            string strSql;
            if (this.blnThem == true)
            {
                strSql = "insert into HoGiaDinh values(@DiaChi,@NgayLap,@MaAp)";
            }
            else {
                strSql = "update HoGiaDinh set DiaChiNha=@DiaChi,NgayLapHo=@NgayLap,MaAp=@MaAp where MaHo=@MaHo";
            }
            if (MyPublics.conMyConnection.State == ConnectionState.Closed)
            {
                MyPublics.conMyConnection.Open();
            }
            SqlCommand sqlCmd = new SqlCommand(strSql, MyPublics.conMyConnection);
            sqlCmd.Parameters.AddWithValue("@DiaChi", txtAddress.Text);
            sqlCmd.Parameters.AddWithValue("@NgayLap", dtpDateEstablish.Value.ToString());
            sqlCmd.Parameters.AddWithValue("@MaAp", cbHamlet.SelectedValue.ToString());
            if (this.blnThem != true)
            {
                sqlCmd.Parameters.AddWithValue("@MaHo",
                    dgvFamilies[0,dgvFamilies.CurrentRow.Index].Value.ToString());
            }
            sqlCmd.ExecuteNonQuery();
            MyPublics.conMyConnection.Close();
            this.dtFamilies.Clear();
            MyPublics.OpenData("select * from HoGiaDinh", this.dtFamilies);
            this.GanDuLieu();
            if (this.blnThem == true) {
                blnThem = false;
            }
            this.DieuKhienBinhThuong();
        }

        private void btnLuu_Click(object sender, EventArgs e) {
            if (txtAddress.Text == "")
            {
                MessageBox.Show("Lỗi chưa nhập địa chỉ!");
                txtAddress.Focus();
                return;
            }
            if (cbHamlet.SelectedIndex == -1) { 
                MessageBox.Show("Lỗi chưa chọn khóm ấp!");
                cbHamlet.Focus();
            }
            else {
                this.ThucThiLuu();
            }
        }

        private void btnKhongLuu_Click(object sender, EventArgs e) {
            this.blnThem = false;
            this.GanDuLieu();
            this.DieuKhienBinhThuong();
        }

        private void btnXoa_Click(object sender, EventArgs e) {
            string maHo = dgvFamilies[0,dgvFamilies.CurrentRow.Index].Value.ToString();
            if (MyPublics.TonTaiKhoaChinh(maHo,"MaHo","ThanhVien"))
            {
                MessageBox.Show("Hộ này còn người! Hãy cân nhắc xóa các thành viên trước!");
            }
            else {
                DialogResult dlDongY;
                dlDongY = MessageBox.Show("Bạn thật sự muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo);
                if (dlDongY == DialogResult.Yes)
                {
                    string sqlDel = "delete HoGiaDinh where MaHo=@MaHo";
                    if (MyPublics.conMyConnection.State == ConnectionState.Closed)
                    {
                        MyPublics.conMyConnection.Open();
                    }
                    SqlCommand cmd = new SqlCommand(sqlDel, MyPublics.conMyConnection);
                    cmd.Parameters.AddWithValue("@MaHo", maHo);
                    cmd.ExecuteNonQuery();
                    MyPublics.conMyConnection.Close();
                    int curRow = dgvFamilies.CurrentRow.Index;
                    this.dtFamilies.Rows.RemoveAt(curRow);
                    this.GanDuLieu();
                }    
            }
            this.DieuKhienBinhThuong();
        }

        private void dgvMon_CellClick(object sender, DataGridViewCellEventArgs e) {
            this.GanDuLieu();
        }

        void GanDuLieu() {
            if (this.dtFamilies.Rows.Count > 0)
            {
                txtAddress.Text = dgvFamilies[1, dgvFamilies.CurrentRow.Index].Value.ToString();
                dtpDateEstablish.Value = DateTime.Parse(dgvFamilies[2, dgvFamilies.CurrentRow.Index].Value.ToString());
                cbHamlet.SelectedValue = dgvFamilies[3, dgvFamilies.CurrentRow.Index].Value.ToString();
            }
            else {
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
                txtAddress.Clear();
                dtpDateEstablish.Value = DateTime.Today;
                cbHamlet.SelectedIndex = -1;
            }
        }

        public frmFamilies()
        {
            InitializeComponent();
        }

        private void frmMon_Load(object sender, EventArgs e)
        {
            MyPublics.OpenData("select * from HoGiaDinh", this.dtFamilies);
            MyPublics.OpenData("select * from KhomAp", this.dtHamlet);
            cbHamlet.DataSource = this.dtHamlet;
            cbHamlet.DisplayMember = "TenAp";
            cbHamlet.ValueMember = "MaAp";
            cbHamlet.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbHamlet.AutoCompleteSource = AutoCompleteSource.ListItems;
            txtAddress.MaxLength = 30;
            dgvFamilies.DataSource = this.dtFamilies;
            dgvFamilies.Width = 430;
            dgvFamilies.AllowUserToAddRows = false;
            dgvFamilies.AllowUserToDeleteRows = false;
            dgvFamilies.Columns[0].Width = 80;
            dgvFamilies.Columns[0].HeaderText = "Mã hộ";
            dgvFamilies.Columns[1].Width = 120;
            dgvFamilies.Columns[1].HeaderText = "Địa chỉ";
            dgvFamilies.Columns[2].Width = 120;
            dgvFamilies.Columns[2].HeaderText = "Ngày lập hộ";
            dgvFamilies.Columns[3].Width = 50;
            dgvFamilies.Columns[3].HeaderText = "Ấp";
            dgvFamilies.EditMode = DataGridViewEditMode.EditProgrammatically;
            this.GanDuLieu();
            this.DieuKhienBinhThuong();
        }

        private void btnClose_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
