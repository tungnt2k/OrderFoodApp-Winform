using QLBH.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBH.Forms
{
    public partial class frmChangePass : Form
    {
        private User user;
        public frmChangePass(User u)
        {
            InitializeComponent();
            user = u;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if(user.Password!=tbOldPassword.Text)
            {
                MessageBox.Show("Sai mật khẩu", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }    
            else if(tbNewPass.Text != tbReNewPass.Text)
            {
                MessageBox.Show("Mật khẩu không trùng nhau", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                using (var DbContext = new AppContext())
                {
                    User u = DbContext.Users.Find(user.Id);
                    if(u!=null)
                    {
                        u.Password = tbNewPass.Text;
                        DbContext.Users.AddOrUpdate(u);
                        DbContext.SaveChanges();
                    }
                    MessageBox.Show("Thay đổi mật khẩu thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
             
        }
    }
}
