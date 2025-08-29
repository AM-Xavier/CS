using System;
using System.Globalization;

namespace TestCase
{
    internal class TestCase
    {
        static void Main(string[] args)
        {
            //Leia 1 valor inteiro N, que representa o número de casos de teste que vem a seguir. Cada caso de teste consiste
            //de 3 valores reais, cada um deles com uma casa decimal.Apresente a média ponderada para cada um destes
            //conjuntos de 3 valores, sendo que o primeiro valor tem peso 2, o segundo valor tem peso 3 e o terceiro valor tem
            //peso 5.

            Console.Write("Enter how many tests will be performed: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write("In the same line, enter the 3 tests: ");
                string[] test = Console.ReadLine().Split(' ');

                double x = double.Parse(test[0], CultureInfo.InvariantCulture),
                       y = double.Parse(test[1], CultureInfo.InvariantCulture),
                       z = double.Parse(test[2], CultureInfo.InvariantCulture);

                double result = (x * 2.0 + y + 3.0 + z * 5.0) / 10;

                Console.WriteLine(result.ToString("F1", CultureInfo.InvariantCulture));

            }


        }
    }
}
