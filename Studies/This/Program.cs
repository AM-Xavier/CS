using System.Globalization;

namespace This {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Enter product info:");
            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Price: ");
            double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Product p = new Product(name, price);

            Console.WriteLine();
            Console.WriteLine("Product info: " + p);
            Console.WriteLine();

            Console.Write("Enter amount of products to be added to storage: ");
            int amt = int.Parse(Console.ReadLine());
            p.AddProducts(amt);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);
            Console.WriteLine();

            Console.Write("Enter amount of products to be removed from storaged: ");
            amt = int.Parse(Console.ReadLine());
            p.RemoveProducts(amt);

            Console.WriteLine();
            Console.WriteLine("Updated info: " + p);

        }
    }
}
