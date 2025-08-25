using System;
using System.Globalization; // Importing the CultureInfo class for formatting numbers

namespace Variables
{
    class Variables
    {
        static void Main(string[] args)
        {
            // Variable declaration and initialization

            // Number variables
            sbyte a = 127; // sbyte can hold values from -128 to 127
            a++; // it will print -128 because it overflows and wraps around
            Console.WriteLine(a);

            byte n1 = 255; // byte can hold values from 0 to 255, it doesn't accept negative values
            n1++;
            Console.WriteLine(n1); // it will print 0 because it overflows and wraps around

            int x,
                y,
                z; // declaring three variables of type int

            int b = 5; // declaring and initializing a variable of type int

            int age = 25;
            Console.WriteLine(age);
            Console.WriteLine(int.MaxValue); // prints the maximum value of an int
            Console.WriteLine(int.MinValue); // prints the minimum value of an int
            age = 30; // reassigning a new value to the variable age

            long population = 7800000000L; // for it to be computed as a long number, you type L at the end of the number
            Console.WriteLine(population);
            Console.WriteLine(long.MinValue);
            Console.Write(long.MaxValue);

            double negative = -55.23; // double is a floating-point number
            Console.WriteLine(negative);
            Console.WriteLine(double.MaxValue); // prints the maximum value of a double
            Console.WriteLine(double.MinValue); // prints the minimum value of a double

            float pi = 3.14F; // for it to be computed as a float number,  you type F at the end of the number
            Console.WriteLine(pi);
            Console.WriteLine(float.MaxValue); // prints the maximum value of a float
            Console.WriteLine(float.MinValue); // prints the minimum value of a float

            decimal price = 19.99M; // for it to be computed as a decimal number, you type M at the end of the number
            Console.WriteLine(price);
            Console.WriteLine(decimal.MaxValue); // prints the maximum value of a decimal
            Console.WriteLine(decimal.MinValue); // prints the minimum value of a decimal

            // To format a number to a specific number of decimal places, you can use the ToString method
            double d = 10.456774;
            Console.WriteLine(d.ToString("F2")); // the output will come out rounded up, so 10.46
            Console.WriteLine(d.ToString("F3", CultureInfo.InvariantCulture)); // by using InvariantCulture, we ensure that the formatting is consistent regardless of the system's culture settings

            // Boolean variables
            bool value = true;
            bool isMale = true;
            Console.WriteLine(isMale);

            bool value2 = false;
            bool isFemale = false;
            Console.WriteLine(isFemale);

            // Character variables
            // Strings are immutable sequences of characters, while characters are single Unicode characters
            string name = "Robert"; // A string should contain quotation marks, not apostrophes
            char letter = 'R'; // A character should be enclosed in single quotes

            Console.WriteLine($"Your name is {name}, it starts with an {letter}");

            string otherName = ""; // An empty string is valid
            char otherLetter = '\0'; // An empty character is represented by the null character
            char anotherLetter = '\u0041'; // Unicode representation of 'A'
            Console.WriteLine(anotherLetter);

            // Object variables
            object obj1 = "Alex"; // An object can hold any data type
            object obj2 = 42; // An object can also hold an integer
            object obj3 = 3.1451515131545; // An object can hold a double

            // Examples
            string str1 = "Alex";
            int int1 = 42;
            double double1 = 3.1451515131545;

            // Placeholder
            Console.WriteLine("{0} is a string, {1} is an integer, and {2:F2} is a double.", str1, int1, double1);

            // Interpolation
            Console.WriteLine($"{str1} is a string, {int1} is an integer, and {double1:F2} is a double");

            // Concatenation
            Console.WriteLine(str1 + " is a string, " + int1 + " is an integer, and " + double1.ToString("F2") + " is a double");
        }
    }
}