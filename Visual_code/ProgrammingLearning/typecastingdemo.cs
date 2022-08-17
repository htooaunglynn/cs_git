using System;
class typecastingdemo
{
    static void Main()
    {
        int i=10;
        double d=i;
        Console.WriteLine("i value is "+i);
        Console.WriteLine("d value is "+d);
        double value1=9.8;
        int result=(int)value1;
        Console.WriteLine("value1 is "+value1);
        Console.WriteLine("result is "+result);

        string data="20";
        int age=Convert.ToInt32(data);
        int result1=30-age;
        Console.WriteLine("final result is "+result1);


    }
}