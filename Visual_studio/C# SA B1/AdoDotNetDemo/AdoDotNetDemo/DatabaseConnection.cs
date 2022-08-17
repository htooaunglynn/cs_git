using System;
using System.Data.SqlClient;

namespace AdoDotNetDemo
{
    public class DatabaseConnection
    {
        public void CheckDatabase()
        {
            try
            {
                string connectionString = @"Data Source=localhost;Initial Catalog=SimpleDB;User Id=sa;Password=azono";

                SqlConnection sqlConnection = new SqlConnection(connectionString);
                sqlConnection.Open();

                if(sqlConnection!=null)
                {
                    Console.WriteLine("Database is connected.");
                    Console.WriteLine("Your connected dataname is "+sqlConnection.Database);
                }
            }
            catch (SqlException ex)
            {

                Console.WriteLine("Error occur "+ex.Message);
            }
        }
    }
}
