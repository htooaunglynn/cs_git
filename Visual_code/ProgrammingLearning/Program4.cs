using System; //call library or Importing namespace
class Program4 //start class
{
    static void Main() //start main method
    {
        int num=5,result;
        result=num*(num-1)*(num-2)*(num-3)*(num-4);
        Console.WriteLine("5 Factorial  is "+result);
       
       num=3;
       result=num*(num-1)*(num-2);
       Console.WriteLine("3 Factorial  is "+result);
    } //end of main method
} //end of class