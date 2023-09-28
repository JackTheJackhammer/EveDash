using Npgsql;
using System.Data;



// being refactored for postgres!
namespace EveDash3.backend.api.sql
{
    public static class SQLHandler
    {


        /// <summary>
        /// same as QueryDB but sends a datatable
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        public static DataTable QueryAsDtDB(string query, string db)
        {

            var cs = "Host=127.0.0.1;Username=postgres;Password=BrownCarrot1;Database=evedb";

            using (NpgsqlConnection connection = new NpgsqlConnection(cs))
            {
                connection.Open();
                DataTable dataTable = new DataTable();

                string selectQuery = query;
                using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(selectQuery, connection))
                {

                    adapter.Fill(dataTable);

                    // Now you have your data in the 'dataTable' variable.
                    // You can work with it as needed.

                    // Example: Iterate through the rows in the DataTable.

                }

                connection.Close();
                return dataTable;
            }


            //return dt;
            //return null;
        }
        public static void QueryWithoutReturn(string query)
        {
            var cs = "Host=127.0.0.1;Username=postgres;Password=BrownCarrot1;Database=evedb";
            using (NpgsqlConnection connection = new NpgsqlConnection(cs))
            {
                connection.Open();


                using (NpgsqlCommand cmd = new NpgsqlCommand(query, connection))
                {
                    connection.Close();
                }


            }


        }
        public static string TypeIDToName(string typeid)
        {
            var sqlget = QueryAsDtDB($"SELECT typeName FROM evesde.invtypes where typeID = {typeid};", "evesde");
            if (sqlget.Rows.Count != 0)
            {
                return sqlget.Rows[0][0].ToString();
            }
            return null;
        }
    }
}
