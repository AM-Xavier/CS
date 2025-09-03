using System.Globalization;
using static System.FormattableString;

namespace StudentGrades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Student: string
            // Grades.a: double
            // Grades.b: double
            // Grades.c: double
            // Final Grade: double

            Grades student = new Grades();

            Console.Write("Student's name: ");
            student.Name = Console.ReadLine();
            Console.WriteLine("Enter student's grades:");
            student.Grade1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            student.Grade2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            student.Grade3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine(Invariant($"Final grade = {student.FinalGrade():F2}"));

            if (student.Approved())
            {
                Console.WriteLine("Approved!");
            }

            else
            {
                Console.WriteLine("Failed");
                Console.WriteLine(Invariant($" Points needed = {student.PointsNeeded():F2}"));
            }

        }
    }
}
