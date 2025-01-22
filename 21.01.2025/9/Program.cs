using System;

public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }
}

public class Student : Person
{
    public int Grade { get; set; }

    public Student(string name, int age, int grade) : base(name, age)
    {
        Grade = grade;
    }

    public void Study()
    {
        Console.WriteLine($"{Name} говорит: Я устала учится");
    }
}

public class Teacher : Person
{
    public string Subject { get; set; }

    public Teacher(string name, int age, string subject) : base(name, age)
    {
        Subject = subject;
    }

    public void Teach()
    {
        Console.WriteLine($"{Name} говорит: Я преподаю {Subject}.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Person[] people = new Person[4];
        people[0] = new Student("Азиа", 16, 10);
        people[1] = new Teacher("Полина", 30, "Bacend");
        people[2] = new Student("виктория", 15, 9);
        people[3] = new Teacher("Polina", 40, 'frontend");

        foreach (var person in people)
        {
            if (person is Student student)
            {
                student.Study();
            }
            else if (person is Teacher teacher)
            {
                teacher.Teach();
            }
        }
    }
}