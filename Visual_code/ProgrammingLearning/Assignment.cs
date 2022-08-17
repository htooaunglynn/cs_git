using System; // call library
class Assignment // declaration class
{
    static void Main() // declaration main method
    {
        int value1=10,value2=20,value3=15; // declare int variable and assign value

        if(value1<value2 && value1<value3) // value1 is less than value2 and value3
        {
            Console.WriteLine("The minimum value is "+value1);
        }
        else if(value2<value1 && value2<value3) // value2 is less than value1 and value3
        {
            Console.WriteLine("The minimum value is "+value2);
        }
        else // value3 is less than value1 and nalue3
        {
            Console.WriteLine("The minimum value is "+value3);
        }

        Console.ReadKey();
    } // end of Main Method 
} // end of class 