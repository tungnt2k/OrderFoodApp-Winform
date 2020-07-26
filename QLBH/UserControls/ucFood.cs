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
using QLBH.Events;

namespace QLBH.UserControls
{
    public partial class ucFood : UserControl
    {
        private Food food;
        public event EventHandler<BillInfoArg> changeFoodCount;
        public ucFood(Food f)
        {
            InitializeComponent();
            food = f;
            lbFoodName.Text = f.Name;
            pbFoodImage.Image = ConvertImage.ByteArrayToImage(food.Content);
        }

        private void nmCount_ValueChanged(object sender, EventArgs e)
        {
            BillInfo bf = new BillInfo();
            bf.FoodId = food.Id;
            bf.Count = int.Parse(nmCount.Value.ToString());
            changeFoodCount(sender, new BillInfoArg(bf));
        }
    }
}
