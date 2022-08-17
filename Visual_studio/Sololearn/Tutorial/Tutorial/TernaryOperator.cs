using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial
{
    internal class TernaryOperator
    {
        public TernaryOperator()
        {
            //create a constructor
        }

        public static void ShortHand(double a,double b)
        {
            //There is also a short-hand if else, which is known as the ternary operator
            //because it consists of three operands. It can be used to replace multiple lines of code
            //with a single line. It is often used to replace simple if else statements
            string result = (a > b) ? $"{a} greater than {b}" : $"{a} less than {b}";
            Console.WriteLine(result);
        }
    }
}
