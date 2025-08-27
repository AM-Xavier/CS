using System;
using System.Globalization;

namespace RadiusExercise
{
    internal class RadiusExercise
    {
        static void Main(string[] args)
        {
            // Calculating the Radius of a circle
            double radius, area;

            Console.WriteLine("Enter the radius of a circule:");

            radius = Double.Parse(Console.ReadLine());
            area = 3.14159 * Math.Pow(radius, 2);

            Console.WriteLine($"The circle's area is: {area}", CultureInfo.InvariantCulture);
        }
    }
}
