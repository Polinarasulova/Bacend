using System;
using System.Collections.Generic;

public class Lesson
{
    public string Subject { get; set; }
    public string Time { get; set; }
    public string Teacher { get; set; }

   public Lesson(string subject, string time, string teacher)
    {
        Subject = subject;
        Time = time;
        Teacher = teacher;
    }
}

public class Program
{
    public static void Main()
    {
         List<Lesson> schedule = new List<Lesson>
        {
            new Lesson("Математика", "08.00", "Ольга Игоревна"),
            new Lesson("Физика", "09:00", "Виктороия Сергеевна"),
            new Lesson("Химия", "10:00", "Снежанна Саидовна"),
            new Lesson("История", "11:00", "Любовь Паловна"),
            new Lesson("География", "12:00", "Светлана Георгевна")
        };

        Console.WriteLine("имя учителя");
        string teacherName = Console.ReadLine();

        Console.WriteLine($"Уроки, проводимые {teacherName}:");
        foreach (var lesson in schedule)
        {
            if (lesson.Teacher.Equals(teacherName, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine($"Предмет: {lesson.Subject}, Время: {lesson.Time}");
            }
        }
    }
}