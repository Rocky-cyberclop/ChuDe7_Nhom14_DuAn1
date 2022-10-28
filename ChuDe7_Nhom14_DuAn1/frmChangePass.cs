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
    public partial class frmChangePass : Form
    {
        public frmChangePass()
        {
            InitializeComponent();
        }

        private void frmChangePass_Load(object sender, EventArgs e)
        {
            txtMaHo.ReadOnly = true;
            txtSTT.ReadOnly = true;
            txtMaHo.Text = MyPublics.strMS;
            txtSTT.Text = MyPublics.strSTT;
            txtNewPass.PasswordChar = '*';
            txtConfirm.PasswordChar = '*';
            txtNewPass.Focus();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            if (txtNewPass.Text == "")
            {
                MessageBox.Show("Mật khẩu mới đang trống!");
                txtNewPass.Focus();
                return;
            }
            if (txtNewPass.Text != txtConfirm.Text)
            {
                MessageBox.Show("Mật khẩu mới và xác nhận không trùng!");
                return;
            }
            else
            {
                string strPasswordSV = MyPublics.EncodePass(txtNewPass.Text);
                string sqlSelect = "update ThanhVien set MatKhau = @MatKhau where MaHo=@MaHo and SttThanhVien=@Stt";
                if (MyPublics.conMyConnection.State == ConnectionState.Closed)
                {
                    MyPublics.conMyConnection.Open();
                }
                SqlCommand cmd = new SqlCommand(sqlSelect, MyPublics.conMyConnection);
                cmd.Parameters.AddWithValue("@MatKhau", strPasswordSV);
                cmd.Parameters.AddWithValue("@MaHo", MyPublics.strMS);
                cmd.Parameters.AddWithValue("@Stt", MyPublics.strSTT);
                cmd.ExecuteNonQuery();
                MyPublics.conMyConnection.Close();
                MessageBox.Show("Đổi mật khẩu thành công!");
                this.Close();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        
    }
}
