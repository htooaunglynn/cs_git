using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AlertDialogWindow dialog = new AlertDialogWindow()
            { Height =200,
              Width = 200,
              Title = "alert",
            };
            dialog.Open();
            dialog.DisplayInfo();
            dialog.Close();

            WarningDialogWindow warningDialog = new WarningDialogWindow()
            {
                Height = 250,
                Width = 250,
                Title = "warning",
            };
            warningDialog.Open();
            warningDialog.DisplayInfo();
            warningDialog.Close();

            Staff staff1 = new Staff()
            {
                Name = "U Bla Bla",
                StaffID = "939Usia3993",
                Department = "Admi Dept",
                JoinedDate = Convert.ToDateTime("12-11-2018"),
                BaseSaler=20000,
                Email="aidnf@gmail.com",
                Phone="29482928",
                Position="Administraction",
            };
            staff1.ShowDetailInfo();

            PayrollService payrollService = new PayrollService();
            payrollService.CalculatePayroll(staff1);
            payrollService.CalculateBonus(staff1);
            

            BackAccount b1 = new BackAccount()
            {
                Balance =2000,
                AccountHolderName =staff1.Name,
                AccountNo ="28300UIMk3920",
                BackAccoundType="Current",
                ManufactureDate=Convert.ToDateTime("10-2-2019"),
                IsValid=true,
            };
            b1.GetDollorExchangeRate(300);
            b1.ShowDetailInfo();

           double result = b1.Balance + payrollService.CalculatePayroll(staff1);

            Console.WriteLine($"Your balance after payroll : {result} ");
    
            

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
