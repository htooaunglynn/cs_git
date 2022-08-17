using System;
class Assignment2forChapter9
{
  static void Main()
  {
    char askchar;
    int count=0;
    do
    {

      Console.WriteLine("Guess Game (0 to 20) Started!!!!");
      Random randomObj=new Random();
      Console.Write("Guess my number: ");
      int intputvalue=Convert.ToInt32(Console.ReadLine());
      int hiddenvalue=randomObj.Next(20);

      bool isNext=true;
      while (isNext)
      {
           if(intputvalue==hiddenvalue)
           {
             count++;
             Console.WriteLine("Wow!!! you got it  right at {0} times. ",count);
             isNext=false;
           }
           else if(intputvalue>=21)
           {
               Console.WriteLine("Read the game info idiot, guess the number between 0 and 20.");
               Console.Write("Guess again: ");
               intputvalue=Convert.ToInt32(Console.ReadLine());
               count++;
           }
           else if(intputvalue+3==hiddenvalue || intputvalue-3==hiddenvalue || intputvalue-2==hiddenvalue || intputvalue+2==hiddenvalue || intputvalue-1==hiddenvalue || intputvalue+1==hiddenvalue)
           {
               Console.WriteLine("No! You got it wrong!! Your number is clsoe to my number");
               Console.Write("Guess again: ");
               intputvalue=Convert.ToInt32(Console.ReadLine());
               count++;
           }

           else
           {
               Console.WriteLine("No! You got it wrong!! Your number is far to my number");
               Console.Write("Guess again: ");
               intputvalue=Convert.ToInt32(Console.ReadLine());
               count++;
           }
      }
           Console.Write("Wanna try again? (y/n): ");
           askchar=Convert.ToChar(Console.ReadLine());
    }while(askchar!='n');
  }
}