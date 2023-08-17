using System;
namespace Hometask
{
    class BMW : Diesel
    {
        public int NumberOfOwners { get; set; }
        public BMW(int year, decimal price, int numberOfDoors, int maxSpeed, int numberOfOwners)
            : base(year, price, numberOfDoors, maxSpeed)
        {
            NumberOfOwners = numberOfOwners;
        }
        public void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"The number of owners:{NumberOfOwners}");
        }
    }
}

