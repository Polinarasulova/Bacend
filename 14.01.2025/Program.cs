using System;

namespace Per
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            SetAge(age); 
        }

        public void Introduce()
        {
            Console.WriteLine($"Привет, мое имя {Name}");
        }

        public void SetAge(int age)
        {
            if (age < 0)
            {
                Console.WriteLine("Возраст не может быть отриц.");
            }
            else
            {
                Age = age;
            }
        }
    }

    public class Employee : Person
    {
        public string Position { get; set; }

         public Employee(string name, int age, string position) : base(name, age)
        {
            Position = position;
        }

        public new void Introduce()
        {
            base.Introduce(); 
            Console.WriteLine($"Я работаю в {Position}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // A
            Person person1 = new Person("Азиз", 18);
            Console.WriteLine($"Имя: {person1.Name}, Возраст: {person1.Age}");

           person1.Name = "Аполинария";
            person1.Age = 15;
            Console.WriteLine($"Имя: {person1.Name}, Возраст: {person1.Age}");

            person1.Introduce();

             Person[] people = new Person[]
            {
                new Person("Света", 18),
                new Person("Дарья", 15),
                new Person("Ксюша Иванова", 12)
            };

            foreach (var person in people)
            {
                person.Introduce();
            }

            //B
            Person person2 = new Person("Дмитрий", 10);
            person2.SetAge(-5);  
            person2.SetAge(15);   
            Console.WriteLine($"Имя: {person2.Name}, Возраст: {person2.Age}");

            //C
            Employee employee1 = new Employee("Анна", 17, "Менеджер");
            employee1.Introduce();  

            Console.ReadLine(); // 
        }
    }
}