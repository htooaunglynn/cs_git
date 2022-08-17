using System; //call library
using UserInfo; // call UserInfo namespace

namespace Assignment2
{
    class Program8
    {
        static void Main()
        {
            AllProgram(); //Call AllProgram method

        } //end of main method 

        static void AllProgram()
        {
            string ask;

            do
            {
                ErrorCheck(); // call ErrorCheck method

                Console.Write("Another user? (yes/no) : ");
                ask=Console.ReadLine();

            } while (ask.Equals("yes"));

            if(ask.Equals("no"))
            {
                Console.WriteLine("Thank you for your information.");
            }

        }// end of AllProgram method 
        
        static void ErrorCheck()
        {
            wrongHere: // input is something wrong program return here

            try
            {
                 DataRequest(); // call DataRequest method
            }
            catch (Exception e) 
            {
                Console.WriteLine("Error occur "+e.Message);
                goto wrongHere;
            }

        } // end of ErrorCheck method 
        static void DataRequest()
        {
            //create object
            User person=new User();

            //name request 
            Console.Write("Enter your name : ");
            person.Name=Console.ReadLine();

            //id request
            Console.Write("Enter your id : ");
            person.Id=Console.ReadLine();

            //email request
            Console.Write("Enter your email : ");
            person.Email=Console.ReadLine();

            //password reques
            Console.Write("Enter your password : ");
            person.Password=Console.ReadLine();

            Console.Write("\n==========================\n");

            // All data output
            person.UserList();

        } // end of DataRequest method
    } // end of Program8 method 
} // end of Assignment2 namespace 

namespace UserInfo
{
    class User
    {
        //1 Constructor , no-argument
        public User()
        {

        }// end of User Constructor

        //id property
        private string id;
        public string Id
        {
            get { return id; }
            set 
            {
                if(string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("invalid stuff ID.");
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
                    throw new ArgumentException("invalid stuff Name.");
                }
                 name = value; 
            }
        } // end of name property

        // email property
        private string email;
        public string Email
        {
            get { return email; }
            set 
            {
                if(string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("invalid stuff Email.");
                }
                 email = value; 
            }
        } // end of email property

        //password property
        private string password;
        public string Password
        {
            get { return password; }
            set 
            {
                if(string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("invalid stuff Password.");
                }
                 password = value; 
            }
        } // end of password property

        //output list
        public void UserList()
        {
            Console.WriteLine("Information of user!\n");
            Console.WriteLine("Name - "+name);
            Console.WriteLine("ID - "+id);
            Console.WriteLine("Email - "+email);
            Console.WriteLine("Password  - "+password);
            Console.WriteLine("Login date - "+DateTime.Now);
            Console.WriteLine("=============================\n");
        } // end of output list
        
    } // end of user class
} // end of UserInfo namespce