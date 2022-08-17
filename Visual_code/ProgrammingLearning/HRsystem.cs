using System;
using StaffInfo;
using DepartmentInfo;
using AttendanceInfo;
namespace HR
{
    class HRsystem
    {
        public static void Main()
        {
            Console.WriteLine("HR system");
            Staff s1=new Staff();
            s1.Id="s)))1";
            Console.WriteLine("staff id {0}",s1.Id);
        }
    }
}

namespace StaffInfo
{
    public class Staff
    {
        
        
      private string id,name,email,phone;
      private int age;
      private DateTime joinedDate;

      public string Id
      {
          get{return id;}
          set
          {
              if(string.IsNullOrEmpty(value))
              {
                  throw new ArgumentException("ivalid staff id.");
              }
              id=value;
         }
      }

      public string Name
      {
          get{return name;}
          set
          {
              if(string.IsNullOrEmpty(value))
              {
                  throw new ArgumentException("ivalid staff id.");
              }
              name=value;}
      }



    }
}

namespace DepartmentInfo
{
    public class Department
    {
       private string id,name,reportTo;
    }
}

namespace AttendanceInfo
{
    public class Attendance
    {
       private DateTime arrivialTime,departureTime;
    }
}