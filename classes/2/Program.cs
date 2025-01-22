using System;

namespace AnimalPolina
{
    public class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Animal(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Имя: {Name}, Возраст: {Age}");
        }
    }

public class Dog : Animal
    {
        public string Breed { get; set; }

         public Dog(string name, int age, string breed) : base(name, age)
        {
            Breed = breed;
        }

        //звук
        public void Bark()
        {
            Console.WriteLine("Гавь!");
        }

  public new void PrintInfo()
        {
            Console.WriteLine($"Имя: {Name}, Возраст: {Age}, Порода: {Breed}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Dog myDog = new Dog("Вика", 15, "такса");
            
            myDog.PrintInfo();
            
            myDog.Bark();
        }
    }
}