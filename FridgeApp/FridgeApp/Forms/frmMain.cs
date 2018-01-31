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
        //Izvršava ove funkcije pri pokretanju prozora
        private void frmMain_Load(object sender, EventArgs e)
        {
            populateGrid("");
            loadCbFoodItems();
        }
        //Popunjava tablicu tablicu sa podacima iz dataseta uz filtriranje iz searcha
        private void populateGrid(string filter)
        {
            controller.FillFridgeGrid(dsFridgeItems, filter);
        }
        //Puni combobox sa food itemima
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
        //Funkcija koja dodaje novu stvar u frizider
        private void insertFridgeItem()
        {
            controller.AddItemToFridge((FoodItem)cbFoodItem.SelectedItem, Convert.ToDecimal(tbQty.Text), Convert.ToInt64(tbDaysRemaining.Text));
        }
        // Ažurira stvar u frižideru
        private void updateFridgeItem()
        {
            selectedItem.FoodItem = (FoodItem)cbFoodItem.SelectedItem;
            selectedItem.Qty = Convert.ToDecimal(tbQty.Text);
            selectedItem.SetRemainingDays(Convert.ToInt64(tbDaysRemaining.Text));
            selectedItem.Save();
        }


        // Dugmad
        #region Buttons

        //Dugmad menija
        private void btnFoodItems_Click(object sender, EventArgs e)
        {
            var addFoodItems = new frmFoodItems(controller);
            addFoodItems.ShowDialog();
            loadCbFoodItems();
        }
        private void btnMeasurement_Click(object sender, EventArgs e)
        {
            var measurements = new frmMeasurement(controller);
            measurements.ShowDialog();
        }
        private void btnRecipeBook_Click(object sender, EventArgs e)
        {
            var addFoodItems = new frmRecipeBook(controller);
            addFoodItems.ShowDialog();
        }

        //Dugmad za upravljanje stvarima

            //
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!isDecimal(tbQty.Text))                                                  //
            {                                                                            //
                MessageBox.Show("Please enter a decimal for the Quantity");              //    Provjera da su upisani podaci ispravni za pohranu
                return;                                                                  //
            }                                                                            //
            if (!isNumber(tbDaysRemaining.Text))                                         //    Ako nisu, skače obavijest
            {                                                                            //
                MessageBox.Show("Please enter a number for the Days remaining");         //
                return;                                                                  //
            }                                                                            //
            if (selectedItem != null)
            {
                updateFridgeItem();
                selectedItem = null;
            }
            else
            {
                insertFridgeItem();
            }
            
            cbFoodItem.SelectedIndex = 0;              // Prazni polja, odnosno vraca na početno stanje
            tbDaysRemaining.Text = "";                 //
            tbQty.Text = "";                           //
            populateGrid(tbSearch.Text);               // Puni tablicu sa novim stanjem
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            long id = (long)dgvFridgeGrid.SelectedRows[0].Cells[4].Value;
            selectedItem = controller.GetFridgeItem(id);
            if (selectedItem != null)
            {
                cbFoodItem.SelectedItem = selectedItem.FoodItem;                       // Postavlja polja unosa na vrijednosti iz odabranog itema
                tbQty.Text = selectedItem.Qty.ToString();                              //
                tbDaysRemaining.Text = selectedItem.DaysRemaining().ToString();        //
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            long id = (long)dgvFridgeGrid.SelectedRows[0].Cells[4].Value;              // (long) - kastanje, iza longa: odabir točne ćelije iz datagridviewa
            controller.DeleteFridgeItem(id);
            populateGrid(tbSearch.Text);
        }
        #endregion


        

        
        //Pomocne metode
        private void cbFoodItem_SelectedIndexChanged(object sender, EventArgs e)       //postavlja u preostale dane vrijednost iz baze
        {
            tbDaysRemaining.Text = ((FoodItem)cbFoodItem.SelectedItem).ExpirationDays.ToString();
        }    
        private bool isNumber(string input)
        {
            var decimalSeparator = Convert.ToChar(CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator);
            return isDecimal(input) && !input.Contains(decimalSeparator);
        }                                         //provjera da li je nešto broj (broj dana)
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
        }                                        //provjera je li nesto decimal (količina)
        private void tbSearch_KeyUp(object sender, KeyEventArgs e)
        {
            populateGrid(tbSearch.Text);
        }

    }
}
