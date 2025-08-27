using System;
using System.Globalization;

namespace EmployeeExercise
{
    internal class EmployeeExercise
    {
        static void Main(string[] args)
        {
            int employee_number = int.Parse(Console.ReadLine()),
                worked_hours = int.Parse(Console.ReadLine());

            double salary_per_hour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture),
                   full_salary = worked_hours * salary_per_hour;

            Console.WriteLine($"Number: {employee_number}");
            Console.WriteLine($"Your salary is: ${full_salary}");
        }
    }
}
