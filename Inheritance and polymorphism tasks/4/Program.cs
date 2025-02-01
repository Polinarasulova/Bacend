using System;
using System.Collections.Generic;

public abstract class Animal
{
    public void Eat()
    {
        Console.WriteLine("животное говорит");
    }

    public abstract string Speak();
}

public class Lion : Animal
{
    public override string Speak()
    {
        return "ла";
    }
}

public class Elephant : Animal
{
    public override string Speak()
    {
        return "ли";
    }
}

public class Monkey : Animal
{
    public override string Speak()
    {
        return "ля";
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<Animal> zoo = new List<Animal>
        {
            new Lion(),
            new Elephant(),
            new Monkey()
        };

        foreach (var animal in zoo)
        {
            Console.WriteLine(animal.Speak());
        }
    }
}
