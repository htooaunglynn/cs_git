using System;
using System.Data.SqlClient;

namespace Assignment4
{
    public class ShowProductList
    {
        public void ShowProduct()
        {
            try
            {
                string connectionString = @"Data Source=localhost;Initial Catalog=ShopMgtDB;User Id=sa;Password=azono";

                SqlConnection sqlConnection = new SqlConnection(connectionString);
                sqlConnection.Open();

                if (sqlConnection != null)
                {
                    string query = "select * from Product";

                    SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                    SqlDataReader reader = sqlCommand.ExecuteReader();

                    Console.WriteLine();

                    while (reader.Read())
                    {
                        Console.WriteLine($"{reader["Id"]}, {reader["Name"]}, {reader["Price"]}, {reader["Category"]}");
                    }

                    reader.Close();
                    sqlConnection.Close();

                    Console.WriteLine();
                }
            }
            catch (Exception error)
            {
                Console.WriteLine("Error occur " + error.Message);
            }
        }  // end of ShowProduct method
    } //end of ShowProductList class
} // end of namespace Assignment4
