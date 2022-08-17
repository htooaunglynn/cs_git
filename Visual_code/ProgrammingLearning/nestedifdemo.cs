using System;
class nestedifdemo
{
    static void Main()
    {
        string username="susu";
        string password="zip";
        int balance=50000;
        if(username=="admin" && password=="123")
        {
          Console.WriteLine("You are administrator.");
          Console.WriteLine("You can do banking process.");
        }
        else if(username=="minmin" && password=="zip")
        {
            Console.WriteLine("You are bank client.");
            Console.WriteLine("User nam and password is correct.");
        }
        else if(balance>1000)
        {
          Console.WriteLine("You can withdraw");
        }
        else
        {
          Console.WriteLine("You can't do any tracs");
        }
    }

}