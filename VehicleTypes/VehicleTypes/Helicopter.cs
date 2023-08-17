using System;
namespace Hometask
{
    class Helicopter : AirVehicle
    {
        public int NumberOfSeats { get; set; }
        public Helicopter(int year, decimal price, decimal fuelCapacity, int numberOfSeats)
            : base(year, price, fuelCapacity)
        {
            NumberOfSeats = numberOfSeats;
        }
        public void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Number of seats in helicopter:{NumberOfSeats}");
        }
    }
}

