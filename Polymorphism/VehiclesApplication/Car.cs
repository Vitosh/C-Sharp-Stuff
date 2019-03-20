namespace VehiclesApplication
{
    using System;

    public class Car : Auto
    {
        new public decimal AirConditionPerKm { get; } = 0.9M;

        public Car(decimal fuelQuantity, decimal litersPerKm) : base(fuelQuantity, litersPerKm)
        {
        }

        public bool CheckFuel(decimal distance)
        {
            return distance * AirConditionPerKm + distance * LitersPerKm >= FuelQuantity;
        }

        public override string ToString()
        {
            return $"Car: {FuelQuantity.ToString("F")}";
        }

        public void Drive(decimal distance)
        {
            DrivenDistance += distance;
            FuelQuantity -= distance * AirConditionPerKm;
            FuelQuantity -= distance * LitersPerKm;
            Console.WriteLine(DrivenDistance);
        }
    }
}
