using System;
using System.Collections.Generic;

public class Passenger
{
     public string Name { get; set; }
    public string PassportNumber { get; set; }

   
    public Passenger(string name, string passportNumber)
    {
        Name = name;
        PassportNumber = passportNumber;
    }
}

public class Flight
{
    public string FlightNumber { get; set; }
    public string Destination { get; set; }
    private List<Passenger> passengers; 

    public Flight(string flightNumber, string destination)
    {
        FlightNumber = flightNumber;
        Destination = destination;
        passengers = new List<Passenger>(); 
    }

    public void AddPassenger(Passenger passenger)
    {
        if (!IsPassengerOnFlight(passenger))
        {
            passengers.Add(passenger);
            Console.WriteLine($"Пассажир {passenger.Name} добавлен в рейс {FlightNumber}.");
        }
        else
        {
            Console.WriteLine($"Пассажир {passenger.Name} уже там {FlightNumber}.");
        }
    }

    public bool IsPassengerOnFlight(Passenger passenger)
    {
        foreach (var p in passengers)
        {
            if (p.PassportNumber == passenger.PassportNumber)
            {
                return true; 
            }
        }
        return false; 
    }

    public void ShowPassengers()
    {
        Console.WriteLine($"Пассажиры на рейсе {FlightNumber}:");
        foreach (var passenger in passengers)
        {
            Console.WriteLine($"- {passenger.Name} паспорт: {passenger.PassportNumber}");
        }
    }
}

public class Program
{
    public static void Main()
    {
         Flight flight = new Flight("pol", "Нью-Йорк");

        
        Passenger passenger1 = new Passenger("Ксюша Иванова", "1234");
        Passenger passenger2 = new Passenger("Маша Иванова", "1235");
        Passenger passenger3 = new Passenger("Ксюша Иванова", "1234"); 

         flight.AddPassenger(passenger1);
        flight.AddPassenger(passenger2);
        flight.AddPassenger(passenger3); 

        flight.ShowPassengers();
    }
}