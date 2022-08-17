using System; //call library or Importing namespace

class Chapter10Assignment //delcaration class
{
    static void Main() // Main Method
    {
        Calculator(); //call calculator method    

    }  //end of main method

    static void Calculator() //This method calcutator
    {
    somethingWrongProgramHere:  //input wrong program return here

        try
        {
            Console.Write("--- Calculator --- \nEnter 1st number: "); //first number 
            double inputNumber1 = Convert.ToDouble(Console.ReadLine()); //first number input accept

            Console.Write("Enter 2nd number: ");                      //second number
            double inputNumber2 = Convert.ToDouble(Console.ReadLine()); //second number input accept

        signSomethingWrongHere: //Mathematic sign wrong input program return here

            Console.Write("Enter choose method. \n('+' for addition,'-' for subtraction,'*' for multiplication,'/' for division,'%' for remainder)  "); //Mathematic sign
            char mathematicSign = Convert.ToChar(Console.ReadLine()); //Mathematic sign accept

            switch (mathematicSign)
            {
                case '+':
                    double resultAddition = Addition(inputNumber1, inputNumber2);  //call addition method
                    Console.WriteLine("{0} + {1} = {2}", inputNumber1, inputNumber2, resultAddition); break;

                case '-':
                    double resultSubtraction = Subtraction(inputNumber1, inputNumber2); //call subtraction method 
                    Console.WriteLine("{0} - {1} = {2}", inputNumber1, inputNumber2, resultSubtraction); break;

                case '*':
                    double resultMultiplication = Multiplication(inputNumber1, inputNumber2); //call multiplication method
                    Console.WriteLine("{0} * {1} = {2}", inputNumber1, inputNumber2, resultMultiplication); break;

                case '/':
                    double resultDivision = Division(inputNumber1, inputNumber2); //call division method
                    Console.WriteLine("{0} / {1} = {2}", inputNumber1, inputNumber2, resultDivision); break;

                case '%':
                    double resultRemainder = Remainder(inputNumber1, inputNumber2); //call remainder method
                    Console.WriteLine("{0} % {1} = {2}", inputNumber1, inputNumber2, resultRemainder); break;

                default: Console.WriteLine("Hey, your mathematic sign is something wrong please check again."); goto signSomethingWrongHere; break;
            }
        }

        catch (Exception e) //if first number and second number input wrong 
        {
            Console.WriteLine("Hey, your input is something wrong please check again.");
            goto somethingWrongProgramHere;
        }
    }

    static double Addition(double inputNum1, double inputNum2) //This method for addition
    {
        double additionResult = inputNum1 + inputNum2;
        return additionResult;
    }

    static double Subtraction(double inputNum1, double inputNum2) //This method for subtraction
    {
        double subtractionResult = inputNum1 - inputNum2;
        return subtractionResult;
    }

    static double Multiplication(double inputNum1, double inputNum2)  //This method for multiplication
    {
        double multiplicationResult = inputNum1 * inputNum2;
        return multiplicationResult;
    }

    static double Division(double inputNum1, double inputNum2)  //This method for division
    {
        double divisionResult = inputNum1 / inputNum2;
        return divisionResult;
    }

    static double Remainder(double inputNum1, double inputNum2)  //Thsi method for remainder
    {
        double remainderResult = inputNum1 % inputNum2;
        return remainderResult;
    }

} //end of class