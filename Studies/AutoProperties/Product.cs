using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AutoProperties {
    internal class Product {
        // A private attribute receives an underline before its name '_price'
        private string _name;
        public double Price { get; private set; }
        public int Amount { get; private set; }

        public Product() {
            Amount = 10;
        }
        public Product(string name, double price) : this() {
            _name = name;
            Price = price;
        }
        public Product(string name, double price, int amount) : this(name, price) {
            Amount = amount;
        }

        public string Name {
            get { return _name; }
            set {
                if(value != null && value.Length > 1) {
                    _name = value;
                }
            }
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
            return _name
            + ", $ "
            + Price.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + Amount
            + " units, Total: $ "
            + TotalValueInStorage().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
