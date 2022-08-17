using System;
class continuedemo
{
    static void Main()
    {
        for(int i=1;i<=10;i++)
        { 
            int result=i%2;
            if(result!=0) 
            {
                continue;
            }
            Console.Write(i+" ");// 1 2 3 4 5 6 7 8 9 10 
        }
    }
}