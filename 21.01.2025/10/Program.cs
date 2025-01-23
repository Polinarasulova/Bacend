using System;

namespace VehicleRentalSystem
{
  public class Vehicle
    {
        public string Brand { get; set; }
        public double PricePerDay { get; set; }

        public Vehicle(string brand, double pricePerDay)
        {
            Brand = brand;
            PricePerDay = pricePerDay;
        }

        public virtual double CalculateCost(int days)
        {
            return PricePerDay * days;
        }
    }

    public class Car : Vehicle
    {
        public Car(string brand, double pricePerDay) : base(brand, pricePerDay) { }

        public string GetTypeOfVehicle()
        {
            return "Легковой автомобиль";
        }
    }

 public class Truck : Vehicle
    {
        public Truck(string brand, double pricePerDay) : base(brand, pricePerDay) { }

        public string GetTypeOfVehicle()
        {
            return "Грузовик";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
             Vehicle[] vehicles = new Vehicle[]
            {
                new Car("тоета", 50),
                new Truck("вольга", 80),
                new Car("бмв", 45),
                new Truck("нисан", 90)
            };
            int rentalDays = 3;
            for (int i = 0; i < vehicles.Length; i++)
            {
               double cost = vehicles[i].CalculateCost(rentalDays);
                string vehicleType = vehicles[i] is Car ? "Легковой автомобиль" : "Грузовик"; 
                Console.WriteLine("Тип: " + vehicleType + ", Марка: " + vehicles[i].Brand + ", Стоимость аренды за " + rentalDays + " дня: " + cost );
            }
        }
    }
}