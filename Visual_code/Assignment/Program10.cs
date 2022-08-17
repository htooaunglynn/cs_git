using System;
using ProductInfo;
 
namespace Assignment3
{
    class Program10
    {
        static void Main()
        {
            ErrorCheck();
        }

        static void ErrorCheck()
        {
            wrongHere:

            try
            {
                 Another();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error occur "+e.Message);
                goto wrongHere;
            }
        }

        static void Another()
        {
            string ask;

            do
            {
                Data();

                Console.Write("Try another? (yes/no) : ");
                ask=Console.ReadLine();

            } while (ask.Equals("yes"));
        }

        static void Data()
        {
            Product materical=new Product();

            Console.Write("Enter product name - ");
            materical.Name=Console.ReadLine();

            Console.Write("Enter product description - ");
            materical.Description=Console.ReadLine();

            Console.Write("Enter product price - ");
            materical.Price=Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter product id - ");
            materical.Id=Console.ReadLine();

            Console.Write("Enter product quantity - ");
            materical.Quantity=Console.ReadLine();

            Console.Write("Enter product category - ");
            materical.ProductCategory=Console.ReadLine();

            Console.Write("Enter product date of manufactured - ");
            materical.ManufacturedDate=Convert.ToDateTime(Console.ReadLine());

            materical.DisplayOutput();

            double result=materical.Price*5/100;

            Console.WriteLine("Tax - "+result);
            Console.WriteLine("========================================================");
        }
    }
}

namespace ProductInfo
{
    class Product
    {
        public Product()
        {

        }

        private string name,id,description,quantity,productCategory;
        private double price;
        private DateTime manufacturedDate;

        public string Name 
        {
            get{return name;}
            set
            {
                if(string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("invalid stuff name.\n");
                }
                name=value;
            }
        }

        public string Id
        {
            get{return id;}
            set
            {
                if(string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("invalid stuff id.\n");
                }
                id=value;
            }
        }

        public string Description
        {
            get{return description;}
            set
            {
                if(string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("invalid stuff description.\n");
                }
                description=value;
            }
        }

        public string Quantity
        {
            get{return quantity;}
            set
            {
                if(string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("invalid stuff quantity.\n");
                }
                quantity=value;
            }
        }

        public string ProductCategory
        {
            get{return productCategory;}
            set
            {
                if(string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("invalid stuff product category.\n");
                }
                productCategory=value;
            }
        }

        public DateTime ManufacturedDate
        {
            get{return manufacturedDate;}
            set{ manufacturedDate=value;}
        }

        public double Price
        {
            get{return price;}
            set
            {
                if(value<=0)
                {
                    throw new ArgumentException("invalid stuff price.\n");
                }
                price=value;
            }
        }

        public void DisplayOutput()
        {
            Console.WriteLine("\n========================================================");
            Console.WriteLine("Enter name of product - "+name);
            Console.WriteLine("Enter description of product - "+description);
            Console.WriteLine("Enter price of product - "+price);
            Console.WriteLine("Enter id  of product - "+id);
            Console.WriteLine("Enter quantity of product - "+quantity);
            Console.WriteLine("Enter product category of product - "+productCategory);
            Console.WriteLine("Enter manufactured date of product - "+manufacturedDate);
            Console.WriteLine();
        }
    }
}