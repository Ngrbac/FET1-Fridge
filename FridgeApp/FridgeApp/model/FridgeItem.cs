using Dapper;
using FridgeApp;
using System;
using System.Data;
using System.Windows.Forms;
using System.Linq;

namespace Lib
{
    public class FridgeItem : MeasuredItem
    {
        public DateTime TimeAdded;
        public long DaysRemainOnAdd;

        //konstruktori

        public FridgeItem(FoodItem item, decimal qty, DateTime timeAdded, long daysRemaining) : base(item, qty)
        { 
            TimeAdded = timeAdded;
            DaysRemainOnAdd = daysRemaining;
        }

        public FridgeItem(long id, FoodItem item, decimal qty, DateTime timeAdded, long daysRemaining) : base(id, item, qty)
        {
            TimeAdded = timeAdded;
            DaysRemainOnAdd = daysRemaining;
        }
        //izracun preostalih dana za izmjene
        public long DaysRemaining()
        {
            var daysElapsed = DateTime.Now - TimeAdded;
            return DaysRemainOnAdd - daysElapsed.Days;
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
                "INSERT INTO FridgeItem (FoodItemID, Qty, TimeAdded, DaysRemainOnAdd )" + Environment.NewLine +
                "VALUES (@FoodItemID, @Qty, @TimeAdded, @DaysRemainOnAdd)";

            DynamicParameters parameter = new DynamicParameters();

            parameter.Add("@FoodItemID", FoodItem.ID, DbType.String, ParameterDirection.Input);
            parameter.Add("@Qty", Qty, DbType.Decimal, ParameterDirection.Input);
            parameter.Add("@TimeAdded", TimeAdded, DbType.Date, ParameterDirection.Input);
            parameter.Add("@DaysRemainOnAdd", DaysRemainOnAdd, DbType.Int64, ParameterDirection.Input);
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
                "UPDATE FridgeItem " + Environment.NewLine +
                "SET    FoodItemID = @FoodItemID, " + Environment.NewLine +
                "       Qty = @Qty, " + Environment.NewLine +
                "       TimeAdded = @TimeAdded, " + Environment.NewLine +
                "       DaysRemainOnAdd = @DaysRemainOnAdd" + Environment.NewLine +
                "WHERE  ID = @ID";

            DynamicParameters parameter = new DynamicParameters();

            parameter.Add("@FoodItemID", FoodItem.ID, DbType.String, ParameterDirection.Input);
            parameter.Add("@Qty", Qty, DbType.Decimal, ParameterDirection.Input);
            parameter.Add("@TimeAdded", TimeAdded, DbType.Date, ParameterDirection.Input);
            parameter.Add("@DaysRemainOnAdd", DaysRemainOnAdd, DbType.Int64, ParameterDirection.Input);
            parameter.Add("@ID", ID, DbType.Int64, ParameterDirection.Input);
            DBLink.ExecuteSQL(sql, parameter);
            
            DBLink.TryDisconnect();
        }

        

        public void SetRemainingDays(long daysRemaining)
        {
            var timeExpired = (DateTime.Now - TimeAdded).Days;
            DaysRemainOnAdd = daysRemaining + timeExpired;
        }

        public void Delete()
        {
            if (!DBLink.TryConnect())
            {
                MessageBox.Show("Cannot connect to the db");
                return;
            }

            string sql = "" +
                "DELETE FROM FridgeItem " + Environment.NewLine +
                "WHERE  ID = @ID";

            DynamicParameters parameter = new DynamicParameters();
            
            parameter.Add("@ID", ID, DbType.Int64, ParameterDirection.Input);
            DBLink.ExecuteSQL(sql, parameter);

            DBLink.TryDisconnect();
        }
    }

}

//(2 days ago)
//(12 days remaining then)
//10 days remaining now -- editable

//change to 15 days remaining
//edit db daysRemainingOnAdd = 15 + 2