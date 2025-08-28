using System;
using System.Globalization;
using System.Runtime.ConstrainedExecution;

namespace Division
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Fazer um programa para ler um número N. Depois leia N pares de números e mostre a divisão do primeiro pelo
            // segundo. Se o denominador for igual a zero, mostrar a mensagem "divisao impossivel".

            Console.Write("Enter the number of divisions you want to do: ");
            int div = int.Parse(Console.ReadLine());

            for (int i = 0; i < div; i++)
            {
                Console.Write("Enter two numbers: ");
                string[] numbers = Console.ReadLine().Split(' ');
                
                double x = double.Parse(numbers[0]),
                    y = double.Parse(numbers[1]),
                    result = x / y;

                if (y <= 0 || x <= 0)
                {
                    Console.WriteLine("Impossible division.");
                }

                else
                {
                    Console.WriteLine($"The result is {result.ToString("F1", CultureInfo.InvariantCulture)}");
                }

            }
        }
    }
}
