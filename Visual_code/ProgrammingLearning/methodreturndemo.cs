using System;
class methodreturndemo
{
    static void Main()
    {
        Console.Write("Enter a text: ");
        string data=Console.ReadLine();
        int result=CountVowelInString(data);
        Console.WriteLine("vowel cout is "+result);
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