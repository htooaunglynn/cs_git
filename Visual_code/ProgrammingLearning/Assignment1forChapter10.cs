using System;
class Assignment1forChapter10
{
    static void Main()
    {
        int s;
        Console.Write("Enter number of value: ");
        string sstring=Console.ReadLine();
        s=Convert.ToInt32(sstring);
        int[] value=new int[s];
        string[] valuestring=new string[s];
        for(int i=0;i<value.Length;i++)
        
        {
            Console.Write("Enter value {0} is ",i+1 );
            valuestring[i]=Console.ReadLine();
            value[i]=Convert.ToInt32(valuestring[i]);
            
        }
        Console.Write("You enter values are ");
        for(int j=0;j<value.Length;j++)
        {
            if(j==value.Length-1){
            Console.Write(value[j]);}
            else
            {
                Console.Write(value[j]+",");
            }
        }
        Console.WriteLine();
        int max=value[0];
        for(int d=0;d<value.Length;d++)
        {
            if(value[d]>max)
            {
                max=value[d];
            }
        }
         Console.WriteLine("Maximum is "+max);

         int min=value[0];
         for(int t=0;t<value.Length;t++)
        {
            if(value[t]<min)
            {
                min=value[t];
            }
        }
        Console.WriteLine("Minimum is  "+min);

        int total=value[0];
        for(int e=1;e<value.Length;e++)
        {
            total+=value[e];
        }
        Console.WriteLine("totol is "+total);
        double dtotal=Convert.ToDouble(total);
        double ds=Convert.ToDouble(s);
        double average=dtotal/ds;
        Console.WriteLine("Average is "+average);
    }    
}