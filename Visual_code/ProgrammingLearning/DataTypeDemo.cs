using System;

class DataTypeDemo
{
    static void Main()
    {
        byte b=23;
        short s=200;
        int i=7000;
        long l=200000;

        Console.WriteLine(b);
        Console.WriteLine(s);
        Console.WriteLine(i);
        Console.WriteLine(l);
        Console.WriteLine("byte value is {0}",b);
        Console.WriteLine("short value is "+s);
        Console.WriteLine("integer value is {0}",i);

        float f=28.29f;
        double d=f-28.22;
        decimal e=292.292m;
 
        Console.WriteLine("float value is "+f);
        Console.WriteLine("Doubel value is "+d);
        Console.WriteLine("Decimal value is "+e);

        bool mdm=true;
        char haha='a';

        Console.WriteLine("bool value is"+mdm);
        Console.WriteLine("Char value is "+haha);


    }
}