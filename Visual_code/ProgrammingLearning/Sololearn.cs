using System;

namespace Program
{
    class Sololearn
    {
       static void Main()
       {
           

         int number = Convert.ToInt32(Console.ReadLine());
            
            //your code goes here
            for(int i=1;i<=number;i++)
            {
                if(i%3==0)
                {
                    Console.Write(i+"*");
                }
                
            }
       }

    }
}