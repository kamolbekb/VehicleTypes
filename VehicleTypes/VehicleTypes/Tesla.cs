using System;
namespace Hometask
{
    class Tesla : Electric
    {
        public int MaxDistance { get; set; }
        public Tesla(int year, decimal price, int numberOfDoors, decimal batteryCapacity, int maxDistance)
            : base(year, price, numberOfDoors, batteryCapacity)
        {
            MaxDistance = maxDistance;
        }
        public void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Maximal distance from full charging:{MaxDistance}");
        }
    }
}

