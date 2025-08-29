using System.Drawing;
using System.Runtime.ConstrainedExecution;

namespace Factorial
{
    internal class Factorial
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int n = int.Parse(Console.ReadLine()),
                factorial = 1;
                

            for (int i = 1; i <= n; i++)
            {

                if (n > 0)
                {
                    factorial *= i;
                }

                else
                {
                    factorial = 1;
                }
                
                Console.WriteLine(factorial);
            }


        }
    }
}
