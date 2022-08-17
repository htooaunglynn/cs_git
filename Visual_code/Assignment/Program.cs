using System;
class Program
{
    static void Main()
    {
        inputIsWrongHere:

        try
        {
          Age();  
        }

        catch(Exception e)
        {
            Console.WriteLine("You input number is something ");
            goto inputIsWrongHere;
        }
    }

    static void Age()
    {
        Console.Write("Enter your age: ");
            int age=int.Parse(Console.ReadLine());
            if(age<18)
            {
                Console.WriteLine("You can't vote.");
            }
            else
            {
                Console.WriteLine("You can vote.");
            }
    }
}