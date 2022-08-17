// call system library
using System; 

// declare Calculation namespace
namespace Calculation  
{
    // delcare SmallCalculator class
    class SmallCalculator 
    {
        // delcare main method
        static void Main() 
        {
            string ask;
            do
            {
                //create object
                ErrorCheck errorCheck=new ErrorCheck();
                errorCheck.ErrorCondition();

                //ask try again
                Console.WriteLine("Another? (yes/no) ");
                ask=Console.ReadLine().ToLower();
            } while (ask.Equals("yes") || ask.Equals("y"));

        } // end of Main Method


    } // end of SmallCalculator
    
    // declare Mathematic class
    public class DataRequest
    {
        // create Constructor no-argument
       public DataRequest()
        {
            //
        }

        //3 state
        private double firstNumInput;
        public double FirstNumInput
        {
            get { return firstNumInput; }
            set 
            {
                
                 firstNumInput = value; 
            }
        }

        private double secondNumInput;
        public double SecondNumInput
        {
            get { return secondNumInput; }
            set 
            {
                
                 secondNumInput = value; 
            }
        }

        private char sign;
        public char Sign
        {
            get { return sign; }
            set 
            { 
                if(value.Equals('+') || value.Equals('-') || value.Equals('*') || value.Equals('/') || value.Equals('%') )
                {
                  throw new ArgumentException("invalid stuff Mathematical symbol.");
                }
                sign = value; 
            }
        }
        
        
        //Data request method
        public void DataAccept()
        {
            Console.Write("Enter frist number : ");
            FirstNumInput=Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter second number : ");
            SecondNumInput=Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Mathematical symbol : ");
            sign=Convert.ToChar(Console.ReadLine());
        } // end of DataAccept
        
    } // end of DataRequest class

    public class Calculator:DataRequest
    {
        // create constructor
        public Calculator()
        {

        }
        
        //6 behaviour
        public double Addition(double num1,double num2)
        {
            FirstNumInput=num1;
            SecondNumInput=num2;
            double result=FirstNumInput+SecondNumInput;
            return result;
        } // end of Addition method

        public double Substruction(double num1,double num2)
        {
            FirstNumInput=num1;
            SecondNumInput=num2;
            double result=FirstNumInput-SecondNumInput;
            return result;
        } // end of Substruction method

        public double Multiplication(double num1,double num2)
        {
            FirstNumInput=num1;
            SecondNumInput=num2;
            double result=FirstNumInput*SecondNumInput;
            return result;
        } // end of Multiplication method

        public double Division(double num1,double num2)
        {
            FirstNumInput=num1;
            SecondNumInput=num2;
            double result=FirstNumInput/SecondNumInput;
            return result;
        } // end of Division method

        public double Remainder(double num1,double num2)
        {
            FirstNumInput=num1;
            SecondNumInput=num2;
            double result=FirstNumInput%SecondNumInput;
            return result;
        }  // end of Remainder method

        public void SignCondition(DataRequest dataRequest)
        {
            switch (Sign)
            {
                case '+':double resultAdd=Addition(FirstNumInput,SecondNumInput);
                        Console.WriteLine("{0} + {1} = {2}",FirstNumInput,SecondNumInput,resultAdd);
                        break;

                case '-':double resultSub=Substruction(FirstNumInput,SecondNumInput);
                        Console.WriteLine("{0} - {1} = {2}",FirstNumInput,SecondNumInput,resultSub);
                        break;

                case '*':double resultMul=Multiplication(FirstNumInput,SecondNumInput);
                        Console.WriteLine("{0} * {1} = {2}",FirstNumInput,SecondNumInput,resultMul);
                        break;

                case '/':double resultDiv=Division(FirstNumInput,SecondNumInput);
                        Console.WriteLine("{0} / {1} = {2}",FirstNumInput,SecondNumInput,resultDiv);
                        break;

                case '%':double resultRem=Remainder(FirstNumInput,SecondNumInput);
                        Console.WriteLine("{0} % {1} = {2}",FirstNumInput,SecondNumInput,resultRem);
                        break;
                
            } // end of switch 
        } // end of SignCondition method
    } // end of Calculator class

    public class ErrorCheck:Calculator
    {
        //create constructor
        public ErrorCheck()
        {

        }

        public void ErrorCondition()
        {
            try
            {
                //create object
                DataRequest dataRequest=new DataRequest();
                dataRequest.DataAccept();

                //create object
                Calculator calculator=new Calculator();
                calculator.SignCondition(dataRequest.DataAccept());

            }
            catch (Exception e)
            {
                
                Console.WriteLine("Error occur "+e.Message);
            }
        }
    } // end of Errocheck class

}  // end of Calculation namespace