using System; //call library or Importing namespace
class CurriculumVitae //class declaration
{
    static void Main() //Main Method declaration
    { 

      Console.WriteLine("Please,answer following question");

      //Name for you
     /* string name;
      Console.Write("Enter your name.  ");
      name=Console.ReadLine();*/
      
      //Age for you
     /* string age;
      int intage;
      Console.Write("Enter your age.  ");
      age=Console.ReadLine();
      intage=Convert.ToInt16(age);*/

      //Sex you
     /* string sex;
      Console.Write("Enter sex. eg.(Male/Female) ");
      sex=Console.ReadLine();*/

      //Phone Number
      /*string phoneno;
      long intPhoneNo;
      Console.Write("Enter your phone number.  ");
      phoneno=Console.ReadLine();
      intPhoneNo=Convert.ToInt64(phoneno); */

      //name for father
     /* string fatherName;
      Console.Write("Enter your father name. ");
      fatherName=Console.ReadLine(); */

      //age for father
     /* string fatherAge;
      int intFatherAge;
      Console.Write("Enter your father age. ");
      fatherAge=Console.ReadLine();
      intFatherAge=Convert.ToInt16(fatherAge); */

      //name for mother
     /* string motherName;
      Console.Write("Enter your mother name. ");
      motherName=Console.ReadLine(); */

      //age for mother
     /* string motherAge;
      int intMotherAge;
      Console.Write("Enter your mother age. ");
      motherAge=Console.ReadLine();
      intMotherAge=Convert.ToInt16(motherAge); */

      //choose question
      char no='n';
      string answer;
      do
      {
      Console.WriteLine("Do you have any brother or sister? (y/n) y for yes and n for no");
      answer=Console.ReadLine();
      
      }while(answer!=no);

      
      //output for you
    /*  Console.WriteLine("\nYour Biography is following");
      Console.WriteLine("Name - "+name);
      Console.WriteLine("Age - "+age);
      Console.WriteLine("Sex - "+sex);
      Console.WriteLine("Your phone no - "+phoneno);
      
      //output for father
      Console.WriteLine("Your father name - "+fatherName);
      Console.WriteLine("Your father age is - "+intFatherAge);

      //output for mother
      Console.WriteLine("Your monter name - "+motherName);
      Console.WriteLine("Your mother age - "+intMotherAge); */

      //end of program
      Console.WriteLine("Press any key to exit.");
      Console.ReadKey(); 
    } //end of Main Method
}// end of class