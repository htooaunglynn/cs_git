using System;
class Program3
{
    static void Main()
    {
        int steps,stepHeight,eachStepWidth;

        for(steps=1;steps<=4;steps++)
        {
            for(stepHeight=1;stepHeight<=3;stepHeight++)
            {
                if(stepHeight%2!=0)
                {
                   for(eachStepWidth=1;eachStepWidth<=steps*5;eachStepWidth++)
                   {
                       Console.Write("*");
                   }
                   Console.WriteLine();
                }

                else if(stepHeight%2==0)
                {
                   for(eachStepWidth=1;eachStepWidth<2;eachStepWidth++)
                   {
                       Console.Write("*");
                   }
                   for(eachStepWidth=1;eachStepWidth<steps*5-1;eachStepWidth++)
                   {
                       Console.Write(" ");
                   }
                   for(eachStepWidth=steps*5;eachStepWidth<=steps*5;eachStepWidth++)
                   {
                       Console.Write("*");
                   }
                   Console.WriteLine();
                }
            }
        }
    }
}