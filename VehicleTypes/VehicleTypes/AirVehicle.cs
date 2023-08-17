using System;
namespace Hometask
{
    class AirVehicle : Vehicle
    {
        public decimal FuelCapacity { get; set; }
        public AirVehicle(int year, decimal price, decimal fuelCapacity)
            : base(year, price)
        {
            FuelCapacity = fuelCapacity;
        }
        public void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Fuel capacity:{FuelCapacity}");
        }
        public void Fly()
        {
            Console.WriteLine($"AirVehicle is flying");
        }
    }
}

