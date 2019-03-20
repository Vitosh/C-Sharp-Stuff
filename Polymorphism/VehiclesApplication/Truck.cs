namespace VehiclesApplication
{
    public class Truck : Auto
    {
        new public decimal AirConditionPerKm { get; } = 1.6M;
        public decimal WastePerRefuel { get; } = 0.05M;

        public Truck(decimal fuelQuantity, decimal litersPerKm) : base(fuelQuantity, litersPerKm)
        {
        }

        public bool CheckFuel(decimal distance)
        {
            return (distance * AirConditionPerKm + distance * LitersPerKm) >= FuelQuantity;
        }

        public void Drive(decimal distance)
        {
            DrivenDistance += distance;
            FuelQuantity -= distance * AirConditionPerKm;
            FuelQuantity -= distance * LitersPerKm;
        }


        public override string ToString()
        {
            return $"Truck: {FuelQuantity.ToString("F")}";
        }
    }
}
