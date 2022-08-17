using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public class Rectangle : Shape
    {
        public double Height { get; set; }
        public double Width { get; set; }
        public double Area { get; set; }   
        public double Pertimeter { get; set; }
        public double Side { get; set; }

        

        public override void InputInfo()
        {
            Console.WriteLine("\nRectangle information!");

            base.InputInfo();

            Console.Write("Enter Height : ");
            Height = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Width : ");
            Width = Convert.ToDouble(Console.ReadLine());
        }

        public override void CalculateArea()
        {
            Area = Height * Width;

            Console.WriteLine($"Area is {Area}");
        }

        public override void CalculatePertimeter()
        {
            Pertimeter = 2 * (Height + Width);

            Console.WriteLine($"Pertimeter is {Pertimeter}");
        }

        public override void DisplayInfo()
        {
            
            Console.WriteLine($"Name : {Name}");
            Console.WriteLine($"Color : {Color}");
            CalculateArea();
            CalculatePertimeter();
            Console.WriteLine("==================================\n");
        }
    }
}
