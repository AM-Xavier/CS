using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace This {
    internal class Product {
        public string Name;
        public double Price;
        public int Amount;
        
        public Product() {
            Amount = 10;
        }
        public Product(string name, double price) : this() {
            Name = name;
            Price = price;
        }
        public Product(string name, double price, int amount) : this(name, price){
            Amount = amount;
        }

        public double TotalValueInStorage() {
            return Price * Amount;
        }
        public void AddProducts(int amount) {
            Amount += amount;
        }
        public void RemoveProducts(int amount) {
            Amount -= amount;
        }
        public override string ToString() {
            return Name
            + ", $ "
            + Price.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + Amount
            + " units, Total: $ "
            + TotalValueInStorage().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
