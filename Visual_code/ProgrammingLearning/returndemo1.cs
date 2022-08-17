using System;
class returndemo1
{
    static void Main()
    {
        int i=1;
        int total=0;
        while(i<=10)
        {
            total+=i;
            i++;
            break;
        }
        Console.WriteLine("Total is "+total);
    }
}