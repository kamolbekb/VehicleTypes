using System;
namespace Hometask
{
    class Diesel : Car
    {
        public int MaxSpeed { get; set; }
        public Diesel(int year, decimal price, int numberOfDoors, int maxSpeed)
            : base(year, price, numberOfDoors)
        {
            MaxSpeed = maxSpeed;
        }
        public void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Maximal speed of your car:{MaxSpeed}");
        }
    }
}

