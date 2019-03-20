namespace VehiclesApplication2
{
    using System;
    using System.Globalization;
    using System.Threading;
    using VehiclesApplication2.Models;

    class Startup
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("en-GB");
            string[] carArgs = Console.ReadLine()
                .Split();

            double carFuelQantity = double.Parse(carArgs[1]);
            double carFuelConsumption = double.Parse(carArgs[2]);

            Car car = new Car(carFuelQantity, carFuelConsumption);

            string[] truckArgs = Console.ReadLine()
                .Split();

            double truckFuelQuantity = double.Parse(truckArgs[1]);
            double truckFuelConsumption = double.Parse(truckArgs[2]);

            Truck truck = new Truck(truckFuelQuantity, truckFuelConsumption);

            int commandsCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < commandsCount; i++)
            {
                string[] commandArgs = Console.ReadLine()
                    .Split();
                string command = commandArgs[0];
                string commandType = commandArgs[1];

                if (command == "Drive")
                {
                    double distance = double.Parse(commandArgs[2]);
                    if (commandType == "Car")
                    {
                        Console.WriteLine(car.Drive(distance)); 
                    }
                    else
                    {
                        Console.WriteLine(truck.Drive(distance));
                    }
                }
                else
                {
                    double fuelAmount = double.Parse(commandArgs[2]);
                    if (commandType == "Car")
                    {
                        car.Refuel(fuelAmount);
                    }
                    else
                    {
                        truck.Refuel(fuelAmount);
                    }
                }
            }
            Console.WriteLine(car);
            Console.WriteLine(truck);
        }
    }
}
