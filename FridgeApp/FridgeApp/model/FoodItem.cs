using Dapper;
using FridgeApp;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Lib
{
	public class FoodItem
	{
        public long ID;
		public string Name;
		public long ExpirationDays;
		public Measurement Measure;

        public FoodItem(string name, long expiresIn, Measurement measure)
        {
            ID = -1;
            Name = name;
            ExpirationDays = expiresIn;
            Measure = measure;
        }

        public FoodItem(long id, string name, long expiresIn, Measurement measure) 
        {
            ID = id;
            Name = name;
            ExpirationDays = expiresIn;
            Measure = measure;
        }

        public override string ToString()
        {
            return Name;
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
        private void insert()
        {
            if (!DBLink.TryConnect())
            {
                MessageBox.Show("Cannot connect to the db");
                return;
            }

            string sql = "" +
                "INSERT INTO FoodItem (Name, ExpirationDays, Measure)" + Environment.NewLine +
                "VALUES (@Name, @ExpirationDays, @Measure)";

            DynamicParameters parameter = new DynamicParameters();

            parameter.Add("@Name", Name, DbType.String, ParameterDirection.Input);
            parameter.Add("@ExpirationDays", ExpirationDays, DbType.Int64, ParameterDirection.Input);
            parameter.Add("@Measure", Measure.ID, DbType.Int64, ParameterDirection.Input);
            DBLink.ExecuteSQL(sql, parameter);

            ID = DBLink.Query<int>("SELECT last_insert_rowid() AS ID").First();

            DBLink.TryDisconnect();
        }

        private void update()
        {
            if (!DBLink.TryConnect())
            {
                MessageBox.Show("Cannot connect to the db");
                return;
            }

            string sql = "" +
                "UPDATE FoodItem" + Environment.NewLine +
                "SET    Name = @Name," + Environment.NewLine +
                "       ExpirationDays = @ExpirationDays," + Environment.NewLine +
                "       Measure = @Measure" + Environment.NewLine +
                "WHERE  ID = @ID";
            DynamicParameters parameter = new DynamicParameters();

            parameter.Add("@ID", ID, DbType.Int64, ParameterDirection.Input);
            parameter.Add("@Name", Name, DbType.String, ParameterDirection.Input);
            parameter.Add("@ExpirationDays", ExpirationDays, DbType.Int64, ParameterDirection.Input);
            parameter.Add("@Measure", Measure.ID, DbType.Int64, ParameterDirection.Input);
            //parameter.Add("@RowCount", dbType: DbType.Int32, direction: ParameterDirection.ReturnValue);
            DBLink.ExecuteSQL(sql, parameter);
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
                "DELETE FROM FoodItem" + Environment.NewLine +
                "WHERE  ID = @ID";
            DynamicParameters parameter = new DynamicParameters();

            parameter.Add("@ID", ID, DbType.Int64, ParameterDirection.Input);

            DBLink.ExecuteSQL(sql, parameter);
            DBLink.TryDisconnect();
        }
    }
}
