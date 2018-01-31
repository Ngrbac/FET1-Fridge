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
    public class Recipe
    {
        public long ID;
        public string Name;
        public long CookTime;
        public string Description;
        public List<Ingredient> Ingredients;

        public Recipe(string name, long cookTime, string desc)
        {
            ID = -1;
            Name = name;
            CookTime = cookTime;
            Description = desc;
            Ingredients = new List<Ingredient>();
        }

        public Recipe(long id, string name, long cookTime, string desc)
        {
            ID = id;
            Name = name;
            CookTime = cookTime;
            Description = desc;
            Ingredients = new List<Ingredient>();
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

        public void AddIngredient(FoodItem item, decimal qty)
        {
            if (ID == -1)
            {
                MessageBox.Show("Please save the  recipe first");
                return;
            }
            var newIngredient = new Ingredient(this, item, qty);
            Ingredients.Add(newIngredient);
            newIngredient.Save();
        }

        public void RemoveIngredient(long id)
        {
            var removeIng = GetIngredientByID(id);
            Ingredients.Remove(removeIng);
            removeIng.Delete();
        }

        public Ingredient GetIngredientByID(long id)
        {
            foreach (var ingredient in Ingredients)
            {
                if (ingredient.ID == id)
                {
                    return ingredient;
                }
                
            }
            return null;
        }
        #region DB
        private void update()
        {
            if (!DBLink.TryConnect())
            {
                MessageBox.Show("Cannot connect to the db");
                return;
            }

            string sql = "" +
                "UPDATE Recipe" + Environment.NewLine +
                "SET Name = @Name, CookTime = @CookTime, Desc = @Desc" + Environment.NewLine +
                "WHERE ID = @ID";
                

            DynamicParameters parameter = new DynamicParameters();

            parameter.Add("@ID", ID, DbType.Int64, ParameterDirection.Input);
            parameter.Add("@Name", Name, DbType.String, ParameterDirection.Input);
            parameter.Add("@CookTime", CookTime, DbType.Int64, ParameterDirection.Input);
            parameter.Add("@Desc", Description, DbType.String, ParameterDirection.Input);
            DBLink.ExecuteSQL(sql, parameter);

            ID = DBLink.Query<int>("SELECT last_insert_rowid() AS ID").First();

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
                "INSERT INTO Recipe (Name, CookTime, Desc)" + Environment.NewLine +
                "VALUES (@Name, @CookTime, @Desc)";

            DynamicParameters parameter = new DynamicParameters();

            parameter.Add("@Name", Name, DbType.String, ParameterDirection.Input);
            parameter.Add("@CookTime", CookTime, DbType.Int64, ParameterDirection.Input);
            parameter.Add("@Desc", Description, DbType.String, ParameterDirection.Input);
            DBLink.ExecuteSQL(sql, parameter);

            ID = DBLink.Query<int>("SELECT last_insert_rowid() AS ID").First();

            DBLink.TryDisconnect();
        }

        public void Delete()
        {
            foreach (var ingredient in Ingredients)
            {
                ingredient.Delete();
            }

            if (!DBLink.TryConnect())
            {
                MessageBox.Show("Cannot connect to the db");
                return;
            }

            string sql = "" +
                "DELETE FROM Recipe " + Environment.NewLine +
                "WHERE ID = @ID";
            
            DynamicParameters parameter = new DynamicParameters();

            parameter.Add("@ID", ID, DbType.Int64, ParameterDirection.Input);            
            DBLink.ExecuteSQL(sql, parameter);

            DBLink.TryDisconnect();
        }
        #endregion
    }
}
