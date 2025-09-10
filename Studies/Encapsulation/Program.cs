using System.Globalization;

namespace Encapsulation {
    internal class Program {
        static void Main(string[] args) {

            Product p = new Product("RTX 5070 TI", 5500.00, 12);

            Console.WriteLine(p.GetName());
            Console.WriteLine(p.GetPrice());
        }
    }
}
