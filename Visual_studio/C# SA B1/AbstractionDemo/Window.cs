using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionDemo
{
    public abstract class Window
    {
        // data member
        public string Title { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }

        //behaviour 
        //non-abstract method
        public void DisplayInfo()
        {
            Console.WriteLine($"Title {Title} \n{Width} \n{Height}");
        }

        //abstract method (only has method signature, do not has implementation/method body)
        //tell what , don't tell how
        public abstract void Close();
        public abstract void Open();
    }
}
