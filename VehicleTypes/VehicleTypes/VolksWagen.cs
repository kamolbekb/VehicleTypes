using System;
namespace Hometask
{
    class VolksWagen : Electric
    {
        public int MaxDistance { get; set; }
        public VolksWagen(int year, decimal price, int numberOfDoors, decimal batteryCapacity, int maxDistance)
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

