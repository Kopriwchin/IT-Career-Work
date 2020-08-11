using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Restaurant
{
    class Product
    {
        private string name;
        private double price;
        private int weight;

        public Product(string name, double price, int weight)
        {
            this.Name = name;
            this.Price = price;
            this.Weight = weight;

        }
        public string Name
        {
            get { return name; }
            set {
                if (value.Length < 3)
                {
                    throw new ArgumentException("Invalid Name!");
                }
                this.name = value; }
        }
        public double Price
        {
            get { return price; }
            set {
                if (value < 0.01)
                {
                    throw new ArgumentException("Invalid Price!");
                }
                this.price = value;
            }
        }
        public int Weight
        {
            get { return this.weight; }
            set {
                if (value <= 0)
                {
                    throw new ArgumentException("Invalid Weight!");
                }
                this.weight = value;
            }
        }

        public static Product GetCheapestProduct(Dictionary<string, Product> products)
        {
            return products.OrderBy(x => x.Value.Price).First().Value;
        }

        public override string ToString()
        {
            return $"{this.name} - {this.weight}";
        }
    }
}
