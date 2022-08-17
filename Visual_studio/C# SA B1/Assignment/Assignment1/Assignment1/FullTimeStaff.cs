using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    public class FullTimeStaff:Staff
    {
        public override void Infomation()
        {
            Console.WriteLine("Full time information!");

            here:

            try
            {
                base.Infomation();
            }
            catch (Exception e)
            {

                Console.WriteLine("Error occur " + e.Message);

                goto here;
            }
        }

        public override void DisplayData()
        {
            base.DisplayData();
        }
    }
}
