using System.Globalization;
using static System.FormattableString;

namespace StaticMembers1
{
    internal class Program
    {

        static double Pi = 3.14;

        static void Main(string[] args)
        {
            Console.Write("Enter circle's radius: ");
            double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double circunference = Circunference(radius);
            double volume = Volume(radius);
            double pi = Pi;

            Console.WriteLine(Invariant($"Circunference = {circunference:F2}"));
            Console.WriteLine(Invariant($"Circunference = {volume:F2}"));
            Console.WriteLine(Invariant($"Circunference = {pi:F2}"));
        }

        static double Circunference(double r)
        {
            return 2.0 * Pi * r;
        }

        static double Volume(double r)
        {
            return 4.0 / 3.0 * Pi * Math.Pow(r, 3);
        }
    }
}
