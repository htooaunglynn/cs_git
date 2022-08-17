using System; // call library
using ProductInfo; // call ProductInfo namespcae
using TaxCalculation; // call TaxCalculation namespace

namespace Assignment3
{
    class Program9
    {
        static void Main()
        {
            ErrorCheck(); //call ErrorCheck method

        } // end of main method

        static void ErrorCheck()
        {
            // 
            wrongHere:

            try
            {
                TryAnother(); // call TryAnother method
            }
            catch (Exception e)
            {
                Console.WriteLine("Error occur "+e.Message);
                goto wrongHere;
            }

        } // end of ErrorCheck method

        static void TryAnother()
        {
            string ask="yes";

            do
            {
                AcceptData(); //call AcceptData method

                // ask try
                Console.Write("Try another? (yes/no) : ");
                ask=Console.ReadLine();

            } while (ask.Equals("yes"));
        } // end of TryAnother method

        static void AcceptData()
        {
            // create new opject for product
            Product materical=new Product();

            // name request
            Console.Write("Enter name of product - ");
            materical.Name=Console.ReadLine();

            //Description request
            Console.Write("Enter description of product - ");
            materical.Description=Console.ReadLine();

            //price request
            Console.Write("Enter price of product - ");
            materical.Price=Convert.ToDouble(Console.ReadLine());

            //id request
            Console.Write("Enter id of product - ");
            materical.Id=Console.ReadLine();

            // quatity request
            Console.Write("Enter quatity of product - ");
            materical.Quatity=Console.ReadLine();

            // Product category request
            Console.Write("Enter product category of product - ");
            materical.ProductCategory=Console.ReadLine();

            //Manufacture Date request
            Console.Write("Enter manufacture date of product \neg.(mm/dd/yy h:m:s AM)- ");
            materical.ManufacturedDate=Convert.ToDateTime(Console.ReadLine());

            //output data 
            materical.DataInfo();

            //crete new object for CommecrialTax
            CommercialTax comTax=new CommercialTax();

            //
            comTax.Tax=5.00;
            comTax.Percent=100.00;

            double taxResult=comTax.Solution(materical.Price);
            Console.WriteLine("price - "+taxResult);

        } //end of AcceptData
    } // end  of Program9 class
} // end of Assignment3 namespace 

namespace ProductInfo
{
    class Product
    {
        //1 Constructor , no-argument
        public Product()
        {
            
        } // end of Product Constructor

        // name Property
        private string name;
        public string Name
        {
            get { return name; }
            set 
            {
                if(string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("invalid stuff name.\n");
                }
                 name = value; 
            }
        } // end of name Property

        // id Property
        private string id;
        public string Id
        {
            get { return id; }
            set 
            {
                if(string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("invalid stuff id.\n");
                }
                 id = value; 
            }
        } // end of id Property

        //description Property
        private string description;
        public string Description
        {
            get { return description; }
            set
            { 
                if(string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("invalid stuff description.\n");
                }
                description = value; 
            }
        } // end of description

        //quatity property
        private string quatity;
        public string Quatity
        {
            get { return quatity; }
            set 
            {
                if(string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("invalid stuff quatity.\n");
                }
                 quatity = value; 
            }
        } // end of quatity property
        
        //productCategory property
        private string productCategory;
        public string ProductCategory
        {
            get { return productCategory; }
            set 
            {
                if(string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("invalid stuff product category.\n");
                }
                 productCategory = value; 
            }
        } // end of productCategory property

        //manufacturedDate property
        private DateTime manufacturedDate;
        public DateTime ManufacturedDate
        {
            get { return manufacturedDate; }
            set { manufacturedDate = value; }
        } // end of manufacturedDate property

        //price property
        private double price;
        public double Price
        {
            get { return price; }
            set 
            {   
                if(value<=0)
                {
                    throw new ArgumentException("invalid stuff price.\n");
                }
                price=value;
                
            }
        } // end of price property
        
        //Display out data
        public void DataInfo()
        {
            Console.WriteLine("\n\n=========================");
            Console.WriteLine("Information of "+name);
            Console.WriteLine("Description - "+description);
            Console.WriteLine("Price - "+price);
            Console.WriteLine("ID - "+id);
            Console.WriteLine("Quatity - "+quatity);
            Console.WriteLine("Product category - "+productCategory);
            Console.WriteLine("Manufacture date - "+manufacturedDate);
            Console.WriteLine();
        } // end of DataInfo method 
                
    } // end of Product class 
} // end of ProductInfo namespace 

namespace TaxCalculation
{
    class CommercialTax
    {
        // 1 Constructor , no-argument
        public CommercialTax()
        {
            //
        } // end of CommercialTax constructor

        private double tax;
        public double Tax
        {
            get { return tax; }
            set { tax = value; }
        }

        private double percent;
        public double Percent
        {
            get { return percent; }
            set { percent = value; }
        }

        public double Solution(double priceTax)
        {
            Product p=new Product();

            priceTax=p.Price;

            double result = priceTax*5/100;
            return result;
        }
        
        
        
    } // end of CommercialTax class
} // end of TaxCalculation namespace 