using System; //call library

class Program3 //declare class 
{
    static void Main() //declare main method
    {
        inputIsWrongHere:

        try
        {
            Some();

        }//end of try

        catch(Exception e)
        {
            Console.WriteLine("Your input is something wrong.");
            goto inputIsWrongHere;
        }//end of catch

    }//end of main method

    static void Some()
    {
        Console.Write("How many number : "); // array length request
            int numberCount=int.Parse(Console.ReadLine()); // array length accept

            int[] value=new int[numberCount]; //declare int array and assign 
            
            for(int i=0;i<numberCount;i++) // value request in array
            {

                switch(i)
                {
                    case 0:Console.Write("Enter 1st number value : ");break;
                    case 1:Console.Write("Enter 2nd number value : ");break;
                    case 2:Console.Write("Enter 3rd number value : ");break;
                    default:Console.Write("Enter {0}th number value : ",i+1);break;
                }

                value[i]=int.Parse(Console.ReadLine());

            }// end of for loop "int i"

            Console.Write("Your entered values are : "); 

            for(int j=0;j<numberCount;j++)  // this for loop for array output
            {
                if(j+1<numberCount) 
                {
                    Console.Write(value[j]+",");
                }

                else
                {
                    Console.Write(value[j]);
                }
            }//end of for loop "int j"

            double maximum=value[0],minimum=value[0],total=0;
            for(int s=0;s<numberCount;s++)
            {
                if(value[s]>maximum)
                {
                    maximum=value[s];
                }

                if(value[s]<minimum)
                {
                    minimum=value[s];
                }

                total+=value[s];
            }

            Console.WriteLine("\nMaximum value    : "+maximum);
            Console.WriteLine("Minimum value    : "+minimum);
            Console.WriteLine("Total value      : "+total);

            double average=total/numberCount;
            Console.WriteLine("Average value    : "+average);
    }
    
}//end of class