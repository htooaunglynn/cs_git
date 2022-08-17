using System;
class continuedemo2
{
    static void Main()
    {
        for(int i=10;i>0;i--)
        {
            if(i==5)
            {
                continue;
            }
            Console.Write(i+" ");
        }
    }
}