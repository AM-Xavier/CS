using System;
using System.Globalization;

namespace SequencialStructureExercise
{
    internal class SumExercise
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
        }
    }
}
