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
    //This class use binding source
    public partial class frmHamlet : Form
    {
        DataTable dtHamlet = new DataTable("KhomAp");
        SqlDataAdapter daHamlet = new SqlDataAdapter();
        BindingSource bsHamlet = new BindingSource();
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
            txGroup.ReadOnly = true;
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
            txGroup.ReadOnly = false;
            txtDescribe.ReadOnly = false;
            txtId.Clear();
            txtName.Clear();
            txGroup.Clear();
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
            txGroup.ReadOnly = false;
            txtDescribe.ReadOnly = false;
            txtName.Focus();
            dgvHamlet.Enabled = false;
        }

        private void btnThem_Click(object sender, EventArgs e) {
            this.blnAdd = true;
            this.bsHamlet.AddNew();
            this.bsHamlet.Position = this.bsHamlet.Count;
            dgvHamlet.CurrentCell = dgvHamlet[0, this.bsHamlet.Count - 1];
            this.DieuKhienThem();
        }

        private void btnSua_Click(object sender, EventArgs e) {
            this.DieuKhienChinhSua();
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
            if ((!int.TryParse(txGroup.Text, out group)) || group <= 0) {
                MessageBox.Show("Lỗi nhập số tổ!");
                txGroup.Focus();
                return;
            }
            if ((blnAdd)&&MyPublics.TonTaiKhoaChinh(txtId.Text,"MaAp","KhomAp"))
            {
                MessageBox.Show("Mã ấp này đã có rồi!");
                txtId.Clear();
                txtId.Focus();
            }
            else {
                this.bsHamlet.EndEdit();
                this.daHamlet.Update(this.dtHamlet);
                this.dtHamlet.AcceptChanges();
                this.blnAdd = false;
                this.DieuKhienBinhThuong();
            }
        }

        private void btnKhongLuu_Click(object sender, EventArgs e) {
            this.bsHamlet.EndEdit();
            this.dtHamlet.RejectChanges();
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
                    this.bsHamlet.RemoveCurrent();
                    this.daHamlet.Update(this.dtHamlet);
                    this.dtHamlet.AcceptChanges();
                }
            }
            this.DieuKhienBinhThuong();
        }

        private void dgvLop_CellClick(object sender, DataGridViewCellEventArgs e) {
            this.bsHamlet.Position = dgvHamlet.CurrentRow.Index;
        }

        private void GanDuLieu() {
            txtId.DataBindings.Add(new Binding("Text", this.bsHamlet, "MaAp"));
            txtName.DataBindings.Add(new Binding("Text", this.bsHamlet, "TenAp"));
            txGroup.DataBindings.Add(new Binding("Text", this.bsHamlet, "SoTo"));
            txtDescribe.DataBindings.Add(new Binding("Text", this.bsHamlet, "DacDiem"));
        }

        public frmHamlet()
        {
            InitializeComponent();
        }

        private void frmLop_Load(object sender, EventArgs e)
        {
            string sqlSelect = "select * from KhomAp";
            MyPublics.OpenDataArgs(sqlSelect, this.dtHamlet,this.daHamlet);
            dgvHamlet.DataSource = this.dtHamlet;
            this.bsHamlet.DataSource = this.dtHamlet;
            txtId.MaxLength = 8;
            txtName.MaxLength = 40;
            this.GanDuLieu();
            dgvHamlet.Width = 460;
            dgvHamlet.Columns[0].Width = 80;
            dgvHamlet.Columns[0].HeaderText = "Mã ấp";
            dgvHamlet.Columns[1].Width = 120;
            dgvHamlet.Columns[1].HeaderText = "Tên ấp";
            dgvHamlet.Columns[2].Width = 80;
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
