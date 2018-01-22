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
    public partial class frmFoodItems : Form
    {
        private Controller controller;
        private FoodItem selectedItem = null;
        public frmFoodItems(Controller controller)
        {
            InitializeComponent();
            this.controller = controller;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvFoodItems.SelectedRows.Count == 0)
            {
                return;
            }
            var selectedItemName = dgvFoodItems.SelectedRows[0].Cells[0].Value.ToString();
            selectedItem = controller.GetFoodItemByName(selectedItemName);

            tbName.Text = selectedItem.Name;
            tbExpiresIn.Text = selectedItem.ExpirationDays.ToString();
            cbMeasure.SelectedItem = selectedItem.Measure;

        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            bool success;
            if (selectedItem != null)
            {
                success = updateAnExistingFoodItem();
                selectedItem = null;
            }                 
            else
            {
                success = insertNewFoodItem();
            }

            if (!success)
            {
                return;
            }

            populateGrid();
            cbMeasure.SelectedIndex = 0;
            tbName.Clear();
            tbExpiresIn.Clear();

        }
        

        private bool updateAnExistingFoodItem()
        {
            var name = tbName.Text;
            var expiresIn = tbExpiresIn.Text;
            var measure = cbMeasure.SelectedItem;

            if (String.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Name cannot be empty.");
                return false;
            }

            if (!isNumber(expiresIn))
            {
                MessageBox.Show("ExpiresIn is not a number.");
                return false;
            }

            selectedItem.Name = name;
            selectedItem.ExpirationDays = Convert.ToInt32(expiresIn);
            selectedItem.Measure = (Measurement)measure;

            return true;
        }

        private bool insertNewFoodItem()
        {
            var name = tbName.Text;
            var expiresIn = tbExpiresIn.Text;
            var measure = cbMeasure.SelectedItem;

            if (String.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Name cannot be empty.");
                return false;
            }

            if (!isNumber(expiresIn))
            {
                MessageBox.Show("ExpiresIn is not a number.");
                return false;
            }                     

            var addSuccessful = controller.AddFoodItem(name, Convert.ToInt32(expiresIn), (Measurement)measure);

            if (!addSuccessful)
            {
                MessageBox.Show("Item with that name already exists.");
                return false;
            }

            return true;
        }

        private bool isNumber(string input)
        {
            if (input == "")
            {
                return false;
            }
            
            foreach (var character in input)
            {
                
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
            return true;
        }

        private void populateGrid()
        {
            controller.FillFoodItemGrid(dsFoodItems);
        }
        private void frmFoodItems_Load(object sender, EventArgs e)
        {
            cbMeasure.Items.Add(new Measurement("Kilogram"));
            cbMeasure.Items.Add(new Measurement("Liter"));
            cbMeasure.Items.Add(new Measurement("Piece"));

            cbMeasure.SelectedIndex = 0;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            deleteFoodItem();
            populateGrid();
        }

        private void deleteFoodItem()
        {
            var selectedItem = dgvFoodItems.SelectedRows[0].Cells[0].Value;
            controller.DeleteFoodItem(selectedItem.ToString());
        }
        
       
    }
}
