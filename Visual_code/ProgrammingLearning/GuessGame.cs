using System;
class GuessGame
{
    static void Main()
    {
        Console.WriteLine("Guess game (0 to 20) Started!!!");
        Random randomObj=new Random();
        Console.Write("Guess my number");
        int inputvalue=Convert.ToInt32(Console.ReadLine());
        int hiddenvalue=randomObj.Next(20);
        
        bool isNext=true;
        while(isNext)
        {
         if(inputvalue==hiddenvalue)
          {
             Console.WriteLine("wow!!! you got it right.");
             Console.WriteLine("Game end.");
             isNext=false;
          }
         else
         {
             
            Console.WriteLine("NO!! You got it wrong!!");
            Console.Write("Guess again:");
            inputvalue=Convert.ToInt32(Console.ReadLine());
         }
        }
        Console.WriteLine();
        Console.ReadKey();       
    }
}