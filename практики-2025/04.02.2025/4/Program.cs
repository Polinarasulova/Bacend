using System;

interface IRefuelable
{
    void Refuel(decimal amount);
}

abstract class Vehicle
{
    public int Speed { get; set; }

    public abstract void Move();
}

class Car : Vehicle, IRefuelable
{
    public string Brand { get; set; }

    public Car(string brand)
    {
        Brand = brand;
    }

    public override void Move() => Console.WriteLine($"{Brand} едет со скоростью {Speed} км/ч.");

    public void Refuel(decimal amount) => Console.WriteLine($"{Brand} заправлен на {amount} литров.");
}

class Motorcycle : Vehicle
{
    public string Type { get; set; }

    public Motorcycle(string type)
    {
        Type = type;
    }

    public override void Move() => Console.WriteLine($"{Type} мотоцикл едет со скоростью {Speed} км/ч.");
}

class Program
{
    static void Main()
    {
        var car = new Car("Toyota");
        car.Speed = 120;
        car.Move();
        car.Refuel(50);

        var motorcycle = new Motorcycle("Спорт");
        motorcycle.Speed = 150;
        motorcycle.Move();
    }
}