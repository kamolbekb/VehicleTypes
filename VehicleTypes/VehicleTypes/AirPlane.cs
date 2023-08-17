using System;
namespace Hometask
{
    class AirPlane : AirVehicle
    {
        public bool HasBussinessClass { get; set; }
        public AirPlane(int year, decimal price, decimal fuelCapacity, bool hasBussinessClass)
            : base(year, price, fuelCapacity)
        {
            HasBussinessClass = hasBussinessClass;
        }
        public void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Has Busssiness Class:{HasBussinessClass}");
        }
    }
}

