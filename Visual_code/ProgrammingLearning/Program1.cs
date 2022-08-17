using System; //call library or Importing namespace
class Program1 //declaration class
{
    static void Main() //declaration main method
    {
        for(int row=1;row<=5;row++) // int variable declaration , assign value and using for loop
        {
            for(int col=1;col<=row;col++) // int variable declaration , assign value and using for loop
            {
                Console.Write(col);
            } // second for loop end 
            Console.WriteLine();
        } //first for loop end 

    } // end of main method
} //end of class