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
                populateGrid();
            }
        }

        private void populateGrid()
        {
            controller.FillGrid(dsFridgeGrid);
        }

        private void btnFoodItems_Click(object sender, EventArgs e)
        {
            var addFoodItems = new frmFoodItems(controller);
            addFoodItems.ShowDialog();
        }
    }
}
