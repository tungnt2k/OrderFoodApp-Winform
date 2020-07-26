using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLBH.Models;

namespace QLBH.UserControls
{
    public partial class ucOrder : UserControl
    {
        private BillInfo billInfo;
        public ucOrder(BillInfo bf)
        {
            InitializeComponent();
            billInfo = bf;
            lbCount.Text = billInfo.Count.ToString();
            using(var DbContext =new AppContext())
            {
                Food f = DbContext.Foods.Find(billInfo.FoodId);
                if (f != null)
                {
                    lbFoodName.Text = f.Name;
                    lbPrice.Text = f.Price.ToString();
                }
            }    
            
        }
    }
}
