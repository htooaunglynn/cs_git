using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoDotNetDemo2
{
    public class Program
    {
        static void Main(string[] args)
        {
            DatabaseConnection databaseConnection = new DatabaseConnection();
            databaseConnection.CheckDatabase();

            CRUDOpreationForUser input =new CRUDOpreationForUser();
            

            

            int choice;
            Console.WriteLine("Choose action: 1,2,3,4");
            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    {
                        input.GetUserList();
                        UserModel userModel = GetInput();
                        input.SaveUser(userModel);
                        break;
                    }
                case 2: input.GetUserList();break;
                case 3:
                    {
                        input.GetUserList();
                        UserModel userModel = GetInput();
                        input.UpdateUser(userModel);
                        break;
                    }
                case 4:
                    {
                        input.GetUserList();
                        Console.Write("User id to delete");
                        int userId = Convert.ToInt32(Console.ReadLine());
                        input.DeleteUser(userId);
                        break;
                    }
            }

            // Console.Write("Enter isdelete : ");
           // userModel.IsDelete= Console.ReadLine();

            

            

            Console.ReadKey();
        }

        private static UserModel GetInput()
        {
            UserModel userModel = new UserModel();

            Console.Write("Enter id : ");
            userModel.Id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter name : ");
            userModel.UserName = Console.ReadLine();

            Console.Write("Enter Email : ");
            userModel.Email = Console.ReadLine();

            Console.Write("Enter password : ");
            userModel.Password = Console.ReadLine();

            return userModel;
        }
    }
}
