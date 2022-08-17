using System;
using Hello;

namespace Hi
{
    class StaticKeywordDemo
    {
        public static void Main()
        {
            Test t1=new Test();
            t1.x=20;
            t1.DisplayValue();
            Test.DisplayInfo();
        }
    }
}


namespace Hello
{
   public class Test
    {
        public static int i=10;
        public int x;

        public static void DisplayInfo()
        {
            Console.WriteLine(i);
        }
        public void DisplayValue()
        {
            Console.WriteLine("Value of i : "+i);
            Console.WriteLine("value of x: "+x);
        }
        
    }
}