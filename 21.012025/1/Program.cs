using System;

namespace AnimalPoli
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
            Console.WriteLine($"Имя: {Name}, Годиков: {Age} ");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
             Animal myAnimal = new Animal("Пончик", 18);
            
           myAnimal.PrintInfo();
        }
    }
}