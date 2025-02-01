using System;

public class Car
{
     public string Model { get; set; }
    public int Speed { get; set; } 
    public int Distance { get; private set; } 

     public Car(string model, int speed)
    {
        Model = model;
        Speed = speed;
        Distance = 0;
    }

    public void Drive(int hours)
    {
        Distance += Speed * hours; 
        Console.WriteLine($"{Model} проехал {Distance} км за {hours} часов.");
    }
}

public class Race
{
    private Car[] cars;
    private int carCount;

    public Race(int maxCars)
    {
        cars = new Car[maxCars];
        carCount = 0;
    }
 public void AddCar(Car car)
    {
        if (carCount < cars.Length)
        {
            cars[carCount] = car;
            carCount++;
            Console.WriteLine($"{car.Model} добавлен ");
        }
        else
        {
            Console.WriteLine("Невозможно добавить");
        }
    }

     public void StartRace(int hours)
    {
        Console.WriteLine($"Гонка началась на {hours} часов!");
        foreach (var car in cars)
        {
            if (car != null)
            {
                car.Drive(hours); 
            }
        }
    }

     public void ShowResults()
    {
        Console.WriteLine("Результаты гонки:");
        Car winner = null;

        foreach (var car in cars)
        {
            if (car != null)
            {
                Console.WriteLine($"{car.Model} проехал {car.Distance} км.");
                if (winner == null || car.Distance > winner.Distance)
                {
                    winner = car;
                }
            }
        }

        if (winner != null)
        {
            Console.WriteLine($"Победитель: {winner.Model} с расстоянием {winner.Distance} км.");
        }
    }
}

public class Program
{
    public static void Main()
    {
        Race race = new Race(3);

        // Создаем машины
        Car car1 = new Car("нисан", 120);
        Car car2 = new Car("лада", 150);
        Car car3 = new Car("бмв", 130);

         race.AddCar(car1);
        race.AddCar(car2);
        race.AddCar(car3);

        race.StartRace(1);

        race.ShowResults();
    }
}