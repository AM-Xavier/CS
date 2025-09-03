using System.Globalization;

namespace Employee
{
    internal class Employee
    {
        static void Main(string[] args)
        {
            EmployeeInfo employee = new EmployeeInfo();

            Console.WriteLine("Enter employee info:");
            Console.Write("Name: ");
            employee.Name = Console.ReadLine();
            Console.Write("Gross salary: ");
            employee.Salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Taxes: ");
            employee.Taxes = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"Employee: {employee}");

            Console.Write("Enter salary increase percentage: ", CultureInfo.InvariantCulture);
            double inc = double.Parse(Console.ReadLine());
            employee.SalaryIncrease(inc);

            Console.WriteLine($"Updated info: {employee}");

            // name: string
            // fullsalary: double
            // taxes: double
            // employee info
            
            // liquidsalary(): double
            // salaryincrease(percentage: double): void

        }
    }
}