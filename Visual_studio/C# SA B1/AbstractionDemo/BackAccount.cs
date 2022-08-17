using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionDemo
{
    public class BackAccount : ICreditCardService,IShowDetailInfo
    {
        public string AccountHolderName { get; set; }
        public string AccountNo { get; set; }
        public string BackAccoundType { get; set; }
        public int Balance { get; set; }
        public DateTime ManufactureDate { get; set; }
        public bool IsValid { get; set; }

        public void GetDollorExchangeRate(double baseAmount)
        {
            double result = baseAmount * 1930;
            Console.WriteLine($"Dollor {baseAmount} is equal to {result} MMK");
        }

        public void GetPoundsExchangeRate(double baseAmount)
        {
            double result = baseAmount * 2380;
            Console.WriteLine($"Pound {baseAmount} is equal to {result} MMK");
        }

        public void GetRupessExchangeRate(double baseAmount)
        {
            double result = baseAmount * 23;
            Console.WriteLine($"Rupess {baseAmount} is equal to {result} MMK");
        }

        public void GetSGDollorExchangeRate(double baseAmount)
        {
            double result = baseAmount * 1300;
            Console.WriteLine($"SG Dollor {baseAmount} is equal to {result} MMK");
        }

        public void ShowDetailInfo()
        {
            Console.WriteLine($"Bank Account Type {BackAccoundType}");
            Console.WriteLine($"Bank Account No {AccountNo}");
            Console.WriteLine($"Bank Account Balance {Balance} MMK ");
            Console.WriteLine($"Bank Account Issued Date {ManufactureDate}");
            Console.WriteLine($"Bank Account Holder Name {AccountHolderName}");
            Console.WriteLine($"Bank Account Card is still Valid {IsValid}");
        }
    }
}
