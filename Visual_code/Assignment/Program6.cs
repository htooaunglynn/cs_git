using System;

class Program6
{
    static void Main()
    {
        try
        {
            Factorial();
        }

        catch(Exception e)
        {
            Console.WriteLine("You input is something wrong.");
        }//end of catch
        
    }//end of main method

    static void Factorial()
    {
        Console.Write("Which number do you know : ");
        int inputNumber=int.Parse(Console.ReadLine());

        int resultnumber=1;

        Console.Write(inputNumber);

        while(inputNumber>0)
        {
            resultnumber*=inputNumber;
            inputNumber--;
        }

        Console.WriteLine(" of factrial is "+resultnumber);
    } // end of factorial
} //end of class