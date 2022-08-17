using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionDemo
{
    public interface ICreditCardService
    {
        void GetRupessExchangeRate(double baseAmount);
        void GetDollorExchangeRate(double baseAmount);
        void GetPoundsExchangeRate(double baseAmount);
        void GetSGDollorExchangeRate(double baseAmount);
    }
}
