namespace ComparisonOperators
{
    internal class ComparisonOperators
    {
        static void Main(string[] args)
        {
            int a = 10,
                b = 15,
                c = 20,
                d = 25;

            bool c1 = a < 10,
                 c2 = b > 10,
                 c3 = c == 10,
                 c4 = d >= 10,
                 c5 = d <= 10,
                 c6 = a != 1;

            Console.WriteLine(c1);
            Console.WriteLine(c2);
            Console.WriteLine(c3);
            Console.WriteLine(c4);
            Console.WriteLine(c5);
            Console.WriteLine(c6);
        }
    }
}
