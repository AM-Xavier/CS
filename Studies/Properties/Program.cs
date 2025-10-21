using System.Globalization;

namespace Properties
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Product p = new Product("RTX 5070 TI", 5500.00, 12);

            p.Name = "RTX 4080 TI";

            Console.WriteLine(p.Name);
        }
    }
}
