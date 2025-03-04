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
            new Person("Мария", "Семенова", 33),
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