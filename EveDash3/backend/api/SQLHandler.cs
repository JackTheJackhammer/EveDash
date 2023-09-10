using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;
using System.Diagnostics;
using System.Threading;
using System.Data;

namespace EveDash3.backend.api.sql
{
    public static class SQLHandler
    {
        public static MySqlConnection Connect(string db)
        {
            var sqlConnection = new MySqlConnection($"server=localhost;user=root;database={db};port=3306;password=BrownCarrot1");
            sqlConnection.Open();
            //only 1 connection should be used! REFACTOR ME 
            return sqlConnection;
        }
        /// <summary>
        /// queries the database
        /// </summary>
        /// <param name="query"> written in SQL</param>
        /// <returns>a list of all the lines that apply to the query</returns>
        public static List<object[]> LegacyQueryEveDB(string query)
        {
            var connection = Connect("evedb");
            var command = new MySqlCommand(query, connection);
            var reader = command.ExecuteReader();
            List<object[]> t = new List<object[]> { };

            while (reader.Read())
            {
                Object[] values = new Object[reader.FieldCount];
                int fieldCount = reader.GetValues(values);
                t.Add(values);
            }
            connection.Close();
            return t;
            //return null;
        }
        /// <summary>
        /// same as QueryDB but sends a datatable
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        public static DataTable QueryAsDtDB(string query, string db)
        {
            var connection = Connect(db);
            var command = new MySqlCommand(query, connection);
            //var reader = command.ExecuteReader();


            DataTable dt = new DataTable();
            dt.Load(command.ExecuteReader());

            connection.Close();
            return dt;
            //return null;
        }
        public static void QueryWithoutReturn(string query, string db)
        {
            var connection = Connect(db);
            var command = new MySqlCommand(query, connection);
            //var reader = command.ExecuteReader();


            command.ExecuteReader();
            connection.Close();
            //return null;
        }
        public static string TypeIDToName(string typeid)
        {
            var sqlget = QueryAsDtDB($"SELECT typeName FROM evedb.invtypes where typeID = {typeid};", "evedb");
            if(sqlget.Rows.Count != 0)
            {
                return sqlget.Rows[0][0].ToString();
            }
            return null;
        }
    }
}
