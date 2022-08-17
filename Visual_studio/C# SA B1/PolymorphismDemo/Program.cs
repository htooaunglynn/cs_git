using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator c=new Calculator();
            c.Add(1, 2);
            c.Add(3.28, 4.21);
            c.Add(2, 3, 8);

            //mammal
            Human p = new Human()
            {
                Name = "AA KK",
                Color = "While",
                lifespan = "100",
                EatFoodType = "All eat",
                NRC = "838jdjdi",
                BloodType = "A",
            };
            p.Info();
            p.Eat();
            p.Sleeping();
            p.Speak();

            //Dog
            Dog d = new Dog()
            {
                Name = "Aung Neck",
                Color = "While",
                lifespan = "8",
                EatFoodType = "All eat",
            };
            d.Eat();
            d.Sleeping();
            d.Speak();

            //Cat
            Cat cat= new Cat()
            {
                Name = "Neiko",
                Color = "While",
                lifespan = "8",
                EatFoodType = "Fish",
            };
            cat.Eat();
            cat.Sleeping();
            cat.Speak();


            Console.ReadKey();
        }
    }
}
