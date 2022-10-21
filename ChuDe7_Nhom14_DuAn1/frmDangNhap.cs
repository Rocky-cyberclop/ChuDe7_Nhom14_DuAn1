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
    public partial class frmDangNhap : Form
    {
        private frmMain fMain;

        public frmDangNhap()
        {
            InitializeComponent();
        }

        public frmDangNhap(frmMain fm)
            : this()
        {
            fMain = fm;
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            txtMaHo.Focus();
            txtMK.PasswordChar = '*';
        }

        private void btnLogin_Click(object sender, EventArgs e) {
            SqlCommand cmdCommand;
            SqlDataReader drReader;
            string sqlTimKiem, strMK;
            try
            {
                MyPublics.ConnectDatabase("ROCKYOPERATION");
                if (MyPublics.conMyConnection.State == ConnectionState.Open)
                {

                    strMK = MyPublics.EncodePass(txtMK.Text);
                    sqlTimKiem = "select MaHo, SttThanhVien, QuyenSD, HoTenThanhVien from ThanhVien where MaHo = @MaHo and "+
                    "SttThanhVien = @STT and MatKhau = @MatKhau";

                    cmdCommand = new SqlCommand(sqlTimKiem, MyPublics.conMyConnection);
                    cmdCommand.Parameters.AddWithValue("@MaHo", txtMaHo.Text);
                    cmdCommand.Parameters.AddWithValue("@STT", txtSTT.Text);
                    cmdCommand.Parameters.AddWithValue("@MatKhau", strMK);

                    

                    drReader = cmdCommand.ExecuteReader();

                    if (drReader.HasRows)
                    {
                        drReader.Read();

                        MyPublics.strMS = drReader.GetInt32(0).ToString();
                        MyPublics.strSTT = drReader.GetInt16(1).ToString();
                        MyPublics.strQuyenSD = drReader.GetString(2);
                        MyPublics.strHoTen = drReader.GetString(3);
                        fMain.mnuQuanLy.Enabled = true;
                        fMain.mnuDangXuat.Enabled = true;
                        fMain.mnuDangNhap.Enabled = false;
                        fMain.mnuDoiMK.Enabled = true;
                        MessageBox.Show(MyPublics.strMS+" "+MyPublics.strSTT,"Thông báo");
                        MessageBox.Show(MyPublics.strHoTen.ToString()+" "+MyPublics.strQuyenSD.ToString(), "Thông báo");
                        MyPublics.conMyConnection.Close();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("MSSV hoặc mật khẩu sai!", "Thông báo");
                    }
                    
                }
                else {
                    MessageBox.Show("Kết nối không thành công!", "Thông báo");
                }
            }
            catch (Exception) {
                MessageBox.Show("Lỗi khi thực hiện kết nối", "Thông báo");
            }

        }



        private void btnClose_Click(object sender, EventArgs e) {
            if (MyPublics.conMyConnection != null) {
                MyPublics.conMyConnection = null;
            }
            fMain.mnuQuanLy.Enabled = false;
            fMain.mnuDangXuat.Enabled = false;
            fMain.mnuDoiMK.Enabled = false;
            fMain.mnuDangNhap.Enabled = true;
            this.Close();
        }
        
        
    }
}
