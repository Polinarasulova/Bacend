using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

namespace PracticeC;

public class Student
{
    public string Name { get; set; } = string.Empty; // Инициализация по умолчанию
    public int Age { get; set; }
    public double Grade { get; set; }
}

public class Program
{
    public static void Main()
    {
        string inputFilePath = "students.txt";
        string outputFilePath = "results.txt";

        try
        {
            List<Student> students = new List<Student>();

            if (File.Exists(inputFilePath))
            {
                string[] lines = File.ReadAllLines(inputFilePath);

                foreach (string line in lines)
                {
                    string[] parts = line.Split(';');
                    if (parts.Length != 3)
                        continue;

                    Student student = new Student
                    {
                        Name = parts[0].Trim(),
                        Age = int.Parse(parts[1].Trim()),
                        Grade = double.Parse(parts[2].Trim(), CultureInfo.GetCultureInfo("fr-FR"))
                    };
                    students.Add(student);
                }

                if (students.Count > 0)
                {
                    double averageGrade = students.Average(s => s.Grade);
                    File.WriteAllText(outputFilePath, $"Средняя оценка: {averageGrade.ToString("F2", CultureInfo.InvariantCulture)}");
                }
                else
                {
                    File.WriteAllText(outputFilePath, "Нет данных о студентах.");
                }
            }
            else
            {
                File.WriteAllText(outputFilePath, "Входной файл не найден.");
            }
        }
        catch (Exception ex)
        {
            File.WriteAllText(outputFilePath, $"Ошибка: {ex.Message}");
        }
    }
}