namespace AbstractExample
{
    using System;
    using System.Collections.Generic;

    class Startup
    {
        static void Main()
        {
            List<Car> myCars = new List<Car>();
            myCars.Add(new BigTruck(2011));
            myCars.Add(new SmallCar(2010));

            foreach (Car car in myCars)
            {
                Console.WriteLine(car.StartEngine());
                Console.WriteLine(car.YearsNeededToDrive());
                Console.WriteLine(car.ProducedIn());
            }
        }
    }
}
