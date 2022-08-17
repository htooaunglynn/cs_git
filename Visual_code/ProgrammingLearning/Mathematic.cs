using System; //call library
class Mathematic //delcaration class
{
    static void Main() // Main Method
    {
        char ask;
        do
        {
            Calculator(); //call calculator method
            Console.Write("Try again? (y/n): ");
            ask=Convert.ToChar(Console.ReadLine());
        }while(ask!='n');

        Console.WriteLine("Press any key to exit!");
        Console.ReadKey();
    }  //end of main method

    static void Calculator() //This method calcutator
    {
        somethingWrongProgramHere: //input wrong program return here
        try
        {
         Console.Write("--- Calculator --- \nEnter 1st number: ");
         double inputNumber1=Convert.ToDouble(Console.ReadLine());
         Console.Write("Enter 2nd number: ");
         double inputNumber2=Convert.ToDouble(Console.ReadLine());
         Console.Write("Enter choose method. \n('+' for addition,'-' for subtraction,'*' for multiplication,'/' for division,'%' for remainder)  ");
         char mathematicSign=Convert.ToChar(Console.ReadLine());

         switch(mathematicSign)
         {
            case '+':double resultAddition=Addition(inputNumber1,inputNumber2);  //call addition method
                     Console.WriteLine("{0} + {1} = {2}",inputNumber1,inputNumber2,resultAddition);break;
            case '-':double resultSubtraction=Subtraction(inputNumber1,inputNumber2); //call subtraction method 
                     Console.WriteLine("{0} - {1} = {2}",inputNumber1,inputNumber2,resultSubtraction);break;
            case '*':double resultMultiplication=Multiplication(inputNumber1,inputNumber2); //call multiplication method
                     Console.WriteLine("{0} * {1} = {2}",inputNumber1,inputNumber2,resultMultiplication);break;
            case '/':double resultDivision=Division(inputNumber1,inputNumber2); //call division method
                     Console.WriteLine("{0} / {1} = {2}",inputNumber1,inputNumber2,resultDivision);break;
            case '%':double resultRemainder=Remainder(inputNumber1,inputNumber2); //call remainder method
                     Console.WriteLine("{0} % {1} = {2}",inputNumber1,inputNumber2,resultRemainder);break;
            default:Console.WriteLine("Hey, your input is something wrong please check again.");goto somethingWrongProgramHere;break;
         }
        }
        catch(Exception e)
        {
            Console.WriteLine("Hey, your input is something wrong please check again.");
            goto somethingWrongProgramHere;
        }
    }

    static double Addition(double inputNum1,double inputNum2) //This method for addition
    {
        double additionResult=inputNum1+inputNum2;
        return additionResult;
    }

    static double Subtraction(double inputNum1,double inputNum2) //This method for subtraction
    {
        double subtractionResult=inputNum1-inputNum2;
        return subtractionResult;
    }

    static double Multiplication(double inputNum1,double inputNum2)  //This method for multiplication
    {
        double multiplicationResult=inputNum1*inputNum2;
        return multiplicationResult;
    }

    static double Division(double inputNum1,double inputNum2)  //This method for division
    {
        double divisionResult=inputNum1/inputNum2;
        return divisionResult;
    }

    static double Remainder(double inputNum1,double inputNum2)  //Thsi method for remainder
    {
        double remainderResult=inputNum1%inputNum2;
        return remainderResult;
    }
} //end of class