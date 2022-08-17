using System;
class methoddemo
{
    static void Main()
    {
        Console.WriteLine("Program start");
        PrintStarPattern();//call or invoke 
        PrintStarPattern();//call or invoke
        PrintStarPattern();//call or invoke
        PrintStarPattern();//call or invoke
        PrintStarPattern();//call or invoke
        Console.WriteLine("Program finished");
    }

    static void PrintStarPattern()
    {
        for(int i=1;i<4;i++)
        {
            for(int j=1;j<=i;j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}