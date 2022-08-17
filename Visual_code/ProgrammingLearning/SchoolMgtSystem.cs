using System;
using StudentInfo; //import / call StudentInfo namespace
using TeacherInfo; //import /call  TeacherInfo namespace 
using CoourseInfo;

namespace SchoolMgtSystemInfo{
    class SchooolMgtSystem{
        static void Main(){
            Console.WriteLine("Program start");
            Student.ShowInfo(); //Hi,I am a student from StudentInfo Namespace.
            Student.SayHello("Htoo Aung Lynn");
            Teacher.ShowInfo(); //Hi,I am a teacher from TeacherInfo Namespace.
            Coourse.DisplayCourseDetail();
            Console.WriteLine("Program stop");
        } //end of Main
    } //end of class 
} //end namespace 

namespace StudentInfo{
    //define Student class  as Prototype/BluePrint/Template 
    class Student{
        public static void ShowInfo(){
            Console.WriteLine ("Hi,I am a student from StudentInfo Namespace.");
        } //end of ShowInfo method 

        public static void SayHello(string name)
        {
            Console.WriteLine("i am  a student, my name is "+name);
        }
    } //end of class 
} //end of namespace 
//define TeacherInfo as namespace 


namespace TeacherInfo{
    //define Teacher class  as Prototype/BluePrint/Template 
    class Teacher{
        public static void ShowInfo(){
            Console.WriteLine ("Hi,I am a teacher from TeacherInfo Namespace.");
        } //end of show Info Method 
    } //end of class 
} //end of TeacherInfo namespace

namespace CoourseInfo
{
    class Coourse
    {
        public static void DisplayCourseDetail()
        {
            Console.WriteLine("Course Name: C# programming Zero To Hero.");
            Console.WriteLine("Courese Suration: 4Month");
            Console.WriteLine("Instrocutr name: Jonh Smith");
            Console.WriteLine("Course fees:10$");
            Console.WriteLine("Course strat "+DateTime.Now);
        }
    }
}
