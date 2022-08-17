using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionDemo
{
    internal interface ITaxService
    {
        double CalculateIncomeTax(int yearlyIncomeAmount);
        double CalculateComsumerTax(int totalAmount);
    }
}
