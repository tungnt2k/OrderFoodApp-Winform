using QLBH.Events;
using QLBH.Models;
using QLBH.UserControls;
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
        private List<Food> foods;
        private List<FoodCategory> categories;
        private List<BillInfo> orders = new List<BillInfo>();
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

        private void frmMain_Load(object sender, EventArgs e)
        {
            LoadFood();
            LoadCates();
        }

        private void LoadCates()
        {
            using (var DbContext = new AppContext())
            {
                categories = DbContext.FoodCategories.ToList();
            }
            cbbFoodCates.DisplayMember = "Text";
            cbbFoodCates.ValueMember = "Value";
            cbbFoodCates.Items.Clear();
            categories.ForEach(e =>
            {
                cbbFoodCates.Items.Add(new { Text = e.Name, Value = e.Id });
            });
        }

        private void LoadFood()
        {
            flpFood.Controls.Clear();
            using (var DbContext = new AppContext())
            {
                foods = DbContext.Foods.ToList();
            }
            foods.ForEach(e =>
            {
                ucFood uc = new ucFood(e);
                uc.changeFoodCount += new EventHandler<Events.BillInfoArg>(ucFood_changeFoodCount);
                flpFood.Controls.Add(uc);
            });
        }

        private void ucFood_changeFoodCount(object sender, BillInfoArg e)
        {
            if (orders!=null||orders.Count > 0)
            {
                int index = -1;
                orders.ForEach(x =>
                {
                    if (x.FoodId == e.billInfo.FoodId)
                    {
                        index = orders.IndexOf(x);
                    }
                });
                if (index != -1)
                {
                    orders.RemoveAt(index);
                }
            }
            if (e.billInfo.Count > 0)
            {
                orders.Add(e.billInfo);
            }

            LoadOrderList();

            if (orders != null || orders.Count > 0)
            {
                float totalPrice = 0;
                orders.ForEach(x =>
                {
                    Food f;
                    using (var DbContext = new AppContext())
                    {
                        f = DbContext.Foods.Find(x.FoodId);
                    }
                    totalPrice += (f.Price * x.Count);
                });
                tbTotalPrice.Text = totalPrice.ToString();
            }
        }

        private void LoadOrderList()
        {
            flpOrder.Controls.Clear();
            if (orders.Count > 0)
            {
                orders.ForEach(e =>
                {
                    ucOrder UcOrder = new ucOrder(e);
                    flpOrder.Controls.Add(UcOrder);
                });
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            flpFood.Controls.Clear();
            int? cateId = (cbbFoodCates.SelectedItem as dynamic).Value;
            using (var DbContext = new AppContext())
            {
                if(cateId!=null && tbKeyword.Text!="")
                {
                    foods = DbContext.Foods
                        .Where(f => f.FoodCategoryId == cateId)
                        .Where(f => f.Name.Contains(tbKeyword.Text)).ToList();
                }
                else if(cateId!=null)
                {
                    foods = DbContext.Foods
                       .Where(f => f.FoodCategoryId == cateId).ToList();
                }    
                else if(tbKeyword.Text!="")
                {
                    foods = DbContext.Foods
                        .Where(f => f.Name.Contains(tbKeyword.Text)).ToList();
                }
                else
                {
                    foods = DbContext.Foods.ToList();
                }
                
                
            }
            foods.ForEach(x =>
            {
                ucFood uc = new ucFood(x);
                flpFood.Controls.Add(uc);
            });
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ResetOrderData();
        }
        
        private void ResetOrderData()
        {
            orders = new List<BillInfo>();
            LoadOrderList();
            tbCustomerName.Text = "";
            tbCustomerTake.Text = "";
            tbReturnMoney.Text = "";
            tbTotalPrice.Text = "";
            LoadFood();
        }

        private void tbCustomerTake_TextChanged(object sender, EventArgs e)
        {
            float customerTake;
            if (tbCustomerTake.Text == "") return;
            if(float.TryParse(tbCustomerTake.Text,out customerTake))
            {
                tbReturnMoney.Text = (customerTake-float.Parse(tbTotalPrice.Text)).ToString();
            }
            else
            {
                MessageBox.Show("Bạn phải nhập vào một số ", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            if (float.Parse(tbReturnMoney.Text) < 0)
            {
                MessageBox.Show("Bạn vui lòng kiểm tra lại thông tin ", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                if (orders.Count > 0)
                {
                    Bill bill = new Bill();
                    bill.StaffId = user.Id;
                    bill.ReturnCustomer = float.Parse(tbReturnMoney.Text);
                    bill.TotalPrice = float.Parse(tbTotalPrice.Text);
                    bill.CustomerTake = float.Parse(tbCustomerTake.Text);
                    bill.CustomerName = tbCustomerName.Text;
                    bill.Checkout = DateTime.Now;
                    using (var DbContext = new AppContext())
                    {
                        DbContext.Bills.Add(bill);
                        DbContext.SaveChanges();
                    }
                    orders.ForEach(x =>
                    {
                        x.BillId = bill.Id;
                    });

                    using (var DbContext = new AppContext())
                    {
                        DbContext.BillInfos.AddRange(orders);
                        DbContext.SaveChanges();
                    }
                    MessageBox.Show("Thanh toán thành công ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ResetOrderData();
                }
                else
                {
                    MessageBox.Show("Bạn chưa order ", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }

            }

        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
