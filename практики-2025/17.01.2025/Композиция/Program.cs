using System;

public class Engine
{
    public int Power { get; set; }

    public Engine(int power)
    {
        Power = power;
    }

     public void Start()
    {
        Console.WriteLine($"Двигатель мощностью {Power} запущен");
    }
}

public class Car
{
   public Engine Engine { get; set; }

    public Car(Engine engine)
    {
        Engine = engine;
    }

    public void Drive()
    {
        Engine.Start(); 
        Console.WriteLine("Машина едет");
    }
}

class Program
{
    static void Main(string[] args)
    {
         Engine engine = new Engine(150);

        Car car = new Car(engine);

         car.Drive(); 
    }
}