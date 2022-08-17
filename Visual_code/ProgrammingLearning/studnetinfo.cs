using System;
class studnetinfo
{
    static void Main()
    {
        string[] studentArray=new string[11];
        for(int i=0;i<11;i++)
        {
            Console.Write("Enter Student Name: ");
            studentArray[i]=Console.ReadLine();
        }
        Console.WriteLine("Studnet information Here");
        for(int i=0;i<11;i++)
        {
            if(i==studentArray.Length-1)
            {
              Console.Write(studentArray[i]);
            }
            else
            {
                Console.Write(studentArray[i]+",");
            }
            
        }
    }
}