using System;
using System.Globalization;

namespace TriangleNonOOP
{
    internal class TriangleNonOOP
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter measures from triangle X:");

            double xA = double.Parse(Console.ReadLine()),
                   xB = double.Parse(Console.ReadLine()),
                   xC = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter measures from triangle Y:");

            double yA = double.Parse(Console.ReadLine()),
                   yB = double.Parse(Console.ReadLine()),
                   yC = double.Parse(Console.ReadLine());

            double pX = (xA + xB + xC) / 2,
                   pY = (yA + yB + yC) / 2;

            double areaX = Math.Sqrt(pX * (pX - xA) * (pX - xB) * (pX - xC)),
                   areaY = Math.Sqrt(yA * (pY - yA) * (pY - yB) * (pY - yC));

            Console.WriteLine($" X Area = {areaX.ToString("F4", CultureInfo.InvariantCulture)}");
            Console.WriteLine($" Y Area = {areaY.ToString("F4", CultureInfo.InvariantCulture)}");

            if (areaX > areaY)
            {
                Console.WriteLine("The biggest area is: X");
            }

            else
            {
                Console.WriteLine("The biggest area is: Y");
            }

        }
    }
}
