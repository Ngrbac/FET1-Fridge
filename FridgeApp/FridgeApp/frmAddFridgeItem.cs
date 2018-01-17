using Lib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FridgeApp
{
    public partial class frmAddFridgeItem : Form
    {
        private Controller controller;
        public frmAddFridgeItem(Controller controller)
        {
            InitializeComponent();
            this.controller = controller;
        }


        private void frmAddFridgeItem_Load(object sender, EventArgs e)
        {
            var foodItems = controller.GetAllFoodItems();

            foreach (var item in foodItems)
            {
                cbFoodItem.Items.Add(item);
            }
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            var item = (FoodItem)cbFoodItem.SelectedItem;
            var qty = Convert.ToDecimal(tbQuantity.Text);
            controller.AddItemToFridge(item, qty);
        }

        private void cbFoodItem_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
