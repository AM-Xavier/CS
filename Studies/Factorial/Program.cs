using System.Drawing;
using System.Runtime.ConstrainedExecution;

namespace Factorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ler um valor N. Calcular e escrever seu respectivo fatorial. Fatorial de N = N * (N - 1) * (N - 2) * (N - 3) * ... *1.
            // Lembrando que, por definição, fatorial de 0 é 1.

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
