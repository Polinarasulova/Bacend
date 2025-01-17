using System;

public class Animal
{
    public virtual void Speak()
    {
        Console.WriteLine("Животное издаёт звук");
    }
}

public class Dog : Animal
{
    public override void Speak()
    {
        Console.WriteLine("Собака гавкает");
    }
}

public class Cat : Animal
{
   public override void Speak()
    {
        Console.WriteLine("Кошка мяукает");
    }
}

class Program
{
    static void Main(string[] args)
    {
         Animal[] animals = new Animal[2];

        animals[0] = new Dog();
        animals[1] = new Cat();

        for (int i = 0; i < animals.Length; i++)
        {
            animals[i].Speak();
        }
    }
}