using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DolarQuotation
{
    internal class CurrencyConversion
    {
        public static double Iof = 6.0;

        public static double Conversion(double quotation, double amount)
        {
            double total = quotation * amount;
            return total + total * (Iof/100);
        }
    }
}
