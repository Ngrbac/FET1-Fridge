using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FridgeApp
{
    public static class DBLink
    {
        public static string DbFile
        {
            get { return Environment.CurrentDirectory + "\\SimpleDb.sqlite"; }
        }

        public static SQLiteConnection SimpleDbConnection()
        {
            return new SQLiteConnection("Data Source=" + DbFile);
        }

        private static SQLiteConnection sqlConnection = new SQLiteConnection("Data Source=" + DbFile);
        public static SQLiteConnection SqlConnection
        {
            get
            {
                return sqlConnection;
            }
        }

        public static bool TryConnect()
        {
            bool success = true;
            
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
        
        public static int ExecuteSQL(string sql, dynamic param = null, IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null)
        {
            return SqlMapper.Execute(sqlConnection, sql, param, transaction, commandTimeout, commandType);
        }

        public static IEnumerable<T> Query<T>(string sql, dynamic param = null, IDbTransaction transaction = null, int? commandTimeout = null, bool buffered = true, CommandType? commandType = null)
        {
            return SqlMapper.Query<T>(sqlConnection, sql, param, transaction, buffered, commandTimeout, commandType);
        }

        public static IEnumerable<dynamic> Query(string sql, dynamic param = null, IDbTransaction transaction = null, int? commandTimeout = null, bool buffered = true, CommandType? commandType = null)
        {
            return SqlMapper.Query(sqlConnection, sql, param, transaction, buffered, commandTimeout, commandType);
        }
    }
}
