using System;
class arrydemo
{
    static void Main()
    {
       /* int[] mm=new int[10];
        mm[0]=7;
        Console.WriteLine(mm[1]);
        Console.WriteLine(mm[0]);

        for(int i=0;i<10;i++)
        {
            Console.Write(mm[i]+" ");

        }

        bool[] ok=new bool[5];
        ok[1]=true;
        for(int i=0;i<5;i++)
        {
            Console.Write(ok[i]+" ");
        }
        Console.WriteLine();
        string[] sms=new string[10];
        sms[0]="hi";
        sms[1]="hello";
        sms[4]="idiot";
        for(int i=0;i<10;i++)
        {
            Console.Write(sms[i]+" ");
        }*/

        double[] myArray=new double[5];
        myArray[0]=2.3; //access(Write) to arry
        myArray[1]=25.9;
        for(int i=0;i<5;i++)
        {
            //access(read) from arry
            Console.Write(myArray[i]+" ");
        }
        
        Console.WriteLine("The Array size of myArray is "+myArray.Length);
        char[] vowelArray={'a','e','i','o','u'};// array intialize the array with value
        for(int i=0;i<vowelArray.Length;i++)
        {
            Console.Write(vowelArray[i]+" ");
        }
    }
}