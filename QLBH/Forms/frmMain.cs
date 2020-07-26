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
    public partial class frmMain : Form
    {
        private User user;
        public frmMain(User u)
        {
            InitializeComponent();
            this.user = u;
        }

        private void quảnTrịViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(user.Role == Role.ADMIN)
            {
                this.Hide();
                frmAdmin admin = new frmAdmin();
                admin.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Bạn phải có quyền ADMIN để truy cập", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void thôngTinTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmUserInfo userInfo = new frmUserInfo(user);
            userInfo.ShowDialog();
            this.Show();
        }
    }
}
