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
            this.KTraKetNoi();
        }

        //Phần này để fix bug
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
