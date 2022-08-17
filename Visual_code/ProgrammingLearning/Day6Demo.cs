using System;

class Day6Demo
{
    static void Main()
    {
        int x=10;
        int y=20;

        Console.WriteLine("x>y"+(x>y));
        Console.WriteLine("x<y"+(x<y));
        Console.WriteLine("x!=y"+(x!=y));

        Console.WriteLine("x>y or x<y"+(x<y || x>y));//true
        Console.WriteLine("x>y and x<y"+(x>y && x<y));//false

    }
}