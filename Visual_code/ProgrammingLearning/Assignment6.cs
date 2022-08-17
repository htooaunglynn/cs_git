using System; //call library

class Assignment6
{ //start class block
    static void Main()
    { //start Main Method block
        char t='\t',n='\n';  //declaration char variable and assign statment
        string c="C# is"; //declaration string variable and assign statment
        string l1="a strongly typed object-oriented programming language.";
        string l2="open source, simple, modern, flexible, and versatile.";
        string l3="a programming language developed and launched by Microsoft in 2012.";
        string l4 ="a simple, modern, and object-oriented language that provides modern day developers\nflexibility and features to build software that will not only work today but will be applicable for years\nin the future.";

        Console.WriteLine(c+t+l1+n+c+t+l2+n+c+t+l3+n+c+t+l4);
        Console.WriteLine("The length of string is "+(c+t+l1+c+t+l2+c+t+l3+c+t+l4).Length);
        Console.WriteLine((c+t+l1+n+c+t+l2+n+c+t+l3+n+c+t+l4).ToUpper());
        string con1="C#",con2="$",con3="Programming";
        Console.WriteLine("C# text in string is "+(c+t+l1+c+t+l2+c+t+l3+c+t+l4).Contains(con1));
        Console.WriteLine("$ text in string is "+(c+t+l1+c+t+l2+c+t+l3+c+t+l4).Contains(con2));
        Console.WriteLine("Programming text in string is "+(c+t+l1+c+t+l2+c+t+l3+c+t+l4).Contains(con3));
        Console.ReadKey();
    } //end of Main Method block
} //end class block
