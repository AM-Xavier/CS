using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArithmeticOperators
{
    internal class ArithmeticOperators
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 5;

            // Addition
            int sum = a + b;
            Console.WriteLine($"Sum: {sum}"); // Output: Sum: 15

            // Subtraction
            int difference = a - b;
            Console.WriteLine($"Difference: {difference}"); // Output: Difference: 5

            // Multiplication
            int product = a * b;
            Console.WriteLine($"Product: {product}"); // Output: Product: 50

            // Division
            double quotient = (double)a / b; // Cast to double for decimal result
            Console.WriteLine($"Quotient: {quotient}"); // Output: Quotient: 2.0

            // Modulus (Remainder)
            int remainder = a % b;
            Console.WriteLine($"Remainder: {remainder}"); // Output: Remainder: 0

            // Expressions
            int x = 3 + 4 * 2; // Multiplication has higher precedence than addition
            Console.WriteLine(x); // Output: 11
            int y = (3 + 4) * 2; // Parentheses change the order of operations
            Console.WriteLine(y); // Output: 14

            double z = 10 / 8;
            Console.WriteLine(z); // Output: 1, because both 10 and 8 are integers, the division is performed as integer division.

            double w = 10.0 / 8.0; // Using a double to get a decimal result
            Console.WriteLine(w); // Output: 1.25, because both 10.0 and 8.0 are doubles, the division is performed as floating-point division.

            double a1 = 1.0, b1 = -3.0 , c1 = -4.0;

            double delta = Math.Pow(b1, 2.0) - 4.0 * a1 * c1; 

            double x1 = (-b1 + Math.Sqrt(delta)) / (2.0 * a1);
            double x2 = (-b1 - Math.Sqrt(delta)) / (2.0 * a1); 

            Console.WriteLine(delta);
            Console.WriteLine(x1);
            Console.WriteLine(x2);
        }
    }
}