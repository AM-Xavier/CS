namespace InOut2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter an amount of numbers to be tested: ");
            int n = int.Parse(Console.ReadLine()),
                countIn = 0,
                countOut= 0;

            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter a number: ");
                int x = int.Parse(Console.ReadLine());

                if (x >= 1 && x <= 15)
                {
                    countIn++;
                }

                else
                {
                    countOut++;
                }

            }

            Console.WriteLine($"{countIn} in");
            Console.WriteLine($"{countOut} out");

        }
    }
}
