namespace SomeDbProject
{
    using System;
    using System.Collections.Generic;

    class Car
    {
        public int Id { get; set; }
        public string Model { get; set; }
        public decimal Price { get; set; }
        public string Origin { get; set; }
        public int Year { get; set; }
        public virtual int? CompanyId {get; set;}
        public virtual Company Company { get; set; }

        public string GetModel(int value)
        {
            int modelDefined = value % 5;
            List<String> carModels = new List<String> { "Ferrari", "Porsche", "Lada", "Opel", "VW" };
            return carModels[modelDefined];
        }

        public string GetOrigin(int value)
        {
            int originDefined = value % 5;
            List<String> carOrigin = new List<String> { "Italy", "Sicily", "Russia", "Germany", "Bulgaria" };
            return carOrigin[originDefined];
        }

        public int GetYear(int value)
        {
            Random rnd = new Random();
            return rnd.Next(1900+value, 2000 +value);
        }


        public decimal GetPrice(int value)
        {
            Random rnd = new Random();
            return rnd.Next(value * 100, value * 1000);
        }

        public override string ToString()
        {
            return $"{Id} \t {Model} \t EUR {Price} \t {Origin} \t {Year} \t";
        }
    }
}
