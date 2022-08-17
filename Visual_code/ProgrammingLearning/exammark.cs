using System;
class exammark
{
    static void Main()
    {
        int[,] markArray=new int[4,6];
        string[] studentArray=new string[4];
        
            for(int j=0;j<studentArray.Length;j++)
            {
                Console.Write("Please Student :"+(j+1)+" Name: ");
                studentArray[j]=Console.ReadLine();
            }
        
        
        for(int i=0;i<markArray.GetLength(0);i++)
        {
            Console.Write("Please Enter Mark of "+studentArray[i]+":");
            for(int j=0;j<markArray.GetLength(1);j++)
            {
                Console.Write("\nPlease enter mark of subject "+(j+1)+":");
               markArray[i,j]=int.Parse(Console.ReadLine());
            }  

        }

        Console.WriteLine("Exam Mark");
        Console.WriteLine("==============");
        for(int i=0;i<markArray.GetLength(0);i++)
        {
            Console.Write(studentArray[i]+" :");
            for(int j=0;j<markArray.GetLength(1);j++)
            {
                Console.Write(markArray[i,j]+" ");
            }
            Console.WriteLine("\n====================");
        }

    }
}