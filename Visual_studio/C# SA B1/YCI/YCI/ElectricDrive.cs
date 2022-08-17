using System;

namespace YCI
{
    class ElectricDrive
    {
        private string type;

        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        private string color;

        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        private DateTime manufactureDate;

        public DateTime ManufactureDate
        {
            get { return manufactureDate; }
            set { manufactureDate = value; }
        }

        private string madeBy;

        public string MadeBy
        {
            get { return madeBy; }
            set { madeBy = value; }
        }

        private string powerOn;

        public string PowerOn
        {
            get { return powerOn; }
            set { powerOn = value; }
        }

        private string powerOff;

        public string PowerOff
        {
            get { return powerOff; }
            set { powerOff = value; }
        }

        public void ShowData()
        {
            Console.WriteLine("Color " + color);
            Console.WriteLine("Type " + type);
            Console.WriteLine("manufacture date " + manufactureDate);
        }



    }
}
