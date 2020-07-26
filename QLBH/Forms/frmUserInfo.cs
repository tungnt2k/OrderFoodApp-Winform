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
    public partial class frmUserInfo : Form
    {
        private User user;
        public frmUserInfo(User u)
        {
            InitializeComponent();
            user = u;
        }

        private void frmUserInfo_Load(object sender, EventArgs e)
        {
            tbUsername.Text = user.Username;
            tbDislayName.Text = user.DislayName;
            tbRole.Text = user.Role.ToString();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            frmChangePass frm = new frmChangePass(user);
            frm.Show();
        }

        private void btnStatistic_Click(object sender, EventArgs e)
        {
            List<Bill> bills;
            float total;
            using(var DbContext = new AppContext())
            {
                bills = DbContext.Bills.Where(b => b.StaffId == user.Id)
                    .Where(b=>b.Checkout>dtpStartDate.Value)
                    .Where(b=>b.Checkout<dtpEndDate.Value).ToList();
                total = DbContext.Bills.Sum(b => b.TotalPrice);
            }
            dgvStatistic.DataSource = bills;
            dgvStatistic.Columns["StaffId"].Visible = false;
            dgvStatistic.Columns["Staff"].Visible = false;
            dgvStatistic.Columns["BillInfos"].Visible = false;
            lbTotal.Text = total.ToString();
        }

    }
}
