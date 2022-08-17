using System;
class userinputdemo
{
    static void Main()
    {
        Console.WriteLine("Program start");
        Console.Write("Please enter your name: ");
        string userName=Console.ReadLine();
        Console.Write("Please type your address: ");
        string userAddress=Console.ReadLine();
        Console.WriteLine("Hi,"+userName+" Nice to see you");
        Console.WriteLine("You live in "+userAddress);
    }
}