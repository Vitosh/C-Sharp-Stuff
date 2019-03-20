namespace VehiclesApplication
{
    public class Auto
    {
        public decimal AirConditionPerKm { get; }

        public decimal FuelQuantity { get; set; }

        public decimal LitersPerKm { get; set; }

        public decimal DrivenDistance { get; set; }
        
        public Auto(decimal fuelQuantity, decimal litersPerKm)
        {
            this.FuelQuantity = fuelQuantity;
            this.LitersPerKm = litersPerKm;
        }

        public virtual void Refuel(decimal liters, decimal wastePerRefuel = 0)
        {
            liters -= (liters * wastePerRefuel);
            FuelQuantity += liters;
        }

        public string DriveInfo(string typeOfAuto, decimal distance)
        {
            return $"{typeOfAuto} travelled {distance} km";
        }

        public string WriteFuelRequest(string typeOfAuto)
        {
            return $"{typeOfAuto} needs refueling";
        }
    }   
}
