using System;

namespace YCI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Dog myDog = new Dog();
            myDog.Name = "Gugu";
            myDog.Color = "red";
            myDog.LivingPlace = "Home";
            myDog.Eat();
            myDog.Sleep();
            myDog.Walk();
            myDog.Sound();

            Cat myCat = new Cat();
            myCat.Name = "Shuhs";
            myCat.Color = "si";
            myCat.LivingPlace = "road";
            myCat.Eat();
            myCat.Sleep();
            myCat.Walk();
            myCat.Sound();

           /* SmarthPhone iPhone = new SmarthPhone();
            iPhone.Color = "red";
            iPhone.MadeBy = "apple";
            iPhone.ManufactureDate = Convert.ToDateTime("11 - 2 - 1999");*/
            /*iPhone.Type = "singal sim";

            iPhone.UseData();
            iPhone.MakeDial();
            iPhone.ShowData();*/

            Lion myLion = new Lion();
            myLion.Name = "papy";
            myLion.Color = "black";
            myLion.LivingPlace = "water";
            myLion.Eat();
            myLion.Display();
            myLion.Display();



            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
        }
    }
}
