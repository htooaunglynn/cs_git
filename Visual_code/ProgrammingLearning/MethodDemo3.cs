using System;
class MethodDemo3
{
    static void Main()
    {
      Console.Write("Please a number 1: ");
      int num1=int.Parse(Console.ReadLine());
      Console.Write("Please a number 2: ");
      int num2=int.Parse(Console.ReadLine());
      int finalresult=Add(num1,num2);
      Console.WriteLine(num1+"+"+num2+"is"+finalresult);
      bool isEvenResult=isEven(num1);
      Console.WriteLine("{0} is even? \n{1}",num1,isEvenResult);
    }

    static int Add(int n1,int n2)
    {
        int result=0;
        result=n1+n2;
        return result;
    }

    static int Substraction(int n1,int n2)
    {
        int result=0;
        result=n1-n2;
        return result;
    }

    static bool isEven(int n1)
    {
        bool check=false;
        if(n1%2==0)
        {
            check=true;
        }
        return check;
    }
}
