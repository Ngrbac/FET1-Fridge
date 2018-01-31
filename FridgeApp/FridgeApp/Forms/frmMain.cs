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
       
    public partial class frmMain : Form
    {
        private Controller controller;
        private FridgeItem selectedItem = null;
        public frmMain()
        {
            InitializeComponent();
            controller = new Controller();
        }

        private void btnAddFridgeItem_Click(object sender, EventArgs e)
        {
            //var item = new FoodItem();
            //controller.AddItemToFridge(item, 10);
            //populateGrid();

            var addFridgeItem = new frmAddFridgeItem(controller);
            var result = addFridgeItem.ShowDialog();
            if (result == DialogResult.OK)
            {
                populateGrid(tbSearch.Text);
            }
        }

        private void populateGrid(string filter)
        {
            controller.FillFridgeGrid(dsFridgeItems, filter);
        }

        private void btnFoodItems_Click(object sender, EventArgs e)
        {
            var addFoodItems = new frmFoodItems(controller);
            addFoodItems.ShowDialog();
            loadCbFoodItems();
        }
        
        private void tbSearch_KeyUp(object sender, KeyEventArgs e)
        {
            populateGrid(tbSearch.Text);
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            populateGrid("");
            loadCbFoodItems();
        }

        private void loadCbFoodItems()
        {
            var foodItems = controller.GetAllFoodItems();
            cbFoodItem.Items.Clear();
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

        private void btnRecipeBook_Click(object sender, EventArgs e)
        {
            var addFoodItems = new frmRecipeBook(controller);
            addFoodItems.ShowDialog();
        }

        private void btnMeasurement_Click(object sender, EventArgs e)
        {
            var measurements = new frmMeasurement(controller);
            measurements.ShowDialog();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!isDecimal(tbQty.Text))
            {
                MessageBox.Show("Please enter a decimal for the Quantity");
                return;
            }
            if (!isNumber(tbDaysRemaining.Text))
            {
                MessageBox.Show("Please enter a number for the Days remaining");
                return;
            }
            if (selectedItem != null)
            {
                updateFridgeItem();
                selectedItem = null;
            }
            else
            {
                insertFridgeItem();
            }
            cbFoodItem.SelectedIndex = 0;
            tbDaysRemaining.Text = "";
            tbQty.Text = "";
            populateGrid(tbSearch.Text);
        }

        private bool isNumber(string input)
        {
            var decimalSeparator = Convert.ToChar(CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator);
            return isDecimal(input) && !input.Contains(decimalSeparator);
        }

        private bool isDecimal(string input)
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

        private void insertFridgeItem()
        {
            controller.AddItemToFridge((FoodItem)cbFoodItem.SelectedItem, Convert.ToDecimal(tbQty.Text), Convert.ToInt64(tbDaysRemaining.Text));
        }

        private void updateFridgeItem()
        {
            selectedItem.FoodItem = (FoodItem)cbFoodItem.SelectedItem;
            selectedItem.Qty = Convert.ToDecimal(tbQty.Text);
            selectedItem.SetRemainingDays(Convert.ToInt64(tbDaysRemaining.Text));
            selectedItem.Save();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            long id = (long)dgvFridgeGrid.SelectedRows[0].Cells[4].Value;
            selectedItem = controller.GetFridgeItem(id);
            if (selectedItem != null)
            {
                cbFoodItem.SelectedItem = selectedItem.FoodItem;
                tbQty.Text = selectedItem.Qty.ToString();
                tbDaysRemaining.Text = selectedItem.DaysRemaining().ToString();
            }
        }

        private void cbFoodItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbDaysRemaining.Text = ((FoodItem)cbFoodItem.SelectedItem).ExpirationDays.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            long id = (long)dgvFridgeGrid.SelectedRows[0].Cells[4].Value;
            controller.DeleteFridgeItem(id);
            populateGrid(tbSearch.Text);
        }
    }
}
