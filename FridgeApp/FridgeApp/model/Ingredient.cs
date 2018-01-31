using Dapper;
using FridgeApp;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lib
{
    public class Ingredient: MeasuredItem
    {
        public Recipe Recipe { get; set; }
        public Ingredient(Recipe parent, FoodItem item, decimal qty):base(item, qty)
        {
            this.Recipe = parent;
        }

        public Ingredient(long id, Recipe parent, FoodItem item, decimal qty) : base(id, item, qty)
        {
            this.Recipe = parent;
        }

        public void Save()
        {
            if (ID == -1)
            {
                insert();
            }
            else
            {
                update();
            }            
        }

        private void update()
        {
            if (!DBLink.TryConnect())
            {
                MessageBox.Show("Cannot connect to the db");
                return;
            }

            string sql = "" +
                "UPDATE Ingredients " + Environment.NewLine +
                "SET    FoodItemID = @FoodItemID, " + Environment.NewLine +
                "       RecipeID = @RecipeID," + Environment.NewLine +
                "       Qty = @Qty, " + Environment.NewLine +
                "WHERE  ID = @ID";

            DynamicParameters parameter = new DynamicParameters();

            parameter.Add("@FoodItemID", FoodItem.ID, DbType.Int64, ParameterDirection.Input);
            parameter.Add("@Qty", Qty, DbType.Decimal, ParameterDirection.Input);            
            parameter.Add("@RecipeID", Recipe.ID, DbType.Int64, ParameterDirection.Input);
            parameter.Add("@ID", ID, DbType.Int64, ParameterDirection.Input);
            DBLink.ExecuteSQL(sql, parameter);

            DBLink.TryDisconnect();
        }

        private void insert()
        {
            if (!DBLink.TryConnect())
            {
                MessageBox.Show("Cannot connect to the db");
                return;
            }

            string sql = "" +
                "INSERT INTO Ingredients (FoodItemID, RecipeID, Qty)" + Environment.NewLine +
                "VALUES (@FoodItemID, @RecipeID, @Qty)";

            DynamicParameters parameter = new DynamicParameters();

            parameter.Add("@FoodItemID", FoodItem.ID, DbType.Int64, ParameterDirection.Input);
            parameter.Add("@Qty", Qty, DbType.Decimal, ParameterDirection.Input);
            parameter.Add("@RecipeID", Recipe.ID, DbType.Int64, ParameterDirection.Input);
            DBLink.ExecuteSQL(sql, parameter);

            ID = DBLink.Query<int>("SELECT last_insert_rowid() AS ID").First();

            DBLink.TryDisconnect();
        }

        public void Delete()
        {
            if (!DBLink.TryConnect())
            {
                MessageBox.Show("Cannot connect to the db");
                return;
            }

            string sql = "" +
                "DELETE FROM Ingredients " + Environment.NewLine +               
                "WHERE  ID = @ID";

            DynamicParameters parameter = new DynamicParameters();           
            parameter.Add("@ID", ID, DbType.Int64, ParameterDirection.Input);
            DBLink.ExecuteSQL(sql, parameter);

            DBLink.TryDisconnect();
        }
    }
}
