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
    public partial class frmNgheNghiep : Form
    {
        DataTable dtNgheNghiep = new DataTable("NgheNghiep");
        bool blnThem = false;

        public frmNgheNghiep()
        {
            InitializeComponent();
        }

        void GanDuLieu()
        {
            if (dtNgheNghiep.Rows.Count > 0)
            {
                txtMaNN.Text = dgvNgheNghiep[0, dgvNgheNghiep.CurrentRow.Index].Value.ToString();
                txtTenNN.Text = dgvNgheNghiep[1, dgvNgheNghiep.CurrentRow.Index].Value.ToString();
            }
            else
            {
                btnChinhSua.Enabled = false;
                btnXoa.Enabled = false;
                txtMaNN.Clear();
                txtTenNN.Clear();
            }
        }

        private void frmNgheNghiep_Load(object sender, EventArgs e)
        {
            string strSelect = "Select * From NgheNghiep";
            MyPublics.OpenData(strSelect, dtNgheNghiep);

            dgvNgheNghiep.DataSource = dtNgheNghiep;
            txtMaNN.MaxLength = 3;
            txtTenNN.MaxLength = 50;

            GanDuLieu();

            dgvNgheNghiep.Width = 350;
            dgvNgheNghiep.Columns[0].Width = 90;
            dgvNgheNghiep.Columns[0].HeaderText = "Mã số";
            dgvNgheNghiep.Columns[1].Width = 200;
            dgvNgheNghiep.Columns[1].HeaderText = "Tên nghề nghiệp";

            dgvNgheNghiep.AllowUserToAddRows = false;
            dgvNgheNghiep.AllowUserToDeleteRows = false;
            dgvNgheNghiep.EditMode = DataGridViewEditMode.EditProgrammatically;
            DieuKhienKhiBinhThuong();

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
            txtMaNN.ReadOnly = true;
            txtTenNN.ReadOnly = true;

            dgvNgheNghiep.Enabled = true;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvNgheNghiep_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            GanDuLieu();
           
        }

        void ThucThiLuu()
        {
            string strSql, strQuyenSD;


            if (blnThem)
            {
                strSql = "Insert Into NgheNghiep Values(@MaNN, @TenNN)";

            }
            else
            {
                strSql = "Update NgheNghiep Set  TenNgheNghiep=@TenNN Where MaNgheNghiep = @MaNN";

            }
            if (MyPublics.conMyConnection.State == ConnectionState.Closed)
                MyPublics.conMyConnection.Open();

            SqlCommand cmmdCommand = new SqlCommand(strSql, MyPublics.conMyConnection);

            cmmdCommand.Parameters.AddWithValue("@MaNN", txtMaNN.Text);
            cmmdCommand.Parameters.AddWithValue("@TenNN", txtTenNN.Text);

            cmmdCommand.ExecuteNonQuery();
            MyPublics.conMyConnection.Close();

            if (blnThem)
            {
                dtNgheNghiep.Rows.Add(txtMaNN.Text, txtTenNN.Text);
                GanDuLieu();
                blnThem = false;
            }
            else
            {
                int curRow = dgvNgheNghiep.CurrentRow.Index;
                dtNgheNghiep.Rows[curRow][1] = txtTenNN.Text;
            }
            DieuKhienKhiBinhThuong();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMaNN.Text == "")
            {
                MessageBox.Show("Lỗi chưa nhập mã nghề nghiệp!", "Thông báo");
                txtMaNN.Focus();
                return;
            }
            if (txtTenNN.Text == "")
            {
                MessageBox.Show("Lỗi chưa nhập tên nghề nghiệp!", "Thông báo");
                txtTenNN.Focus();
                return;
            }

            if (blnThem && MyPublics.TonTaiKhoaChinh(txtMaNN.Text, "MaNgheNghiep", "NgheNghiep"))
            {
                MessageBox.Show("Mã nghề nghiệp này đã tồn tại!", "Thông báo!");
                txtMaNN.Focus();
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

        private void btnThem_Click(object sender, EventArgs e)
        {
            blnThem = true;
            DieuKhienKhiThem();
        }

        void DieuKhienKhiThem()
        {
            btnThem.Enabled = false;
            btnChinhSua.Enabled = false;
            btnLuu.Enabled = true;
            btnKhongLuu.Enabled = true;
            btnXoa.Enabled = false;
            btnDong.Enabled = false;
            txtMaNN.ReadOnly = false;
            txtTenNN.ReadOnly = false;
            txtMaNN.Clear();
            txtTenNN.Clear();
            txtMaNN.Focus();
            dgvNgheNghiep.Enabled = false;

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MyPublics.TonTaiKhoaChinh(txtMaNN.Text,"MaNgheNghiep" ,"ThanhVien"))
            {
                MessageBox.Show("Bạn phải xóa thành viên có nghề nghiệp này trước!", "Thông báo");

            }
            else
            {
                DialogResult blnDongY;
                blnDongY = MessageBox.Show("Bạn thật sự muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo);
                if (blnDongY == DialogResult.Yes)
                {
                    string strSelect = "Delete NgheNghiep Where MaNgheNghiep=@MaNN";
                    if (MyPublics.conMyConnection.State == ConnectionState.Closed)
                        MyPublics.conMyConnection.Open();
                    SqlCommand cmdCommand = new SqlCommand(strSelect, MyPublics.conMyConnection);
                    cmdCommand.Parameters.AddWithValue("@MaNN", txtMaNN.Text);

                    cmdCommand.ExecuteNonQuery();
                    MyPublics.conMyConnection.Close();

                    int curRow = dgvNgheNghiep.CurrentRow.Index;
                    dtNgheNghiep.Rows.RemoveAt(curRow);
                    GanDuLieu();
                }
            }
            DieuKhienKhiBinhThuong();
        }

        private void btnChinhSua_Click(object sender, EventArgs e)
        {
            DieuKhienKhiChinhSua();
        }

        void DieuKhienKhiChinhSua()
        {
            btnThem.Enabled = false;
            btnChinhSua.Enabled = false;
            btnLuu.Enabled = true;
            btnKhongLuu.Enabled = true;
            btnXoa.Enabled = false;
            btnDong.Enabled = false;
           
            txtTenNN.ReadOnly = false;
            dgvNgheNghiep.Enabled = false;
            txtTenNN.Focus();
        }
    }
}
