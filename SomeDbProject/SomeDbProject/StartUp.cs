using System;
using System.Linq;

namespace SomeDbProject
{
    class StartUp
    {
        static void Main()
        {
            SomeDbContext context = new SomeDbContext();

            for (int i = 0; i < 1000; i++)
            {
                Car newCar = new Car();
                newCar.Model = newCar.GetModel(i);
                newCar.Origin = newCar.GetOrigin(i);
                newCar.Price = newCar.GetPrice(i);
                newCar.Year = newCar.GetYear(i);
                context.Cars.Add(newCar);
            }
            context.SaveChanges();

            //LINQ
            Console.WriteLine("LINQ:\n");
            var queryFerrari =
                from c in context.Cars
                where c.Model.Contains("Ferrari")
                orderby c.Price
                select c;

            foreach (Car myCar in queryFerrari)
            {
                Console.WriteLine(myCar);
            }

            //Extension method
            Console.WriteLine("\n\nExtentsion method:");
            var queryBulgaria = context.Cars
                .Where(c => c.Origin.Contains("Bulgaria"))
                .OrderBy(c => c.Price);

            foreach (Car myCar in queryBulgaria)
            {
                Console.WriteLine(myCar);
            }
        }
    }
}
