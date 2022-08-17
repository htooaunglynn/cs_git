using System;

namespace Assignment4
{
    public class Product
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
} // end of Assignment4
