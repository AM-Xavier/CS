using System;
using System.Globalization;

namespace NameSalaryOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            Person p2 = new Person();

            double mean;

            Console.WriteLine("First employee data:");
            Console.Write("First name: ");
            p1.Name = Console.ReadLine();
            Console.Write("Salary: ");
            p1.Salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Second employee data:");
            Console.Write("First name: ");
            p2.Name = Console.ReadLine();
            Console.Write("Salary: ");
            p2.Salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            mean = p1.Salary + p2.Salary / 2;

            Console.WriteLine($"Salary mean: {mean:F2}", CultureInfo.InvariantCulture);

        }
    }
}
