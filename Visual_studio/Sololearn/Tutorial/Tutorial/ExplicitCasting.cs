using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial
{
    internal class ExplicitCasting
    {
        public ExplicitCasting()
        {
            //Create a constructor
        }

        public static void Method1()
        {
            double myDouble = 3.12;
            long myLong = (long)myDouble;  // Manual casting: double to long
            int myInt=(int)myDouble;      // Manual casting: double to int

            Console.WriteLine($"{myLong} and {myInt} ");
        }

        public static void Method2()
        {
            bool myBool = true;

            Console.WriteLine(Convert.ToString(myBool));
        }
    }
}
