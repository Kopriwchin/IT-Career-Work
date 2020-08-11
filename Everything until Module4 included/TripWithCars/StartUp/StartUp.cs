using System;
using System.Linq;
using System.Collections.Generic;

namespace TripWithCars
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int countCars = int.Parse(Console.ReadLine());
            Dictionary<string, Car> carDict = new Dictionary<string, Car>();

            for (int i = 0; i < countCars; i++)
            {
                string[] infoArgs = Console.ReadLine().Split().ToArray();

                string model = infoArgs[0];
                double fuelQuantity = double.Parse(infoArgs[1]);
                double costPerKilometer = double.Parse(infoArgs[2]);

                Car car = new Car(model, fuelQuantity, costPerKilometer, 0);

                carDict.Add(car.Model, car);
            }

            string[] commandArgs = Console.ReadLine().Split().ToArray();

            while (commandArgs[0] != "End")
            {
                if (commandArgs[0] == "Drive")
                {
                    string model = commandArgs[1];
                    double distance = double.Parse(commandArgs[2]);
                    carDict[commandArgs[1]]
                        .Drive(model, carDict[commandArgs[1]].CostPerKilometer, carDict[commandArgs[1]].FuelQuantity, distance);
                }
                commandArgs = Console.ReadLine().Split().ToArray();
            }

            foreach (var item in carDict.Values)
            {
                Console.WriteLine($"{item.ToString()}");
            }
        }
    }
}
