using System;


namespace Mathematic
{
    class Solution
    {
        static void Main()
        {
            AskAgain(); 

        }//end of main

        //ask try again method 
        static void AskAgain()
        {
            string ask = "yes";
            do
            {
                Wrong();

                Console.WriteLine("Try again? (yes/no) : ");
                ask = Console.ReadLine();

            } while (ask.Equals("yes")); // end of do loop
        } // end of AskAgain method 

        //This method for try catch
        static void Wrong()
        {
            inputWrongHere: // input wrong program return

            try
            {
                Calculator();
            } // end of try

            catch (Exception e)
            {
                Console.WriteLine("You input is something please check again.");
                goto inputWrongHere;
            } // end of catch
        }

        //this method for Calculator
        static void Calculator()
        {
            //first number request and accept
            Console.Write("Enter first number : ");
            double firstNumber = Convert.ToDouble(Console.ReadLine());

            //second number request and accept
            Console.Write("Enter second number : ");
            double secondNumber = Convert.ToDouble(Console.ReadLine());

            //Mathematical symbol request and accept
            Console.Write("Enter Mathematic sign : ");
            char sign = Convert.ToChar(Console.ReadLine());

            //Condition for mathematical symbol
            switch(sign)
            {
                case '+':double resultAdd = Addition(firstNumber, secondNumber);Console.WriteLine("{0} + {1} = {2}", firstNumber, secondNumber, resultAdd);break;
                case '-':double resultSub = Substraction(firstNumber, secondNumber);Console.WriteLine("{0} - {1} = {2}", firstNumber, secondNumber, resultSub);break;
                case '*':double resultMul = Multiplication(firstNumber, secondNumber);Console.WriteLine("{0} * {1} = {2}", firstNumber, secondNumber, resultMul);break;
                case '/':double resultDiv = Division(firstNumber, secondNumber);Console.WriteLine("{0} / {1} = {2}", firstNumber, secondNumber, resultDiv);break;
                case '%':double resultRem = Remainder(firstNumber, secondNumber);Console.WriteLine("{0} % {1} = {2}", firstNumber, secondNumber, resultRem);break;
                default:Console.WriteLine("You input Mathematical symbol is something wrong.");break;
            } //end of switch

        }  //end of Calculator method

        //This method for addition
        static double Addition(double num1,double num2)
        {
            double resultAddition = num1 + num2;
            return resultAddition;
        } //end of addition

        // This method for substraction
        static double Substraction(double num1,double num2)
        {
            double resultSubstraction = num1 - num2;
            return resultSubstraction;
        } // end of Substraction

        // This method for multiplication
        static double Multiplication(double num1,double num2)
        {
            double resultMultiplication = num1 * num2;
            return resultMultiplication;
        } // end of Multiplication

        // This method for division
        static double Division(double num1,double num2)
        {
            double resultDivision = num1 / num2;
            return resultDivision;
        }// end of Division

        // this method for remainder
        static double Remainder(double num1,double num2)
        {
            double resultRemainder = num1 % num2;
            return resultRemainder;
        } // end of Remainder

    } //end of class

} //end of namespace
