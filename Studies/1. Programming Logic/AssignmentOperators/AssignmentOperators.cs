using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOperators
{
    internal class AssignmentOperators
    {
        static void Main(string[] args)
        {
            int age = 25;

            // Increment and decrement operators
            age++; // Increment operator, but it only increments by 1
            age = age + 5; // Alternative way to increment
            age += 10; // Compound assignment operator
            Console.WriteLine($"Age after increment: {age}");

            age--; // Decrement operator, but it only decrements by 1
            age = age - 5; // Alternative way to decrement
            age -= 10; // Compound assignment operator
            Console.WriteLine($"Age after decrement: {age}");

            age *= 2; // Multiplication assignment operator
            Console.WriteLine($"Age after multiplication: {age}");

            age /= 2; // Division assignment operator
            Console.WriteLine($"Age after division: {age}");

            age /= 10; // The problem is that this will not give the expected result, it will omit
                       // the decimal part and will result in an integer division.
            Console.WriteLine($"Age after division by 10: {age}");

            // When dividing integers, the result is also an integer.
            // To get a decimal result, you can cast one of the operands to a double:

            double ageDouble = 25;
            ageDouble /= 10; // This will give a decimal result
            Console.WriteLine($"Age as double after division by 10: {ageDouble}");

            // Postfix and prefix increment/decrement operators
            int i = 0;
            Console.WriteLine($"Initial value of i: {i}");
            Console.WriteLine($"i before increment: {i++}"); // Postfix increment, prints 0, then increments
            Console.WriteLine($"i after increment: {i}"); // Now i is 1

            Console.WriteLine($"i before increment: {++i}"); // Prefix increment, increments first, then prints
            Console.WriteLine($"i after increment: {i}"); // Now i is 2

            // Operators with strings
            string name = "Alex";
            name += " is learning C#";
            Console.WriteLine($"Name after concatenation: {name}");

            char initial = 'a';
            initial += 'b'; // This will add the ASCII values of 'A' and 'B'
            Console.WriteLine($"Initial after addition: {initial}"); // This will print the character corresponding to the ASCII value

            // Modulus operator
            int remainder = 10 % 3; // This will give the remainder of the division
            Console.WriteLine($"Remainder of 10 divided by 3: {remainder}");

            // Modulus operators are a good way to check if a number is even or odd
            int firstNum = 10 % 2;
            int secondNum = 11 % 2;

            Console.WriteLine($"10 % 2 = {firstNum} (0 means even)");
            Console.WriteLine($"11 % 2 = {secondNum} (1 means odd)");


            Console.ReadLine();
        }
    }
}
