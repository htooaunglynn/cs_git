using System;
class nestedloopdemo
{
    static void Main()
    {
        for(int row=1;row<=5;row++)
        {
            for(int col=1;col<=row;col++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}