using System; //call library or importin namespace
class Assignment3  //declaration class
{
    static void Main() //declaration main method
    { 
        string stringmonth;
        int intmonth;
        Console.Write("Please enter from 1 to 12: ");
        stringmonth=Console.ReadLine();
        intmonth=Convert.ToInt16(stringmonth);

        switch(intmonth)
        {
            case 1:Console.WriteLine("This is January");break;
            case 2:Console.WriteLine("This is February");break;
            case 3:Console.WriteLine("This is March");break;
            case 4:Console.WriteLine("This is Apirl");break;
            case 5:Console.WriteLine("This is May");break;
            case 6:Console.WriteLine("This is June");break;
            case 7:Console.WriteLine("This is July");break;
            case 8:Console.WriteLine("This is August");break;
            case 9:Console.WriteLine("This is September");break;
            case 10:Console.WriteLine("This is October");break;
            case 11:Console.WriteLine("This is November");break;
            case 12:Console.WriteLine("This is December");break;
            default:Console.WriteLine("This is invalid month");break;

        }
    } //end of mani method 
}// end of class