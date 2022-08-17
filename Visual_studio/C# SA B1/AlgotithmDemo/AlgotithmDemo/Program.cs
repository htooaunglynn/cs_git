using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgotithmDemo
{
    public class Program
    {
        static void Main()
        {
            int pass = 0, fail = 0, student = 1;

            while (student<=10)
            {
                Console.Write("Enter exam mark ");
                int mark=Convert.ToInt32(Console.ReadLine());

                if(mark>=40)
                {
                    pass++;
                }
                else
                {
                    fail++;
                }
                student++;
            }
            Console.WriteLine($"Number of passed student {pass}");
            Console.WriteLine($"Number of failed student {fail}");

            if(pass>=8)
            {
                Console.WriteLine("raise tutition.");
            }

            
        }
	}
}
