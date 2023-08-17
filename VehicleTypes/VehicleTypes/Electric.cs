using System;
namespace Hometask
{
    class Electric : Car
    {
        public decimal BatteryCapacity { get; set; }
        public Electric(int year, decimal price, int numberOfDoors, decimal batteryCapacity)
            : base(year, price, numberOfDoors)
        {
            BatteryCapacity = batteryCapacity;
        }
        public void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Battery capacity of your car:{BatteryCapacity}");
        }
        public void ChargingBattery()
        {
            Console.WriteLine($"Car with battery capacity {BatteryCapacity} is being charged");
        }
    }
}

