namespace StorageOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product p = new Product();

            Console.WriteLine("Enter product info: ");
            Console.Write("Name: ");
            p.Name = Console.ReadLine();
            Console.Write("Price: ");
            p.Price = double.Parse(Console.ReadLine());
            Console.Write("Quantity in storage: ");
            p.Quantity = int.Parse(Console.ReadLine());

            Console.WriteLine($"Product info: {p}");

            Console.Write("Enter number of products to be added to storage: ");
            int quant = int.Parse(Console.ReadLine());
            p.AddProduct(quant);
            Console.WriteLine($"Updated info: {p}");

            Console.Write("Enter number of products to be removed from storage: ");
            quant = int.Parse(Console.ReadLine());
            p.RemoveProduct(quant);
            Console.WriteLine($"Updated info: {p}");

        }
    }
}
