using System;
using System.Collections.Generic;
using System.Text;

namespace CarStore
{
    public class Car
    {
        private int number;
        private double price;

        public Car(int number, double price)
        {
            this.Number = number;
            this.Price = price;
        }

        public Car(int number, double price, string make)
        {
            this.Number = number;
            this.Price = price;
            this.Make = make;
        }
        public string Make { get; set; }
      
        public int Number
        {
            get { return this.number; }
            set { this.number = value; }
        }
        public double Price
        {
            get { return price; }
            set {
                if (value < 1000.00)
                {
                    throw new ArgumentException("Invalid car price!");
                }
                this.price = value;
            }
        }       
        public override string ToString()
        {
            return $"Car number {this.Number} costs {this.Price:F2}";
        }
    }
}
