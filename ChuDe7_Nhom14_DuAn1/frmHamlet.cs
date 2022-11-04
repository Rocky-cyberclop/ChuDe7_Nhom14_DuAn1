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
    public partial class frmHamlet : Form
    {
        DataTable dtHamlet = new DataTable("KhomAp");
        bool blnAdd = false;

        void DieuKhienBinhThuong() {
            if (MyPublics.strQuyenSD=="Admin")
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
            txtId.ReadOnly = true;
            txtName.ReadOnly = true;
            txtGroup.ReadOnly = true;
            txtDescribe.ReadOnly = true;
            btnClose.Enabled = true;
            dgvHamlet.Enabled = true;
        }

        void DieuKhienThem() {
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnLuu.Enabled = true;
            btnKhongLuu.Enabled = true;
            btnXoa.Enabled = false;
            btnClose.Enabled = false;
            txtId.ReadOnly = false;
            txtName.ReadOnly = false;
            txtGroup.ReadOnly = false;
            txtDescribe.ReadOnly = false;
            txtId.Clear();
            txtName.Clear();
            txtGroup.Clear();
            txtDescribe.Clear();
            txtId.Focus();
            dgvHamlet.Enabled = false;
        }

        void DieuKhienChinhSua() {
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnLuu.Enabled = true;
            btnKhongLuu.Enabled = true;
            btnXoa.Enabled = false;
            btnClose.Enabled = false;
            txtName.ReadOnly = false;
            txtGroup.ReadOnly = false;
            txtDescribe.ReadOnly = false;
            txtName.Focus();
            dgvHamlet.Enabled = false;
        }

        private void btnThem_Click(object sender, EventArgs e) {
            this.blnAdd = true;
            this.DieuKhienThem();
        }

        private void btnSua_Click(object sender, EventArgs e) {
            this.DieuKhienChinhSua();
        }

        private void ThucThiLuu() {
            string sql;
            if (this.blnAdd == true)
            {
                sql = "insert into KhomAp values(@MaAp,@TenAp,@SoTo,@DacDiem)";
            }
            else
            {
                sql = "update KhomAp set TenAp=@TenAp,SoTo=@SoTo,DacDiem=@DacDiem where MaAp=@MaAp ";
            }
            if (MyPublics.conMyConnection.State == ConnectionState.Closed)
            {
                MyPublics.conMyConnection.Open();
            }
            SqlCommand sqlCmd = new SqlCommand(sql, MyPublics.conMyConnection);
            sqlCmd.Parameters.AddWithValue("@MaAp", txtId.Text);
            sqlCmd.Parameters.AddWithValue("@TenAp", txtName.Text);
            sqlCmd.Parameters.AddWithValue("@SoTo", txtGroup.Text);
            sqlCmd.Parameters.AddWithValue("@DacDiem", txtDescribe.Text);
            sqlCmd.ExecuteNonQuery();
            MyPublics.conMyConnection.Close();
            if (this.blnAdd == true)
            {
                this.dtHamlet.Rows.Add(txtId.Text, txtName.Text, txtGroup.Text, txtDescribe.Text);
                this.blnAdd = false;
            }
            else {
                int curRow = dgvHamlet.CurrentRow.Index;
                this.dtHamlet.Rows[curRow][0] = txtId.Text;
                this.dtHamlet.Rows[curRow][1] = txtName.Text;
                this.dtHamlet.Rows[curRow][2] = txtGroup.Text;
                this.dtHamlet.Rows[curRow][3] = txtDescribe.Text;
            }
            this.GanDuLieu();
            this.DieuKhienBinhThuong();
        }

        private void btnLuu_Click(object sender, EventArgs e) {
            int group;
            if (txtId.Text == "") {
                MessageBox.Show("Lỗi chưa nhập mã ấp!");
                txtId.Focus();
                return;
            }
            if (txtName.Text == "")
            {
                MessageBox.Show("Lỗi chưa nhập tên ấp!");
                txtName.Focus();
                return;
            }
            if ((!int.TryParse(txtGroup.Text, out group)) || group <= 0) {
                MessageBox.Show("Lỗi nhập số tổ!");
                txtGroup.Focus();
                return;
            }
            if ((blnAdd)&&MyPublics.TonTaiKhoaChinh(txtId.Text,"MaAp","KhomAp"))
            {
                MessageBox.Show("Mã ấp này đã có rồi!");
                txtId.Clear();
                txtId.Focus();
            }
            else {
                this.ThucThiLuu();
            }
        }

        private void btnKhongLuu_Click(object sender, EventArgs e) {
            this.GanDuLieu();
            this.blnAdd = false;
            this.DieuKhienBinhThuong();
        }

        private void btnXoa_Click(object sender, EventArgs e) {
            if (MyPublics.TonTaiKhoaChinh(txtId.Text,"MaAp","HoGiaDinh"))
            {
                MessageBox.Show("Khóm ấp này còn có các hộ gia đình, hãy cân nhắc xóa các hộ trước!");
            }
            else {
                DialogResult dlDongY;
                dlDongY = MessageBox.Show("Bạn thật sự muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo);
                if (dlDongY == DialogResult.Yes) {
                    string sqlDel = "delete KhomAp where MaAp=@MaAp";
                    if (MyPublics.conMyConnection.State == ConnectionState.Closed)
                    {
                        MyPublics.conMyConnection.Open();
                    }
                    SqlCommand cmd = new SqlCommand(sqlDel, MyPublics.conMyConnection);
                    cmd.Parameters.AddWithValue("@MaAp", txtId.Text);
                    cmd.ExecuteNonQuery();
                    MyPublics.conMyConnection.Close();
                    int curRow = dgvHamlet.CurrentRow.Index;
                    this.dtHamlet.Rows.RemoveAt(curRow);
                    this.GanDuLieu();
                }
            }
            this.DieuKhienBinhThuong();
        }

        private void dgvLop_CellClick(object sender, DataGridViewCellEventArgs e) {
            this.GanDuLieu();
        }

        private void GanDuLieu() {
            if (this.dtHamlet.Rows.Count > 0)
            {
                int curRow = dgvHamlet.CurrentRow.Index;
                txtId.Text = dgvHamlet[0, curRow].Value.ToString();
                txtName.Text = dgvHamlet[1, curRow].Value.ToString();
                txtGroup.Text = dgvHamlet[2, curRow].Value.ToString();
                txtDescribe.Text = dgvHamlet[3, curRow].Value.ToString();
            }
            else
            {
                txtId.Clear();
                txtName.Clear();
                txtGroup.Clear();
                txtDescribe.Clear();
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
            }
        }

        public frmHamlet()
        {
            InitializeComponent();
        }

        private void frmLop_Load(object sender, EventArgs e)
        {
            string sqlSelect = "select * from KhomAp";
            MyPublics.OpenData(sqlSelect, this.dtHamlet);
            dgvHamlet.DataSource = this.dtHamlet;
            txtId.MaxLength = 8;
            txtName.MaxLength = 40;
            this.GanDuLieu();
            dgvHamlet.Width = 470;
            dgvHamlet.Columns[0].Width = 78;
            dgvHamlet.Columns[0].HeaderText = "Mã ấp";
            dgvHamlet.Columns[1].Width = 120;
            dgvHamlet.Columns[1].HeaderText = "Tên ấp";
            dgvHamlet.Columns[2].Width = 78;
            dgvHamlet.Columns[2].HeaderText = "Số tổ";
            dgvHamlet.Columns[3].Width = 120;
            dgvHamlet.Columns[3].HeaderText = "Đặc điểm";
            dgvHamlet.AllowUserToAddRows = false;
            dgvHamlet.AllowUserToDeleteRows = false;
            dgvHamlet.EditMode = DataGridViewEditMode.EditProgrammatically;
            this.DieuKhienBinhThuong();
        }

        private void btnClose_Click(object sender, EventArgs e) {
            this.Close();
        }


    }
}
