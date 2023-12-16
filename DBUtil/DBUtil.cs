// DBUtil.cs
using System;
using System.Data.SqlClient;

namespace OrderManagementSystem.util
{
    public static class DBUtil
    {
        public static SqlConnection GetDBConn()
        {
            try
            {
                
                string connectionString = "Data Source=localhost\\MSSQLSERVER;Initial Catalog=Order_Management_System;Integrated Security=True;";
                var connection = new SqlConnection(connectionString);
                connection.Open();
                return connection;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while establishing the database connection: {ex.Message}");
                throw; 
            }
        }
    }
}
