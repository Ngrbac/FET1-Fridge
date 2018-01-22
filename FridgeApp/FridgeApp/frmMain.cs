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
       
    public partial class frmMain : Form
    {
        private Controller controller;
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
            controller.FillFridgeGrid(dsFridgeGrid, filter);
        }

        private void btnFoodItems_Click(object sender, EventArgs e)
        {
            var addFoodItems = new frmFoodItems(controller);
            addFoodItems.ShowDialog();
        }
        
        private void tbSearch_KeyUp(object sender, KeyEventArgs e)
        {
            populateGrid(tbSearch.Text);
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            populateGrid("");
        }

        private void btnRecipeBook_Click(object sender, EventArgs e)
        {
            var addFoodItems = new frmRecipeBook(controller);
            addFoodItems.ShowDialog();
        }
    }
}
