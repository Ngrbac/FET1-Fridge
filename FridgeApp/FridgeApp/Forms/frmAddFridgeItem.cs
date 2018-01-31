using Lib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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
            if (foodItems.Count == 0)
            {
                return;
            }
            cbFoodItem.SelectedIndex = 0;
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            //var item = (FoodItem)cbFoodItem.SelectedItem;
            //var qty = Convert.ToDecimal(tbQuantity.Text);
            //controller.AddItemToFridge(item, qty);
        }

        private bool isDecimal(String input)
        {
            if (input == "")
            {
                return false;
            }
            var decimalSeparator = Convert.ToChar(CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator);
            if (input.StartsWith(decimalSeparator.ToString()))
            {
                return false;
            }

            if (input.EndsWith(decimalSeparator.ToString()))
            {
                return false;
            }

            var i = 0;
            
            foreach (var character in input)
            {                
                if (character == decimalSeparator)
                {
                    if (i >= 1)
                    {
                        return false;
                    }
                    i++;
                    continue;
                }
                switch (character)
                {
                    case '1':
                        break;
                    case '2':
                        break;
                    case '3':
                        break;
                    case '4':
                        break;
                    case '5':
                        break;
                    case '6':
                        break;
                    case '7':
                        break;
                    case '8':
                        break;
                    case '9':
                        break;
                    case '0':
                        break;
                    default:
                        return false;                       
                }
            }
            var qty = Convert.ToDecimal(input);
            if (qty <= 0)
            {
                return false;
            }
            return true;
        }
        private void cbFoodItem_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tbQuantity_TextChanged(object sender, EventArgs e)
        {
            if (isDecimal(tbQuantity.Text))
            {
                btnAccept.Enabled = true;
            }
            else
            {
                btnAccept.Enabled = false;
            }
        }
        
        private void tbQuantity_Leave(object sender, EventArgs e)
        {
            
            
        }
    }
}
