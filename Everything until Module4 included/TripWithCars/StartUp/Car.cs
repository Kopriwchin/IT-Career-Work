using System;
using System.Collections.Generic;
using System.Text;

namespace TripWithCars
{
    public class Car
    {
        private string model;
        private double fuelQuantity;
        private double costPerKilometer;
        private double traveledDistance;

        public Car(string model, double fuelQuantity, double costPerKilometer, double travelDistance)
        {
            this.Model = model;
            this.FuelQuantity = fuelQuantity;
            this.CostPerKilometer = costPerKilometer;
            this.TraveledDistance = traveledDistance;
        }
       
        
        public string Model
        {
           get { return model; }
           set { model = value; }
        }
        public double FuelQuantity
        {
            get { return fuelQuantity; }
            set { fuelQuantity = value; }
        }
        public double CostPerKilometer
        {
            get { return costPerKilometer; }
            set { costPerKilometer = value; }
        }
        public double TraveledDistance
        {
            get { return traveledDistance; }
            set { traveledDistance = value; }
        }
         
        public void Drive(string model, double CostPerKilometer, double FuelQuantity, double kilometers)
        {
            if (FuelQuantity - CostPerKilometer * kilometers <= 0)
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
            else
            {
                fuelQuantity = FuelQuantity - CostPerKilometer * kilometers;
                traveledDistance += kilometers;
            }
        }

        public override string ToString()
        {
            return $"{Model} {FuelQuantity:f2} {TraveledDistance}";
        }
    }
}
