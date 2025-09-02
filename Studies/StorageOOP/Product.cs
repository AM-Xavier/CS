using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.FormattableString;

namespace StorageOOP
{
    internal class Product
    {
        public string Name;
        public double Price;
        public int Quantity;

        public double TotalValueInStorage()
        {
            return Price * Quantity;
        }


        public void AddProduct(int quantity)
        {
            Quantity += quantity;
        }

        public void RemoveProduct(int quantity)
        {
            Quantity -= quantity;
        }

        public override string ToString()
        {
            return Invariant($"{Name}, {Price:F2}, {Quantity} units, Total: ${TotalValueInStorage():F2}");
        }

    }
}
