using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YCI
{
    class KeyPadPhone:Phone
    {
        public void TakeCamera(string captureType)
        {
            if (captureType.Equals("image"))
            {
                Console.WriteLine("Capture image.");
            }
            else
            {
                Console.WriteLine("Capture video.");
            }
        }

        public void Radio(bool status)
        {
            if(status)
            {
                Console.WriteLine("Radio on.");
            }
            else
            {
                Console.WriteLine("Radio off.");
            }
        }
    }
}
