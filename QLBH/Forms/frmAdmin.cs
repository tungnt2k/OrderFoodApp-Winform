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
        private int? currentFoodCateId;
        private int? currentUserId;
        private int? currentFoodId;
        private void frmAdmin_Load(object sender, EventArgs e)
        {
            LoadFoodCates();
            LoadFood();
            LoadUser();
        }

        private void LoadUser()
        {
            using (var DbContext = new AppContext())
            {
                users = DbContext.Users.ToList();
            }
            cbbStaff.DisplayMember = "Text";
            cbbStaff.ValueMember = "Value";
            cbbStaff.Items.Clear();
            if (users!=null)
            {
                cbbStaff.Items.Add(new { Text = "Chọn nhân viên", Value = 0 });
                cbbStaff.SelectedIndex = cbbStaff.FindString("Chọn nhân viên");
                users.ForEach(e =>
                {
                    cbbStaff.Items.Add(new { Text = e.DislayName, Value = e.Id });
                });
            }

            dgvUser.DataSource = users;
            dgvUser.Columns["Bills"].Visible = false;
            dgvUser.ClearSelection();
        }

        private void LoadFood()
        {
            using (var DbContext = new AppContext())
            {
                foods = DbContext.Foods.ToList();
            }
            cbbFoodCate.DisplayMember = "Text";
            cbbFoodCate.ValueMember = "Value";
            cbbFoodCate.Items.Clear();
            foodCates.ForEach(e =>
            {
                cbbFoodCate.Items.Add(new { Text = e.Name, Value = e.Id });
            });

            dgvFood.DataSource = foods;
            dgvFood.Columns["BillInfos"].Visible = false;
            dgvFood.Columns["FoodCategory"].Visible = false;
            dgvFood.ClearSelection();
        }
        private void LoadFoodCates()
        {
            using (var DbContext = new AppContext())
            {
                foodCates = DbContext.FoodCategories.ToList();
            }
            dgvFoodCate.DataSource = foodCates;
            dgvFoodCate.Columns["foods"].Visible = false;
            dgvFoodCate.ClearSelection();
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
            tbCateName.Text = "";
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
            tbCateName.Text = "";
            currentFoodCateId = null;
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
            tbCateName.Text = "";
            currentFoodCateId = null;
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
            ResetUserData();

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
            ResetUserData();
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
            ResetUserData();
        }

        private void ResetUserData()
        {
            currentUserId = null;
            tbDislayNameUser.Text = "";
            tbUsername.Text = "";
            tbPassword.Text = "";
            rBtnAdmin.Checked =  false;
            rBtnStaff.Checked =  false;
        }

        private void ResetFoodData()
        {
            currentFoodId = null;
            tbFoodName.Text = "";
            tbFoodPrice.Text = "";
            cbbFoodCate.SelectedItem = "";
        }

        private void dgvUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int UserId;
            if(int.TryParse(dgvUser.Rows[e.RowIndex].Cells["Id"].Value.ToString(),out UserId))
            {
                tbDislayNameUser.Text = dgvUser.Rows[e.RowIndex].Cells["DislayName"].Value.ToString();
                tbUsername.Text = dgvUser.Rows[e.RowIndex].Cells["Username"].Value.ToString();
                tbPassword.Text = dgvUser.Rows[e.RowIndex].Cells["Password"].Value.ToString();
                rBtnAdmin.Checked = (Role)dgvUser.Rows[e.RowIndex].Cells["Role"].Value == Role.ADMIN ? true : false;
                rBtnStaff.Checked = (Role)dgvUser.Rows[e.RowIndex].Cells["Role"].Value == Role.STAFF ? true : false;
            }
            currentUserId = UserId;
        }

        private void dgvFoodCate_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int CateId;
            if (int.TryParse(dgvFoodCate.Rows[e.RowIndex].Cells["Id"].Value.ToString(), out CateId))
            {
                tbCateName.Text = dgvFoodCate.Rows[e.RowIndex].Cells["Name"].Value.ToString();
            }
            currentFoodCateId = CateId;
        }

        private void btnAddFood_Click(object sender, EventArgs e)
        {
            Food food= new Food();
            food.Name = tbFoodName.Text;
            float price;
            if (float.TryParse(tbFoodPrice.Text, out price)) 
            {
                food.Price = price;   
            };
            food.FoodCategoryId = (cbbFoodCate.SelectedItem as dynamic).Value;
            food.Content = ConvertImage.ImageToByteArray(pbFoodImage.Image);
            using (var DbContext = new AppContext())
            {
                DbContext.Foods.Add(food);
                DbContext.SaveChanges();
            }
            LoadFood();
            ResetFoodData();
        }

        private void btnUpdateFood_Click(object sender, EventArgs e)
        {
            using (var DbContext = new AppContext())
            {
                Food food = DbContext.Foods.Find(currentFoodId);
                if (food != null)
                {
                    food.Name = tbFoodName.Text;
                    float price;
                    if (float.TryParse(tbFoodPrice.Text, out price))
                    {
                        food.Price = price;
                    };
                    food.FoodCategoryId = (cbbFoodCate.SelectedItem as dynamic).Value;
                    food.Content = ConvertImage.ImageToByteArray(pbFoodImage.Image);
                    DbContext.Foods.AddOrUpdate(food);
                    DbContext.SaveChanges();
                }
            }
            LoadFood();
            ResetFoodData();
        }

        private void btnDeleteFood_Click(object sender, EventArgs e)
        {
            using (var DbContext = new AppContext())
            {
                Food food = DbContext.Foods.Find(currentFoodId);
                if (food != null)
                {
                    DbContext.Foods.Remove(food);
                    DbContext.SaveChanges();
                }
            }
            LoadFood();
            ResetFoodData();
        }

        private void dgvFood_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int FoodId;
            if (int.TryParse(dgvFood.Rows[e.RowIndex].Cells["Id"].Value.ToString(), out FoodId))
            {
                tbFoodName.Text = dgvFood.Rows[e.RowIndex].Cells["Name"].Value.ToString();
                tbFoodPrice.Text = dgvFood.Rows[e.RowIndex].Cells["Price"].Value.ToString();
                using (var DbContext = new AppContext())
                {
                    int FoodCateId;
                    if(int.TryParse(dgvFood.Rows[e.RowIndex].Cells["FoodCategoryId"].Value.ToString(), out FoodCateId))
                    {
                        FoodCategory fc = DbContext.FoodCategories.Find(FoodCateId);
                        cbbFoodCate.SelectedIndex = cbbFoodCate.FindString(fc.Name);
                    }

                    Food f = DbContext.Foods.Find(FoodId);
                    pbFoodImage.Image = ConvertImage.ByteArrayToImage(f.Content);


                }    
                    
            }
            currentFoodId = FoodId;
        }

        private void btnOpenImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();

            dialog.Title = "Open Image";
            dialog.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                pbFoodImage.Image = Image.FromFile(dialog.FileName);
                pbFoodImage.SizeMode = PictureBoxSizeMode.StretchImage;
            }

            dialog.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Bill> bills;
            float total;
            int staffId = (cbbStaff.SelectedItem as dynamic).Value;
            using (var DbContext = new AppContext())
            {
                if(staffId != 0)
                {
                    bills = DbContext.Bills.Where(b => b.StaffId == staffId)
                    .Where(b => b.Checkout > dtpStartDate.Value)
                    .Where(b => b.Checkout < dtpEndDate.Value).ToList();
                }
                else
                {
                    bills = DbContext.Bills
                    .Where(b => b.Checkout > dtpStartDate.Value)
                    .Where(b => b.Checkout < dtpEndDate.Value).ToList();
                }
                
                total = DbContext.Bills.Sum(b => b.TotalPrice);
            }
            dgvStatistic.DataSource = bills;
            dgvStatistic.Columns["Staff"].Visible = false;
            dgvStatistic.Columns["BillInfos"].Visible = false;
            lbTotalStatistic.Text = total.ToString();
        }
    }
}
