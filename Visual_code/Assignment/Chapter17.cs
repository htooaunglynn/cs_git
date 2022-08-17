using System;
using Program;

namespace Assignment
{
    class Chapter17
    {
        static void Main()
        {
            Monotreme mono=new Monotreme();
            mono.Bio();
            mono.DataInput();
            mono.DataOutput();

            Marsupial mar=new Marsupial();
            mar.Bio();
            mar.DataInput();
            mar.DataOutput();

            Placental pla=new Placental();
            pla.Bio();
            pla.DataInput();
            pla.DataOutput();
        }
    }
}

namespace Program
{
    class Mammal
    {
        public string name,age,color,livingPlace;

        public void DataInput()
        {
            Console.Write("Name : ");
            name=Console.ReadLine().ToUpper();

            Console.Write("Age : ");
            age=Console.ReadLine().ToUpper();

            Console.Write("Color : ");
            color=Console.ReadLine().ToUpper();

            Console.Write("Living Place : ");
            livingPlace=Console.ReadLine().ToUpper();
        }

        public void DataOutput()
        {
            Console.WriteLine("Name is "+name);
            Console.WriteLine("Age is "+age);
            Console.WriteLine("Color is "+color);
            Console.WriteLine("Living place is "+livingPlace);
        }
    }

    class Monotreme:Mammal
    {
        public void Bio()
        {
            Console.WriteLine("Monotremes are mammals that lay eggs. \nThe only monotremes that are alivetoday are the spiny anteater, or echidna, and the platypus. \nThey live in Australia,Tasmania, and New Guinea.");
        }
    }

    class Marsupial:Mammal
    {
        public void Bio()
        {
            Console.WriteLine("Marsupial mammals give birth to babies that are not completely developed. \nThe babies are very tiny.");
        }
    }

    class Placental:Mammal
    {
        public void Bio()
        {
            Console.WriteLine("A placental mammal develops inside its mother's body until its body systemscan function on their own.");
        }
    }
}