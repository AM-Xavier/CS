using System;
using System.Globalization;
using static System.FormattableString;

namespace RectangleOOP
{
    internal class RectangleOOP
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle();

            Console.WriteLine("Enter rectangle's lenght and width:");
            r.Lenght = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            r.Width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine(Invariant($"Area = {r.Area():F2}"));
            Console.WriteLine(Invariant($"Perimeter = {r.Perimeter():F2}"));
            Console.WriteLine(Invariant($"Diagonal = {r.Diagonal():F2}"));

        }
    }
}
