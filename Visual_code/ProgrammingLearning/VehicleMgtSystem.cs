using System;
using CarInfo;

namespace VehicleInfo
{
    class VehicleMgtSystem
    {
        public static void Main()
        {
            Car myCar=new Car();
            myCar.speed=2000;
            myCar.color="Red";
            myCar.licenceNo="Bg-001";
            myCar.DisplayCarInfo();
            myCar.StartEngine();
            myCar.Drive();
            myCar.StartEngine();

            Console.WriteLine("=============================");

            Car yourCar=new Car();
            yourCar.DisplayCarInfo();

            Console.WriteLine("=============");
        
            Engine myengine=new Engine();
            myengine.enginePower="1010";
            myengine.numberOfPinion=30;
            myengine.madeBy="idnf";
            myengine.DisplayEngineInfo();

            Circle c1=new Circle();
            c1.SetRadius(2.2);
            double result1=c1.GetAre();
            Console.WriteLine("C1 {0}",result1);

            Circle c2=new Circle(5.5);
            double resutl2=c2.GetAre();
            
            Console.WriteLine("C2 {0}",resutl2);
        }
    }
}

namespace CarInfo
{
    class Car
    {
      public int speed;
      public string licenceNo,color;

      public Car()
      {
        speed=0;
        licenceNo="no Licence ";
        color="no color";;
      }
      
      public void StartEngine()
      {
          Console.WriteLine("start engine");
      }

      public void Drive()
      {
         Console.WriteLine("Diver the car");
      }

      public void StopEngine()
      {
          Console.WriteLine("Stop engine");
      }

      public void DisplayCarInfo()
      {
          Console.WriteLine("Color:{0}",color);
          Console.WriteLine("LicenceNo:{0}",licenceNo);
          Console.WriteLine("Speed:{0}",speed);
      }

    }


    class Engine
    {
        //2state
        public string enginePower,madeBy;
        public int numberOfPinion;


        public void DisplayEngineInfo() //1 behavior/action/method
        {
            Console.WriteLine("Engine Pover : {0}",enginePower);
            Console.WriteLine("niumbr of pinion {0}",numberOfPinion);
            Console.WriteLine("Moded by : {0}",madeBy);
        }
        
    }

    class Circle
    {
        //1 state
        public double radius=1;

        //1 
        public Circle()
        {

        }

        public Circle(double newRadius)
        {
            radius=newRadius;
        }

        public double GetAre()
        {
            double result=Math.PI*radius*radius;
            return result;
        }

        public double GetPerimeter()
        {
            double result=2*Math.PI*radius*radius;
            return result;
        }

        public void SetRadius(double newRadius)
        {
            radius=newRadius;
        }
    }
}