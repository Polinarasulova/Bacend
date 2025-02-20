using System;

public interface ICanFly
{
    void Fly();
}

public abstract class Animal
{
    protected string Name { get; set; }

    public Animal(string name)
    {
        Name = name;
    }

    public abstract void MakeSound();

    public virtual void Info()
    {
        Console.WriteLine($"{Name} {this.GetType().Name}");
    }
}

public class Lion : Animal
{
    public Lion(string name) : base(name) { }

    public override void MakeSound()
    {
        Console.WriteLine("Р-р-р!");
    }
}

public class Elephant : Animal
{
    public Elephant(string name) : base(name) { }

    public override void MakeSound()
    {
        Console.WriteLine("Тууу!");
    }
}

public class Parrot : Animal, ICanFly
{
    public Parrot(string name) : base(name) { }

    public override void MakeSound()
    {
        Console.WriteLine("прив!");
    }

    public void Fly()
    {
        Console.WriteLine("у меня есть крылья");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Animal[] animals = new Animal[3]
        {
            new Lion("ксюша"),
            new Elephant("вика"),
            new Parrot("даша")
        };

        Console.WriteLine("Они издают звуки:");
        foreach (var animal in animals)
        {
            animal.MakeSound();
        }

         Console.WriteLine("\nИнформация о животных:");
        foreach (var animal in animals)
        {
            animal.Info();
        }

        Console.WriteLine("\nПопытка полета попугая:");
        foreach (var animal in animals)
        {
            if (animal is ICanFly flyer)
            {
                flyer.Fly();
            }
        }
    }
}