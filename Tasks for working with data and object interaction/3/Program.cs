using System;

namespace AirlineSystem
{
    public class Passenger
    {
        public string Name { get; set; }
        public string PassportNumber { get; set; }

        public Passenger(string name, string passportNumber)
        {
            Name = name;
            PassportNumber = passportNumber;
        }

        public override string ToString()
        {
            return $"{Name} (Passport: {PassportNumber})";
        }
    }

    public class Flight
    {
        public string FlightNumber { get; set; }
        public string Destination { get; set; }
        private Passenger[] Passengers;
        private int passengerCount;

        public Flight(string flightNumber, string destination, int capacity)
        {
            FlightNumber = flightNumber;
            Destination = destination;
            Passengers = new Passenger[capacity];
            passengerCount = 0;
        }

        public bool AddPassenger(Passenger passenger)
        {
            if (passengerCount < Passengers.Length)
            {
                Passengers[passengerCount] = passenger;
                passengerCount++;
                return true; 
            }
            else
            {
                Console.WriteLine("Рейс заполнен");
                return false; 
            }
        }

        public bool IsPassengerOnFlight(string passportNumber)
        {
            for (int i = 0; i < passengerCount; i++)
            {
                if (Passengers[i].PassportNumber == passportNumber)
                {
                    return true; 
                }
            }
            return false; 
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Passenger passenger1 = new Passenger("Polina", "AB11111");
            Passenger passenger2 = new Passenger("Aziz", "CD221522");

            Flight flight = new Flight("SU123", "Москва", 2);

            flight.AddPassenger(passenger1);
            flight.AddPassenger(passenger2);

            string passportToCheck = "AB22222";
            if (flight.IsPassengerOnFlight(passportToCheck))
            {
                Console.WriteLine($"Пассажир с паспортом {passportToCheck} на рейсе {flight.FlightNumber}");
            }
            else
            {
                Console.WriteLine($"Пассажир с паспортом {passportToCheck} не найден на рейсе {flight.FlightNumber}");
            }

            passportToCheck = "CD221522"; 
            if (flight.IsPassengerOnFlight(passportToCheck))
            {
                Console.WriteLine($"Пассажир с паспортом {passportToCheck} на рейсе {flight.FlightNumber}");
            }
            else
            {
                Console.WriteLine($"Пассажир с паспортом {passportToCheck} не найден на рейсе {flight.FlightNumber}");
            }
        }
    }
}