namespace VehiclesApplication
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Threading;

    class Startup
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("en-GB");
            List<string> carInfo = ReadLineAndParseToList();
            List<string> truckInfo = ReadLineAndParseToList();

            Car car = new Car(decimal.Parse(carInfo[1]), decimal.Parse(carInfo[2]));
            Truck truck = new Truck(decimal.Parse(truckInfo[1]), decimal.Parse(truckInfo[2]));

            int commandCounts = int.Parse(Console.ReadLine());
            for (int i = 0; i < commandCounts; i++)
            {
                CommandReader(ReadLineAndParseToList(),car,truck);
            }

            Console.WriteLine(car.ToString());
            Console.WriteLine(truck.ToString());

        }

        public static void Globalization()
        {
            NumberFormatInfo nfi = new NumberFormatInfo();
            nfi.NumberDecimalSeparator = ".";
        }

        public static void CommandReader(List<string> consoleInput,Car car, Truck truck)
        {
            decimal distanceOrLiters = decimal.Parse(consoleInput[2]);

            switch (consoleInput[0])
            {
                case "Drive":
                    switch (consoleInput[1])
                    {
                        case "Car":
                            if (car.CheckFuel(distanceOrLiters))
                            {
                                Console.WriteLine(car.WriteFuelRequest("Car"));
                            }
                            else
                            {
                                car.Drive(distanceOrLiters);
                                Console.WriteLine(car.DriveInfo("Car", distanceOrLiters)); 
                            }
                            break;
                        case "Truck":
                            if (truck.CheckFuel(distanceOrLiters))
                            {
                                Console.WriteLine(truck.WriteFuelRequest("Truck"));
                            }
                            else
                            {
                                truck.Drive(distanceOrLiters);
                                Console.WriteLine(truck.DriveInfo("Truck", distanceOrLiters));
                            }
                            break;
                    }
                    break;
                case "Refuel":
                    switch (consoleInput[1])
                    {
                        case "Car":
                            car.Refuel(distanceOrLiters);
                            break;
                        case "Truck":
                            truck.Refuel(distanceOrLiters, truck.WastePerRefuel);
                            break;
                    }
                    break;
            }
        }

        public static List<string> ReadLineAndParseToList()
        {
            return Console.ReadLine().Split().ToList();
        }
    }
}
