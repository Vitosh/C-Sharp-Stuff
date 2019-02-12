using System;
using System.Collections.Generic;
using System.Linq;

namespace SomeDbProject
{
    class StartUp
    {
        static void Main()
        {
            SomeDbContext context = new SomeDbContext();
            int companiesToMake = 20;
            int carsPerCompany = 5;
            int carsToMake = companiesToMake * carsPerCompany;

            for (int i = 0; i < carsToMake; i++)
            {
                Car newCar = new Car();
                newCar.Model = newCar.GetModel(i);
                newCar.Origin = newCar.GetOrigin(i);
                newCar.Price = newCar.GetPrice(i);
                newCar.Year = newCar.GetYear(i);
                context.Cars.Add(newCar);
            }
            context.SaveChanges();

            for (int i = 0; i < companiesToMake; i++)
            {
                List<Car> companyCars = new List<Car>();
                for (int x = 0; x < carsPerCompany; x++)
                {
                    int idOfCar = i * 5 + x + 1;
                    Car currentCar = new Car();
                    currentCar = context.Cars.FirstOrDefault(car => car.Id == idOfCar);
                    companyCars.Add(currentCar);
                }

                context.Companies.Add(new Company
                {
                    Name = $"Company {i.ToString()}",
                    Owner = $"Owner {i.ToString()}",
                    YearEstablished = 1999,
                    Cars = companyCars,
                });
            }
            context.SaveChanges();

            Console.WriteLine("LINQ:\n");
            var queryCars =
                    from ca in context.Cars
                    from co in context.Companies
                    where co.Id == ca.CompanyId &&
                        (ca.Origin == "Bulgaria" || ca.Origin == "Italy")
                    select new
                    {
                        CarId = ca.Id,
                        companyId = co.Id,
                        companyName = co.Name,
                        carModel = ca.Model,
                        carPrice = ca.Price,
                        carCountry = ca.Origin

                    };

            foreach (var car in queryCars)
            {
                Console.WriteLine($"{car.companyId} - " +
                                    $"{car.companyName} - " +
                                    $"{car.CarId} - " +
                                    $"{car.carModel} - " +
                                    $"{car.carPrice} - " +
                                    $"{car.carCountry}");
            }
        }
    }
}
