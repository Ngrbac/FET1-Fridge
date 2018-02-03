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
    public partial class frmRecipeBook : Form
    {
        private Controller controller;
        private Recipe currentRecipe = null;
        private Recipe selectRecipe = null; // for edit mode
        private Ingredient selectedIngredient = null;
        //private bool editCheck = false;

        public frmRecipeBook(Controller controller)
        {
            InitializeComponent();
            this.controller = controller;

        }
        private void frmRecipeBook_Load(object sender, EventArgs e)
        {
            loadCbFoodItems();
            populateRecipeGrid();
            populateIngredientsGrid();
        }

        private void btnSaveIngredient_Click(object sender, EventArgs e)
        {
            if (!isDecimal(tbQuantity.Text))
            {
                MessageBox.Show("Please enter a decimal for the Quantity");
                return;
            }
            if (selectedIngredient != null)
            {
                selectedIngredient.FoodItem = (FoodItem)cbFoodItem.SelectedItem;
                selectedIngredient.Qty = Convert.ToDecimal(tbQuantity.Text);
                selectedIngredient.Save();
            }
            else
            {
                currentRecipe.AddIngredient((FoodItem)cbFoodItem.SelectedItem, Convert.ToDecimal(tbQuantity.Text));
            }            
            populateIngredientsGrid();
            colorCurrentRecipe();
        }

        private void colorCurrentRecipe()
        {
            Color color;
            if (controller.HasSupply(currentRecipe))
            {
                color = Color.LightGreen;
            }
            else
            {
                color = Color.White;
            }
            foreach (DataGridViewCell cell in dgvRecipes.SelectedRows[0].Cells)
            {
                cell.Style.BackColor = color;
            }
        }
        private void DgvRecipes_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvRecipes.SelectedRows.Count == 0)
            {
                return;
            }
            currentRecipe = controller.GetRecipeByID((long)dgvRecipes.SelectedRows[0].Cells[1].Value);
            clearIngredientsFields();
            populateIngredientsGrid();
        }

        private void colorIngredients()
        {
            foreach (var ingredient in currentRecipe.Ingredients)
            {
                if (controller.HasSupply(ingredient))
                {
                    var row = getIngredientRow(ingredient);
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        cell.Style.BackColor = Color.LightGreen; 
                    }
                }
            }
        }
        private void colorRecipes()
        {
            foreach (DataGridViewRow row in dgvRecipes.Rows)
            {
                var recipe = controller.GetRecipeByID((long)row.Cells[1].Value);

                if (controller.HasSupply(recipe))
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        cell.Style.BackColor = Color.LightGreen;
                    }
                }
            }
        }

        
        private DataGridViewRow getIngredientRow(Ingredient ingredient)
        {
            foreach (DataGridViewRow row in dgvIngredients.Rows)
            {
                if (ingredient.ID == (long)row.Cells[0].Value)
                {
                    return row; 
                }                
            }
            return null;
        }
        private void clearIngredientsFields()
        {
            selectedIngredient = null;
            cbFoodItem.SelectedIndex = 0;
            tbQuantity.Text = "";
        }

        private void populateIngredientsGrid()
        {
            if (currentRecipe != null)
            {
                dsIngredients.Tables[0].Rows.Clear();
                foreach (var ingredient in currentRecipe.Ingredients)
                {
                    dsIngredients.Tables[0].Rows.Add(ingredient.FoodItem.Name, ingredient.Qty, ingredient.FoodItem.Measure, ingredient.ID);
                }
            }
            colorIngredients();
        } 
        private void btnSaveRecipe_Click(object sender, EventArgs e)
        {
            if (!isNumber(tbCookTime.Text))
            {
                MessageBox.Show("Please enter a number for the cooking time");
                return;
            }
            if (selectRecipe != null)
            {
                updateRecipe();
                selectedIngredient = null;
            }
            else
            {
                insertRecipe();
            }
            tbName.Text = "";
            tbCookTime.Text = "";
            tbDescription.Text = "";
            populateRecipeGrid();
            populateIngredientsGrid();
            selectRecipe = null;
        }

        private void populateRecipeGrid()
        {
            controller.FillRecipeGrid(dsRecipes);
            colorRecipes();
        }

        private void insertRecipe()
        {
            controller.AddRecipeToRecipeBook(tbName.Text, Convert.ToInt64(tbCookTime.Text), tbDescription.Text);
            controller.FillRecipeGrid(dsRecipes);
        }

        private void updateRecipe()
        {
            selectRecipe.Name = tbName.Text;
            selectRecipe.CookTime = Convert.ToInt64(tbCookTime.Text);
            selectRecipe.Description = tbDescription.Text;
            selectRecipe.Save();
            controller.FillRecipeGrid(dsRecipes);
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

        

        private void btnEditRecipe_Click(object sender, EventArgs e)
        {
            if (dgvRecipes.SelectedRows.Count == 0)
            {
                return;
            }
            var selectRecipeID = (long)dgvRecipes.SelectedRows[0].Cells[1].Value;
            selectRecipe = controller.GetRecipeByID(selectRecipeID);

            tbName.Text = selectRecipe.Name;
            tbCookTime.Text = selectRecipe.CookTime.ToString();
            tbDescription.Text = selectRecipe.Description;
        }

        private void btnDeleteRecipe_Click(object sender, EventArgs e)
        {
            var selectRecipeID = (long)dgvRecipes.SelectedRows[0].Cells[1].Value;
            controller.DeleteRecipe(selectRecipeID);
            populateRecipeGrid();
            
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

        private void btnDeleteIngredient_Click(object sender, EventArgs e)
        {
            var selectedIng = (long)dgvIngredients.SelectedRows[0].Cells[0].Value;
            currentRecipe.RemoveIngredient(selectedIng);               
            populateIngredientsGrid();
            colorCurrentRecipe();
        }

        private void btnEditIngredient_Click(object sender, EventArgs e)
        {
            selectedIngredient = currentRecipe.GetIngredientByID((long)dgvIngredients.SelectedRows[0].Cells[0].Value);
            if (selectedIngredient != null)
            {
                cbFoodItem.SelectedItem = selectedIngredient.FoodItem;
                tbQuantity.Text = selectedIngredient.Qty.ToString();              
            }            
        }
    }
}
