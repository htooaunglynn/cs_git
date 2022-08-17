using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public class Circle : Shape
    {
        

        public override void InputInfo()
        {
            Console.WriteLine("Circle information!");

            base.InputInfo();

            Console.Write("Enter radius : ");
            Radius = Convert.ToDouble(Console.ReadLine());
        }

        public override void CalculateArea()
        {
            double area = Radius * Radius * Math.PI;

            Console.WriteLine($"Area is {area}");
        }

        public override void CalculatePertimeter()
        {
            double pertimeter = 2 * Radius * Math.PI;

            Console.WriteLine($"Pertimeter is {pertimeter}");
        }

        public override void DisplayInfo()
        {
            
            Console.WriteLine($"Name : {Name}");
            Console.WriteLine($"Color : {Color}");
            CalculateArea();
            CalculatePertimeter();
            Console.WriteLine("=================================\n");
        }
    }
}
