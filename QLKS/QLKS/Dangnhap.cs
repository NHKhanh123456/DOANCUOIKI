using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKS
{
    public partial class Dangnhap : Form
    {
        public Dangnhap()
        {
            InitializeComponent();
        }

        private void Dangnhap_Load(object sender, EventArgs e)
        {

        }

        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            if ((txtTaikhoan.Text == "") || (txtMatkhau.Text == ""))
            {
                MessageBox.Show("Vui lòng nhập thông tin", "Thông báo");
            }
            else
            {
                if ((txtTaikhoan.Text == "nhanvien") && (txtMatkhau.Text == "123"))
                {
                    MessageBox.Show("Đăng nhập thành công!", "Thông báo");
                    Tinhtienphong ds = new Tinhtienphong();
                    this.Hide();
                    ds.Show();
                }
                else
                {
                    MessageBox.Show("Đăng nhập không thành công!", "Thông báo");
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
