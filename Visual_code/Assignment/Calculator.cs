using System;
using Sign;
using Factorial;


namespace CalculatorInfo
{
    class Calculator
    {
        static void Main()
        {
           Some();
           Torial();
           
        } //end of main mehto

        static void Some()
        {
            firstCal c1=new firstCal();

           double result;

           Console.Write("Enter first number.  ");
           c1.firstNum=Convert.ToDouble(Console.ReadLine());

           Console.Write("Enter second number:   ");
           c1.secondNum=Convert.ToDouble(Console.ReadLine());

           result=c1.Addition();
           Console.WriteLine("Add is {0}",result);

           result=c1.Substraction();
           Console.WriteLine("Sub is {0}",result);

           result=c1.Multiplication();
           Console.WriteLine("Mul is {0}",result);

           result=c1.Division();
           Console.WriteLine("Div is {0}",result);

           result=c1.Remainder();
           Console.WriteLine("Rem is {0}",result);
        }

        static void Torial()
        {
            secondCal c2=new secondCal();

            Console.Write("Factorial :   ");
            c2.inputNum1=int.Parse(Console.ReadLine());

            int result=c2.fact();
            Console.WriteLine("Factorial is "+result);
        }

    } // end of claculator class
}//end of namespace 

namespace Sign
{
    public class firstCal
    {
        //3 state
        public double firstNum,secondNum;
        public char MathematicSign;
        
        //1 Constuctor
        public firstCal()
        {

        }
 
        //5 behavior/method
        public double Addition()
        {
            double result=firstNum+secondNum;
            return result;
        }

        public double Substraction()
        {
            double result=firstNum-secondNum;
            return result;
        }

        public double Multiplication()
        {
            double result=firstNum*secondNum;
            return result;
        }

        public double Division()
        {
            double result=firstNum/secondNum;
            return result;
        }

        public double Remainder()
        {
            double result=firstNum%secondNum;
            return result;
        }
    }
}

namespace Factorial
{
    public class secondCal 
    {
        //1 state
        public int inputNum1;

        //1 Constuctor
        public secondCal()
        {

        }
        
        //1 behaviour/action/method
        public int fact()
        {
           int result=1;
           while(inputNum1>0)
           {
               result*=inputNum1;
               inputNum1--;
           } 
           return result;
        }
    }
}