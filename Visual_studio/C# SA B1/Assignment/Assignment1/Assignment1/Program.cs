using System;

namespace Assignment1
{
    class Program
    {
        static void Main()
        {
            string ask;

            Console.Write("You work full time or part time? (Full or part) : ");
            ask = Console.ReadLine().ToLower();

            if(ask.Equals("full"))
            {
                FullTimeStaff ft = new FullTimeStaff();
                ft.Infomation();
                ft.DisplayData();
            }
            else if(ask.Equals("part"))
            {
                PartTimeStaff ps=new PartTimeStaff();
                ps.Infomation();
                ps.DisplayData();
            }

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}