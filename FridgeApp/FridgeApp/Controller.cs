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
        private Dictionary<string,FoodItem> foodItemStorage { get; set; }
        public Controller()
        {
            theFridge = new Refrigerator();
            foodItemStorage = new Dictionary<string, FoodItem>();
            testData();
        }

        private void testData()
        {
            AddItemToFridge(new FoodItem("Orange", 10, new Measurement("Kilo")), 3);
            AddItemToFridge(new FoodItem("Apple", 11, new Measurement("Kilo")), 3);
            AddItemToFridge(new FoodItem("Orange Juice", 2, new Measurement("Liters")), 2);
        }

        public List<FoodItem> GetAllFoodItems()
        {
            List<FoodItem> result = new List<FoodItem>();
            foreach (var item in foodItemStorage)
            {
                result.Add(item.Value);
            }

            return result;
        }

        public FoodItem GetFoodItemByName(string selectedItemName)
        {
            return foodItemStorage[selectedItemName];
        }

        public void AddItemToFridge(FoodItem item, decimal qty)
        {
            theFridge.AddItem(item, qty);
             
        }

        public void FillFridgeGrid(DataSet dsFridgeGrid, string filter)
        {
            dsFridgeGrid.Tables[0].Rows.Clear();
            foreach (var fridgeItem in theFridge.Items)
            {
                if (fridgeItem.FoodItem.Name.ToUpper().Contains(filter.ToUpper()))
                {
                    dsFridgeGrid.Tables[0].Rows.Add(fridgeItem.FoodItem.Name, fridgeItem.Qty, fridgeItem.Measure.Name, fridgeItem.DaysRemaining());
                }
            }
        }

        public void FillFoodItemGrid(DataSet dsFoodItems)
        {
            dsFoodItems.Tables[0].Rows.Clear();
            foreach (var foodItem in foodItemStorage)
            {
                dsFoodItems.Tables[0].Rows.Add(foodItem.Value.Name, foodItem.Value.ExpirationDays, foodItem.Value.Measure);
            }
        }
        
        public bool AddFoodItem(string name, int expiresIn, Measurement measure)
        {
            if (foodItemStorage.ContainsKey(name))
            {
                return false;
            }
            foodItemStorage.Add(name, new FoodItem(name, expiresIn, measure));
            return true;
        }

        public void DeleteFoodItem(string name)
        {
            foodItemStorage.Remove(name);
        }
    }
}
