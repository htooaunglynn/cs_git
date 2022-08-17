using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YCI
{
    class Phone:ElectricDrive
    {
        public void MakeDial()
        {
            Console.WriteLine("Dialing.");
        }

        public void SendSMS()
        {
            Console.WriteLine("sending mail.");
        }

        public void PressKey()
        {
            Console.WriteLine("Pressing a key.");
        }
    }
}
