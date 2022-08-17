using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial
{
    internal class Mathematic
    {
        public Mathematic()
        {
            // create a constuctor
        }

        public static void Maxmimum(int x,int y)
        {
            //The Math.Max(x,y) method can be used to find the highest value of x and y
            Console.WriteLine(Math.Max(x,y));
        }

        public static void Minimum(int x,int y)
        {
            //The Math.Min(x,y) method can be used to find the lowest value of of x and y
            Console.WriteLine(Math.Min(x, y));
        }

        public static void Square(int x)
        {
            //The Math.Sqrt(x) method returns the square root of x
            Console.WriteLine(Math.Sqrt(x));
        }

        public static void PositiveValue(double x)
        {
            //The Math.Abs(x) method returns the absolute(positive) value of x
            Console.WriteLine(Math.Abs(x));
        }

        public static void NearestWholeNumber(double x)
        {
            //Math.Round() rounds a number to the nearest whole number
            Console.WriteLine(Math.Round(x));
        }
    }// end of Mathematic class
} // end of Tutorial namespace
