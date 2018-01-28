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
        private Refrigerator theFridge { get; set; }
        private Dictionary<string,FoodItem> foodItemStorage { get; set; }
        private Dictionary<string,Measurement> measurementStorage { get; set; }
        public Controller()
        {
            connectToDB();
            theFridge = new Refrigerator();
            foodItemStorage = new Dictionary<string, FoodItem>();
            loadMeasurements();
            //testData();
        }
        
        
   
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
)
";
            DBLink.ExecuteSQL(sqlMeasurement);
            DBLink.ExecuteSQL(sqlFoodItem);
            if (!res)
            {
                MessageBox.Show("Unable to connect to db");
            }
            DBLink.TryDisconnect();
        }

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

        public void FillMeasurementGrid(DataSet dsMeasurement)
        {
            dsMeasurement.Tables[0].Rows.Clear();
            foreach (var measurement in measurementStorage)
            {
                dsMeasurement.Tables[0].Rows.Add(measurement.Value.Name, measurement.Value.Shortname);
            }
        }

        internal void UpdateFoodItem(string oldName, string name, string expiresIn, object measure)
        {
            var selectedItem = foodItemStorage[oldName];
            selectedItem.Name = name;
            selectedItem.ExpirationDays = Convert.ToInt32(expiresIn);
            selectedItem.Measure = (Measurement)measure;
            selectedItem.Save();
            foodItemStorage.Remove(oldName);
            foodItemStorage.Add(name, selectedItem);
        }

        internal void UpdateMeasurement(string oldName, string name, string shortName)
        {
            var selectedItem = measurementStorage[oldName];
            selectedItem.Name = name;
            selectedItem.Shortname = shortName;
            selectedItem.Save();
            measurementStorage.Remove(oldName);
            measurementStorage.Add(name, selectedItem);
        }

        public Measurement GetMeasurement(string name)
        {
            return measurementStorage[name];
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

        public void DeleteMeasurement(string name)
        {
            measurementStorage[name].Delete();
            measurementStorage.Remove(name);            
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

        public List<Measurement> GetMeasurements()
        {
            var measurementList = new List<Measurement>();
            foreach (var measure in measurementStorage)
            {
                measurementList.Add(measure.Value);
            }
            return measurementList;
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
    }
}
