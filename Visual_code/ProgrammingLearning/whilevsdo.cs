using System;
class whilevsdo
{
    static void Main()
    {
        int i=1;
        while(i>1)
        {
            Console.WriteLine("hi,I am coming In");
            i++;
        }

        do
        {
            Console.WriteLine("Hello, I am coming In");
            i++;
        }while(i<10);
    }
}