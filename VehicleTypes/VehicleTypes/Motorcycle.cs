using System;
namespace Hometask
{
    class Motorcycle : Vehicle
    {
        public bool HasSideCar { get; set; }
        public Motorcycle(int year, decimal price, bool hasSideCar)
            : base(year, price)
        {
            HasSideCar = hasSideCar;
        }
        public void Wheelie()
        {

        }
    }
}

