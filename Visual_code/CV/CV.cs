using System;
class CV
{
    static void Main()
    {
     Receive();
    }
    static void Receive()
    {
        Console.Write("How many value you input?  ");

        int inputNumberLength=int.Parse(Console.ReadLine());

        int[] valueArray=new int[inputNumberLength];

        for(int i=0;i<valueArray.Length;i++)
        {
            Console.Write("Enter {0} number is: ",i+1);
            valueArray[i]=int.Parse(Console.ReadLine());
        }  

        Console.Write("Input number are : ");

        for(int j=0;j<valueArray.Length;j++)
        {
            if(j<valueArray.Length-1)
            {
                Console.Write(valueArray[j]+",");
            }
            else
            {
                Console.Write(valueArray[j]);
            }
        }

        Console.WriteLine();

        int total=0;

        for(int s=0;s<valueArray.Length;s++)
        {
            total+=valueArray[s];
        }

        Console.WriteLine("Total number is {0}",total);

        int Maximum=valueArray[0];

        for(int m=1;m<valueArray.Length;m++)
        {
            if(Maximum<valueArray[m])
            {
                Maximum=valueArray[m];
            }
        }    
        Console.WriteLine("Maximum is {0}",Maximum);
        
    }
    
    
}