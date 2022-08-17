using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial
{
    internal class ParameterAndArgument
    {
        // When a parameter is passed to the method, it is called an argument.

        // conuntry is a parameter.
        public static void MyMethod(string country = "Yangon")
        {
            Console.WriteLine(country);
        }

        // Mandalay is argument.
        public static void Call()
        {
            MyMethod("Mandalay");
            MyMethod2(d: "HALo", b: "I", c: "am", a: "Hello");
        }

        public static int Calculation(int x,int y)
        {
            return x + y;
        }

        public static void MyMethod2(string a,string b,string c,string d)
        {
            //It is also possible to send arguments with the key: value syntax
            // MyMethod2(d: "HALo", b: "I", c: "am", a: "Hello");

            Console.WriteLine(a + b + c + d);
        }
    }
}
