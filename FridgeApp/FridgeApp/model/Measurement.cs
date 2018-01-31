using Dapper;
using FridgeApp;
using System;
using System.Data;
using System.Windows.Forms;
using System.Linq;

namespace Lib
{
	public class Measurement
	{
        public long ID { get; private set; }
		public string Name;
        public string Shortname;

		
        public Measurement(string name, string shortname)
        {
            ID = -1;
            Name = name;
            Shortname = shortname;
        }
        public Measurement(long id, string name, string shortname)
        {
            ID = id;
            Name = name;
            Shortname = shortname;
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

        private void update()
        {
            if (!DBLink.TryConnect())
            {
                MessageBox.Show("Cannot connect to the db");
                return;
            }

            string sql = "" +
                "UPDATE Measurement" + Environment.NewLine +
                "SET    Name = @Name," + Environment.NewLine +
                "       ShortName = @Shortname" + Environment.NewLine +
                "WHERE  ID = @ID";
            DynamicParameters parameter = new DynamicParameters();

            parameter.Add("@ID", ID, DbType.Int64, ParameterDirection.Input);
            parameter.Add("@Name", Name, DbType.String, ParameterDirection.Input);
            parameter.Add("@Shortname", Shortname, DbType.String, ParameterDirection.Input);
            //parameter.Add("@RowCount", dbType: DbType.Int32, direction: ParameterDirection.ReturnValue);
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
                "INSERT INTO Measurement (Name, ShortName)" + Environment.NewLine +
                "VALUES (@Name, @Shortname)";

            DynamicParameters parameter = new DynamicParameters();
            
            parameter.Add("@Name", Name, DbType.String, ParameterDirection.Input);
            parameter.Add("@Shortname", Shortname, DbType.String, ParameterDirection.Input);
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
                "DELETE FROM Measurement" + Environment.NewLine +
                "WHERE  ID = @ID";
            DynamicParameters parameter = new DynamicParameters();

            parameter.Add("@ID", ID, DbType.Int64, ParameterDirection.Input);
            
            DBLink.ExecuteSQL(sql, parameter);
            DBLink.TryDisconnect();
        }
    }
}
