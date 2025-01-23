using System;

public class Toy
{
    public string Name { get; set; }
    public double Price { get; set; }

    public Toy(string name, double price)
    {
        Name = name;
        Price = price;
    }

    public virtual void Play()
    {
        Console.WriteLine("Играть с игрушкой.");
    }
}
public class Car : Toy
{
    public Car(string name, double price) : base(name, price)();

    public override void Play()
    {
        Console.WriteLine($"Врум! Я  машина {Name}.");
    }
}

public class Doll : Toy
{
    public Doll(string name, double price) : base(name, price)();

    public override void Play()
    {
        Console.WriteLine($"Привет, я барби {Name}!");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Toy[] toys = new Toy[4];
        toys[0] = new Car("Спортивная машинка", 1500);
        toys[1] = new Doll("Барби", 1200);
        toys[2] = new Car("Грузовик", 1800);
        toys[3] = new Doll("Кукла-неваляшка", 800);

        foreach (var toy in toys)
        {
            toy.Play();
        }
    }
}