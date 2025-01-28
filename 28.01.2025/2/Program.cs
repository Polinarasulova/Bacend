using System;
using System.Collections.Generic;

namespace AnimalSounds
{
      public abstract class Animal
    {
        public string Name { get; set; }

        public Animal(string name)
        {
            Name = name;
        }

        public abstract void MakeSound();
    }

    public class Dog : Animal
    {
        public Dog(string name) : base(name) {}

        public override void MakeSound()
        {
            Console.WriteLine($"{Name} говорит: Гав-гав");
        }
    }

    public class Cat : Animal
    {
        public Cat(string name) : base(name) {}

        public override void MakeSound()
        {
            Console.WriteLine($"{Name} говорит: Мяу-мяу");
        }
    }

    public class Cow : Animal
    {
        public Cow(string name) : base(name) {}

        public override void MakeSound()
        {
            Console.WriteLine($"{Name} говорит: Муу");
        }
    }

   
    public class Program
    {
        public static void Main()
        {
            // Создаем список животных
            List<Animal> animals = new List<Animal>
            {
                new Dog("бульба"),
                new Cat("тарас"),
                new Cow("тарас-бульба")
            };

             foreach (Animal animal in animals)
            {
                animal.MakeSound();
            }
        }
    }
}