using System;

namespace SpaceMission
{
    public class Astronaut
    {
        public string Name { get; set; }
        public string Role { get; set; }

        public Astronaut(string name, string role)
        {
            Name = name;
            Role = role;
        }

        public override string ToString()
        {
            return $"{Name} - {Role}";
        }
    }

 public class Rocket
    {
        public string Name { get; set; }
        public int Fuel { get; set; }
        public Astronaut[] Crew { get; private set; }
        private int crewCount;

        public Rocket(string name, int fuel, int crewCapacity)
        {
            Name = name;
            Fuel = fuel;
            Crew = new Astronaut[crewCapacity];
            crewCount = 0;
        }

        public void AddCrewMember(Astronaut astronaut)
        {
            if (crewCount < Crew.Length)
            {
                Crew[crewCount] = astronaut;
                crewCount++;
            }
            else
            {
                Console.WriteLine("Экипаж полон");
            }
        }
public void Launch()
        {
            if (Fuel > 0)
            {
                Console.WriteLine($"Запуск{Name}");
                Console.WriteLine("Экипаж:");
                for (int i = 0; i < crewCount; i++)
                {
                    Console.WriteLine(Crew[i]);
                }
            }
            else
            {
                Console.WriteLine($"Нету топлива{Name}");
            }
        }
    }

  class Program
    {
        static void Main(string[] args)
        {
            Astronaut astronaut1 = new Astronaut("Полина", "Пилот");
            Astronaut astronaut2 = new Astronaut("Галина", "Инженер");

           Rocket rocket = new Rocket(" Азиз 18", 100, 2);

             rocket.AddCrewMember(astronaut1);
            rocket.AddCrewMember(astronaut2);

            rocket.Launch();

            Rocket rocket2 = new Rocket("ррр", 0, 2);
            rocket2.AddCrewMember(astronaut1);
            rocket2.Launch();
        }
    }
}