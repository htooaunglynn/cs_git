using System;
using GeneralCalculator;
using FactorialCalculator;
using CircleCalculator;

namespace Training 
{
    class Try
    {
        static void Main()
        {
           ForCircle();
           
        } //end of main method

        static void TryCatch()
        { 
            try
            {
                 //
            }
            catch (Exception e)
            {
                Console.WriteLine("Error occur, please check your input again.");
            }
        }

        static void ForGeneral()
        {
            //create object
            General cal=new General();

            // first input number
            Console.Write("Enter first number : ");
            cal.firstNumIP=Convert.ToDouble(Console.ReadLine());

            // second input number
            Console.Write("Enter second number : ");
            cal.secondNumIP=Convert.ToDouble(Console.ReadLine());

            // operator choose
            Console.Write("Enter Mathematical symbol :  ");
            cal.mathSignIP=Convert.ToChar(Console.ReadLine());

            //calculation
            cal.MathematicSymbol();
        }//end of ForGeneral

        static void ForFactorial()
        {
            //creat object
            //Factorial fact=new Factorial();

            //input factorial number
            Console.Write("Factorial number : ");
            Factorial.inputFactorial=int.Parse(Console.ReadLine());
            
            //output
            int resutl=Factorial.FactorialCondition(Factorial.inputFactorial);
            Console.WriteLine("Factorial is {0}",resutl);
        } // end of ForFactorial method

        static void ForCircle()
        {
            //create object
            Circle cir=new Circle();
            
            // radius request
            Console.Write("Enter radius : ");
            cir.radius=Convert.ToDouble(Console.ReadLine());
            cir.SetRadius(cir.radius);
            
            opWrongHere:

            // choose option area or Perimeter
            Console.Write("Which one? (Area or Perimeter) :  ");
            string op=Console.ReadLine();
            
            //condition
            if(op.Equals("Area"))
            {
                double resultA=cir.GetArea();
                Console.WriteLine("Arae is "+resultA);
            } // end of if
            else if(op.Equals("Perimeter"))
            {
                double resultP=cir.GetPerimeter();
                Console.WriteLine("Perimeter is "+resultP);
            } // end of else if
            else
            {
                Console.WriteLine("Error occur!!! Please choose Area or Preimeter.");
                goto opWrongHere;
            } // end of elase

        } // end of ForCircle method 
    } //end of try class
} // end of training namespace

namespace GeneralCalculator
{
    class General
    {
        //3 state
       public double firstNumIP,secondNumIP;
       public char mathSignIP;

        // 1 Constructor 
        //no-argument/parmeter
        public General()
        {

        } // end of General constructor

        //1 behavior/method and 1 argument/parmeter
        public void MathematicSymbol()
        {
            double fIN=firstNumIP;
            double sIN=secondNumIP;
            char sign=mathSignIP;
            
            switch(sign)
            {
                case '+':double resultAdd=Addition(fIN,sIN);Console.WriteLine("{0} + {1} = {2}",fIN,sIN,resultAdd);break;
                case '-':double resultSub=Substraction(fIN,sIN);Console.WriteLine("{0} - {1} = {2}",fIN,sIN,resultSub);break;
                case '*':double resultMul=Multiplication(fIN,sIN);Console.WriteLine("{0} * {1} = {2}",fIN,sIN,resultMul);break;
                case '/':double resultDiv=Division(fIN,sIN);Console.WriteLine("{0} / {1} = {2}",fIN,sIN,resultDiv);break;
                case '%':double resultRem=Remainder(fIN,sIN);Console.WriteLine("{0} % {1} = {2}",fIN,sIN,resultRem);break;
                default:Console.WriteLine("Your input Mathemaitcal symbol is wrong please check again.");break;
            }
        }// end of MathematicSymbol method 

        //5 behaviors/method 
        //2 argument/parmeter in each of behaviors

        //This method/behaviour for additions
        public double Addition(double num1,double num2)
        {
            double result=num1+num2;
            return result;
        } // end of addition method

        //This method/behaviour for substraction
        public double Substraction(double num1,double num2)
        {
            double result=num1-num2;
            return result;
        } // end of Substraction method

        //This method/behaviour for Multiplication
        public double Multiplication(double num1,double num2)
        {
            double result=num1*num2;
            return result;
        } // end of multiplication method

        //This method/behaviour for division
        public double Division(double num1,double num2)
        {
            double result=num1/num2;
            return result;
        } // end of division method

        //This method/behaviour for remainder
        public double Remainder(double num1,double num2)
        {
            double result=num1%num2;
            return result;
        } // end of Remainder method

        
    } // end  of general class
} // end of GeneralCalculator

namespace FactorialCalculator
{
    class Factorial
    {
        //1 state
        public static int inputFactorial;

        //1 Constructor
        //no-argument/parmeter
        public Factorial()
        {

        } // end of Factorial constructor


        // 1 behavior/method
        //1 argument/parmeter 
        public static int FactorialCondition(int num1)
        {
            inputFactorial=num1;
            int result=1;
            while(inputFactorial>0)
            {
                result*=inputFactorial;
                inputFactorial--;
            }
            return result;
        } // end of FactorialCondition method
    } //end of Factorial class
} // end of FactorialCalculator 

namespace CircleCalculator
{
    class Circle
    {
        // 1 state
        public double radius;

        //1 constructor , no-argument
        public Circle()
        {

        }
     
        //2 behaviour , no-argument
        public double GetArea()
        {
            double result=Math.PI*radius*radius;
            return result;
        }

        public double GetPerimeter()
        {
            double result=2*Math.PI*radius*radius;
            return result;
        }

        public void SetRadius(double newRadius)
        {
            radius=newRadius;
        }

    } // end of Circle class
} // end of CircleCalculator namespace