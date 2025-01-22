using System;

namespace AnimalApp
{
public class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Species { get; set; }

     public void PrintInfo()
        {
            Console.WriteLine($"Имя: {Name}, Возраст: {Age}, Вид: {Species}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Animal[] animals = new Animal[5];

             animals[0] = new Animal { Name = "Эмиль", Age = 3, Species = "собака" };
            animals[1] = new Animal { Name = "Саша", Age = 2, Species = "шиншила" };
            animals[2] = new Animal { Name = "Егор", Age = 5, Species = "макака" };
            animals[3] = new Animal { Name = "Сергей", Age = 1, Species = "паук" };
            animals[4] = new Animal { Name = "Вика", Age = 8, Species = "обезьяна" };
           

             Console.WriteLine("Информация о животных:");
            foreach (var animal in animals)
            {
                animal.PrintInfo();
            }
        }
    }
}