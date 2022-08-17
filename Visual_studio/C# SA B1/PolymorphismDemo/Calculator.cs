using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismDemo
{
    internal class Calculator
    {
        public void Add(int n1,int n2)
        {
            int result = n1 + n2;
            Console.WriteLine(result);
        }

        public void Add(double n1,double n2)
        {
            double result = n1 + n2;
            Console.WriteLine(result);
        }

        public void Add(int n1,int n2,int n3)
        {
            int result = n1 + n2 + n3;
            Console.WriteLine(result);
        }
    }
}
