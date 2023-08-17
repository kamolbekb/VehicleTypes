using System;
namespace Hometask
{
    class Car : Vehicle
    {
        public int NumberOfDoors { get; set; }
        public Car(int year, decimal price, int numberOfDoors)
            : base(year, price)
        {
            NumberOfDoors = numberOfDoors;
        }
        public void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Number of doors:{NumberOfDoors}");
        }
        public void StartEngine()
        {
            Console.WriteLine($"{NumberOfDoors} door car is starting engine");
        }
    }
}

