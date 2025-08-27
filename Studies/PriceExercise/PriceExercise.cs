using System;
using System.Globalization;

namespace PriceExercise
{
    internal class PriceExercise
    {
        static void Main(string[] args)
        {
            string[] product1 = Console.ReadLine().Split(' '),
                     product2 = Console.ReadLine().Split(' ');

            int code1 = int.Parse(product1[0]), 
                number_of_items1 = int.Parse(product1[1]),
                code2 = int.Parse(product2[0]),
                number_of_items2 = int.Parse(product2[1]);

            double item_price1 = double.Parse(product1[2], CultureInfo.InvariantCulture),
                item_price2 = double.Parse(product2[2], CultureInfo.InvariantCulture),
                   total = (number_of_items1 * item_price1) + (number_of_items2 * item_price2);

            Console.WriteLine($"Total due: U${total}");
        }
    }
}
