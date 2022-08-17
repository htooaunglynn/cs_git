using System;

class Program4
{
    static void Main()
    {
        try
        {
            StudentList();
        }

        catch(Exception e)
        {
            Console.WriteLine("You input is something wrong.");
        }
    } // end of main method 

    static void StudentList()
    {
        Console.Write("How many rows : ");
        int rows=int.Parse(Console.ReadLine());

        Console.Write("How many colums : ");
        int colums=int.Parse(Console.ReadLine());

        string[,] table=new string[rows,colums];

        for(int i=0;i<rows;i++)
        {
            for(int j=0;j<colums;j++)
            {
                Console.Write("Room {0},{1} is ",i+1,j+1);
                table[i,j]=Console.ReadLine();
            }
        }

        for(int d=0;d<rows;d++)
        {
            for(int s=0;s<colums;s++)
            {
                Console.Write(table[d,s]+" ");
            }
            Console.WriteLine();
        }
    }
}