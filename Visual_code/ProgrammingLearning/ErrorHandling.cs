using System;
class ErrorHandling
{
    static void Main()
    {
        try
        {
          Console.Write("Enter your age: ");
          int age=int.Parse(Console.ReadLine());
          bool result=IsGreaterThan18(age);
          if(result)
          {
              Console.WriteLine("You can vote.");
          }
          else
          {
              Console.WriteLine("You cannot vote.");
          }
        }

        catch(Exception email)
        {
            Console.WriteLine("Hmmmmm.....Error occur becaue of "+email.Message);
        }

    }
    static bool IsGreaterThan18(int age)
    {
        bool result=false;
        if(age<=0)
        {
            throw new Exception("Your age cannot nagative value.");
        }
        else if(age>18)
        {
            result=true;
        }
        return result;
    }
}