using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overloading {
    internal class Product {
        public string Name;
        public double Price;
        public int Amount;

        public Product(string name, double price, int amount) {
            Name = name;
            Price = price;
            Amount = amount;
        }

        public Product(string name, double price) {
            Name = name;
            Price = price;
            Amount = 10;
        }

        public Product() {

        }

        public double ValorTotalEmEstoque() {
            return Price * Amount;
        }
        public void AdicionarProdutos(int amount) {
            Amount += amount;
        }
        public void RemoverProdutos(int amount) {
            Amount -= amount;
        }
        public override string ToString() {
            return Name
            + ", $ "
            + Price.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + Amount
            + " units, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
