using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
    internal class Conversion
    {
        static void Main(string[] args)
        {
            // Implicitly converting numeric types in C#
            float x = 4.5f;
            double y = x; // Implicit conversion from float to double
            Console.WriteLine(y); // Output: 4.5

            // Explicitly converting strings to numeric types in C#
            string textAge = "25";
            int age = Convert.ToInt32(textAge); // Convert string to int by using Convert.ToInt32
            Console.WriteLine(age);

            string textPopulation = "7800000000";
            long population = Convert.ToInt64(textPopulation); // Convert string to long by using Convert.ToInt64
            Console.WriteLine(population);

            string textNegative = "-55.23";
            double negative = Convert.ToDouble(textNegative); // Convert string to double by using Convert.ToDouble
            Console.WriteLine(negative);

            string textPi = "3.14";
            float pi = Convert.ToSingle(textPi); // Convert string to float by using Convert.ToSingle
            Console.WriteLine(pi);

            string textPrice = "19.99";
            decimal price = Convert.ToDecimal(textPrice); // Convert string to decimal by using Convert.ToDecimal
            Console.WriteLine(price);

            // Special cases
            double a;
            float b;
            int c, d, e;

            a = 5.1;
            b = a; // The opposite won't work, as float cannot hold all double values
            b = (float)a; // In this case you'll have to explicitly convert double to float
            c = a; // The same thing happens here, as a double cannot be converted to int implicitly
            c = (int)a; // You have to explicitly convert double to int, but you'll lose the decimal part
            d = 5;
            e = 2;

            double result = d / e; // This will perform integer division, resulting in 2.0,
            Console.WriteLine(result); // instead of 2.5 as you might expect.
            result = (double) d / e; // To get the expected result, you need to cast one of the operands to double
        }
    }
}
