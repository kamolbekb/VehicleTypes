using System;
namespace Hometask
{
    class Mercedes : Diesel
    {
        public int NumberOfOwners { get; set; }
        public Mercedes(int year, decimal price, int numberOfDoors, int maxSpeed, int numberOfOwners)
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

