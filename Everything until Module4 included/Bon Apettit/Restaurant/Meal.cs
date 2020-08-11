using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    class Meal
    {
        private string name;
        private string type;
        private double price;
        private List<Product> products = new List<Product>();
        private int ordered = 0;

        public Meal(string name, string type)
        {
            this.Name = name;
            this.Type = type;
        }
        public Meal(string name, string type, List<Product> products)
        {
            this.Name = name;
            this.Type = type;
            this.products = products;
        }
        public string Name
        {
            get { return this.name; }
            set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("Invalid Name!");
                }
                this.name = value;
            }
        }
        public string Type
        {
            get { return this.type; }
            set
            {
                if (value == "")
                {
                    throw new ArgumentException("Invalid Type!");
                }
                this.type = value;
            }
        }
        public double Price
        {
            get
            {
                this.price = CalculatePrice();
                return this.price;
            }
        }

        public int Ordered
        {
            get { return this.ordered; }
            set { this.ordered = value; }
        }

        public void AddProduct(Product p)
        {
            products.Add(p);
        }
        public bool ContainsProduct(string name)
        {
            return products.Exists(e => e.Name == name);
        }
        public double CalculatePrice()
        {
            double price = 0;
            foreach (var item in products)
            {
                price += item.Price;
            }
            foreach (var item in products)
            {
                price += item.Price * 0.3;
            }
            return price;
        }
        public void PrintRecipe()
        {
            string str = new string('-', 25);
            Console.WriteLine(str);
            Console.WriteLine($"{name} RECIPE");
            Console.WriteLine(str);
            foreach (var item in products)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(str);
        }
        public void Order()
        {
            this.ordered++;
        }

        public static Meal GetSpecialty(Dictionary<string, Meal> meals)
        {
            return meals.OrderByDescending(p => p.Value.ordered).First().Value;
        }
        public static Meal RecommendByPrice(double price, Dictionary<string, Meal> meals)
        {
            return meals.Where(m => (m.Value.Price <= price)).OrderByDescending(m => m.Value.Price).First().Value;
        }
        public static Meal RecommendByPriceAndType(double price, string type, Dictionary<string, Meal> meals)
        {
            return meals.Where(m => m.Value.Name == type).Where(m => (m.Value.Price <= price)).OrderByDescending(m => m.Value.Price).First().Value;
        }

        public override string ToString()
        {
            return $"{this.name} - {this.type}";
        }

    }
}
