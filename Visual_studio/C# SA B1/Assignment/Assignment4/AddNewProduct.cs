using System;
using System.Data.SqlClient;

namespace Assignment4
{
    public class AddNewProduct
    { 
        public void AddProduct(Product product)
        {
            try
            {
                string connectionString = @"Data Source=localhost;Initial Catalog=ShopMgtDB;User Id=sa;Password=azono";

                SqlConnection sqlConnection = new SqlConnection(connectionString);
                sqlConnection.Open();

                if (sqlConnection != null)
                {
                    string query = $"insert into Product values ({product.Id},'{product.Name}','{product.Price}','{product.Category}')";

                    SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                    int result = sqlCommand.ExecuteNonQuery();

                    if (result > 0)
                    {
                        Console.WriteLine($"\nCommands completed successfully. \nCompletion time: {DateTime.Now}\n");
                    }

                    sqlConnection.Close();
                }
            }
            catch (Exception error)
            {
                Console.WriteLine("Error occur " + error.Message);
            }
        }
    }
}
