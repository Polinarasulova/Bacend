using System;

interface ITeachable
{
    void Teach();
}

abstract class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public abstract void Introduce();
}

class Student : Person
{
    public int Grade { get; set; }

    public override void Introduce()
    {
        Console.WriteLine($"{Name}, {Age} лет, учится в {Grade}");
    }
}

class Teacher : Person, ITeachable
{
    public string Subject { get; set; }

    public override void Introduce()
    {
        Console.WriteLine($"{Name}, {Age} лет, преподает {Subject}.");
    }

    public void Teach() => Console.WriteLine($"{Name} проводит урок.");
}

class Program
{
    static void Main()
    {
        var student = new Student { Name = "Азизик", Age = 14, Grade = 8 };
        var teacher = new Teacher { Name = "Полинчик", Age = 18, Subject = "Математика" };

        student.Introduce();
        teacher.Introduce();
        teacher.Teach();
    }
}