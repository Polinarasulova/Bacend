using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<Person> people = new List<Person>
        {
            new Person("Александр", "Иванов", 30),
            new Person("Мария", "Петрова", 22),
            new Person("Сергей", "Сидоров", 40),
            new Person("Алексей", "Козлов", 17),
            new Person("Ольга", "Морозова", 25),
            new Person("Александр", "Федоров", 18),
            new Person("Елена", "Смирнова", 35),
            new Person("Дмитрий", "Васильев", 28),
            new Person("Анна", "Попова", 19),
            new Person("Алексей", "Кузнецов", 45),
            new Person("Александр", "Воробьев", 20),
            new Person("Мария", "Семенова", 50),
            new Person("Иван", "Иванов", 50)
        };
// 1
    var age = people.Where(p => p.Age >= 18);
    Console.WriteLine(string.Join(" ", age.Select(p => p.FirstName)));

//  2
    var human = people.Where(p => p.FirstName == "Александр");
    Console.WriteLine(string.Join(" ", human.Select(p => p.LastName)));
// 3
    var user = people.OrderByDescending(p => p.Age);
    Console.WriteLine(string.Join(" ", user.Select(p => p.LastName)));

// 4
    var names = people.Select(p => p.FirstName);
    Console.WriteLine(string.Join(", ", names));

// 5
    double averageAge = people.Average(p => p.Age);
    Console.WriteLine($"{averageAge}");

// 6
    var oldestPerson = people.OrderByDescending(p => p.Age).First();
    Console.WriteLine($"{oldestPerson.FirstName} {oldestPerson.LastName} {oldestPerson.Age}");

// 7
    bool hasMinors = people.Any(p => p.Age < 18);
    Console.WriteLine(hasMinors ? "несовершеннолетний" : "все взрослые");
// 8
   var groupedByAge = people.GroupBy(p => p.Age)
    .Select(g => new { Age = g.Key, Users = g.ToList() });

foreach (var group in groupedByAge)
{
    Console.WriteLine($"{group.Age}");
    foreach (var person in group.Users)
    {
        Console.WriteLine($"  {person.FirstName} {person.LastName}");
    }
}
// 9
    int count = people.Count(p => p.LastName == "Иванов");
    Console.WriteLine($"{count}");

// 10
    var dictionary = people.ToDictionary(p => p.FirstName);
    foreach (var entry in dictionary)
    {
        Console.WriteLine($"{entry.Key}: {entry.Value.LastName}, {entry.Value.Age}");
    }
}

class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }

    public Person(string firstName, string lastName, int age)
    {
        FirstName = firstName;
        LastName = lastName;
        Age = age;
    }
}
}