using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public class Parallelogram:Rectangle
    {
        public double Base { get; set; }

        public override void InputInfo()
        {
            Console.WriteLine("\nParallelogram information!");

            Console.Write("Enter name : ");
            Name = Console.ReadLine();

            Console.Write("Color : ");
            Color = Console.ReadLine();

            Console.Write("Enter Height : ");
            Height = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter base : ");
            Base = Convert.ToDouble(Console.ReadLine());
        }

        public override void CalculateArea()
        {
            Area = Base * Height;
            Console.WriteLine($"Area is {Area}");
        }

        public override void CalculatePertimeter()
        {
            Pertimeter = 2 * (Base + Side);
            Console.WriteLine($"Pertimeter is {Pertimeter}");
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
        }
    }
}
