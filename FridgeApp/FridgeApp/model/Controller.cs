using Lib;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FridgeApp
{
    public class Controller
    {
        private List<Recipe> recipeBook { get; set; }
        private List<FridgeItem> fridge { get; set; }
        private Dictionary<string, FoodItem> foodItemStorage { get; set; }
        private Dictionary<string, Measurement> measurementStorage { get; set; }
        public Controller()
        {
            connectToDB();
            fridge = new List<FridgeItem>();
            foodItemStorage = new Dictionary<string, FoodItem>();
            loadMeasurements();
            loadFoodItems();
            loadFridgeItems();
            loadRecipeBook();
            //testData();
        }

        private void loadRecipeBook()
        {
            recipeBook = new List<Recipe>();
            //Load recipe
            if (!DBLink.TryConnect())
            {
                MessageBox.Show("Cannot connect to the db");
                return;
            }
            var sql = "SELECT ID, Name, CookTime, Desc FROM Recipe";
            var values = DBLink.Query(sql);
            foreach (var value in values)
            {
                var recipe = new Recipe(value.ID, value.Name, value.CookTime, value.Desc);
                recipeBook.Add(recipe);
            }
            DBLink.TryDisconnect();

            //Load ingredients
            if (!DBLink.TryConnect())
            {
                MessageBox.Show("Cannot connect to the db");
                return;
            }
            var sqlIng = "SELECT ID, FoodItemID, RecipeID, Qty FROM Ingredients";
            var valuesIng = DBLink.Query(sqlIng);
            foreach (var value in valuesIng)
            {
                var foodItem = GetFoodItemByID(value.FoodItemID);
                var recipe = GetRecipeByID(value.RecipeID);
                var ingredient = new Ingredient(value.ID, recipe, foodItem, value.Qty);
                recipe.Ingredients.Add(ingredient);
            }
            DBLink.TryDisconnect();
        }

        public Recipe GetRecipeByID(long recipeID)
        {
            foreach (var recipe in recipeBook)
            {
                if (recipe.ID == recipeID)
                {
                    return recipe;
                }
            }
            return null;
        }

        // DB connection part
        #region Database
        private void connectToDB()
        {
            var res = DBLink.TryConnect();

            string sqlMeasurement = @"
CREATE TABLE IF NOT EXISTS Measurement 
(
    ID          INTEGER PRIMARY KEY,
    Name        NVARCHAR(50) NOT NULL,
    ShortName   NVARCHAR(5) NOT NULL
)";
            string sqlFoodItem = @"
CREATE TABLE IF NOT EXISTS FoodItem
(
    ID              INTEGER PRIMARY KEY,
    Name            NVARCHAR(50) NOT NULL,
    ExpirationDays  INTEGER NOT NULL,
    Measure         INTEGER NOT NULL,
    FOREIGN KEY (Measure) REFERENCES Measurement (ID)
)";
            string sqlFridgeItem = @"
CREATE TABLE IF NOT EXISTS FridgeItem
(
    ID              INTEGER PRIMARY KEY,    
    FoodItemID      INTEGER NOT NULL,
    Qty             DECIMAL(18,6) NOT NULL,
    TimeAdded       DATETIME,
    DaysRemainOnAdd INTEGER NOT NULL,
    FOREIGN KEY (FoodItemID) REFERENCES FoodItem (ID)
)
";
            string sqlRecipe = @"
CREATE TABLE IF NOT EXISTS Recipe
(
    ID              INTEGER PRIMARY KEY,    
    Name            NVARCHAR NOT NULL,
    Cooktime        INTEGER NOT NULL,
    Desc            NVARCHAR NOT NULL,
 )";
            string sqlIngredients = @"
CREATE TABLE IF NOT EXISTS Ingredients
(
    ID              INTEGER PRIMARY KEY,    
    FoodItemID      INTEGER NOT NULL,
    RecipeID        INTEGER NOT NULL,
    Qty             DECIMAL(18,6) NOT NULL,
    FOREIGN KEY (FoodItemID) REFERENCES FoodItem (ID),
    FOREIGN KEY (RecipeID) REFERENCES Recipe (ID),
)
";

            DBLink.ExecuteSQL(sqlMeasurement);
            DBLink.ExecuteSQL(sqlFoodItem);
            DBLink.ExecuteSQL(sqlFridgeItem);
            DBLink.ExecuteSQL(sqlRecipe);
            DBLink.ExecuteSQL(sqlIngredients);

            if (!res)
            {
                MessageBox.Show("Unable to connect to db");
            }
            DBLink.TryDisconnect();
        }
        #endregion 
        // Measurement part
        #region Measurement

        public bool AddMeasurement(string name, string shortname)
        {
            if (measurementStorage.ContainsKey(name))
            {
                return false;
            }
            var measure = new Measurement(name, shortname);
            measurementStorage.Add(name, measure);
            measure.Save();
            return true;
        }
        public void UpdateMeasurement(string oldName, string name, string shortName)
        {
            var selectedItem = measurementStorage[oldName];
            selectedItem.Name = name;
            selectedItem.Shortname = shortName;
            selectedItem.Save();
            measurementStorage.Remove(oldName);
            measurementStorage.Add(name, selectedItem);
        }
        public void DeleteMeasurement(string name)
        {
            measurementStorage[name].Delete();
            measurementStorage.Remove(name);
        }
        private void loadMeasurements()
        {
            measurementStorage = new Dictionary<string, Measurement>();

            if (!DBLink.TryConnect())
            {
                MessageBox.Show("Cannot connect to the db");
                return;
            }
            var sql = "SELECT ID, Name, ShortName FROM Measurement";
            var values = DBLink.Query(sql);
            foreach (var value in values)
            {
                var measurement = new Measurement(value.ID, value.Name, value.ShortName);
                measurementStorage.Add(measurement.Name, measurement);
            }
            DBLink.TryDisconnect();
        }
        public void FillMeasurementGrid(DataSet dsMeasurement)
        {
            dsMeasurement.Tables[0].Rows.Clear();
            foreach (var measurement in measurementStorage)
            {
                dsMeasurement.Tables[0].Rows.Add(measurement.Value.Name, measurement.Value.Shortname);
            }
        }

        public Measurement GetMeasurement(string name)
        {
            return measurementStorage[name];
        }

        public Measurement GetMeasurementByID(long id)
        {
            foreach (var measure in measurementStorage)
            {
                if (id == measure.Value.ID)
                {
                    return measure.Value;
                }
            }
            return null;
        }
        public List<Measurement> GetMeasurements()
        {
            var measurementList = new List<Measurement>();
            foreach (var measure in measurementStorage)
            {
                measurementList.Add(measure.Value);
            }
            return measurementList;
        }

        #endregion


        // Food Item part
        #region FoodItem
        private FoodItem GetFoodItemByID(long foodItemID)
        {
            foreach (var foodItem in foodItemStorage)
            {
                if (foodItemID == foodItem.Value.ID)
                {
                    return foodItem.Value;
                }
            }
            return null;
        }
        public bool AddFoodItem(string name, long expiresIn, Measurement measure)
        {
            if (foodItemStorage.ContainsKey(name))
            {
                return false;
            }
            var foodItem = new FoodItem(name, expiresIn, measure);
            foodItemStorage.Add(name, foodItem);
            foodItem.Save();
            return true;
        }

        public void UpdateFoodItem(string oldName, string name, string expiresIn, object measure)
        {
            var selectedItem = foodItemStorage[oldName];
            selectedItem.Name = name;
            selectedItem.ExpirationDays = Convert.ToInt64(expiresIn);
            selectedItem.Measure = (Measurement)measure;
            selectedItem.Save();
            foodItemStorage.Remove(oldName);
            foodItemStorage.Add(name, selectedItem);
        }
        public void DeleteFoodItem(string name)
        {
            foodItemStorage[name].Delete();
            foodItemStorage.Remove(name);
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
        public void FillFoodItemGrid(DataSet dsFoodItems)
        {
            dsFoodItems.Tables[0].Rows.Clear();
            foreach (var foodItem in foodItemStorage)
            {
                dsFoodItems.Tables[0].Rows.Add(foodItem.Value.Name, foodItem.Value.ExpirationDays, foodItem.Value.Measure);
            }
        }

        public void DeleteFridgeItem(long id)
        {
            var item = GetFridgeItem(id);
            fridge.Remove(item);
            item.Delete();
        }

        private void loadFoodItems()
        {
            foodItemStorage = new Dictionary<string, FoodItem>();

            if (!DBLink.TryConnect())
            {
                MessageBox.Show("Cannot connect to the db");
                return;
            }
            var sql = "SELECT ID, Name, ExpirationDays, Measure FROM FoodItem";
            var values = DBLink.Query(sql);
            foreach (var value in values)
            {
                var measure = GetMeasurementByID(value.Measure);
                var foodItem = new FoodItem(value.ID, value.Name, value.ExpirationDays, measure);

                foodItemStorage.Add(foodItem.Name, foodItem);
            }
            DBLink.TryDisconnect();
        }
        #endregion


        // Fridge Item part
        #region FridgeItem

        public void AddItemToFridge(FoodItem item, decimal qty, long daysRemainingOnAdd)
        {
            var fridgeItem = new FridgeItem(item, qty, DateTime.Now, daysRemainingOnAdd);
            fridge.Add(fridgeItem);
            fridgeItem.Save();
        }

        public void FillFridgeGrid(DataSet dsFridgeItems, string filter)
        {
            dsFridgeItems.Tables[0].Rows.Clear();
            foreach (var fridgeItem in fridge)
            {
                if (fridgeItem.FoodItem.Name.ToUpper().Contains(filter.ToUpper()))
                {
                    dsFridgeItems.Tables[0].Rows.Add(fridgeItem.FoodItem.Name, fridgeItem.Qty, fridgeItem.FoodItem.Measure.Name, fridgeItem.DaysRemaining(), fridgeItem.ID);
                }
            }
        }

        private void loadFridgeItems()
        {
            fridge = new List<FridgeItem>();

            if (!DBLink.TryConnect())
            {
                MessageBox.Show("Cannot connect to the db");
                return;
            }
            var sql = "SELECT ID, FoodItemID, Qty, TimeAdded, DaysRemainOnAdd FROM FridgeItem";
            var values = DBLink.Query(sql);
            foreach (var value in values)
            {
                var foodItem = GetFoodItemByID(value.FoodItemID);
                var fridgeItem = new FridgeItem(value.ID, foodItem, value.Qty, value.TimeAdded, value.DaysRemainOnAdd);
                fridge.Add(fridgeItem);
            }
            DBLink.TryDisconnect();
        }

        public FridgeItem GetFridgeItem(long id)
        {
            foreach (var item in fridge)
            {
                if (id == item.ID)
                {
                    return item;
                }
            }
            return null;
        }
        #endregion
    }
}
