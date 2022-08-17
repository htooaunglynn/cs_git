using System;
class berakdemo
{
    static void Main()
    {
        int i=100;
        while(i>0)
        {
            Console.Write(i+" ");
            if(i==10)
            {
                break;
            }
            i--;
        }
    }
}