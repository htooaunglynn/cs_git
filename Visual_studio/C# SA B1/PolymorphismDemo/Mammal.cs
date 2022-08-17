using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismDemo
{
    internal class Mammal
    {
        //data member of mammal
        public string Name { get; set; }
        public string Color { get; set; }
        public string lifespan { get; set; }
        public string EatFoodType { get; set; }

            public virtual void Eat()
        {
            Console.WriteLine($"{Name} is eating.");
        }

        public virtual void Speak()
        {
            Console.WriteLine($"{Name} is Speaking.");
        }

        public void Sleeping()
        {
            Console.WriteLine($"{Name} is sleeeping.");
        }

        public virtual void Info()
        {
            Console.WriteLine($"Name {Name}");
            Console.WriteLine($"Color {Color}");
            Console.WriteLine($"Lifespan {lifespan}");
            Console.WriteLine($"Eat food type {EatFoodType}");
        }
    }
}
