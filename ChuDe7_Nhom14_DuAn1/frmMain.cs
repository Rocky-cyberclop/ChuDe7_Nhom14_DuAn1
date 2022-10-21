using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChuDe7_Nhom14_DuAn1
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            mnuQuanLy.Enabled = false;
            mnuDangXuat.Enabled = false;
            mnuDoiMK.Enabled = false;
            frmDangNhap form = new frmDangNhap(this);
            form.ShowDialog();
        }

        private void mnuDangNhap_Click(object sender, EventArgs e) {
            frmDangNhap form = new frmDangNhap(this);
            form.ShowDialog();
        }

        private void mnuThoat_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        //Phần này để fix bug

        //Gọi hàm này để kiểm tra kết nối
        private void KTraKetNoi() {
            try
            {
                MyPublics.ConnectDatabase("ROCKYOPERATION");
                if (MyPublics.conMyConnection.State == ConnectionState.Open)
                {
                    MessageBox.Show("Ngon!");

                }
                else
                {
                    MessageBox.Show("Toang!");
                }
            }
            catch (Exception)
            {

            }
        }
    }
}
