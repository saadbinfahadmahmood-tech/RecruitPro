using MySqlConnector;
using System.Data;

namespace Recruit_Pro
{
    public static class SqlHelper
    {
        public static string ConnectionString { get; set; }

        // DQL (Select) using MySqlParameter
        public static DataTable ExecuteQuery(string sqlQuery, MySqlParameter[] parameters = null)
        {
            DataTable dataTable = new DataTable();
            using (MySqlConnection connection = new MySqlConnection(ConnectionString))
            {
                using (MySqlCommand command = new MySqlCommand(sqlQuery, connection))
                {
                    if (parameters != null)
                    {
                        command.Parameters.AddRange(parameters); // Adds all parameters at once
                    }
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        connection.Open();
                        adapter.Fill(dataTable);
                    }
                }
            }
            return dataTable;
        }

        // DML (Insert/Update/Delete) using MySqlParameter
        public static int ExecuteNonQuery(string sqlCommand, MySqlParameter[] parameters = null)
        {
            int rowsAffected = 0;
            using (MySqlConnection connection = new MySqlConnection(ConnectionString))
            {
                using (MySqlCommand command = new MySqlCommand(sqlCommand, connection))
                {
                    if (parameters != null)
                    {
                        command.Parameters.AddRange(parameters);
                    }
                    connection.Open();
                    rowsAffected = command.ExecuteNonQuery();
                }
            }
            return rowsAffected;
        }
    }
}
