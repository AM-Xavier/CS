using System;
using System.Globalization;

namespace SequencialStructureExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Sum
            int a, b, sum;

            Console.WriteLine("Enter a:");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter b:");
            b = int.Parse(Console.ReadLine());

            sum = a + b;
            Console.WriteLine($"Your result is: {sum}");

            // Radius of a circle
            double radius, area;
            
            Console.WriteLine("Enter the radius of a circule:");
            
            radius = Double.Parse(Console.ReadLine());
            area = 3.14159 * Math.Pow(radius, 2);
            
            Console.WriteLine($"The circle's area is: {area}", CultureInfo.InvariantCulture);
        }
    }
}
