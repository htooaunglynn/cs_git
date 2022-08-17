using System;
class Try1
{
   static void Main()
   {
      
      Console.WriteLine("Program start!");
      do
      {
        Console.Write("Play again? (y/n): ");
        string ask=Console.ReadLine();
      }while(ask.equals("y"));
   }
}