using System;

abstract class Animal
{
    public string Name { get; set; }

    public Animal(string name)
    {
        Name = name;
    }

    public abstract void MakeSound();
}

class Dog : Animal
{
    public Dog(string name) : base(name) { }

    public override void MakeSound()
    {
        Console.WriteLine($"{Name} говорит: Гав-гав");
    }
}

class Cat : Animal
{
    public Cat(string name) : base(name) { }

    public override void MakeSound()
    {
        Console.WriteLine($"{Name} говорит: Мяу-мяу");
    }
}

class Cow : Animal
{
    public Cow(string name) : base(name) { }

    public override void MakeSound()
    {
        Console.WriteLine($"{Name} говорит: Муу");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Animal[] animals = 
        {
            new Dog("Cережа"),
            new Cat("Саша"),
            new Cow("тоша")
        };

        foreach (var animal in animals)
        {
            animal.MakeSound();
        }
    }
}
