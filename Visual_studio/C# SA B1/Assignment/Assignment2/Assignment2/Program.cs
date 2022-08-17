using System;

namespace Assignment2
{
    class Program
    {
        static void Main()
        {
            Circle circle = new Circle();
            circle.InputInfo();
            circle.DisplayInfo();

            Rectangle rectangle = new Rectangle();
            rectangle.InputInfo();
            rectangle.DisplayInfo();

            Square square = new Square();
            square.InputInfo();
            square.DisplayInfo();

            Parallelogram parallelogram = new Parallelogram();
            parallelogram.InputInfo();
            parallelogram.DisplayInfo();

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}