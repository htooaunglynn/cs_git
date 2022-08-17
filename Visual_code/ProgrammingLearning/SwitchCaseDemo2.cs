using System;
class SwitchCaseDemo2
{
    static void Main()
    {
        char vowel='z';
        switch (vowel)
        {
            case 'A':Console.WriteLine("vowel");break;
            case 'E':Console.WriteLine("vowel");break;
            case 'I':Console.WriteLine("vowel");break;
            case 'O':Console.WriteLine("vowel");break;
            case 'U':Console.WriteLine("vowel");break;
            default:Console.WriteLine(vowel+" is not vowel");break;
        }
    }
}