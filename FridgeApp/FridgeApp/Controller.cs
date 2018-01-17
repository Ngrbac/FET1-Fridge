using Lib;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FridgeApp
{
    public class Controller
    {
        private Refrigerator theFridge { get; set; }
        private List<FoodItem> foodItemStorage { get; set; }
        public Controller()
        {
            theFridge = new Refrigerator();
            foodItemStorage = new List<FoodItem>();

            foodItemStorage.Add(new FoodItem());
            foodItemStorage.Add(new FoodItem());
            foodItemStorage.Add(new FoodItem());
        }

        public List<FoodItem> GetAllFoodItems()
        {
            return foodItemStorage;
        }

        public void AddItemToFridge(FoodItem item, decimal qty)
        {
            theFridge.AddItem(item, qty);
             
        }

        public void FillGrid(DataSet dsFridgeGrid)
        {
            dsFridgeGrid.Tables[0].Rows.Clear();
            foreach (var fridgeItem in theFridge.Items)
            {
                dsFridgeGrid.Tables[0].Rows.Add(fridgeItem.FoodItem.Name, fridgeItem.Qty, fridgeItem.Measure.Name, fridgeItem.DaysRemaining());
            }
        }
    }
}
