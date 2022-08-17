using System;
class gotodemo
{
    static void Main()
    {
        int num=20;
        switch(num)
        {
            case 5:Console.WriteLine("This is case 5");break;
            case 10:Console.WriteLine("This is case 10");break;
            case 20:goto case 5;
            default:Console.WriteLine("invalid vale");break;
        }
    }
}