using System.Runtime.Intrinsics.X86;

namespace InOut
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter a number: ");
            int n = int.Parse(Console.ReadLine()),
                count_in = 0,
                count_out = 0;

            for (int i = 0; i < n; i++)
            {

                int x = int.Parse(Console.ReadLine());

                if (x >= 10 && x <= 20)
                {
                    count_in++;
                }

                else
                {
                    count_out++;
                }
            }
            
            Console.WriteLine($"{count_in} in");
            Console.WriteLine($"{count_out} out");

        }
    }
}
