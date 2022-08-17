using System;

namespace HelloWrold
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int result;

            Console.Write("Enter first number : ");
            int n1 =Convert.ToInt32 (Console.ReadLine());

            Console.Write("Enter second number : ");
            int n2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter char : ");
            char s = Convert.ToChar(Console.ReadLine());

            switch(s)
            {
                case '+':result = n1 + n2;Console.WriteLine(result);break;
                case '-':result = n1 - n2;Console.WriteLine(result);break;
                case '*':result = n1 * n2;Console.WriteLine(result);break;
                case '/':result = n1 / n2;Console.WriteLine(result);break;
                case '%':result = n1 % n2;Console.WriteLine(result);break;
                default:Console.WriteLine("Wrong!!!");break;
            }



            Console.WriteLine("\nPress any key to exit.");
            Console.ReadKey();
        }
    }
}
