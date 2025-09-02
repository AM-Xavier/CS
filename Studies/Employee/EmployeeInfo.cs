using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    internal class EmployeeInfo
    {
        public string Name;
        public double Salary, Taxes;

        public double LiquidSalary()
        {
            return Salary - Taxes;
        }

        public void SalaryIncrease(double increase)
        {
            Salary = Salary * (increase/100);
        }


    }
}
