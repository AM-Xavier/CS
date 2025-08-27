namespace DifferenceExercise
{
    internal class DifferenceExercise
    {
        static void Main(string[] args)
        {

            int a = int.Parse(Console.ReadLine()),
                b = int.Parse(Console.ReadLine()),
                c = int.Parse(Console.ReadLine()),
                d = int.Parse(Console.ReadLine()),
                difference = (a * b) - (c * d);

            Console.WriteLine(difference);

        }
    }
}
