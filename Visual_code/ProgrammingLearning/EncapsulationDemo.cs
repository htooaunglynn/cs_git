using System;
using ComputerFactoru;
namespace Demo
{
    class Encapsulation
    {
        static void Main()
        {
           try
           {
            Console.WriteLine("Program start");

           Computer myPc=new Computer();
           myPc.SetCPU("core i9");
           myPc.SetRAM("32 GB");
           myPc.SetStorage("1 TB SSD");
           myPc.SetGPU("4 GB");
           myPc.DisplayInfo();

           Console.WriteLine();

           Computer uPC=new Computer();
           uPC.SetCPU("sss");
           uPC.SetRAM("eee");
           uPC.SetStorage("fff");
           uPC.SetGPU("4 GB");
           uPC.DisplayInfo();

           Console.WriteLine("you cp                                   "+uPC.GetCPU());

           Console.WriteLine("Program emd ");
           }
           catch (Exception e)
           {
               
               Console.WriteLine("error occur of "+e.Message);
           }
            
        }
    }
}

namespace ComputerFactoru
{
    public class Computer
    {
        private string cpu,ram,storage,gpu;

        public void SetCPU(string _cpu)
        {
            if(String.IsNullOrEmpty(_cpu))
            {
                throw new ArgumentException("invalid cpu value.");
            }
            cpu=_cpu;
        }

        public void SetRAM(string _ram)
        {
            if(String.IsNullOrEmpty(_ram))
            {
                throw new ArgumentException("invalid ram value.");
            }
            ram=_ram;
        }

        public void SetStorage(string _storage)
        {
            if(String.IsNullOrEmpty(_storage))
            {
                throw new ArgumentException("invalid storage value.");
            }
            storage=_storage;
        }

        public void SetGPU(string _gpu)
        {
            if(String.IsNullOrEmpty(_gpu))
            {
                throw new ArgumentException("invalid gpu value.");
            }
            gpu=_gpu;
        }

        public string GetCPU()
        {
            return cpu;
        }


        public void DisplayInfo()
        {
            Console.WriteLine("Computer Specification.");
            Console.WriteLine("cpu: {0}",cpu);
            Console.WriteLine("ram: {0}",ram);
            Console.WriteLine("storge: {0}",storage);
            Console.WriteLine("gpu: {0}",gpu);
        }
    }
}