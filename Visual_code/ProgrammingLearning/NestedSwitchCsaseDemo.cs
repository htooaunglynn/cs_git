using System;
class NestedSwitchCsaseDemo
{
    static void Main()
    {
        int value1=20;
        switch (value1)
        {
            case20:
            {
             int i=value1%2;
             Console.WriteLine("Value is 20");
             switch (i)
             {
                 case 0: Console.WriteLine("Even");break;

             };break;

            };break;
        }
    }
}