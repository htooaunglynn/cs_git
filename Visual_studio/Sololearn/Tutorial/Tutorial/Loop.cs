using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial
{
    internal class Loop
    {
        public static void UseFor(int i)
        {
            // Statement 1 is executed (one time) before the execution of the code block.

           // Statement 2 defines the condition for executing the code block.

           // Statement 3 is executed(every time) after the code block has been executed

            for (i = 0; i < 10; i++)
            {
                Console.Write(i+" ");
            }
        }

        public static void Useforeach()
        {
            //There is also a foreach loop, which is used exclusively to loop through elements in an array

            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            foreach (string i in cars)
            {
                Console.WriteLine(i);
            }
        }
    } // end of loop
}// end of Tutorial
