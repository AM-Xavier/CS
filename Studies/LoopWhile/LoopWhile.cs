using System;
using System.Globalization;

namespace LoopWhile
{
    internal class LoopWhile
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Enter a number: ");
                double x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (x >= 0)
                {
                    double sqroot = Math.Sqrt(x);
                    Console.WriteLine($"The root of {x} is {sqroot:F3}");
                    continue;
                }

                else
                {
                    Console.WriteLine("Negative number.");
                    break;
                }
            }
        }
    }
}
