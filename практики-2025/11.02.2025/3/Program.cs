using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        Dictionary<string, int> students = new Dictionary<string, int>();

        students.Add("Аполинария", 3);
        students.Add("Пилагея", 4);
        students.Add("Полина", 2);
        students.Add("Светлана", 5);
        var bestStudent = students.OrderByDescending(s => s.Value).First();
        Console.WriteLine($"{bestStudent.Key} ({bestStudent.Value})");
    }
}