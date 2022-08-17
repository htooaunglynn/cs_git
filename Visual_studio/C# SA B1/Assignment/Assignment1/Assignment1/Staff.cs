using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    public class Staff
    {
        private string id;

        public string ID
        {
            get { return id; }
            set 
            { 
                if(string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("invalid stuff id.");
                }
                id = value; 
            }
        }

        private string name;

        public string Name
        {
            get { return name; }
            set 
            { 
                if(string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("invalid stuff name.");
                }
                name = value; 
            }
        }

        private int age;

        public int Age
        {
            get { return age; }
            set 
            { 
                if(value<1 && value>90)
                {
                    throw new ArgumentException("invalid stuff age.");
                }
                age = value; 
            }
        }

        private string address;

        public string Address
        {
            get { return address; }
            set 
            { 
                if(string.IsNullOrEmpty (value))
                {
                    throw new ArgumentException("invalid stuff address.");
                }
                address = value; 
            }
        }

        private double basicPay;

        public double BasicPay
        {
            get { return basicPay; }
            set
            {
                if (value < 1)
                {
                    throw new ArgumentException("invalid stuff basic pay.");
                }
                basicPay = value;
            }
        }

        private double workingDay;

        public double WorkingDay
        {
            get { return workingDay; }
            set
            {
                if (value < 1)
                {
                    throw new ArgumentException("invalid stuff working day.");
                }
                workingDay = value;
            }
        }

        private double attendanceDay;

        public double AttendanceDay
        {
            get { return attendanceDay; }
            set
            {
                if (value < 1)
                {
                    throw new ArgumentException("invalid stuff attendance day.");
                }
                attendanceDay = value;
            }
        }

        private double benefit;

        public double Benefit
        {
            get { return benefit; }
            set
            {
                if (value < 1)
                {
                    throw new ArgumentException("invalid stuff parttime benefit.");
                }
                benefit = value;
            }
        }

        private double deduction;

        public double Deduction
        {
            get { return deduction; }
            set
            {
                if (value < 1)
                {
                    throw new ArgumentException("invalid stuff parttime deduction.");
                }
                deduction = value;
            }
        }

        public virtual void Infomation()
        {

            Console.Write("Name : ");
            Name = Console.ReadLine().ToUpper();

            Console.Write("ID : ");
            ID = Console.ReadLine();

            Console.Write("Age : ");
            Age = int.Parse(Console.ReadLine());

            Console.Write("Address : ");
            Address = Console.ReadLine();

            Console.Write("Basic payment : ");
            BasicPay = Convert.ToDouble(Console.ReadLine());

            Console.Write("Working Day : ");
            WorkingDay = Convert.ToDouble(Console.ReadLine());

            Console.Write("Attendance day : ");
            AttendanceDay = Convert.ToDouble(Console.ReadLine());

            Console.Write("Benefit : ");
            Benefit = Convert.ToDouble(Console.ReadLine());

            Console.Write("Deduction : ");
            Deduction = Convert.ToDouble(Console.ReadLine());
        }

        public void CalculationSalary()
        {
            double salary = ((((BasicPay / WorkingDay) * AttendanceDay) + Benefit) - Deduction);
            Console.WriteLine($"Salary is {salary} MMK");
        }

        public virtual void DisplayData()
        {
            Console.WriteLine("\n============================================");
            Console.WriteLine($"Name is {Name}");
            Console.WriteLine($"ID is {ID}");
            Console.WriteLine($"Age is {Age}");
            Console.WriteLine($"Address is {Address}");
            CalculationSalary();
            Console.WriteLine("============================================");
        }


    }
}
