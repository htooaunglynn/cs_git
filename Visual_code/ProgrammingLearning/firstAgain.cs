using System;

namespace firstAgain
{
    class Program
    {
        public static void Main() 
        {
            Mathematic();
        }

        public static void Mathematic()
        {
            Console.Write("Enter First Number : ");
            double firstNumber = Convert.ToDouble(Console.ReadLine()) ;

            Console.Write("Enter Second Number : ");
            double secondNumber = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Operator : ");
            string op = Console.ReadLine();

            switch (op)
            {
                case "+": Console.WriteLine("Answer is {0}",firstNumber+secondNumber);
                break;                

                // case "-": Console.WriteLine("Answer is {0}"+firstNumber-secondNumber);
                // break;    

                case "*": Console.WriteLine("Answer is {0}",firstNumber*secondNumber);
                break;    

                case "/": Console.WriteLine("Answer is {0}",firstNumber/secondNumber);
                break;    

                case "%": Console.WriteLine("Answer is {0}",firstNumber%secondNumber);
                break;    

                default:Console.WriteLine("Opeartor is wrong.");
                break;
            }
        }
    }
}