using RefrigeratorApp.lib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RefrigeratorApp
{
    public partial class frmMain : Form
    {
        Refrigerator ourFridge = new Refrigerator();
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ourFridge.Name = "OurFridge";
            var newIngredient = tbAddIngredient.Text;
            ourFridge.Ingredients.Add(newIngredient);
        }
    }
}
