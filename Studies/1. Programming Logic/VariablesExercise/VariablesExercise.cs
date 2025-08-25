using System;

namespace VariablesExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string product1 = "Computer";
            string product2 = "Office table";

            byte age = 30;
            int code = 5290;
            char gender = 'M';

            double price1 = 2100.00;
            double price2 = 650.50;
            double measurement = 53.234567;

            Console.WriteLine("Products:");
            Console.WriteLine($"{product1}, wich price is ${price1}");
            Console.WriteLine($"{product2}, wich price is ${price2}");
            Console.WriteLine();

            Console.WriteLine($"Record: {age} years old, code {code} and gender: {gender}");
            Console.WriteLine();

            Console.WriteLine($"Measurement with eight decimal places: {measurement:F8}");
            Console.WriteLine($"Rouded (three decimal places): {measurement:F3}");
            Console.WriteLine($"US decimal point: {measurement.ToString("F3", System.Globalization.CultureInfo.InvariantCulture)}");
        }
    }
}