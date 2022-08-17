using System;
class Program
{
    static void Main()
    {
        Console.Write("Enter number of values are ");
        int lengtharray=Convert.ToInt32(Console.ReadLine());
        int[] value=new int[lengtharray];

        for(int i=0;i<value.Length;i++)
        {
            Console.Write("Enter value {0} is ",i+1);
            value[i]=Convert.ToInt32(Console.ReadLine());
        }

        Console.Write("You entered values are ");
        for(int j=0;j<value.Length;j++)
        {
            if(j==value.Length-1)
            {
                Console.Write(value[j]);
            }
            else
            {
                Console.Write(value[j]+",");
            }
        }
        Console.WriteLine();

        int Maximum=value[0],Minimum=value[0],Total=value[0];
        for(int b=1;b<value.Length;b++)
        {
            if(value[b]>Maximum)
            {
                Maximum=value[b];
            }
            else if(value[b]<Minimum)
            {
                Minimum=value[b];
            }

                Total+=value[b];
        }
        Console.WriteLine("Maximum value is "+Maximum);
        Console.WriteLine("Minimum value is "+Minimum);
        Console.WriteLine("Total value is "+Total);

        /*double Average=Convert.ToDouble(Total/lengtharray);*/
        double dTotal=Convert.ToDouble(Total);
        double dlengtharray=Convert.ToDouble(lengtharray);
        double Average=dTotal/dlengtharray;
        Console.WriteLine("Average is "+Average);
    }
}