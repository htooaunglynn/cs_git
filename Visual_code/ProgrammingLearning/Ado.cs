using System;
using System.Data.SqlClient;

namespace Assignment4
{
    public class Program
    {
        static void Main(string[] args)
        {
            int operation;

            Here:

            try
            {
                do
                {
                    Console.WriteLine("Write a Console Program with the following output.");
                    Console.WriteLine("1. Add New Product");
                    Console.WriteLine("2. Show Product List");
                    Console.WriteLine("3. Update the existing Product");
                    Console.WriteLine("4. Delete the existing Product");
                    Console.WriteLine("5. Exit");

                    AddNewProduct add = new AddNewProduct();
                    ShowProductList show = new ShowProductList();
                    UpdateExistingProduct update = new UpdateExistingProduct();
                    DeleteExistingProduct delete = new DeleteExistingProduct();
                    ColumnsName name = new ColumnsName();

                    Console.Write("Select the Operation(1,2,3,4,5) : ");
                    operation = Convert.ToInt32(Console.ReadLine());

                    switch (operation)
                    {
                        case 1: name.GetInformation(); add.AddProduct(name); break;
                        case 2: show.ShowProduct(); break;
                        case 3: show.ShowProduct(); name.GetInformation(); update.UpdateProduct(name); break;
                        case 4: show.ShowProduct(); name.DeleteId(); delete.DeleteProduct(name); break;
                        case 5: break;
                        default: goto Here;
                    } 
                } while (operation!=5); 
            }
            catch (Exception error)
            {
                Console.WriteLine("Error occur " + error.Message);
                goto Here;
            }
        } // end of main method
    } // end of program

public class ColumnsName
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }
        public string Category { get; set; }

        public void GetInformation()
        {
            Console.Write("Enter id : ");
            Id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter name : ");
            Name = Console.ReadLine();

            Console.Write("Enter Price : ");
            Price = Console.ReadLine();

            Console.Write("Enter Category : ");
            Category = Console.ReadLine();
        }

        public void DeleteId()
        {
            Console.Write("Enter id : ");
            Id = Convert.ToInt32(Console.ReadLine());
        }
    }//end of ColumnsName class

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

public class AddNewProduct
    { 
        public void AddProduct(ColumnsName columns)
        {
            try
            {
                string connectionString = @"Data Source=localhost;Initial Catalog=ShopMgtDB;User Id=sa;Password=azono";

                SqlConnection sqlConnection = new SqlConnection(connectionString);
                sqlConnection.Open();

                if (sqlConnection != null)
                {
                    string query = $"insert into Product values ({columns.Id},'{columns.Name}','{columns.Price}','{columns.Category}')";

                    SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                    int result = sqlCommand.ExecuteNonQuery();

                    if (result > 0)
                    {
                        Console.WriteLine("Commands completed successfully. \nCompletion time: " + DateTime.Now);
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

public class UpdateExistingProduct
    {
        public void UpdateProduct(ColumnsName columns)
        {
            try
            {
                string connectionString = @"Data Source=localhost;Initial Catalog=ShopMgtDB;User Id=sa;Password=azono";

                SqlConnection sqlConnection = new SqlConnection(connectionString);
                sqlConnection.Open();

                if (sqlConnection != null)
                {
                    string query = $"update Product set Name = '{columns.Name}', Price = '{columns.Price}' , Category = '{columns.Category}' where Id = {columns.Id} ";

                    SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                    int result = sqlCommand.ExecuteNonQuery();

                    if (result > 0)
                    {
                        Console.WriteLine($"Commands completed successfully. \nCompletion time: {DateTime.Now}\n");
                    }

                    sqlConnection.Close();
                }
            }
            catch (Exception error)
            {
                Console.WriteLine("Error occur " + error.Message);
            }
        } // end of UpdateProduct
    } // end of UpdateExistingProduct class

public class DeleteExistingProduct
    {
        public void DeleteProduct(ColumnsName columns)
        {
            try
            {
                string connectionString = @"Data Source=localhost;Initial Catalog=ShopMgtDB;User Id=sa;Password=azono";

                SqlConnection sqlConnection = new SqlConnection(connectionString);
                sqlConnection.Open();

                if (sqlConnection != null)
                {
                    string query = $"delete from Product where Id={columns.Id}";

                    SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                    int result = sqlCommand.ExecuteNonQuery();

                    if (result > 0)
                    {
                        Console.WriteLine($"Commands completed successfully. \nCompletion time: {DateTime.Now}\n");
                    }

                    sqlConnection.Close();
                }
            }
            catch (Exception error)
            {
                Console.WriteLine("Error occur " + error.Message);
            }
        } // end of DeleteProduct method
    } //end of DeleteExistingProduct class

} // end of namespace Assignment4