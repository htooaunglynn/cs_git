using System;
class Assignment1forChapter9
{
    static void Main()
    {
        int intAge;
        Console.Write("Enter your age: ");
        string age=Console.ReadLine();
        intAge=Convert.ToInt16(age);
        if(intAge>=18)
        {
            Console.WriteLine("You can vote in election,");
        }
        else
        {
            Console.WriteLine("You can't voute in election yet");
        }

        Console.Write("Enter your name: ");
        string name=Console.ReadLine();
        Console.WriteLine("Your name is "+name);
        
        int result=CountVowelInString(name);
        Console.WriteLine("Your name vowel count is "+result);
    }


     static int CountVowelInString(string inputdata)
    {
        int cout=0;
        char[] myvalue=inputdata.ToCharArray();
        for(int i=0;i<myvalue.Length;i++)
        {
            switch(myvalue[i])
            {
                case 'a':cout++;break;
                case 'e':cout++;break;
                case 'i':cout++;break;
                case 'o':cout++;break;
                case 'u':cout++;break;
            }
        }
        return cout;
    }
}