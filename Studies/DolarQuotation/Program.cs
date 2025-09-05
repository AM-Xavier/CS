using System.Globalization;
using static System.FormattableString;

namespace DolarQuotation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double quotation, amount;
            
            Console.Write("What is the current dolar quotation in Reais? ");
            quotation = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("How many dolar are you going to buy? ");
            amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine(Invariant($"Amount to pay in Reais = {CurrencyConversion.Conversion(quotation, amount):F2}"));
        }
    }
}
