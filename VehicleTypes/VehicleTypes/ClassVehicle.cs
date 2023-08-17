using System;
namespace Hometask
{
	public class Vehicle
	{
        public int Year { get; set; }
        public decimal Price { get; set; }
        public Vehicle(int year, decimal price)
        {
            Year = year;
            Price = price;
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Year:{Year}\nPrice:{Price}");
        }
    }
}

