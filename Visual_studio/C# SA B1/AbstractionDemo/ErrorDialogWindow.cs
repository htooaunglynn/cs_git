using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionDemo
{
    internal class ErrorDialogWindow : Window
    {
        public override void Close()
        {
            Console.WriteLine("error dialog window are closing now.");
        }

        public override void Open()
        {
            Console.WriteLine($"Error dialog window is open at : {base.Width} and {base.Height}");
        }
    }
}
