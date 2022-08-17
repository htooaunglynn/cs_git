using System;
using System.Linq;

namespace Tutorial
{
    internal class ArrayEX
    {
        public static void SortArray()
        {
            //There are many array methods available,
            //for example Sort(), which sorts an array alphabetically or in an ascending order

            // Sort a string
            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            Array.Sort(cars);
            foreach (string i in cars)
            {
                Console.WriteLine(i);
            }

            // Sort an integer
            int[] x = { 90, 100, 1, 98, 827, 928, 2222 };
            Array.Sort(x);
            foreach (int i in x)
            {
                Console.WriteLine(i);
            }
        }

        public static void SystemLinqName()
        {
            //Other useful array methods, such as Min, Max, and Sum, can be found in the System.Linq namespace

            int[] v = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, };
            Console.WriteLine(v.Max());
            Console.WriteLine(v.Min());
            Console.WriteLine(v.Sum());
        }
    }
}
