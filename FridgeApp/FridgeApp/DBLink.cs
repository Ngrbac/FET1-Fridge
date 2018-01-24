using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FridgeApp
{
    public static class DBLink
    {
        public static string ConnectionString
        {
            get { return ConnectionStringBuilder.ConnectionString; }
        }

        private static SqlConnectionStringBuilder ConnectionStringBuilder = new SqlConnectionStringBuilder();

        private static SqlConnection sqlConnection = new SqlConnection();
        public static SqlConnection SqlConnection
        {
            get
            {
                return sqlConnection;
            }
        }

        public static bool TryConnect()
        {
            bool success = true;
            sqlConnection.ConnectionString = ConnectionString;
            try
            {
                sqlConnection.Open();
            }
            catch (Exception)
            {
                //TODO add handle-able exceptions
                success = false;
            }
            return success;
        }

        public static bool TryDisconnect()
        {
            bool success = true;
            if (sqlConnection.State == ConnectionState.Closed)
            {
                return true;
            }

            try
            {
                sqlConnection.Close();
            }
            catch (Exception)
            {
                //TODO add handle-able exceptions
                success = false;
            }
            return success;
        }

        public static void BuildConnString(string datasource, bool integratedSecurity, string name, string pass, string initialCatalog)
        {
            ConnectionStringBuilder.DataSource = datasource;
            ConnectionStringBuilder.IntegratedSecurity = integratedSecurity;
            if (integratedSecurity)
            {
                ConnectionStringBuilder.UserID = name;
                ConnectionStringBuilder.Password = pass;
            }
            ConnectionStringBuilder.InitialCatalog = initialCatalog;
        }

        public static int ExecuteSQL(string sql, dynamic param = null, IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null)
        {
            return SqlMapper.Execute(sqlConnection, sql, param, transaction, commandTimeout, commandType);
        }

        public static IEnumerable<T> Query<T>(string sql, dynamic param = null, IDbTransaction transaction = null, int? commandTimeout = null, bool buffered = true, CommandType? commandType = null)
        {
            return SqlMapper.Query<T>(sqlConnection, sql, param, transaction, buffered, commandTimeout, commandType);
        }
    }
}
