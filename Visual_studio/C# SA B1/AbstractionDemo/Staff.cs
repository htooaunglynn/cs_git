using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionDemo
{
    public class Staff:IShowDetailInfo
    {
        public string StaffID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Department { get; set; }
        public string Position { get; set; }
        public DateTime JoinedDate { get; set; }
        public double BaseSaler { get; set; }

        public void ShowDetailInfo()
        {
            Console.WriteLine($"Staff ID : {StaffID}");
            Console.WriteLine($"Staff Name : {Name}");
            Console.WriteLine($"Staff Email : {Email}");
            Console.WriteLine($"Staff Phone : {Phone}");
            Console.WriteLine($"Staff Position : {Position}");
            Console.WriteLine($"Staff Department : {Department}");
            Console.WriteLine($"Staff Base Salyer : {BaseSaler}");
            Console.WriteLine($"Staff Joined Date : {JoinedDate}");
            //
            Console.WriteLine($"Staff service ");
        }
    }

    
}
