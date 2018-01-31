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
    public partial class frmRecipeBook : Form
    {
        private Controller controller;
        private Recipe currentRecipe = null;

        private Recipe selectRecipe = null; // for edit mode
        private Ingredient selectedIngredient = null;

        public frmRecipeBook(Controller controller)
        {
            InitializeComponent();
            this.controller = controller;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSaveIngredient_Click(object sender, EventArgs e)
        {

        }

        private void DgvRecipes_SelectionChanged(object sender, EventArgs e)
        {
            currentRecipe = controller.GetRecipeByID((long)dgvRecipes.SelectedRows[0].Cells[3].Value);
            clearIngredientsFields();
            populateIngredientsGrid();
        }

        private void clearIngredientsFields()
        {
            selectedIngredient = null;
            cbFoodItem.SelectedIndex = 0;
            tbQuantity.Text = "";
        }

        private void populateIngredientsGrid()
        {
            dsIngredients.Tables[0].Rows.Clear();
            foreach (var ingredient in currentRecipe.Ingredients)
            {
                dsIngredients.Tables[0].Rows.Add(ingredient.FoodItem.Name, ingredient.Qty, ingredient.FoodItem.Measure, ingredient.ID);
            }
        }
    }
}
