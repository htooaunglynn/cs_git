using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
                 
namespace AbstractionDemo
{
    internal class PayrollService : IPayrollService
    {
        public void CalculateBonus(Staff staff)
        {
            Console.WriteLine($"Bonus amount of this month is 30000");
        }

        public double CalculatePayroll(Staff staff)
        {
            int workingDay = 31;
            int attendanceDay = 20;
            double totalAmont = (staff.BaseSaler / workingDay) * attendanceDay;
            Console.WriteLine($"Total pay amount of this month is                    {totalAmont}");
            return totalAmont;
        }
    }
}
