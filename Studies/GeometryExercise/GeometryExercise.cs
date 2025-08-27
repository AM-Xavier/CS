using System;
using System.Globalization;

namespace GeometryExercise
{
    internal class GeometryExercise
    {
        static void Main(string[] args)
        {
            Console.WriteLine("In the same line, enter values for A, B and C:");
            string[] geometry = Console.ReadLine().Split(' ');

            double a = double.Parse(geometry[0], CultureInfo.InvariantCulture),
                   b = double.Parse(geometry[1], CultureInfo.InvariantCulture),
                   c = double.Parse(geometry[2], CultureInfo.InvariantCulture),
                   pi = 3.14159;

            double triangle_area = (a * c) / 2,
                   circle_radius = pi * Math.Pow(c, 2),
                   trapezoid_area = ((a + b) * c) / 2,
                   square_area = Math.Pow(b, 2),
                   rectangle_area = a * b;

            Console.WriteLine("Your results are:");
            Console.WriteLine($"Triangle area: {triangle_area:F3}");
            Console.WriteLine($"Circle radius: {circle_radius:F3}");
            Console.WriteLine($"Trapezoid area: {trapezoid_area:F3}");
            Console.WriteLine($"Square area: {square_area:F3}");
            Console.WriteLine($"Rectangle area: {rectangle_area:F3}");
        }
    }
}
