using System;
class TryCatchDemo
{
  static void Main()
  {
      Here:
      try{
      Console.Write("Enter number of values: ");
      int numberOfValue=Convert.ToInt32(Console.ReadLine());
      string[] name=new string[numberOfValue];
      for(int i=0;i<numberOfValue;i++)
      {
          Console.Write("Enter values  : ");
          name[i]=Console.ReadLine();
      }
      }

      catch(Exception e){
         Console.WriteLine("Hay plz type number only when you define values! Try again");
         goto Here;
      }
  }
}