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
    public partial class frmAdmin : Form
    {
        public frmAdmin()
        {
            InitializeComponent();
        }
        private List<User> users;
        private List<Food> foods;
        private List<FoodCategory> foodCates;
        private int currentFoodCateId;
        private int currentUserId;
        private void frmAdmin_Load(object sender, EventArgs e)
        {
            LoadFood();
            LoadFoodCates();
            LoadUser();
        }

        private void LoadUser()
        {
            using (var DbContext = new AppContext())
            {
                users = DbContext.Users.ToList();
            }

            dgvUser.DataSource = users;
            dgvUser.Columns["Id"].Visible = false;
            dgvUser.Columns["Bills"].Visible = false;
            dgvUser.CurrentCell = null;
        }

        private void LoadFood()
        {
            using (var DbContext = new AppContext())
            {
                foods = DbContext.Foods.ToList();
            }
        }
        private void LoadFoodCates()
        {
            using (var DbContext = new AppContext())
            {
                foodCates = DbContext.FoodCategories.ToList();
            }
            dgvFoodCate.DataSource = foodCates;
            dgvFoodCate.Columns["Id"].Visible = false;
            dgvFoodCate.Columns["foods"].Visible = false;
            dgvFoodCate.CurrentCell = null;
        }

        private void btnAddCate_Click(object sender, EventArgs e)
        {
            FoodCategory fc = new FoodCategory();
            fc.Name = tbCateName.Text;
            using (var DbContext = new AppContext())
            {
                DbContext.FoodCategories.Add(fc);
                DbContext.SaveChanges();
            }
            LoadFoodCates();
        }


        private void dgvFoodCate_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvFoodCate.CurrentCell != null)
            {
                currentFoodCateId = int.Parse(dgvFoodCate.Rows[dgvFoodCate.CurrentCell.RowIndex].Cells["Id"].Value.ToString());
                tbCateName.Text = dgvFoodCate.Rows[dgvFoodCate.CurrentCell.RowIndex].Cells["Name"].Value.ToString();
            }
        }

        private void btnUpdateCate_Click(object sender, EventArgs e)
        {
            using (var DbContext = new AppContext())
            {
                FoodCategory fc = DbContext.FoodCategories.Find(currentFoodCateId);
                if (fc != null)
                {
                    fc.Name = tbCateName.Text;
                    fc.UpdateAt = DateTime.Now;
                    DbContext.FoodCategories.AddOrUpdate(fc);
                    DbContext.SaveChanges();
                }
            }
            LoadFoodCates();

        }

        private void btnDeleteCate_Click(object sender, EventArgs e)
        {
            using (var DbContext = new AppContext())
            {
                FoodCategory fc = DbContext.FoodCategories.Find(currentFoodCateId);
                if (fc != null)
                {
                    DbContext.FoodCategories.Remove(fc);
                    DbContext.SaveChanges();
                }
            }
            LoadFoodCates();
        }

        private void dgvUser_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvUser.CurrentCell != null)
            {
                currentUserId = int.Parse(dgvUser.Rows[dgvUser.CurrentCell.RowIndex].Cells["Id"].Value.ToString());
                tbDislayNameUser.Text = dgvUser.Rows[dgvUser.CurrentCell.RowIndex].Cells["DislayName"].Value.ToString();
                tbUsername.Text = dgvUser.Rows[dgvUser.CurrentCell.RowIndex].Cells["Username"].Value.ToString();
                tbPassword.Text = dgvUser.Rows[dgvUser.CurrentCell.RowIndex].Cells["Password"].Value.ToString();
                rBtnAdmin.Checked = (Role)dgvUser.Rows[dgvUser.CurrentCell.RowIndex].Cells["Role"].Value == Role.ADMIN ? true : false;
                rBtnStaff.Checked = (Role)dgvUser.Rows[dgvUser.CurrentCell.RowIndex].Cells["Role"].Value == Role.STAFF ? true : false;
            }
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.Username = tbUsername.Text;
            user.Password = tbPassword.Text;
            user.DislayName = tbDislayNameUser.Text;
            user.Role = rBtnAdmin.Checked ? Role.ADMIN : Role.STAFF;
            using (var DbContext = new AppContext())
            {
                DbContext.Users.Add(user);
                DbContext.SaveChanges();
            }
            LoadUser();
        }

        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            using (var DbContext = new AppContext())
            {
                User user = DbContext.Users.Find(currentUserId);
                if (user != null)
                {
                    user.Username = tbUsername.Text;
                    user.Password = tbPassword.Text;
                    user.DislayName = tbDislayNameUser.Text;
                    user.Role = rBtnAdmin.Checked ? Role.ADMIN : Role.STAFF;
                    user.UpdateAt = DateTime.Now;
                    DbContext.Users.AddOrUpdate(user);
                    DbContext.SaveChanges();
                }
            }
            LoadUser();
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            using (var DbContext = new AppContext())
            {
                User user = DbContext.Users.Find(currentUserId);
                if (user != null)
                {
                    DbContext.Users.Remove(user);
                    DbContext.SaveChanges();
                }
            }
            LoadUser();
        }

    }
}
