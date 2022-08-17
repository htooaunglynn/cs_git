using System;
class aa
{
    static void Main()
    {
        string[,] table=new string[5,2];

        table[0,0]="No";
        table[1,0]="==";
        table[0,1]="Name";
        table[1,1]="===";
        table[2,0]="1";
        table[2,1]="Maung Maung";
        table[3,0]="2";
        table[3,1]="Hla Hla";
        table[4,0]="3";
        table[4,1]="Mg Mg";

          for(int t=0;t<5;t++)
        {
            for(int s=0;s<2;s++)
            {
            Console.Write(table[t,s]+" ");
            }
            Console.WriteLine();
        }   
       
    }
}