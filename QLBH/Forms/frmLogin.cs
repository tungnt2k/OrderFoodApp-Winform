using QLBH.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBH.Forms
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (tbUsername.Text == "" || tbPassword.Text == "")
            {
                MessageBox.Show("Cảnh báo", "Bạn chưa nhập tài khoản mật khẩu", MessageBoxButtons.OK);
                return;
            }
            User user;
            using (var DbContext = new AppContext())
            {
                user = DbContext.Users.FirstOrDefault<User>(u => u.Username == tbUsername.Text);
            }

            if (user != null && user.Password == tbPassword.Text)
            {
                this.Hide();
                frmMain main = new frmMain(user);
                main.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Cảnh báo", "Sai tài khoản hoặc mật khẩu", MessageBoxButtons.OK);
            }
        }
    }
}
