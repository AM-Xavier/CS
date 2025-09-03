using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using static System.FormattableString;

namespace Employee
{
    internal class EmployeeInfo
    {
        public string Name;
        public double Salary, Taxes;

        public double NetSalary()
        {
            return Salary - Taxes;
        }

        public void SalaryIncrease(double increase)
        {
            Salary *= (1 + (increase / 100));
        }

        public override string ToString()
        {
            return Invariant($"{Name}, ${NetSalary():F2}");
        }
        

    }
}
