using System;
class Whileloop2
{
    static void Main()
    {
        int i=1,result=0;
        while (i<=100)
        {
            result+=i;
            i++;
        }
        Console.WriteLine(result);
    }
}