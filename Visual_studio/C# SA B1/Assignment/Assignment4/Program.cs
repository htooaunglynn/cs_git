using System;

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
                    Product name = new Product();

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
} // end of namespace Assignment4
