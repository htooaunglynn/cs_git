using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial
{
    internal class AboutString
    {
        public AboutString()
        {
            //create a constructor
        }

        public static void Concatenation(string a,string b)
        {
            //The + operator can be used between strings to combine them. 
            Console.WriteLine(a +" "+ b);

            //You can also use the string.Concat() method to concatenate two strings
            Console.WriteLine(string.Concat(a,b));
        }

        public static void Interpolation(string a,string b)
        {
            //you have to use the dollar sign ($) when using the string interpolation method
            //String interpolation was introduced in C# version 6.
            //you do not have to worry about spaces
            Console.WriteLine($"{a} {b}");
        }

        public static void Access()
        {
            //you can find position of specific character in a string, by using of IndexOf method:
            string myString = "Hello";
            Console.WriteLine(myString.IndexOf("o"));

            //Another useful method is Substring(), which extracts the characters from a string,
            //starting from the specified character position/index, and returns a new string.
            //This method is often used together with IndexOf() to get the specific character position:
            // Full name
            string name = "John Doe";

            // Location of the letter D
            int charPos = name.IndexOf("D");

            // Get last name
            string lastName = name.Substring(charPos);

            // Print the result
            Console.WriteLine(lastName);
        }
    } // end of AboutString
} // end of Turoral
