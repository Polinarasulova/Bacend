using System;
using System.Collections.Generic;
using System.Linq;

class Person
{
    public string Name { get; set; } 
    public int Age { get; set; }     
}
class Program
{
    static void Main()
    {
         List<Person> people = new List<Person>
        {
            new Person { Name = "Апполинария", Age = 15 }, 
            new Person { Name = "Полина", Age = 17 },
            new Person { Name = "Пилагея", Age = 85 }
        };
        var olderThan30 = people.Where(p => p.Age > 30);
        foreach (var person in olderThan30)
        {
            Console.WriteLine($"{person.Name} - {person.Age}");
        }
    }
}