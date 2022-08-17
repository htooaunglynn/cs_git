using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public abstract class Shape
    {
        public string Color { get; set; }

        public string Name { get; set; }

        public double Radius { get; set; }

        public abstract void CalculateArea();

        public abstract void CalculatePertimeter();

        public abstract void DisplayInfo();

        public virtual void InputInfo()
        {
            Console.Write("Enter name : ");
            Name = Console.ReadLine();

            Console.Write("Color : ");
            Color = Console.ReadLine();
        }
    }
}
