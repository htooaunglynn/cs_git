using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public class Square:Rectangle
    { 

        public override void InputInfo()
        {
            Console.WriteLine("\nSquare information!");

            Console.Write("Enter name : ");
            Name = Console.ReadLine();

            Console.Write("Color : ");
            Color = Console.ReadLine();

            Console.Write($"Enter side : ");
            Side = Convert.ToDouble(Console.ReadLine());
        }

        public override void CalculateArea()
        {
            Area = Side * Side;

            Console.WriteLine($"Area is {Area}");
        }

        public override void CalculatePertimeter()
        {
            Pertimeter = 4 * Side;

            Console.WriteLine($"Pertimeter is {Pertimeter}");
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
        }
    }
}
