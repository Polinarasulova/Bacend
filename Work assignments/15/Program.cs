using System;
using System.Collections.Generic;

class Astronaut
{
    public string Name { get; set; } 
    public string Role { get; set; } 

    public Astronaut(string name, string role)
    {
        Name = name;
        Role = role;
    }
}

class Rocket
{
    public string Name { get; set; } 
    public int Fuel { get; set; }    //топливо
    public List<Astronaut> Crew { get; set; } 

    public Rocket(string name, int fuel)
    {
        Name = name;
        Fuel = fuel;
        Crew = new List<Astronaut>();
    }

      public void AddAstronaut(Astronaut astronaut)
    {
        Crew.Add(astronaut);
    }

    public void Launch()
    {
        const int RequiredFuel = 100; 

        if (Fuel >= RequiredFuel)
        {
            Console.WriteLine($"Ракета '{Name}' успешно запущена!");
            Console.WriteLine("Экипаж на борту:");
            foreach (var astronaut in Crew)
            {
                Console.WriteLine($"- {astronaut.Name}, Роль: {astronaut.Role}");
            }
        }
        else
        {
            Console.WriteLine($"Ракета '{Name}' недостаточно топлива Требуется: {RequiredFuel}, доступно: {Fuel}");
        }
    }
}

class Program
{
    static void Main()
    {
        // Создаём астронавтов
        Astronaut astronaut1 = new Astronaut("Ксюша Иванова", "Пилот");
        Astronaut astronaut2 = new Astronaut("Маша Иванова", "Инженер");
        Astronaut astronaut3 = new Astronaut("Полина Шерышова", "Врач");

        Rocket rocket = new Rocket("Союз-сср", 120);

        rocket.AddAstronaut(astronaut1);
        rocket.AddAstronaut(astronaut2);
        rocket.AddAstronaut(astronaut3);

        rocket.Launch();
    }
}