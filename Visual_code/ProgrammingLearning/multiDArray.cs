using System;
class multiDArray
{
    static void Main()
    {
        int[,] examMarkArray=new int[3,5];
        examMarkArray[0,0]=5;
        examMarkArray[1,2]=10;
        examMarkArray[2,1]=22;

        for(int i=0;i<3;i++)
        {
            for(int j=0;j<5;j++)
            {
                Console.Write(examMarkArray[i,j]);
            }
            Console.WriteLine();
        }
    }
}