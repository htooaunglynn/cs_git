using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YCI
{
    public class Animal
    {
        private string name, color, livingPlace;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        public string LivingPlace
        {
            get { return livingPlace; }
            set { livingPlace = value; }
        }

        public virtual void Eat()
        {
            Console.WriteLine("{0} eat meal.",name);
        }

        public void Sleep()
        {
            Console.WriteLine("{0} sleep a place.",name);
        }

        public void Walk()
        {
            Console.WriteLine("{0} is walking.", name);
        }

        public void Display()
        {
            Console.WriteLine("{0} name", Name); //string indexing >> {0} ,
            Console.WriteLine("Color " + Color); //string concatenation pattern >> +
            Console.WriteLine($"Living Place:{LivingPlace}"); // string interpolation pattern >> $ ":{}"
        }
    }
}
