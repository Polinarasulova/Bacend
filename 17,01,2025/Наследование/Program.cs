using System;

namespace Pol
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public virtual string GetInfo()
        {
            return $"Имя: {Name}, Возраст: {Age}";
        }
    }

    public class Student : Person
    {
        public string Group { get; set; }

        public Student(string name, int age, string group) : base(name, age)
        {
            Group = group;
        }

        public override string GetInfo()
        {
            return $"Имя: {Name}, Возраст: {Age}, Группа: {Group}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Polina", 17);
            Console.WriteLine(person.GetInfo());

            
            Student student = new Student("Aziz", 18, "студент");
            Console.WriteLine(student.GetInfo());
        }
    }
}
