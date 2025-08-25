using System;
using System.Globalization;

namespace DataEntry
{
    class DataEntryNumber
    {
        static void Main(string[] args)
        {
            // Data entry with non string types
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("You typed: " + n1);

            char ch = char.Parse(Console.ReadLine());
            Console.WriteLine("You typed: " + ch);

            double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("You typed: " + n2);

            // Splitting with multiple data types
            string[] vet = Console.ReadLine().Split(' ');
            string name = vet[0];
            char gender = char.Parse(vet[1]);
            int age = int.Parse(vet[2]);
            double height = double.Parse(vet[3], CultureInfo.InvariantCulture);

            Console.WriteLine("You typed: " + name);
            Console.WriteLine("You typed " + gender);
            Console.WriteLine("You typed " + age);
            Console.WriteLine("You typed " + height.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}