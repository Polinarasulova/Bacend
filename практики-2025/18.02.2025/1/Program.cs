using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<string, int> data = new Dictionary<string, int>
        {
            {"apple", 10},
            {"banana", 5},
            {"orange", 7}
        };

        Console.Write("Введите название фрукта: ");
        string key = Console.ReadLine();

        try
        {
            int value = data[key];
            Console.WriteLine($"Значение: {value}");
        }
        catch (KeyNotFoundException)
        {
            Console.WriteLine("Ошибка: введенный ключ не найден в словаре.");
        }

        Console.WriteLine("Программа продолжает выполнение.");
    }
}