using System;
class ifelsedemon
{
    static void Main()
    {
        Console.WriteLine("Program start");
        int age=16;
        string name="U Mya";
        bool isNation=false;
        if(age>18 && isNation==true)
        {
            Console.WriteLine("Hello,"+name);
            Console.WriteLine("You can vote in election");
        }
        else
        {
            Console.WriteLine("Hello,"+name);
            Console.WriteLine("You can't vote in election");
            //Console.WriteLine("one year");
        }
        Console.WriteLine("Program end");
    }
}