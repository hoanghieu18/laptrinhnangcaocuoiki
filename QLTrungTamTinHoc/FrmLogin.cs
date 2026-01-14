using QLTTTH.BLL.Services;
using QLTTTH.Entities.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTrungTamTinHoc
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            UserBLL bll = new UserBLL();
            User user = bll.DangNhap(txtUsername.Text, txtPassword.Text);

            if (user != null)
            {
                MessageBox.Show("Đăng nhập thành công!");

                FrmMain frm = new FrmMain();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu!");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
