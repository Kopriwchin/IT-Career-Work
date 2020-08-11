using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace CarStore
{
    public class Store
    {
        private string name;
        private List<Car> cars = new List<Car>();

        public Store(string name)
        {
            this.Name = name;
            this.cars = new List<Car>();
        }
        //public Store(string name, List<Car> cars)
        //{
        //    this.Name = name;
        //    this.cars = cars;
        //}

        public string Name
        {
            get { return name; }
            set
            {
                if (value.Length < 5)
                {
                    throw new ArgumentException("Invalid store name!");
                }
                this.name = value;
            }
        }

        public void AddCar(Car car)
        {
            if (cars.Count(x => x.Number == car.Number) == 0 )
            {
                cars.Add(car);
            }

        }
        public bool SellCar(Car car)
        {
            foreach (var currentCar in cars)
            {
                if (currentCar.Number == car.Number && currentCar.Price == car.Price)
                {
                    cars.Remove(currentCar);
                    return true;
                }
            }
           
            return false;
        }

        public double CalculateTotalPrice()
        {
            return cars.Sum(x => x.Price);
        }

        public Car GetCarWithHighestPrice()
        {
            return cars.OrderByDescending(x => x.Price).First();
        }

        public Car GetCarWithLowestPrice()
        {
            return cars.OrderBy(x => x.Price).First();
        }

        public void RenameStore(string newName)
        {
            this.Name = newName;
        }

        public void SellAllCars()
        {
            cars.Clear();
        }

        public override string ToString()
        {
            if (this.cars.Count > 0)
            {
                var sb = new StringBuilder();
                sb.Append($"Store {this.name} has {this.cars.Count} car/s:");
                foreach (var car in this.cars)
                {
                    sb.Append($"\n{car.ToString()}");
                }
                return sb.ToString();
            }
            return $"Store {this.name} has no available cars.";
        }
    }
}
