
using System;
using System.Data.SqlClient;

namespace OrderManagementSystem.util
{
    public static class DBConnUtil
    {
        public static SqlConnection GetDBConn(string connectionString)
        {
            try
            {
                var connection = new SqlConnection(connectionString);
                connection.Open();
                return connection;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while opening the database connection: {ex.Message}");
                throw; 
            }
        }
    }
}
