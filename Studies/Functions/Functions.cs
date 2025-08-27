namespace Functions
{
    internal class Functions
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter three integers:");

            int n1 = int.Parse(Console.ReadLine()),
                n2 = int.Parse(Console.ReadLine()),
                n3 = int.Parse(Console.ReadLine());

            double result = Biggest(n1, n2, n3);

            Console.WriteLine($"The biggest number is: {result}");
        }

        static int Biggest(int a, int b, int c)
        {
            int big;

            if (a > b && a > c)
            {
                big = a;
            }

            else if (b > c)
            {
                big = b;
            }

            else
            {
                big = c;
            }

            return big;
        }
    }
}
