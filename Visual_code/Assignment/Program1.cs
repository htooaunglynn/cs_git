using System; //call library 

class Program1 //declare class
{
    static void Main() //main method 
    {
        inputIsWrongHere:  // input wrong program return here

        try 
        {
            GuessGame();
        
        }//end of try

        catch(Exception e)
        {
            Console.WriteLine("You input is something wrong");
            goto inputIsWrongHere;
        }//end of catch

    } //end of main method 

    static void GuessGame()
    {
        Console.WriteLine("Guess game from 0 to 20 Start!!!)"); 

        Random radomObj=new Random();

        Console.Write("Guess my number  : ");
        int inputValue=int.Parse(Console.ReadLine());

        int hiddenValue=radomObj.Next(20);    

        bool again=true;

        int count=0; // input count

        while(again)
        {
            if(inputValue>20) // input number greter than 20
            {
                count++;
                
                Console.WriteLine("Read the game info idiot, guess the number between 0 to 20.");

                Console.Write("Guess my number  : ");
                inputValue=int.Parse(Console.ReadLine());
            }

            else if(inputValue==hiddenValue) // input number and hide number are same
            {
                count++;

                Console.Write("Wow!!! you got it right at ");

                switch(count)
                {
                    case 1:Console.WriteLine("{0}st time",count);break;
                    case 2:Console.WriteLine("{0}nd time",count);break;
                    case 3:Console.WriteLine("{0}rd time",count);break;
                    default:Console.WriteLine("{0}th time",count);break;
                }

                again=false;
            }

            else if(inputValue==hiddenValue+2 || inputValue==hiddenValue-2 || inputValue==hiddenValue+1 || inputValue==hiddenValue-1) //for close
            {
                count++;

                Console.WriteLine("No!!! You got it wrong!!! Your number is too close to my number.");

                Console.Write("Guess my number  : ");
                inputValue=int.Parse(Console.ReadLine());
            }

            else // for far
            {
                count++;

                Console.WriteLine("No!!! You got it wrong!!! Your number is too far to my number.");

                Console.Write("Guess my number  : ");
                inputValue=int.Parse(Console.ReadLine());
            }
        }
    }

} //end of class