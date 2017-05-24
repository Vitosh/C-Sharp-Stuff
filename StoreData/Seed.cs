using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreData
{
    public static class Seed
    {
        public static void EnterData()
        {

            SalesContext context = new SalesContext();
            Product car = new Product();
            car.Name = "Car";
            car.Price = 2000M;
            car.Quantity = 10;

            Product motorcycle = new Product();
            motorcycle.Name = "Motorcycle";
            motorcycle.Price = 2000M;
            motorcycle.Quantity = 8;

            Product truck = new Product();
            truck.Name = "Truck";
            truck.Price = 20000M;
            truck.Quantity = 8;

            Customer mitko = new Customer();
            mitko.Name = "Dimitar";
            mitko.CreditCardNumber = "123123";

            Customer pesho = new Customer();
            pesho.Name = "Peter";
            pesho.CreditCardNumber = "123123";

            Customer georgi = new Customer();
            georgi.Name = "Georgi";
            georgi.CreditCardNumber = "123123";

            StoreLocation sofia = new StoreLocation();
            sofia.LocationName = "Grad Sofia";

            StoreLocation plovdiv = new StoreLocation();
            plovdiv.LocationName = "Grad Plovdiv";

            Sale carSale = new Sale();
            carSale.Product = car;
            carSale.Customer = mitko;
            carSale.StoreLocation = sofia;
            carSale.Date = DateTime.Now;

            Sale motorcycleSale = new Sale();
            motorcycleSale.Product = motorcycle;
            motorcycleSale.Customer = georgi;
            motorcycleSale.StoreLocation = sofia;
            motorcycleSale.Date = DateTime.Now;

            Sale truckSale = new Sale();
            truckSale.Product = truck;
            truckSale.Customer = pesho;
            truckSale.StoreLocation = plovdiv;
            truckSale.Date = DateTime.Now;

            context.Sales.Add(carSale);
            context.Sales.Add(truckSale);
            context.Sales.Add(motorcycleSale);

            foreach (var item in context.Products)
            {
                if (item.Description == null)
                {
                    item.Description = "A";
                }
            }
            context.SaveChanges();
        }
    }
}
