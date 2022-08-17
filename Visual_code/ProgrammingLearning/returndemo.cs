using System;
class returndemo
{
    static void Main()
    {
        bool value=true;
        Console.WriteLine("Program Start");
        if(value)
        {
            Console.WriteLine("come from before return statment");
            return;
        }
        Console.WriteLine("Program end");
    }
}