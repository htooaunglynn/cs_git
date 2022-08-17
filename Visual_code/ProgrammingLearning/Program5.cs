using System;
class Program5
{
    static void Main()
    {
        int steps,stepHeight,eachStepWidth;

        for(steps=1;steps<=5;steps++)
        {
            for(stepHeight=1;stepHeight<=5;stepHeight++)
            {
                if(stepHeight==1)
                {
                   for(eachStepWidth=1;eachStepWidth<=steps*5;eachStepWidth++)
                   {
                       Console.Write("*");
                   }
                   Console.WriteLine();
                }

                else if(stepHeight==2)
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

                 else if(stepHeight==3)
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

                 else if(stepHeight==4)
                {
                   for(eachStepWidth=1;eachStepWidth<=steps*5;eachStepWidth++)
                   {
                       Console.Write("*");
                   }
                   Console.WriteLine();
                
                }
            }
        }
    }
 }

