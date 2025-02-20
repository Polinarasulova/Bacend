using System;
interface ITurboBoost
{
    void Boost();
}
abstract class Racer
{
    public string Name { get; set; }
    public int Speed { get; protected set; }

    public Racer(string name, int speed)
    {
        Name = name;
        Speed = speed;
    }

    public abstract void Race();
public virtual void GetRaceStatus()
    {
        Console.WriteLine($"{Name} едет со скоростью {Speed} км/ч.");
    }
}

class CarRacer : Racer, ITurboBoost
{
    public CarRacer(string name, int speed) : base(name, speed) { }

    public override void Race()
    {
        Console.WriteLine($"{Name} участвует в автомобильной гонке!");
        GetRaceStatus();
    }

    public void Boost()
    {
        Speed += 50; 
        Console.WriteLine($"{Name}ускорение! Новая скорость {Speed} км/ч.");
    }
}


class BikeRacer : Racer
{
    public BikeRacer(string name, int speed) : base(name, speed) { }

    public override void Race()
    {
        Console.WriteLine($"{Name} участвует ");
        GetRaceStatus();
    }
}

class Program
{
    static void Main()
    {
        Racer carRacer = new CarRacer("Молния МакКвин", 200);
        Racer bikeRacer = new BikeRacer("Велосипедист Азиз", 30);

        carRacer.Race();
        bikeRacer.Race();

         if (carRacer is ITurboBoost turboCar)
        {
            turboCar.Boost();
        }
         Console.WriteLine("\nСтатус гонщиков после гонки:");
        carRacer.GetRaceStatus();
        bikeRacer.GetRaceStatus();
    }
}