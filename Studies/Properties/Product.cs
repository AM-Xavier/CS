using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Properties {
    internal class Product {
        // A private attribute receives an underline before its name '_price'
        private string _name;
        private double _price;
        private int _amount;

        public Product() {
            _amount = 10;
        }
        public Product(string name, double price) : this() {
            _name = name;
            _price = price;
        }
        public Product(string name, double price, int amount) : this(name, price) {
            _amount = amount;
        }

        public string Name {
            get { return _name; }
            set {
                if(value != null && value.Length > 1) {
                    _name = value;
                }
            }
        }

        public double Price {
            get { return _price; }
        }

        public int Amount {
            get { return _amount; }
        }

        public double TotalValueInStorage() {
            return _price * _amount;
        }
        public void AddProducts(int amount) {
            _amount += amount;
        }
        public void RemoveProducts(int amount) {
            _amount -= amount;
        }
        public override string ToString() {
            return _name
            + ", $ "
            + _price.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + _amount
            + " units, Total: $ "
            + TotalValueInStorage().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
