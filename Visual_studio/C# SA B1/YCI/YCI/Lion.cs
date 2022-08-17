using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YCI
{
    internal class Lion:Animal
    {
        public override void Eat()
        {
            Console.WriteLine("{0} Lion ate meal.",base.Name);
        }

        
    }
}
