using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismDemo
{
    internal class Human:Mammal
    {
        public string NRC { get; set; }
        public string BloodType { get; set; }

        public override void Speak()
        {
            Console.WriteLine($"Hi!!!, My name is {base.Name}");
        }

        public override void Info()
        {
            base.Info();
            Console.WriteLine($"NRC {NRC}");
            Console.WriteLine($"Blood type {BloodType}");
        }
    }
}
