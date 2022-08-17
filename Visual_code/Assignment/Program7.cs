using System;
using CustomerInfo;

namespace Assignment1
{
    class Program7
    {
       static void Main()
       {
           TryAgain(); //call TryAgain method
       }// end of main method

       static void TryAgain()
       {
           string ask="yes";
           do
           {
               ErrorSearch(); // call ErrorSearch method

               Console.Write("Have another customer information? (yes/no) : ");
               ask=Console.ReadLine();

               Console.WriteLine(); 

           }while(ask.Equals("yes"));
       }//end of TryAgain method

       static void ErrorSearch()
       {
           wrongHere:

           try
           {
                DataIO(); // call DataIO method 
           }
           catch (Exception e) 
           {
               Console.WriteLine("Error occur "+e.Message);
               goto wrongHere;
           }
       } // end of ErrorSearch method

       static void DataIO()
       {
           //create new opject
           Customer human=new Customer();
           
           // 
           Console.WriteLine("Please answer the following question.");
           
           //name request 
           Console.Write("Enter your name :  ");
           human.Name=Console.ReadLine();

           //id request 
           Console.Write("Enter your ID : ");
           human.ID=Console.ReadLine();

           //email request 
           Console.Write("Enter your Email : ");
           human.Email=Console.ReadLine();

           //NRC request 
           Console.Write("Enter your NRC No. : ");
           human.Nrc=Console.ReadLine();
           
           //phone request 
           Console.Write("Enter your phone No. : ");
           human.SetPhone(Console.ReadLine());

           //address request 
           Console.Write("Enter your adddress : ");
           human.SetAddress(Console.ReadLine());

           //birthday request 
           Console.Write("Enter your Birthday (month/day/year): ");
           human.DayOfBirth=Convert.ToDateTime(Console.ReadLine());


           Console.WriteLine("========================\n\n");

           //All data output
           human.CustomerDisplay();

       } //end of DataAccept method
    } // end of Program 7 class
} // end of ProgramList namespace

namespace CustomerInfo
{
    class Customer
    {
        //1 constructor
        public Customer()
        {

        } // end of Customer constructor
        // id property
        private string id;
        public string ID
        {
            get { return id; }
            set 
            { 
                if(string.IsNullOrEmpty(value))
                {
                  throw new ArgumentException("invalid staff id.");
                }
                id = value;
            }
        } // end of id property 

        //name property
        private string name;
        public string Name 
        {
            get { return name; }
            set 
            { 
                if(string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("invalid staff name.");
                }
                name = value; 
            }
        } // end of name property
 
        // email property
        private string  email;
        public string  Email
        {
            get { return email; }
            set 
            {
                if(string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("invalid stuff email.");
                }
                 email = value; 
            }
        } //end of email 

        // nrc property
        private string nrc;
        public string Nrc
        {
            get { return nrc; }
            set
            {
                if(string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("invalid staff NRC.");
                }
                 nrc = value; 
            }
        } // end of nrc property
        
        //phone Set method
        private string phone;

        public void SetPhone(string _phone)
        {
            if(string.IsNullOrEmpty(_phone))
            {
                throw new ArgumentException("invalid staff phone.");
            }
            phone=_phone;
        } // end of phone set method 

        //phone get method 
        public string GetPhone()
        {
            return phone;
        } // end of phone get method 

        //address Set method 
        private string address;

        public void SetAddress(string _address)
        {
            if(string.IsNullOrEmpty(_address))
            {
                throw new ArgumentException("invalid stuff address.");
            }
            address=_address;
        } //end of address set method

        // address get method
        public string GetAddress()
        {
            return address;
        } // end of address get method 

       // private DateTime dayOfBirth;

       //Day of birth property
       private DateTime dayOfBirth;
       public DateTime DayOfBirth
       {
           get { return dayOfBirth; }
           set { dayOfBirth = value;}
       } // end of day of birth properth

       public void CustomerDisplay()
       {
           Console.WriteLine("\n========================================");
           Console.WriteLine("Customer data information!");
           Console.WriteLine("Name - "+name.ToUpper());
           Console.WriteLine("ID - "+id);
           Console.WriteLine("Email - "+email);
           Console.WriteLine("NRC - "+nrc.ToUpper());
           Console.WriteLine("Phone No. - "+phone);
           Console.WriteLine("Address - "+address);
           Console.WriteLine("Birthday - "+dayOfBirth);
           Console.WriteLine("========================================\n");
       }

    }// end of Customer class
} // end of CustomerInfo namespace