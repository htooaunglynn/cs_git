using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionDemo
{
    internal class WarningDialogWindow : Window
    {
        public override void Close()
        {
            Console.WriteLine("warning dialog window are closing.");
        }

        public override void Open()
        {
            Console.WriteLine($"warning dialog window is open at : {base.Width} and {base.Height}");
        }
    }
}
