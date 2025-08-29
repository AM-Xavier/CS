using System;
using System.Globalization;

namespace TriangleOOP
{
    internal class TriangleOOP
    {
        static void Main(string[] args)
        {
            Triangle x, y;
            x = new Triangle();
            y = new Triangle();

            Console.WriteLine("Enter measures for Triangle X:");
            x.A = double.Parse(Console.ReadLine());
            x.B = double.Parse(Console.ReadLine());
            x.C = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter measures for Triangle Y:");
            y.A = double.Parse(Console.ReadLine());
            y.B = double.Parse(Console.ReadLine());
            y.C = double.Parse(Console.ReadLine());

            double pX = (x.A + x.B + x.C) / 2,
                   pY = (y.A + y.B + y.C) / 2;

            double areaX = Math.Sqrt(pX * (pX - x.A) * (pX - x.B) * (pX - x.C)),
                   areaY = Math.Sqrt(pY * (pY - y.A) * (pY - y.B) * (pY - y.C));

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
