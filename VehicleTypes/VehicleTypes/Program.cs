namespace Hometask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tesla tesla = new Tesla(2016, 120000, 2, 500000,600);   //7,62-63,44-45,27-28,14,64-66
            tesla.DisplayInfo();
        }
    }
    class Vehicle
    {
        public int Year { get; set; }
        public decimal Price { get; set; }
        public Vehicle(int year,decimal price)
        {
            Year = year;
            Price = price;
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Year:{Year}\nPrice:{Price}");
        }
    }
    class Car:Vehicle
    {
        public int NumberOfDoors { get; set; }
        public Car (int year,decimal price,int numberOfDoors)
            : base(year, price)
        {
            NumberOfDoors = numberOfDoors;
        }
        public void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Number of doors:{NumberOfDoors}");
        }
        public void StartEngine() {
            Console.WriteLine($"{NumberOfDoors} door car is starting engine");
        }
    }
    class Electric : Car
    {
        public decimal BatteryCapacity { get; set; }
        public Electric(int year,decimal price,int numberOfDoors,decimal batteryCapacity)
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
    class Tesla:Electric
    {
        public int MaxDistance { get; set; }
        public Tesla(int year, decimal price, int numberOfDoors, decimal batteryCapacity,int maxDistance)
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
    class VolksWagen : Electric
    {
        public int MaxDistance { get; set; }
        public VolksWagen(int year, decimal price, int numberOfDoors, decimal batteryCapacity, int maxDistance)
            :base(year, price, numberOfDoors, batteryCapacity)
        {
            MaxDistance = maxDistance;
        }
        public void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Maximal distance from full charging:{MaxDistance}");
        }
    }
    class Diesel : Car
    {
        public int MaxSpeed { get; set; }
        public Diesel(int year,decimal price,int numberOfDoors,int maxSpeed)
            :base(year, price, numberOfDoors)
        {
            MaxSpeed = maxSpeed;
        }
        public void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Maximal speed of your car:{MaxSpeed}");
        }
    }
    class BMW : Diesel
    {
        public int NumberOfOwners { get; set; }
        public BMW(int year, decimal price, int numberOfDoors, int maxSpeed,int numberOfOwners)
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
    class Motorcycle : Vehicle
    {
        public bool HasSideCar { get; set; }
        public Motorcycle(int year,decimal price,bool hasSideCar)
            : base(year, price)
        {
            HasSideCar = hasSideCar;
        }
        public void Wheelie()
        {

        }
    }
    class AirVehicle : Vehicle
    {
        public decimal FuelCapacity { get; set; }
        public AirVehicle(int year, decimal price,decimal fuelCapacity)
            : base(year, price)
        {
            FuelCapacity = fuelCapacity;
        }
        public void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Fuel capacity:{FuelCapacity}");
        }
        public void Fly()
        {
            Console.WriteLine($"AirVehicle is flying");
        }
    }
    class AirPlane:AirVehicle
    {
        public bool HasBussinessClass { get; set; }
        public AirPlane(int year, decimal price, decimal fuelCapacity,bool hasBussinessClass)
            : base(year, price,fuelCapacity)
        {
            HasBussinessClass = hasBussinessClass;
        }
        public void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Has Busssiness Class:{HasBussinessClass}");
        }
    }
    class Helicopter : AirVehicle
    {
        public int  NumberOfSeats { get; set; }
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